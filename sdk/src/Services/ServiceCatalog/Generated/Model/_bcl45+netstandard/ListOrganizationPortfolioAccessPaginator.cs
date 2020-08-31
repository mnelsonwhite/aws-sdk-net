#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Base class for ListOrganizationPortfolioAccess paginators.
    /// </summary>
    internal sealed partial class ListOrganizationPortfolioAccessPaginator : IPaginator<ListOrganizationPortfolioAccessResponse>, IListOrganizationPortfolioAccessPaginator
    {
        private readonly IAmazonServiceCatalog _client;
        private readonly ListOrganizationPortfolioAccessRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListOrganizationPortfolioAccessResponse> Responses => new PaginatedResponse<ListOrganizationPortfolioAccessResponse>(this);

        internal ListOrganizationPortfolioAccessPaginator(IAmazonServiceCatalog client, ListOrganizationPortfolioAccessRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListOrganizationPortfolioAccessResponse> IPaginator<ListOrganizationPortfolioAccessResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var pageToken = _request.PageToken;
            ListOrganizationPortfolioAccessResponse response;
            do
            {
                _request.PageToken = pageToken;
                response = _client.ListOrganizationPortfolioAccess(_request);
                pageToken = response.NextPageToken;
                yield return response;
            }
            while (pageToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListOrganizationPortfolioAccessResponse> IPaginator<ListOrganizationPortfolioAccessResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var pageToken = _request.PageToken;
            ListOrganizationPortfolioAccessResponse response;
            do
            {
                _request.PageToken = pageToken;
                response = await _client.ListOrganizationPortfolioAccessAsync(_request, cancellationToken).ConfigureAwait(false);
                pageToken = response.NextPageToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (pageToken != null);
        }
#endif
    }
}
#endif