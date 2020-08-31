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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCustomVerificationEmailTemplate Request Marshaller
    /// </summary>       
    public class GetCustomVerificationEmailTemplateRequestMarshaller : IMarshaller<IRequest, GetCustomVerificationEmailTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCustomVerificationEmailTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetCustomVerificationEmailTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetTemplateName())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field TemplateName set");
            request.AddPathResource("{TemplateName}", StringUtils.FromString(publicRequest.TemplateName));
            request.ResourcePath = "/v2/email/custom-verification-email-templates/{TemplateName}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetCustomVerificationEmailTemplateRequestMarshaller _instance = new GetCustomVerificationEmailTemplateRequestMarshaller();        

        internal static GetCustomVerificationEmailTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCustomVerificationEmailTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}