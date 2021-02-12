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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateIdentityProviderConfig operation.
    /// Associate an identity provider configuration to a cluster.
    /// 
    ///  
    /// <para>
    /// If you want to authenticate identities using an identity provider, you can create
    /// an identity provider configuration and associate it to your cluster. After configuring
    /// authentication to your cluster you can create Kubernetes <code>roles</code> and <code>clusterroles</code>
    /// to assign permissions to the roles, and then bind the roles to the identities using
    /// Kubernetes <code>rolebindings</code> and <code>clusterrolebindings</code>. For more
    /// information see <a href="https://kubernetes.io/docs/reference/access-authn-authz/rbac/">Using
    /// RBAC Authorization</a> in the Kubernetes documentation.
    /// </para>
    /// </summary>
    public partial class AssociateIdentityProviderConfigRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;
        private OidcIdentityProviderConfigRequest _oidc;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster to associate the configuration to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Oidc. 
        /// <para>
        /// An object that represents an OpenID Connect (OIDC) identity provider configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OidcIdentityProviderConfigRequest Oidc
        {
            get { return this._oidc; }
            set { this._oidc = value; }
        }

        // Check to see if Oidc property is set
        internal bool IsSetOidc()
        {
            return this._oidc != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata to apply to the configuration to assist with categorization and organization.
        /// Each tag consists of a key and an optional value, both of which you define.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}