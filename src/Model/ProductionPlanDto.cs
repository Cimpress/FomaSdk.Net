using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Detailed production plan.
  /// </summary>
  [DataContract]
  public class ProductionPlanDto {
    /// <summary>
    /// When production should be started, according to the production times for the fulfiller and SKU, adhering to shipping requirements.  This is optimized based on fulfiller's configuration  and is not a contractual plan.
    /// </summary>
    /// <value>When production should be started, according to the production times for the fulfiller and SKU, adhering to shipping requirements.  This is optimized based on fulfiller's configuration  and is not a contractual plan.</value>
    [DataMember(Name="expectedProductionStartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expectedProductionStartTime")]
    public DateTime? ExpectedProductionStartTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductionPlanDto {\n");
      sb.Append("  ExpectedProductionStartTime: ").Append(ExpectedProductionStartTime).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
