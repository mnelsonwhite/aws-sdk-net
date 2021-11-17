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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecoveryInstanceDataReplicationInfoReplicatedDisk Object
    /// </summary>  
    public class RecoveryInstanceDataReplicationInfoReplicatedDiskUnmarshaller : IUnmarshaller<RecoveryInstanceDataReplicationInfoReplicatedDisk, XmlUnmarshallerContext>, IUnmarshaller<RecoveryInstanceDataReplicationInfoReplicatedDisk, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecoveryInstanceDataReplicationInfoReplicatedDisk IUnmarshaller<RecoveryInstanceDataReplicationInfoReplicatedDisk, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecoveryInstanceDataReplicationInfoReplicatedDisk Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RecoveryInstanceDataReplicationInfoReplicatedDisk unmarshalledObject = new RecoveryInstanceDataReplicationInfoReplicatedDisk();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("backloggedStorageBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.BackloggedStorageBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deviceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicatedStorageBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ReplicatedStorageBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rescannedStorageBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.RescannedStorageBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalStorageBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalStorageBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RecoveryInstanceDataReplicationInfoReplicatedDiskUnmarshaller _instance = new RecoveryInstanceDataReplicationInfoReplicatedDiskUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecoveryInstanceDataReplicationInfoReplicatedDiskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}