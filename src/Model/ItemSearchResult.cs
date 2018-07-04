using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Search result with additional item detail insight.
  /// </summary>
  [DataContract]
  public class ItemSearchResult {
    /// <summary>
    /// A list of items including some simplified details about the items.
    /// </summary>
    /// <value>A list of items including some simplified details about the items.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<ItemSearchDto> Items { get; set; }

    /// <summary>
    /// The amount of items that were result with this search.
    /// </summary>
    /// <value>The amount of items that were result with this search.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The amount of items that were found totally without the restriction of the current page size.
    /// </summary>
    /// <value>The amount of items that were found totally without the restriction of the current page size.</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Links regarding this search result.
    /// </summary>
    /// <value>Links regarding this search result.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemSearchResult {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
