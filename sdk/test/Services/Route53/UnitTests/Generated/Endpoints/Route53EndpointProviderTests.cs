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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.Route53.Endpoints;
using Amazon.Route53.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class Route53EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Route53")]
        [Description("For region aws-cn-global with FIPS disabled and DualStack disabled")]
        public void For_region_awscnglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new Route53EndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "aws-cn-global";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRoute53EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://route53.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Route53")]
        [Description("For region aws-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new Route53EndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRoute53EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://route53.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Route53")]
        [Description("For region aws-iso-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsisoglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new Route53EndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "aws-iso-global";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRoute53EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://route53.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Route53")]
        [Description("For region aws-iso-b-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsisobglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new Route53EndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "aws-iso-b-global";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRoute53EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://route53.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Route53")]
        [Description("For region aws-us-gov-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsusgovglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new Route53EndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "aws-us-gov-global";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRoute53EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://route53.us-gov.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Route53")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new Route53EndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRoute53EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Route53")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new Route53EndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRoute53EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Route53")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new Route53EndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRoute53EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}