// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingRoleDefinitionsOperations.
    /// </summary>
    public static partial class BillingRoleDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Gets the definition for a role on a billing account. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// The ID that uniquely identifies a role definition.
            /// </param>
            public static BillingRoleDefinition GetByBillingAccount(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingRoleDefinitionName)
            {
                return operations.GetByBillingAccountAsync(billingAccountName, billingRoleDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the definition for a role on a billing account. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// The ID that uniquely identifies a role definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinition> GetByBillingAccountAsync(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingRoleDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByBillingAccountWithHttpMessagesAsync(billingAccountName, billingRoleDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the definition for a role on an invoice section. The operation is
            /// supported only for billing accounts with agreement type Microsoft Customer
            /// Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The ID that uniquely identifies an invoice section.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// The ID that uniquely identifies a role definition.
            /// </param>
            public static BillingRoleDefinition GetByInvoiceSection(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, string billingRoleDefinitionName)
            {
                return operations.GetByInvoiceSectionAsync(billingAccountName, billingProfileName, invoiceSectionName, billingRoleDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the definition for a role on an invoice section. The operation is
            /// supported only for billing accounts with agreement type Microsoft Customer
            /// Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The ID that uniquely identifies an invoice section.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// The ID that uniquely identifies a role definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinition> GetByInvoiceSectionAsync(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, string billingRoleDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByInvoiceSectionWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, billingRoleDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the definition for a role on a billing profile. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// The ID that uniquely identifies a role definition.
            /// </param>
            public static BillingRoleDefinition GetByBillingProfile(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingProfileName, string billingRoleDefinitionName)
            {
                return operations.GetByBillingProfileAsync(billingAccountName, billingProfileName, billingRoleDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the definition for a role on a billing profile. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// The ID that uniquely identifies a role definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinition> GetByBillingProfileAsync(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingProfileName, string billingRoleDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, billingRoleDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definitions for a billing account. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            public static IPage<BillingRoleDefinition> ListByBillingAccount(this IBillingRoleDefinitionsOperations operations, string billingAccountName)
            {
                return operations.ListByBillingAccountAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definitions for a billing account. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingRoleDefinition>> ListByBillingAccountAsync(this IBillingRoleDefinitionsOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definitions for an invoice section. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The ID that uniquely identifies an invoice section.
            /// </param>
            public static IPage<BillingRoleDefinition> ListByInvoiceSection(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName)
            {
                return operations.ListByInvoiceSectionAsync(billingAccountName, billingProfileName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definitions for an invoice section. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The ID that uniquely identifies an invoice section.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingRoleDefinition>> ListByInvoiceSectionAsync(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definitions for a billing profile. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            public static IPage<BillingRoleDefinition> ListByBillingProfile(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListByBillingProfileAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definitions for a billing profile. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingRoleDefinition>> ListByBillingProfileAsync(this IBillingRoleDefinitionsOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definitions for a billing account. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingRoleDefinition> ListByBillingAccountNext(this IBillingRoleDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListByBillingAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definitions for a billing account. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingRoleDefinition>> ListByBillingAccountNextAsync(this IBillingRoleDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definitions for an invoice section. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingRoleDefinition> ListByInvoiceSectionNext(this IBillingRoleDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListByInvoiceSectionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definitions for an invoice section. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingRoleDefinition>> ListByInvoiceSectionNextAsync(this IBillingRoleDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definitions for a billing profile. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingRoleDefinition> ListByBillingProfileNext(this IBillingRoleDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListByBillingProfileNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definitions for a billing profile. The operation is
            /// supported for billing accounts with agreement type Microsoft Partner
            /// Agreement or Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingRoleDefinition>> ListByBillingProfileNextAsync(this IBillingRoleDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
