using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Simplified details of the item, with further links to full details.
  /// </summary>
  [DataContract]
  public class ItemSearchDto {
    /// <summary>
    /// The item's id.
    /// </summary>
    /// <value>The item's id.</value>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemId")]
    public string ItemId { get; set; }

    /// <summary>
    /// The item's order.
    /// </summary>
    /// <value>The item's order.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public OrderSearchDto Order { get; set; }

    /// <summary>
    /// Details to the product of the item.
    /// </summary>
    /// <value>Details to the product of the item.</value>
    [DataMember(Name="product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product")]
    public ProductSummaryDto Product { get; set; }

    /// <summary>
    /// The quantity that should be produced in total.
    /// </summary>
    /// <value>The quantity that should be produced in total.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Links to get additional details of the item.
    /// </summary>
    /// <value>Links to get additional details of the item.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemSearchDto {\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Product: ").Append(Product).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
