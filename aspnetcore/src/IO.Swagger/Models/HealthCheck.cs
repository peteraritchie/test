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
    public partial class HealthCheck : IEquatable<HealthCheck>
    { 
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [Required]
        [DataMember(Name="status")]
        public Status Status { get; set; }

        /// <summary>
        /// (optional) is a unique identifier of the service, in the application scope. 
        /// </summary>
        /// <value>(optional) is a unique identifier of the service, in the application scope. </value>
        [Required]
        [DataMember(Name="serviceId")]
        public string ServiceId { get; set; }

        /// <summary>
        /// (optional) is a human-friendly description of the service. 
        /// </summary>
        /// <value>(optional) is a human-friendly description of the service. </value>
        [DataMember(Name="version")]
        public string Version { get; set; }

        /// <summary>
        /// (optional) in well-designed APIs, backwards-compatible changes in the service should not update a version number.  APIs usually change their version number as infrequently as  possible, to preserve stable interface.  However, implementation of an API may change much more frequently, which leads to the importance of having separate \&quot;release number\&quot; or \&quot;releaseId\&quot; that is different from the public version of the API. 
        /// </summary>
        /// <value>(optional) in well-designed APIs, backwards-compatible changes in the service should not update a version number.  APIs usually change their version number as infrequently as  possible, to preserve stable interface.  However, implementation of an API may change much more frequently, which leads to the importance of having separate \&quot;release number\&quot; or \&quot;releaseId\&quot; that is different from the public version of the API. </value>
        [DataMember(Name="releaseId")]
        public string ReleaseId { get; set; }

        /// <summary>
        /// (optional) array of notes relevant to current state of health 
        /// </summary>
        /// <value>(optional) array of notes relevant to current state of health </value>
        [DataMember(Name="notes")]
        public List<string> Notes { get; set; }

        /// <summary>
        /// output: (optional) raw error output, in case of \&quot;fail\&quot; or \&quot;warn\&quot; states.  This field SHOULD be omitted for \&quot;pass\&quot; state. 
        /// </summary>
        /// <value>output: (optional) raw error output, in case of \&quot;fail\&quot; or \&quot;warn\&quot; states.  This field SHOULD be omitted for \&quot;pass\&quot; state. </value>
        [DataMember(Name="output")]
        public string Output { get; set; }

        /// <summary>
        /// Gets or Sets Checks
        /// </summary>
        [DataMember(Name="checks")]
        public Checks Checks { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links")]
        public Links Links { get; set; }

        /// <summary>
        /// (optional) is a human-friendly description of the service. 
        /// </summary>
        /// <value>(optional) is a human-friendly description of the service. </value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealthCheck {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ReleaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HealthCheck)obj);
        }

        /// <summary>
        /// Returns true if HealthCheck instances are equal
        /// </summary>
        /// <param name="other">Instance of HealthCheck to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthCheck other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    ServiceId == other.ServiceId ||
                    ServiceId != null &&
                    ServiceId.Equals(other.ServiceId)
                ) && 
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.Equals(other.Version)
                ) && 
                (
                    ReleaseId == other.ReleaseId ||
                    ReleaseId != null &&
                    ReleaseId.Equals(other.ReleaseId)
                ) && 
                (
                    Notes == other.Notes ||
                    Notes != null &&
                    Notes.SequenceEqual(other.Notes)
                ) && 
                (
                    Output == other.Output ||
                    Output != null &&
                    Output.Equals(other.Output)
                ) && 
                (
                    Checks == other.Checks ||
                    Checks != null &&
                    Checks.Equals(other.Checks)
                ) && 
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.Equals(other.Links)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (ServiceId != null)
                    hashCode = hashCode * 59 + ServiceId.GetHashCode();
                    if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                    if (ReleaseId != null)
                    hashCode = hashCode * 59 + ReleaseId.GetHashCode();
                    if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                    if (Output != null)
                    hashCode = hashCode * 59 + Output.GetHashCode();
                    if (Checks != null)
                    hashCode = hashCode * 59 + Checks.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HealthCheck left, HealthCheck right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HealthCheck left, HealthCheck right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
