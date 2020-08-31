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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Paginators for the ElasticBeanstalk service
    ///</summary>
    public class ElasticBeanstalkPaginatorFactory : IElasticBeanstalkPaginatorFactory
    {
        private readonly IAmazonElasticBeanstalk client;

        internal ElasticBeanstalkPaginatorFactory(IAmazonElasticBeanstalk client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeEnvironmentManagedActionHistory operation
        ///</summary>
        public IDescribeEnvironmentManagedActionHistoryPaginator DescribeEnvironmentManagedActionHistory(DescribeEnvironmentManagedActionHistoryRequest request) 
        {
            return new DescribeEnvironmentManagedActionHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlatformBranches operation
        ///</summary>
        public IListPlatformBranchesPaginator ListPlatformBranches(ListPlatformBranchesRequest request) 
        {
            return new ListPlatformBranchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlatformVersions operation
        ///</summary>
        public IListPlatformVersionsPaginator ListPlatformVersions(ListPlatformVersionsRequest request) 
        {
            return new ListPlatformVersionsPaginator(this.client, request);
        }
    }
}
#endif