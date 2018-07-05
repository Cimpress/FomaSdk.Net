using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Various shiping details.
  /// </summary>
  [DataContract]
  public class ShippingDetailsDto {
    /// <summary>
    /// Merchant requested shipping label.
    /// </summary>
    /// <value>Merchant requested shipping label.</value>
    [DataMember(Name="shippingLabelDetail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingLabelDetail")]
    public ShippingLabelDetail ShippingLabelDetail { get; set; }

    /// <summary>
    /// Link to self.
    /// </summary>
    /// <value>Link to self.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingDetailsDto {\n");
      sb.Append("  ShippingLabelDetail: ").Append(ShippingLabelDetail).Append("\n");
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
