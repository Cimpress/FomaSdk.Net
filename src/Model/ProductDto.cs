using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Product details.
  /// </summary>
  [DataContract]
  public class ProductDto {
    /// <summary>
    /// The unique SKU.
    /// </summary>
    /// <value>The unique SKU.</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// A human friendly display name of the OrderManager.Controllers.SimpleApi.Items.ItemDetails.ProductDto.Sku.
    /// </summary>
    /// <value>A human friendly display name of the OrderManager.Controllers.SimpleApi.Items.ItemDetails.ProductDto.Sku.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A more detailed description of the product's OrderManager.Controllers.SimpleApi.Items.ItemDetails.ProductDto.Name.
    /// </summary>
    /// <value>A more detailed description of the product's OrderManager.Controllers.SimpleApi.Items.ItemDetails.ProductDto.Name.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Constant product attributes describing static translations and manufacturing configuration. Configured by https://introductiontool.products.cimpress.io
    /// </summary>
    /// <value>Constant product attributes describing static translations and manufacturing configuration. Configured by https://introductiontool.products.cimpress.io</value>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public List<AttributeDto> Attributes { get; set; }

    /// <summary>
    /// Decoration technologies used for this product.
    /// </summary>
    /// <value>Decoration technologies used for this product.</value>
    [DataMember(Name="decorationTechnologies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decorationTechnologies")]
    public List<string> DecorationTechnologies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductDto {\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  DecorationTechnologies: ").Append(DecorationTechnologies).Append("\n");
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
