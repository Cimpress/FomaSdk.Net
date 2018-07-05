using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Pad printing insight.
  /// </summary>
  [DataContract]
  public class PadPrintingTechnologyInsightDto {
    /// <summary>
    /// The spot color to use when using pad printing technology.
    /// </summary>
    /// <value>The spot color to use when using pad printing technology.</value>
    [DataMember(Name="spotColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spotColor")]
    public string SpotColor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PadPrintingTechnologyInsightDto {\n");
      sb.Append("  SpotColor: ").Append(SpotColor).Append("\n");
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
