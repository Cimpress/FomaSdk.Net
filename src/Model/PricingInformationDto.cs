using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Provides an early insight into pricing information.
  /// </summary>
  [DataContract]
  public class PricingInformationDto {
    /// <summary>
    /// The price that has been agreed to pay a fulfiller for producing this item.
    /// </summary>
    /// <value>The price that has been agreed to pay a fulfiller for producing this item.</value>
    [DataMember(Name="tradePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradePrice")]
    public PricingInformationDetailsDto TradePrice { get; set; }

    /// <summary>
    /// A hyperlink to this pricing information or known as the \"self\" link relation.
    /// </summary>
    /// <value>A hyperlink to this pricing information or known as the \"self\" link relation.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PricingInformationDto {\n");
      sb.Append("  TradePrice: ").Append(TradePrice).Append("\n");
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
