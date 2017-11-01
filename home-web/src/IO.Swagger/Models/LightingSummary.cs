/*
 * home-api
 *
 * The API for the Home Starter project
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// ok
    /// </summary>
    [DataContract]
    public partial class LightingSummary :  IEquatable<LightingSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightingSummary" /> class.
        /// </summary>
        /// <param name="Zones">Zones.</param>
        /// <param name="ZoneStatus">ZoneStatus.</param>
        public LightingSummary(List<LightingZone> Zones = null, List<LightingZoneStatus> ZoneStatus = null)
        {
            this.Zones = Zones;
            this.ZoneStatus = ZoneStatus;
            
        }

        /// <summary>
        /// Gets or Sets Zones
        /// </summary>
        [DataMember(Name="zones")]
        public List<LightingZone> Zones { get; set; }

        /// <summary>
        /// Gets or Sets ZoneStatus
        /// </summary>
        [DataMember(Name="zoneStatus")]
        public List<LightingZoneStatus> ZoneStatus { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LightingSummary {\n");
            sb.Append("  Zones: ").Append(Zones).Append("\n");
            sb.Append("  ZoneStatus: ").Append(ZoneStatus).Append("\n");
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
            if (obj.GetType() != GetType()) return false;
            return Equals((LightingSummary)obj);
        }

        /// <summary>
        /// Returns true if LightingSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of LightingSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LightingSummary other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Zones == other.Zones ||
                    this.Zones != null &&
                    this.Zones.SequenceEqual(other.Zones)
                ) && 
                (
                    this.ZoneStatus == other.ZoneStatus ||
                    this.ZoneStatus != null &&
                    this.ZoneStatus.SequenceEqual(other.ZoneStatus)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Zones != null)
                    hash = hash * 59 + this.Zones.GetHashCode();
                if (this.ZoneStatus != null)
                    hash = hash * 59 + this.ZoneStatus.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(LightingSummary left, LightingSummary right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LightingSummary left, LightingSummary right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
