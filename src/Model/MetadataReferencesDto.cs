using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MetadataReferencesDto {
    /// <summary>
    /// An item id reference, for example a non-mcp id
    /// </summary>
    /// <value>An item id reference, for example a non-mcp id</value>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemId")]
    public string ItemId { get; set; }

    /// <summary>
    /// A SKU, for example a non-mcp sku
    /// </summary>
    /// <value>A SKU, for example a non-mcp sku</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetadataReferencesDto {\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
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
