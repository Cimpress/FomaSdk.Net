using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Various manufacturing details.
  /// </summary>
  [DataContract]
  public class ManufacturingDetailDto {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }

    /// <summary>
    /// The insights for various manufacturing details, different depending on the printing technology of the product.
    /// </summary>
    /// <value>The insights for various manufacturing details, different depending on the printing technology of the product.</value>
    [DataMember(Name="insights", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insights")]
    public InsightDto Insights { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ManufacturingDetailDto {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Insights: ").Append(Insights).Append("\n");
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
