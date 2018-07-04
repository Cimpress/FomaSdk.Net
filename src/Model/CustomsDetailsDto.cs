using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Various customs details.
  /// </summary>
  [DataContract]
  public class CustomsDetailsDto {
    /// <summary>
    /// The ConsigneeAddress provided for trade compliance.
    /// </summary>
    /// <value>The ConsigneeAddress provided for trade compliance.</value>
    [DataMember(Name="consigneeAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consigneeAddress")]
    public AddressDto ConsigneeAddress { get; set; }

    /// <summary>
    /// The Tax Payer's ID for order.
    /// </summary>
    /// <value>The Tax Payer's ID for order.</value>
    [DataMember(Name="taxpayerIdentification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxpayerIdentification")]
    public string TaxpayerIdentification { get; set; }

    /// <summary>
    /// Shipping details per item.
    /// </summary>
    /// <value>Shipping details per item.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public Dictionary<string, CustomsItemDetailsDto> Items { get; set; }

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
      sb.Append("class CustomsDetailsDto {\n");
      sb.Append("  ConsigneeAddress: ").Append(ConsigneeAddress).Append("\n");
      sb.Append("  TaxpayerIdentification: ").Append(TaxpayerIdentification).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
