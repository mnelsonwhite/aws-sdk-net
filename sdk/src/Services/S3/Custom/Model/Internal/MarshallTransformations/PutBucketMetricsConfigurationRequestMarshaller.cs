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

using System;
using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket MetricsConfigurationRequest Marshaller
    /// </summary>   
    public class PutBucketMetricsConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketMetricsConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketMetricsConfigurationRequest)input);
        }
        public IRequest Marshall(PutBucketMetricsConfigurationRequest PutBucketMetricsConfigurationRequest)
        {
            IRequest request = new DefaultRequest(PutBucketMetricsConfigurationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (PutBucketMetricsConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(PutBucketMetricsConfigurationRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(PutBucketMetricsConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketMetricsConfigurationRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("metrics");

            request.AddSubResource("id", PutBucketMetricsConfigurationRequest.MetricsId);

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                var metricsConfiguration = PutBucketMetricsConfigurationRequest.MetricsConfiguration;
                if (metricsConfiguration != null)
                {
                    xmlWriter.WriteStartElement("MetricsConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (metricsConfiguration != null)
                    {
                        if (metricsConfiguration.IsSetMetricsId())
                        {
                            xmlWriter.WriteElementString("Id", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(metricsConfiguration.MetricsId));
                        }

                        if (metricsConfiguration.IsSetMetricsFilter())
                        {
                            xmlWriter.WriteStartElement("Filter", "http://s3.amazonaws.com/doc/2006-03-01/");
                            var filterPredicate = metricsConfiguration.MetricsFilter.MetricsFilterPredicate;
                            filterPredicate.Accept(new MetricsPredicateVisitor(xmlWriter));

                            xmlWriter.WriteEndElement();
                        }
                    }
                    xmlWriter.WriteEndElement();
                }
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                var checksum = AWSSDKUtils.GenerateChecksumForContent(content, true);
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        private static PutBucketMetricsConfigurationRequestMarshaller _instance;

        public static PutBucketMetricsConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutBucketMetricsConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
