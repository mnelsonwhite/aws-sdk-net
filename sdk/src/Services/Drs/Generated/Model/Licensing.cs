/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Configuration of a machine's license.
    /// </summary>
    public partial class Licensing
    {
        private bool? _osByol;

        /// <summary>
        /// Gets and sets the property OsByol. 
        /// <para>
        /// Whether to enable "Bring your own license" or not.
        /// </para>
        /// </summary>
        public bool OsByol
        {
            get { return this._osByol.GetValueOrDefault(); }
            set { this._osByol = value; }
        }

        // Check to see if OsByol property is set
        internal bool IsSetOsByol()
        {
            return this._osByol.HasValue; 
        }

    }
}