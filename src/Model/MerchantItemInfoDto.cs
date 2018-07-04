using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Information regarding the merchant&#39;s item.
  /// </summary>
  [DataContract]
  public class MerchantItemInfoDto {
    /// <summary>
    /// The merchant's Item Id.
    /// </summary>
    /// <value>The merchant's Item Id.</value>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemId")]
    public string ItemId { get; set; }

    /// <summary>
    /// The merchant's product name.
    /// </summary>
    /// <value>The merchant's product name.</value>
    [DataMember(Name="productName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productName")]
    public string ProductName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantItemInfoDto {\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
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
