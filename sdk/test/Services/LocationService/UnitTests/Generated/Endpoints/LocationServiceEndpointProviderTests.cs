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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.LocationService.Endpoints;
using Amazon.LocationService.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class LocationServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LocationService")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new LocationServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonLocationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}