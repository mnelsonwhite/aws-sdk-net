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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2VpcDetails Marshaller
    /// </summary>       
    public class AwsEc2VpcDetailsMarshaller : IRequestMarshaller<AwsEc2VpcDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2VpcDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCidrBlockAssociationSet())
            {
                context.Writer.WritePropertyName("CidrBlockAssociationSet");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCidrBlockAssociationSetListValue in requestObject.CidrBlockAssociationSet)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CidrBlockAssociationMarshaller.Instance;
                    marshaller.Marshall(requestObjectCidrBlockAssociationSetListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDhcpOptionsId())
            {
                context.Writer.WritePropertyName("DhcpOptionsId");
                context.Writer.Write(requestObject.DhcpOptionsId);
            }

            if(requestObject.IsSetIpv6CidrBlockAssociationSet())
            {
                context.Writer.WritePropertyName("Ipv6CidrBlockAssociationSet");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpv6CidrBlockAssociationSetListValue in requestObject.Ipv6CidrBlockAssociationSet)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = Ipv6CidrBlockAssociationMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6CidrBlockAssociationSetListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.Write(requestObject.State);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsEc2VpcDetailsMarshaller Instance = new AwsEc2VpcDetailsMarshaller();

    }
}