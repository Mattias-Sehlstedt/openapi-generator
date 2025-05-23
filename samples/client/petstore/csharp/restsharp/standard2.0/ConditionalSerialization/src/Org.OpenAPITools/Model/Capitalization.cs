/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Capitalization
    /// </summary>
    [DataContract(Name = "Capitalization")]
    public partial class Capitalization : IEquatable<Capitalization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capitalization" /> class.
        /// </summary>
        /// <param name="smallCamel">smallCamel.</param>
        /// <param name="capitalCamel">capitalCamel.</param>
        /// <param name="smallSnake">smallSnake.</param>
        /// <param name="capitalSnake">capitalSnake.</param>
        /// <param name="sCAETHFlowPoints">sCAETHFlowPoints.</param>
        /// <param name="aTTNAME">Name of the pet .</param>
        public Capitalization(string smallCamel = default, string capitalCamel = default, string smallSnake = default, string capitalSnake = default, string sCAETHFlowPoints = default, string aTTNAME = default)
        {
            this._SmallCamel = smallCamel;
            if (this.SmallCamel != null)
            {
                this._flagSmallCamel = true;
            }
            this._CapitalCamel = capitalCamel;
            if (this.CapitalCamel != null)
            {
                this._flagCapitalCamel = true;
            }
            this._SmallSnake = smallSnake;
            if (this.SmallSnake != null)
            {
                this._flagSmallSnake = true;
            }
            this._CapitalSnake = capitalSnake;
            if (this.CapitalSnake != null)
            {
                this._flagCapitalSnake = true;
            }
            this._SCAETHFlowPoints = sCAETHFlowPoints;
            if (this.SCAETHFlowPoints != null)
            {
                this._flagSCAETHFlowPoints = true;
            }
            this._ATT_NAME = aTTNAME;
            if (this.ATT_NAME != null)
            {
                this._flagATT_NAME = true;
            }
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets SmallCamel
        /// </summary>
        [DataMember(Name = "smallCamel", EmitDefaultValue = false)]
        public string SmallCamel
        {
            get{ return _SmallCamel;}
            set
            {
                _SmallCamel = value;
                _flagSmallCamel = true;
            }
        }
        private string _SmallCamel;
        private bool _flagSmallCamel;

        /// <summary>
        /// Returns false as SmallCamel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSmallCamel()
        {
            return _flagSmallCamel;
        }
        /// <summary>
        /// Gets or Sets CapitalCamel
        /// </summary>
        [DataMember(Name = "CapitalCamel", EmitDefaultValue = false)]
        public string CapitalCamel
        {
            get{ return _CapitalCamel;}
            set
            {
                _CapitalCamel = value;
                _flagCapitalCamel = true;
            }
        }
        private string _CapitalCamel;
        private bool _flagCapitalCamel;

        /// <summary>
        /// Returns false as CapitalCamel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCapitalCamel()
        {
            return _flagCapitalCamel;
        }
        /// <summary>
        /// Gets or Sets SmallSnake
        /// </summary>
        [DataMember(Name = "small_Snake", EmitDefaultValue = false)]
        public string SmallSnake
        {
            get{ return _SmallSnake;}
            set
            {
                _SmallSnake = value;
                _flagSmallSnake = true;
            }
        }
        private string _SmallSnake;
        private bool _flagSmallSnake;

        /// <summary>
        /// Returns false as SmallSnake should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSmallSnake()
        {
            return _flagSmallSnake;
        }
        /// <summary>
        /// Gets or Sets CapitalSnake
        /// </summary>
        [DataMember(Name = "Capital_Snake", EmitDefaultValue = false)]
        public string CapitalSnake
        {
            get{ return _CapitalSnake;}
            set
            {
                _CapitalSnake = value;
                _flagCapitalSnake = true;
            }
        }
        private string _CapitalSnake;
        private bool _flagCapitalSnake;

        /// <summary>
        /// Returns false as CapitalSnake should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCapitalSnake()
        {
            return _flagCapitalSnake;
        }
        /// <summary>
        /// Gets or Sets SCAETHFlowPoints
        /// </summary>
        [DataMember(Name = "SCA_ETH_Flow_Points", EmitDefaultValue = false)]
        public string SCAETHFlowPoints
        {
            get{ return _SCAETHFlowPoints;}
            set
            {
                _SCAETHFlowPoints = value;
                _flagSCAETHFlowPoints = true;
            }
        }
        private string _SCAETHFlowPoints;
        private bool _flagSCAETHFlowPoints;

        /// <summary>
        /// Returns false as SCAETHFlowPoints should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSCAETHFlowPoints()
        {
            return _flagSCAETHFlowPoints;
        }
        /// <summary>
        /// Name of the pet 
        /// </summary>
        /// <value>Name of the pet </value>
        [DataMember(Name = "ATT_NAME", EmitDefaultValue = false)]
        public string ATT_NAME
        {
            get{ return _ATT_NAME;}
            set
            {
                _ATT_NAME = value;
                _flagATT_NAME = true;
            }
        }
        private string _ATT_NAME;
        private bool _flagATT_NAME;

        /// <summary>
        /// Returns false as ATT_NAME should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeATT_NAME()
        {
            return _flagATT_NAME;
        }
        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Capitalization {\n");
            sb.Append("  SmallCamel: ").Append(SmallCamel).Append("\n");
            sb.Append("  CapitalCamel: ").Append(CapitalCamel).Append("\n");
            sb.Append("  SmallSnake: ").Append(SmallSnake).Append("\n");
            sb.Append("  CapitalSnake: ").Append(CapitalSnake).Append("\n");
            sb.Append("  SCAETHFlowPoints: ").Append(SCAETHFlowPoints).Append("\n");
            sb.Append("  ATT_NAME: ").Append(ATT_NAME).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Capitalization).AreEqual;
        }

        /// <summary>
        /// Returns true if Capitalization instances are equal
        /// </summary>
        /// <param name="input">Instance of Capitalization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Capitalization input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SmallCamel != null)
                {
                    hashCode = (hashCode * 59) + this.SmallCamel.GetHashCode();
                }
                if (this.CapitalCamel != null)
                {
                    hashCode = (hashCode * 59) + this.CapitalCamel.GetHashCode();
                }
                if (this.SmallSnake != null)
                {
                    hashCode = (hashCode * 59) + this.SmallSnake.GetHashCode();
                }
                if (this.CapitalSnake != null)
                {
                    hashCode = (hashCode * 59) + this.CapitalSnake.GetHashCode();
                }
                if (this.SCAETHFlowPoints != null)
                {
                    hashCode = (hashCode * 59) + this.SCAETHFlowPoints.GetHashCode();
                }
                if (this.ATT_NAME != null)
                {
                    hashCode = (hashCode * 59) + this.ATT_NAME.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
