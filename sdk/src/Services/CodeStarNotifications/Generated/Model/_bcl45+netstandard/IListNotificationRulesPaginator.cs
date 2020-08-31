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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */
using Amazon.Runtime;

namespace Amazon.CodeStarNotifications.Model
{
    /// <summary>
    /// Paginator for the ListNotificationRules operation
    ///</summary>
    public interface IListNotificationRulesPaginator
    {
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        IPaginatedEnumerable<ListNotificationRulesResponse> Responses { get; }

        /// <summary>
        /// Enumerable containing all of the NotificationRules
        /// </summary>
        IPaginatedEnumerable<NotificationRuleSummary> NotificationRules { get; }
    }
}
#endif