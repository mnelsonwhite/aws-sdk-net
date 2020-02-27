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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticFileSystem.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeFileSystemPolicy Request Marshaller
    /// </summary>       
    public class DescribeFileSystemPolicyRequestMarshaller : IMarshaller<IRequest, DescribeFileSystemPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeFileSystemPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeFileSystemPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticFileSystem");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-02-01";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetFileSystemId())
                throw new AmazonElasticFileSystemException("Request object does not have required field FileSystemId set");
            request.AddPathResource("{FileSystemId}", StringUtils.FromString(publicRequest.FileSystemId));
            request.ResourcePath = "/2015-02-01/file-systems/{FileSystemId}/policy";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DescribeFileSystemPolicyRequestMarshaller _instance = new DescribeFileSystemPolicyRequestMarshaller();        

        internal static DescribeFileSystemPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeFileSystemPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}