/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk�s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com 
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
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model.DesignAutomation.v3
{
    /// <summary>
    /// Signatures for various attributes in WorkItem.
    /// </summary>
    [DataContract]
    public partial class WorkItemSignatures :  IEquatable<WorkItemSignatures>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemSignatures" /> class.
        /// </summary>
        /// <param name="ActivityId">Digital signature of the ActivityId. The client must supply this when using a 3-legged oauth token for submitting a workitem..</param>
        /// <param name="BaseUrls">Digitally signed base urls that are allowed in the workitem. The client may supply these when using a 3-legged oauth token for submitting a workitem..</param>
        public WorkItemSignatures(string ActivityId = null, List<SignedUrl> BaseUrls = null)
        {
            this.ActivityId = ActivityId;
            this.BaseUrls = BaseUrls;
        }
        
        /// <summary>
        /// Digital signature of the ActivityId. The client must supply this when using a 3-legged oauth token for submitting a workitem.
        /// </summary>
        /// <value>Digital signature of the ActivityId. The client must supply this when using a 3-legged oauth token for submitting a workitem.</value>
        [DataMember(Name="activityId", EmitDefaultValue=false)]
        public string ActivityId { get; set; }
        /// <summary>
        /// Digitally signed base urls that are allowed in the workitem. The client may supply these when using a 3-legged oauth token for submitting a workitem.
        /// </summary>
        /// <value>Digitally signed base urls that are allowed in the workitem. The client may supply these when using a 3-legged oauth token for submitting a workitem.</value>
        [DataMember(Name="baseUrls", EmitDefaultValue=false)]
        public List<SignedUrl> BaseUrls { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemSignatures {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  BaseUrls: ").Append(BaseUrls).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WorkItemSignatures);
        }

        /// <summary>
        /// Returns true if WorkItemSignatures instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkItemSignatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemSignatures other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActivityId == other.ActivityId ||
                    this.ActivityId != null &&
                    this.ActivityId.Equals(other.ActivityId)
                ) && 
                (
                    this.BaseUrls == other.BaseUrls ||
                    this.BaseUrls != null &&
                    this.BaseUrls.SequenceEqual(other.BaseUrls)
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
                if (this.ActivityId != null)
                    hash = hash * 59 + this.ActivityId.GetHashCode();
                if (this.BaseUrls != null)
                    hash = hash * 59 + this.BaseUrls.GetHashCode();
                return hash;
            }
        }
    }

}
