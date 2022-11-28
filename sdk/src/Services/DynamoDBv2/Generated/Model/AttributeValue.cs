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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the data for an attribute.
    /// 
    ///  
    /// <para>
    /// Each attribute value is described as a name-value pair. The name is the data type,
    /// and the value is the data itself.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html#HowItWorks.DataTypes">Data
    /// Types</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AttributeValue
    {
        private AttributeValueType _type;
        private bool _isSet;
        private object _value;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public AttributeValue(object value, AttributeValueType type)
        {
            this._type = type;
            this._value = value;
            this._isSet = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool HasValue
        {
            get { return _isSet; }
        }

        /// <summary>
        /// 
        /// </summary>
        public object Value
        {
            get { return _value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public AttributeValueType AttributeType
        {
            get { return _type; }
        }

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        [Obsolete("Use constructor with value and type parameters")]
        public AttributeValue() {
            this._type = AttributeValueType.Unknown;
            this._value = default;
            this._isSet = false;
        }

        /// <summary>
        /// Instantiates AttributeValue with the parameterized properties
        /// </summary>
        /// <param name="s">An attribute of type String. For example:  <code>"S": "Hello"</code> </param>
        public AttributeValue(string s)
        {
            this._type = AttributeValueType.String;
            this._value = s;
            this._isSet = true;
        }

        /// <summary>
        /// Instantiates AttributeValue with the parameterized properties
        /// </summary>
        /// <param name="ss">An attribute of type String Set. For example:  <code>"SS": ["Giraffe", "Hippo" ,"Zebra"]</code> </param>
        public AttributeValue(List<string> ss)
        {
            this._type = AttributeValueType.StringSet;
            this._value = ss;
            this._isSet = true;
        }

        /// <summary>
        /// Gets and sets the property B. 
        /// <para>
        /// An attribute of type Binary. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"B": "dGhpcyB0ZXh0IGlzIGJhc2U2NC1lbmNvZGVk"</code> 
        /// </para>
        /// </summary>
        public MemoryStream B
        {
            get
            {
                if (this._type == AttributeValueType.Binary
                    && this._value is MemoryStream memoryStream)
                {
                    return memoryStream;
                }
                
                return default;
            }
            set
            {
                this._type = AttributeValueType.Binary;
                this._value = value;
            }
        }

        // Check to see if B property is set
        internal bool IsSetB()
        {
            return this._type == AttributeValueType.Binary && this._isSet;
        }

        /// <summary>
        /// Gets and sets the property BOOL. 
        /// <para>
        /// An attribute of type Boolean. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"BOOL": true</code> 
        /// </para>
        /// </summary>
        public bool BOOL
        {
            get
            {
                return this._type == AttributeValueType.Boolean
                    && this._isSet
                    && this._value is bool b
                    ? b : default;
            }
            set
            {
                this._type = AttributeValueType.Boolean;
                this._value = value;
                this._isSet = true;
            }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="BOOL"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsBOOLSet
        {
            get
            {
                return this._type == AttributeValueType.Boolean
                    && this._isSet;
            }
            set
            {
                this._type = AttributeValueType.Boolean;
                this._value = default(bool);
                this._isSet = value;
            }
        }

        // Check to see if BOOL property is set
        internal bool IsSetBOOL()
        {
            return this._type == AttributeValueType.Boolean
                && this._isSet;
        }

        /// <summary>
        /// Gets and sets the property BS. 
        /// <para>
        /// An attribute of type Binary Set. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"BS": ["U3Vubnk=", "UmFpbnk=", "U25vd3k="]</code> 
        /// </para>
        /// </summary>
        public List<MemoryStream> BS
        {
            get
            {
                if (this._type == AttributeValueType.BinarySet
                    && this._isSet
                    && this._value is List<MemoryStream> memoryStreamSet)
                {
                    return memoryStreamSet;
                }

                return default;
            }
            set {
                this._type = AttributeValueType.BooleanSet;
                this._value = value;
                this._isSet = true;
            }
        }

        // Check to see if BS property is set
        internal bool IsSetBS()
        {
            return this._type == AttributeValueType.BinarySet
                && this._isSet
                && this._value is List<MemoryStream> memoryStreamSet
                && memoryStreamSet.Count > 0;
        }

        /// <summary>
        /// Gets and sets the property L. 
        /// <para>
        /// An attribute of type List. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"L": [ {"S": "Cookies"} , {"S": "Coffee"}, {"N": "3.14159"}]</code> 
        /// </para>
        /// </summary>
        public List<AttributeValue> L
        {
            get {
                if (this._type == AttributeValueType.BinarySet
                    && this._isSet
                    && this._value is List<AttributeValue> list)
                {
                    return list;
                }

                return default;
            }
            set {
                this._type = AttributeValueType.List;
                this._value = value;
                this._isSet = true;
            }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="L"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsLSet
        {
            get
            {
                return this._type == AttributeValueType.List
                    && this._isSet;
            }
            set
            {
                this._type = AttributeValueType.List;
                this._value = default(List<AttributeValue>);
                this._isSet = value;
            }
        }

        // Check to see if L property is set
        internal bool IsSetL()
        {
            return this._type == AttributeValueType.List
                && this._isSet;
        }

        /// <summary>
        /// Gets and sets the property M. 
        /// <para>
        /// An attribute of type Map. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"M": {"Name": {"S": "Joe"}, "Age": {"N": "35"}}</code> 
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> M
        {
            get {
                return this._type == AttributeValueType.Map
                   && this._isSet
                   && this._value is Dictionary<string, AttributeValue> map
                   ? map: default;
            }
            set {
                this._type = AttributeValueType.Map;
                this._value = value;
                this._isSet = true;
            }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="M"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsMSet
        {
            get
            {
                return this._type == AttributeValueType.MapSet
                    && this._isSet;
            }
            set
            {
                this._type = AttributeValueType.MapSet;
                this._value = default(bool);
                this._isSet = value;
            }
        }

        // Check to see if M property is set
        internal bool IsSetM()
        {
            return this._type == AttributeValueType.MapSet
                && this._isSet;
        }

        /// <summary>
        /// Gets and sets the property N. 
        /// <para>
        /// An attribute of type Number. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"N": "123.45"</code> 
        /// </para>
        ///  
        /// <para>
        /// Numbers are sent across the network to DynamoDB as strings, to maximize compatibility
        /// across languages and libraries. However, DynamoDB treats them as number type attributes
        /// for mathematical operations.
        /// </para>
        /// </summary>
        public string N
        {
            get {
                if (this._type == AttributeValueType.Number
                    && this._isSet
                    && this._value is string s)
                {
                    return s;
                }

                return default;
            }
            set {
                this._type = AttributeValueType.Number;
                this._value = value;
                this._isSet = true;
            }
        }

        // Check to see if N property is set
        internal bool IsSetN()
        {
            return this._type == AttributeValueType.Number
                && this._isSet;
        }

        /// <summary>
        /// Gets and sets the property NS. 
        /// <para>
        /// An attribute of type Number Set. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"NS": ["42.2", "-19", "7.5", "3.14"]</code> 
        /// </para>
        ///  
        /// <para>
        /// Numbers are sent across the network to DynamoDB as strings, to maximize compatibility
        /// across languages and libraries. However, DynamoDB treats them as number type attributes
        /// for mathematical operations.
        /// </para>
        /// </summary>
        public List<string> NS
        {
            get {
                if (this._type == AttributeValueType.NumberSet
                    && this._isSet
                    && this._value is List<string> list)
                {
                    return list;
                }

                return default;
            }
            set {
                this._type = AttributeValueType.NumberSet;
                this._value = value;
                this._isSet = true;
            }
        }

        // Check to see if NS property is set
        internal bool IsSetNS()
        {
            return this._type == AttributeValueType.NumberSet
                && this._isSet;
        }

        /// <summary>
        /// Gets and sets the property NULL. 
        /// <para>
        /// An attribute of type Null. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"NULL": true</code> 
        /// </para>
        /// </summary>
        public bool NULL
        {
            get {
                return this._type == AttributeValueType.Null
                    && this._isSet
                    && this._value is bool b
                    ? b : default;
            }
            set {
                this._type = AttributeValueType.Null;
                this._value = value;
                this._isSet = true;
            }
        }

        // Check to see if NULL property is set
        internal bool IsSetNULL()
        {
            return this._type == AttributeValueType.Null
                && this._isSet;
        }

        /// <summary>
        /// Gets and sets the property S. 
        /// <para>
        /// An attribute of type String. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"S": "Hello"</code> 
        /// </para>
        /// </summary>
        public string S
        {
            get {
                if (this._type == AttributeValueType.String
                    && this._isSet
                    && this._value is string s)
                {
                    return s;
                }

                return default;
            }
            set {
                this._type = AttributeValueType.String;
                this._value = value;
                this._isSet = true;
            }
        }

        // Check to see if S property is set
        internal bool IsSetS()
        {
            return this._type == AttributeValueType.String
                && this._isSet;
        }

        /// <summary>
        /// Gets and sets the property SS. 
        /// <para>
        /// An attribute of type String Set. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"SS": ["Giraffe", "Hippo" ,"Zebra"]</code> 
        /// </para>
        /// </summary>
        public List<string> SS
        {
            get
            {
                if (this._type == AttributeValueType.StringSet
                    && this._isSet
                    && this._value is List<string> stringSet)
                {
                    return stringSet;
                }

                return default;
            }
            set
            {
                this._type = AttributeValueType.StringSet;
                this._value = value;
                this._isSet = true;
            }
        }

        // Check to see if SS property is set
        internal bool IsSetSS()
        {
            return this._type == AttributeValueType.StringSet
                && this._isSet;
        }

    }
}