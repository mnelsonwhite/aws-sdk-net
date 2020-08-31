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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The structure representing the GetFindingsReportAccountSummaryResponse.
    /// </summary>
    public partial class GetFindingsReportAccountSummaryResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<FindingsReportSummary> _reportSummaries = new List<FindingsReportSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>GetFindingsReportAccountSummary</code>
        /// request. When the results of a <code>GetFindingsReportAccountSummary</code> request
        /// exceed <code>maxResults</code>, this value can be used to retrieve the next page of
        /// results. This value is <code>null</code> when there are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReportSummaries. 
        /// <para>
        /// The return list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_FindingsReportSummary.html">
        /// <code>FindingsReportSummary</code> </a> objects taht contain summaries of analysis
        /// results for all profiling groups in your AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FindingsReportSummary> ReportSummaries
        {
            get { return this._reportSummaries; }
            set { this._reportSummaries = value; }
        }

        // Check to see if ReportSummaries property is set
        internal bool IsSetReportSummaries()
        {
            return this._reportSummaries != null && this._reportSummaries.Count > 0; 
        }

    }
}