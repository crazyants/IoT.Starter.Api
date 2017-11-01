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
    /// 
    /// </summary>
    [DataContract]
    public partial class Forecast :  IEquatable<Forecast>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Forecast" /> class.
        /// </summary>
        /// <param name="Date">Date.</param>
        /// <param name="Pressure">Pressure.</param>
        /// <param name="Humidity">Humidity.</param>
        /// <param name="WindSpeed">WindSpeed.</param>
        /// <param name="Clouds">Clouds.</param>
        /// <param name="Temperature">Temperature.</param>
        /// <param name="Weather">Weather.</param>
        public Forecast(DateTime? Date = null, double? Pressure = null, int? Humidity = null, double? WindSpeed = null, int? Clouds = null, ForecastTemperature Temperature = null, WeatherForecast Weather = null)
        {
            this.Date = Date;
            this.Pressure = Pressure;
            this.Humidity = Humidity;
            this.WindSpeed = WindSpeed;
            this.Clouds = Clouds;
            this.Temperature = Temperature;
            this.Weather = Weather;
            
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Pressure
        /// </summary>
        [DataMember(Name="pressure")]
        public double? Pressure { get; set; }

        /// <summary>
        /// Gets or Sets Humidity
        /// </summary>
        [DataMember(Name="humidity")]
        public int? Humidity { get; set; }

        /// <summary>
        /// Gets or Sets WindSpeed
        /// </summary>
        [DataMember(Name="windSpeed")]
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Clouds
        /// </summary>
        [DataMember(Name="clouds")]
        public int? Clouds { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name="temperature")]
        public ForecastTemperature Temperature { get; set; }

        /// <summary>
        /// Gets or Sets Weather
        /// </summary>
        [DataMember(Name="weather")]
        public WeatherForecast Weather { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Forecast {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Pressure: ").Append(Pressure).Append("\n");
            sb.Append("  Humidity: ").Append(Humidity).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  Clouds: ").Append(Clouds).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  Weather: ").Append(Weather).Append("\n");
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
            return Equals((Forecast)obj);
        }

        /// <summary>
        /// Returns true if Forecast instances are equal
        /// </summary>
        /// <param name="other">Instance of Forecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Forecast other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Pressure == other.Pressure ||
                    this.Pressure != null &&
                    this.Pressure.Equals(other.Pressure)
                ) && 
                (
                    this.Humidity == other.Humidity ||
                    this.Humidity != null &&
                    this.Humidity.Equals(other.Humidity)
                ) && 
                (
                    this.WindSpeed == other.WindSpeed ||
                    this.WindSpeed != null &&
                    this.WindSpeed.Equals(other.WindSpeed)
                ) && 
                (
                    this.Clouds == other.Clouds ||
                    this.Clouds != null &&
                    this.Clouds.Equals(other.Clouds)
                ) && 
                (
                    this.Temperature == other.Temperature ||
                    this.Temperature != null &&
                    this.Temperature.Equals(other.Temperature)
                ) && 
                (
                    this.Weather == other.Weather ||
                    this.Weather != null &&
                    this.Weather.Equals(other.Weather)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Pressure != null)
                    hash = hash * 59 + this.Pressure.GetHashCode();
                if (this.Humidity != null)
                    hash = hash * 59 + this.Humidity.GetHashCode();
                if (this.WindSpeed != null)
                    hash = hash * 59 + this.WindSpeed.GetHashCode();
                if (this.Clouds != null)
                    hash = hash * 59 + this.Clouds.GetHashCode();
                if (this.Temperature != null)
                    hash = hash * 59 + this.Temperature.GetHashCode();
                if (this.Weather != null)
                    hash = hash * 59 + this.Weather.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Forecast left, Forecast right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Forecast left, Forecast right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
