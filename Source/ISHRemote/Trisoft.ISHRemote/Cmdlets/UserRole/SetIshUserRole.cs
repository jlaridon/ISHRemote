/*
* Copyright © 2014 All Rights Reserved by the RWS Group for and on behalf of its affiliates and subsidiaries.
* 
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
* 
*     http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Trisoft.ISHRemote.Objects;
using Trisoft.ISHRemote.Objects.Public;
using Trisoft.ISHRemote.Exceptions;
using Trisoft.ISHRemote.HelperClasses;

namespace Trisoft.ISHRemote.Cmdlets.UserRole
{
    /// <summary>
    /// <para type="synopsis">The Set-IshUserRole cmdlet updates the user roles that are passed through the pipeline or determined via provided parameters</para>
    /// <para type="description">The Set-IshUserRole cmdlet updates the user roles that are passed through the pipeline or determined via provided parameters</para>
    /// </summary>
    /// <example>
    /// <code>
    /// New-IshSession -WsBaseUrl "https://example.com/InfoShareWS/" -PSCredential Admin
    /// Get-IshUserRole -Id VUSERROLEADMINISTRATOR  | 
    /// Set-IshMetadataField -Name DESCRIPTION -Value "Something new over ISHRemote" | 
    /// Set-IshUserRole
    /// </code>
    /// <para>New-IshSession will submit into SessionState, so it can be reused by this cmdlet. Gets the user role and adapts the client-side memory structure to hold a new description and sets in the repository.</para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "IshUserRole", SupportsShouldProcess = true)]
    [OutputType(typeof(IshUserRole))]
    public sealed class SetIshUserRole : UserRoleCmdlet
    {
        /// <summary>
        /// <para type="description">The IshSession variable holds the authentication and contract information. This object can be initialized using the New-IshSession cmdlet.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ParameterSetName = "ParameterGroup")]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ParameterSetName = "IshObjectsGroup")]
        [ValidateNotNullOrEmpty]
        public IshSession IshSession { get; set; }

        /// <summary>
        /// <para type="description">The identifier of the user role to update</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ParameterSetName = "ParameterGroup"), ValidateNotNullOrEmpty]
        public string Id { get; set; }

        /// <summary>
        /// <para type="description">The metadata to set for the user role</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ParameterSetName = "ParameterGroup"), ValidateNotNull]
        public IshField[] Metadata { get; set; }

        /// <summary>
        /// <para type="description">User roles for which to update the metadata. This array can be passed through the pipeline or explicitly passed via the parameter.</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "IshObjectsGroup")]
        [AllowEmptyCollection]
        public IshObject[] IshObject { get; set; }

        protected override void BeginProcessing()
        {
            if (IshSession == null) { IshSession = (IshSession)SessionState.PSVariable.GetValue(ISHRemoteSessionStateIshSession); }
            if (IshSession == null) { throw new ArgumentException(ISHRemoteSessionStateIshSessionException); }
            WriteDebug($"Using IshSession[{IshSession.Name}] from SessionState.{ISHRemoteSessionStateIshSession}");
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {

            try
            {
                List<IshObject> returnedObjects = new List<IshObject>();

                if (IshObject != null && IshObject.Length == 0)
                {
                    // Do nothing                    
                    WriteVerbose("IshObject is empty, so nothing to update");
                    WriteVerbose("IshObject is empty, so nothing to retrieve");
                }
                else
                {
                    List<string> returnUserRoles = new List<string>();
                    IshFields returnFields;

                    // 1. Doing the update
                    WriteDebug("Updating");

                    if (IshObject != null)
                    {
                        int current = 0;
                        // 1b. Using IshObject[] pipeline or specificly set
                        foreach (IshObject ishObject in IshObject)
                        {
                            WriteDebug($"Id[{ishObject.IshRef}] Metadata.length[{ishObject.IshFields.ToXml().Length}] {++current}/{IshObject.Length}");
                            var metadata = IshSession.IshTypeFieldSetup.ToIshMetadataFields(ISHType, ishObject.IshFields, Enumerations.ActionMode.Update);
                            if (ShouldProcess(ishObject.IshRef))
                            {
                                IshSession.UserRole25.Update(ishObject.IshRef, metadata.ToXml());
                            }
                            returnUserRoles.Add(ishObject.IshRef);
                        }
                        returnFields = (IshObject[0] == null)
                            ? new IshFields()
                            : IshObject[0].IshFields;
                    }
                    else
                    {
                        // 1a. Using Id and Metadata
                        var metadata = IshSession.IshTypeFieldSetup.ToIshMetadataFields(ISHType, new IshFields(Metadata), Enumerations.ActionMode.Update);
                        WriteDebug($"Id[{Id}] metadata.length[{metadata.ToXml().Length}]");
                        if (ShouldProcess(Id))
                        {
                            IshSession.UserRole25.Update(Id, metadata.ToXml());
                        }
                        returnUserRoles.Add(Id);
                        returnFields = metadata;
                    }

                    // 2. Retrieve the updated material from the database and write it out
                    WriteDebug("Retrieving");

                    // Add the required fields (needed for pipe operations)
                    IshFields requestedMetadata = IshSession.IshTypeFieldSetup.ToIshRequestedMetadataFields(IshSession.DefaultRequestedMetadata, ISHType, returnFields, Enumerations.ActionMode.Read);

                    string xmlIshObjects = IshSession.UserRole25.RetrieveMetadata(
                        returnUserRoles.ToArray(),
                        UserRole25ServiceReference.ActivityFilter.None,
                        "",
                        requestedMetadata.ToXml());
                    
                    returnedObjects.AddRange(new IshObjects(ISHType, xmlIshObjects).Objects);
                }

                // 3. Write it
                WriteVerbose("returned object count[" + returnedObjects.Count + "]");
                WriteObject(IshSession, ISHType, returnedObjects.ConvertAll(x => (IshBaseObject)x), true);
            }
            catch (TrisoftAutomationException trisoftAutomationException)
            {
                ThrowTerminatingError(new ErrorRecord(trisoftAutomationException, base.GetType().Name, ErrorCategory.InvalidOperation, null));
            }
            catch (Exception exception)
            {
                ThrowTerminatingError(new ErrorRecord(exception, base.GetType().Name, ErrorCategory.NotSpecified, null));
            }
        }
    }
}
