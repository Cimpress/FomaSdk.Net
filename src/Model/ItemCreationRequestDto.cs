using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ItemCreationRequestDto {
    /// <summary>
    /// Gets or Sets SkuCode
    /// </summary>
    [DataMember(Name="skuCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skuCode")]
    public string SkuCode { get; set; }

    /// <summary>
    /// Links to other data about the item.
    /// </summary>
    /// <value>Links to other data about the item.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public ItemRequestLinks Links { get; set; }

    /// <summary>
    /// The customer promised date in the customer's local time.
    /// </summary>
    /// <value>The customer promised date in the customer's local time.</value>
    [DataMember(Name="localPromisedArrivalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localPromisedArrivalDate")]
    public DateTime? LocalPromisedArrivalDate { get; set; }

    /// <summary>
    /// The destination address where all items in this order should be shipped to.
    /// </summary>
    /// <value>The destination address where all items in this order should be shipped to.</value>
    [DataMember(Name="destinationAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationAddress")]
    public AddressDto DestinationAddress { get; set; }

    /// <summary>
    /// Dynamic product attributes of an item configrued.  For the same product, items can have different attributes.
    /// </summary>
    /// <value>Dynamic product attributes of an item configrued.  For the same product, items can have different attributes.</value>
    [DataMember(Name="itemAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemAttributes")]
    public Dictionary<string, string> ItemAttributes { get; set; }

    /// <summary>
    /// Information regarding the merchant including contact options to request support for the order.
    /// </summary>
    /// <value>Information regarding the merchant including contact options to request support for the order.</value>
    [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantInformation")]
    public ImportedMerchantItemInfoDto MerchantInformation { get; set; }

    /// <summary>
    /// List of additional configuration tags which help identify aspects of this item
    /// </summary>
    /// <value>List of additional configuration tags which help identify aspects of this item</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemCreationRequestDto {\n");
      sb.Append("  SkuCode: ").Append(SkuCode).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  LocalPromisedArrivalDate: ").Append(LocalPromisedArrivalDate).Append("\n");
      sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
      sb.Append("  ItemAttributes: ").Append(ItemAttributes).Append("\n");
      sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
