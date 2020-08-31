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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Base class for DescribeClusterParameterGroups paginators.
    /// </summary>
    internal sealed partial class DescribeClusterParameterGroupsPaginator : IPaginator<DescribeClusterParameterGroupsResponse>, IDescribeClusterParameterGroupsPaginator
    {
        private readonly IAmazonRedshift _client;
        private readonly DescribeClusterParameterGroupsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeClusterParameterGroupsResponse> Responses => new PaginatedResponse<DescribeClusterParameterGroupsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ParameterGroups
        /// </summary>
        public IPaginatedEnumerable<ClusterParameterGroup> ParameterGroups => 
            new PaginatedResultKeyResponse<DescribeClusterParameterGroupsResponse, ClusterParameterGroup>(this, (i) => i.ParameterGroups);

        internal DescribeClusterParameterGroupsPaginator(IAmazonRedshift client, DescribeClusterParameterGroupsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeClusterParameterGroupsResponse> IPaginator<DescribeClusterParameterGroupsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            DescribeClusterParameterGroupsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeClusterParameterGroups(_request);
                marker = response.Marker;
                yield return response;
            }
            while (marker != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeClusterParameterGroupsResponse> IPaginator<DescribeClusterParameterGroupsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            DescribeClusterParameterGroupsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeClusterParameterGroupsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (marker != null);
        }
#endif
    }
}
#endif