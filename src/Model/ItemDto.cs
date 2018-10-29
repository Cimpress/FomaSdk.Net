using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Fulfillment information for an order line.
  /// </summary>
  [DataContract]
  public class ItemDto {
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    /// <value>The unique ID of the item.</value>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemId")]
    public string ItemId { get; set; }

    /// <summary>
    /// Order information.
    /// </summary>
    /// <value>Order information.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public ItemOrderDto Order { get; set; }

    /// <summary>
    /// Product information.
    /// </summary>
    /// <value>Product information.</value>
    [DataMember(Name="product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product")]
    public ProductDto Product { get; set; }

    /// <summary>
    /// The ordered quantity.
    /// </summary>
    /// <value>The ordered quantity.</value>
    [DataMember(Name="orderedQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderedQuantity")]
    public int? OrderedQuantity { get; set; }

    /// <summary>
    /// Item related information of the merchant.
    /// </summary>
    /// <value>Item related information of the merchant.</value>
    [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantInformation")]
    public MerchantItemInfoDto MerchantInformation { get; set; }

    /// <summary>
    /// Whether this is a test item or not.
    /// </summary>
    /// <value>Whether this is a test item or not.</value>
    [DataMember(Name="isTestItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTestItem")]
    public bool? IsTestItem { get; set; }

    /// <summary>
    /// Dynamic product attributes of an item configrued by the merchant.  For the same product, items can have different attributes.
    /// </summary>
    /// <value>Dynamic product attributes of an item configrued by the merchant.  For the same product, items can have different attributes.</value>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public List<AttributeDto> Attributes { get; set; }

    /// <summary>
    /// Delivery details the merchant has submitted with the order.
    /// </summary>
    /// <value>Delivery details the merchant has submitted with the order.</value>
    [DataMember(Name="deliveryDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryDetails")]
    public List<DeliveryDetailsDto> DeliveryDetails { get; set; }

    /// <summary>
    /// Metadata for this Item
    /// </summary>
    /// <value>Metadata for this Item</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public MetadataDto Metadata { get; set; }

    /// <summary>
    /// Links to additional resources for this item. Specified rels are:  * document: Retrieving the document of the item.  * preview: Retrieving the preview of the item.  * plan: Simplified production and shipping plan.  * action: Actions to perform like status changes.  * status: Status changes.  * manufacturing-details: Additional, manufacturing related details, depending on decoration technology.  * delivery-details: Details to delivery details that are relevant for split shipping.
    /// </summary>
    /// <value>Links to additional resources for this item. Specified rels are:  * document: Retrieving the document of the item.  * preview: Retrieving the preview of the item.  * plan: Simplified production and shipping plan.  * action: Actions to perform like status changes.  * status: Status changes.  * manufacturing-details: Additional, manufacturing related details, depending on decoration technology.  * delivery-details: Details to delivery details that are relevant for split shipping.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemDto {\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Product: ").Append(Product).Append("\n");
      sb.Append("  OrderedQuantity: ").Append(OrderedQuantity).Append("\n");
      sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
      sb.Append("  IsTestItem: ").Append(IsTestItem).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  DeliveryDetails: ").Append(DeliveryDetails).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
