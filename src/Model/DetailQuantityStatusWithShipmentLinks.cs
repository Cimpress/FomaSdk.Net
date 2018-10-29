using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DetailQuantityStatusWithShipmentLinks {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }

    /// <summary>
    /// The quantity affected by this status.
    /// </summary>
    /// <value>The quantity affected by this status.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Whether costs have incurred for the fulfiller in this status.
    /// </summary>
    /// <value>Whether costs have incurred for the fulfiller in this status.</value>
    [DataMember(Name="costsIncurred", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "costsIncurred")]
    public bool? CostsIncurred { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailQuantityStatusWithShipmentLinks {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  CostsIncurred: ").Append(CostsIncurred).Append("\n");
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
