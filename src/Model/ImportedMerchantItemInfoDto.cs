using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Information regarding the merchant&#39;s order.
  /// </summary>
  [DataContract]
  public class ImportedMerchantItemInfoDto {
    /// <summary>
    /// The ID of the merchant.
    /// </summary>
    /// <value>The ID of the merchant.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The merchant's item Id.
    /// </summary>
    /// <value>The merchant's item Id.</value>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemId")]
    public string ItemId { get; set; }

    /// <summary>
    /// The merchant's order Id.
    /// </summary>
    /// <value>The merchant's order Id.</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// Support options to contact the merchant.
    /// </summary>
    /// <value>Support options to contact the merchant.</value>
    [DataMember(Name="support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "support")]
    public MerchantSupportDto Support { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImportedMerchantItemInfoDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Support: ").Append(Support).Append("\n");
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
