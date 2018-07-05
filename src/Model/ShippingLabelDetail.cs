using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ShippingLabelDetail {
    /// <summary>
    /// Gets or Sets ShippingReference
    /// </summary>
    [DataMember(Name="shippingReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingReference")]
    public string ShippingReference { get; set; }

    /// <summary>
    /// Gets or Sets ReturnAddress
    /// </summary>
    [DataMember(Name="returnAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnAddress")]
    public AddressDto ReturnAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingLabelDetail {\n");
      sb.Append("  ShippingReference: ").Append(ShippingReference).Append("\n");
      sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
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
