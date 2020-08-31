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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Audio Track
    /// </summary>
    public partial class AudioTrack
    {
        private int? _track;

        /// <summary>
        /// Gets and sets the property Track. 1-based integer value that maps to a specific audio
        /// track
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int Track
        {
            get { return this._track.GetValueOrDefault(); }
            set { this._track = value; }
        }

        // Check to see if Track property is set
        internal bool IsSetTrack()
        {
            return this._track.HasValue; 
        }

    }
}