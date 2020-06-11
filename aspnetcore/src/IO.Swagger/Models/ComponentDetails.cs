/*
 * Health-check API
 *
 * Health-check API  See: [https://tools.ietf.org/html/draft-inadarei-api-health-check-04#section-3.8]() 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: you@your-company.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ComponentDetails : IEquatable<ComponentDetails>
    { 
        /// <summary>
        /// (optional) is a unique identifier of an instance of a specific sub-component/dependency of a service. 
        /// </summary>
        /// <value>(optional) is a unique identifier of an instance of a specific sub-component/dependency of a service. </value>
        [DataMember(Name="componentId")]
        public string ComponentId { get; set; }

        /// <summary>
        /// (optional) SHOULD be present if componentName is present. It&#x27;s a type of the component and could be one of:    o  Pre-defined value from this spec.  Pre-defined values include:       *  component       *  datastore       *  system    o  A common and standard term from a well-known source such as      schema.org, IANA or microformats.    o  A URI that indicates extra semantics and processing rules that MAY      be provided by a resource at the other end of the URI.  URIs do      not have to be dereferenceable, however.  They are just a      namespace, and the meaning of a namespace CAN be provided by any      convenient means (e.g. publishing an RFC, Swagger document or a      nicely printed book). 
        /// </summary>
        /// <value>(optional) SHOULD be present if componentName is present. It&#x27;s a type of the component and could be one of:    o  Pre-defined value from this spec.  Pre-defined values include:       *  component       *  datastore       *  system    o  A common and standard term from a well-known source such as      schema.org, IANA or microformats.    o  A URI that indicates extra semantics and processing rules that MAY      be provided by a resource at the other end of the URI.  URIs do      not have to be dereferenceable, however.  They are just a      namespace, and the meaning of a namespace CAN be provided by any      convenient means (e.g. publishing an RFC, Swagger document or a      nicely printed book). </value>
        [DataMember(Name="componentType")]
        public string ComponentType { get; set; }

        /// <summary>
        /// (optional) could be any valid JSON value, such as: string, number, object, array or literal. 
        /// </summary>
        /// <value>(optional) could be any valid JSON value, such as: string, number, object, array or literal. </value>
        [DataMember(Name="observedValue")]
        public string ObservedValue { get; set; }

        /// <summary>
        /// (optional) SHOULD be present if observedValue is present.  Clarifies the unit of measurement in which observedUnit is reported, e.g. for a time-based value it is important to know whether the time is reported in seconds, minutes, hours or something else. To make sure unit is denoted by a well-understood name or an abbreviation, it SHOULD be one of:  o  A common and standard term from a well-known source such as    schema.org, IANA, microformats, or a standards document such as    [RFC3339].  o  A URI that indicates extra semantics and processing rules that MAY    be provided by a resource at the other end of the URI.  URIs do    not have to be dereferenceable, however.  They are just a    namespace, and the meaning of a namespace CAN be provided by any    convenient means (e.g. publishing an RFC, Swagger document or a    nicely printed book). 
        /// </summary>
        /// <value>(optional) SHOULD be present if observedValue is present.  Clarifies the unit of measurement in which observedUnit is reported, e.g. for a time-based value it is important to know whether the time is reported in seconds, minutes, hours or something else. To make sure unit is denoted by a well-understood name or an abbreviation, it SHOULD be one of:  o  A common and standard term from a well-known source such as    schema.org, IANA, microformats, or a standards document such as    [RFC3339].  o  A URI that indicates extra semantics and processing rules that MAY    be provided by a resource at the other end of the URI.  URIs do    not have to be dereferenceable, however.  They are just a    namespace, and the meaning of a namespace CAN be provided by any    convenient means (e.g. publishing an RFC, Swagger document or a    nicely printed book). </value>
        [DataMember(Name="observedUnit")]
        public OneOfcomponentDetailsObservedUnit ObservedUnit { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public Status Status { get; set; }

        /// <summary>
        /// (optional) is a JSON array containing URI Templates as defined by [RFC6570].  This field SHOULD be omitted if the \&quot;status\&quot; field is present and has value equal to \&quot;pass\&quot;.  A typical API has many URI endpoints.  Most of the time we are interested in the overall health of the API, without diving into details.  That said, sometimes operational and resilience middleware needs to know more details about the health of the API (which is why \&quot;checks\&quot; property provides details).  In such cases, we often need to indicate which particular endpoints are affected by a particular check&#x27;s troubles vs. other endpoints that may be fine. 
        /// </summary>
        /// <value>(optional) is a JSON array containing URI Templates as defined by [RFC6570].  This field SHOULD be omitted if the \&quot;status\&quot; field is present and has value equal to \&quot;pass\&quot;.  A typical API has many URI endpoints.  Most of the time we are interested in the overall health of the API, without diving into details.  That said, sometimes operational and resilience middleware needs to know more details about the health of the API (which is why \&quot;checks\&quot; property provides details).  In such cases, we often need to indicate which particular endpoints are affected by a particular check&#x27;s troubles vs. other endpoints that may be fine. </value>
        [DataMember(Name="affectedEndpoints")]
        public List<string> AffectedEndpoints { get; set; }

        /// <summary>
        /// time (optional) is the date-time, in ISO8601 format, at which the reading of the observedValue was recorded. 
        /// </summary>
        /// <value>time (optional) is the date-time, in ISO8601 format, at which the reading of the observedValue was recorded. </value>
        [DataMember(Name="time")]
        public string Time { get; set; }

        /// <summary>
        /// output: (optional) raw error output, in case of \&quot;fail\&quot; or \&quot;warn\&quot; states.  This field SHOULD be omitted for \&quot;pass\&quot; state. 
        /// </summary>
        /// <value>output: (optional) raw error output, in case of \&quot;fail\&quot; or \&quot;warn\&quot; states.  This field SHOULD be omitted for \&quot;pass\&quot; state. </value>
        [DataMember(Name="output")]
        public string Output { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links")]
        public Links Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComponentDetails {\n");
            sb.Append("  ComponentId: ").Append(ComponentId).Append("\n");
            sb.Append("  ComponentType: ").Append(ComponentType).Append("\n");
            sb.Append("  ObservedValue: ").Append(ObservedValue).Append("\n");
            sb.Append("  ObservedUnit: ").Append(ObservedUnit).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AffectedEndpoints: ").Append(AffectedEndpoints).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ComponentDetails)obj);
        }

        /// <summary>
        /// Returns true if ComponentDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ComponentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComponentDetails other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ComponentId == other.ComponentId ||
                    ComponentId != null &&
                    ComponentId.Equals(other.ComponentId)
                ) && 
                (
                    ComponentType == other.ComponentType ||
                    ComponentType != null &&
                    ComponentType.Equals(other.ComponentType)
                ) && 
                (
                    ObservedValue == other.ObservedValue ||
                    ObservedValue != null &&
                    ObservedValue.Equals(other.ObservedValue)
                ) && 
                (
                    ObservedUnit == other.ObservedUnit ||
                    ObservedUnit != null &&
                    ObservedUnit.Equals(other.ObservedUnit)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    AffectedEndpoints == other.AffectedEndpoints ||
                    AffectedEndpoints != null &&
                    AffectedEndpoints.SequenceEqual(other.AffectedEndpoints)
                ) && 
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                ) && 
                (
                    Output == other.Output ||
                    Output != null &&
                    Output.Equals(other.Output)
                ) && 
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.Equals(other.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ComponentId != null)
                    hashCode = hashCode * 59 + ComponentId.GetHashCode();
                    if (ComponentType != null)
                    hashCode = hashCode * 59 + ComponentType.GetHashCode();
                    if (ObservedValue != null)
                    hashCode = hashCode * 59 + ObservedValue.GetHashCode();
                    if (ObservedUnit != null)
                    hashCode = hashCode * 59 + ObservedUnit.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (AffectedEndpoints != null)
                    hashCode = hashCode * 59 + AffectedEndpoints.GetHashCode();
                    if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                    if (Output != null)
                    hashCode = hashCode * 59 + Output.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ComponentDetails left, ComponentDetails right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ComponentDetails left, ComponentDetails right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
