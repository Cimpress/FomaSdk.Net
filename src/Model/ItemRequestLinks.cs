using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ItemRequestLinks {
    /// <summary>
    /// All manufacturing related properties link. This link must point to a resource with fields:  * \"artworkUri\": This is link to a manufacturing ready document.  It can be in any format.  * \"DefaultPreviewUrl\": this is the preview of the product image
    /// </summary>
    /// <value>All manufacturing related properties link. This link must point to a resource with fields:  * \"artworkUri\": This is link to a manufacturing ready document.  It can be in any format.  * \"DefaultPreviewUrl\": this is the preview of the product image</value>
    [DataMember(Name="manufacturingProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "manufacturingProperties")]
    public LinkDto ManufacturingProperties { get; set; }

    /// <summary>
    /// Dynamic product attributes of an item configrued. For the same product, items can have different product configuration attributes.
    /// </summary>
    /// <value>Dynamic product attributes of an item configrued. For the same product, items can have different product configuration attributes.</value>
    [DataMember(Name="productConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productConfiguration")]
    public LinkDto ProductConfiguration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemRequestLinks {\n");
      sb.Append("  ManufacturingProperties: ").Append(ManufacturingProperties).Append("\n");
      sb.Append("  ProductConfiguration: ").Append(ProductConfiguration).Append("\n");
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
