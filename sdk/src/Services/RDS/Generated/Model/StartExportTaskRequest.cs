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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the StartExportTask operation.
    /// Starts an export of a snapshot to Amazon S3. The provided IAM role must have access
    /// to the S3 bucket.
    /// </summary>
    public partial class StartExportTaskRequest : AmazonRDSRequest
    {
        private List<string> _exportOnly = new List<string>();
        private string _exportTaskIdentifier;
        private string _iamRoleArn;
        private string _kmsKeyId;
        private string _s3BucketName;
        private string _s3Prefix;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property ExportOnly. 
        /// <para>
        /// The data to be exported from the snapshot. If this parameter is not provided, all
        /// the snapshot data is exported. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>database</code> - Export all the data of the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database.table [table-name]</code> - Export a table of the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database.schema [schema-name]</code> - Export a database schema of the snapshot.
        /// This value isn't valid for RDS for MySQL, RDS for MariaDB, or Aurora MySQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database.schema.table [table-name]</code> - Export a table of the database
        /// schema. This value isn't valid for RDS for MySQL, RDS for MariaDB, or Aurora MySQL.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> ExportOnly
        {
            get { return this._exportOnly; }
            set { this._exportOnly = value; }
        }

        // Check to see if ExportOnly property is set
        internal bool IsSetExportOnly()
        {
            return this._exportOnly != null && this._exportOnly.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExportTaskIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot export task. This ID isn't an identifier for
        /// the Amazon S3 bucket where the snapshot is to be exported to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExportTaskIdentifier
        {
            get { return this._exportTaskIdentifier; }
            set { this._exportTaskIdentifier = value; }
        }

        // Check to see if ExportTaskIdentifier property is set
        internal bool IsSetExportTaskIdentifier()
        {
            return this._exportTaskIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The name of the IAM role to use for writing to the Amazon S3 bucket when exporting
        /// a snapshot. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the AWS KMS key to use to encrypt the snapshot exported to Amazon S3. The
        /// KMS key ID is the Amazon Resource Name (ARN), the KMS key identifier, or the KMS key
        /// alias for the KMS encryption key. The IAM role used for the snapshot export must have
        /// encryption and decryption permissions to use this KMS key. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket to export the snapshot to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The Amazon S3 bucket prefix to use as the file name and path of the exported snapshot.
        /// </para>
        /// </summary>
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot to export to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

    }
}