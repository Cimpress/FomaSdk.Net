using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FulfilledItemStatusDto {
    /// <summary>
    /// Gets or Sets StatusDetails
    /// </summary>
    [DataMember(Name="statusDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusDetails")]
    public DetailStatus StatusDetails { get; set; }

    /// <summary>
    /// Gets or Sets StatusSummary
    /// </summary>
    [DataMember(Name="statusSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusSummary")]
    public SummaryStatus StatusSummary { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FulfilledItemStatusDto {\n");
      sb.Append("  StatusDetails: ").Append(StatusDetails).Append("\n");
      sb.Append("  StatusSummary: ").Append(StatusSummary).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
