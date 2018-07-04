using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Simplified details of the item, with further links to full details.
  /// </summary>
  [DataContract]
  public class NotificationItemDto {
    /// <summary>
    /// The item's id.
    /// </summary>
    /// <value>The item's id.</value>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemId")]
    public string ItemId { get; set; }

    /// <summary>
    /// Status of the item notification. Each item has its own notification status
    /// </summary>
    /// <value>Status of the item notification. Each item has its own notification status</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

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
      sb.Append("class NotificationItemDto {\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
