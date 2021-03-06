// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Security.KeyVault.Administration.Models;
using NUnit.Framework;

namespace Azure.Security.KeyVault.Administration.Tests
{
    public abstract class AccessControlTestBase : AdministrationTestBase
    {
        private readonly ConcurrentQueue<(string Name, string Scope)> _roleAssignmentsToDelete = new ConcurrentQueue<(string Name, string Scope)>();

        public KeyVaultAccessControlClient Client { get; private set; }

#pragma warning disable IDE1006 // Naming Styles
        internal KeyVaultAccessControlClient client;
#pragma warning restore IDE1006 // Naming Styles

        internal const string RoleName = "Managed HSM Crypto User";
        internal readonly Guid _roleAssignmentId = new Guid("e7ae2aff-eb17-4c9d-84f0-d12f7f468f16");
        internal string _roleDefinitionId;
        internal string _objectId;

        public AccessControlTestBase(bool isAsync, RecordedTestMode? mode)
            : base(isAsync, mode)
        { }

        internal KeyVaultAccessControlClient GetClient(TestRecording recording = null)
        {
            return InstrumentClient
                (new KeyVaultAccessControlClient(
                    Uri,
                    TestEnvironment.Credential,
                    InstrumentClientOptions(new KeyVaultAdministrationClientOptions())));
        }

        protected override void Start()
        {
            Client = GetClient();

            base.Start();
        }

        [TearDown]
        public override async Task Cleanup()
        {
            // Start deleting resources as soon as possible.
            while (_roleAssignmentsToDelete.TryDequeue(out var assignment))
            {
                await DeleteRoleAssignment(assignment);
            }

            await base.Cleanup();
        }

        protected async Task DeleteRoleAssignment((string Name, string Scope) assignment)
        {
            if (Mode == RecordedTestMode.Playback)
            {
                return;
            }

            try
            {
                using (Recording.DisableRecording())
                {
                    await Client.DeleteRoleAssignmentAsync(assignment.Scope, assignment.Name).ConfigureAwait(false);
                }
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
            }
        }

        protected void RegisterForCleanup(KeyVaultRoleAssignment assignment)
        {
            _roleAssignmentsToDelete.Enqueue((assignment.Name, assignment.Properties.Scope));
        }
    }
}
