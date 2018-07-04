using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// A notification request&#39;s associated item information.
  /// </summary>
  [DataContract]
  public class NotificationRequestItemDto {
    /// <summary>
    /// Item information for this creation request. Either must be an existing item or for OrderRequests must be a unique external itemId.
    /// </summary>
    /// <value>Item information for this creation request. Either must be an existing item or for OrderRequests must be a unique external itemId.</value>
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemId")]
    public string ItemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationRequestItemDto {\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
