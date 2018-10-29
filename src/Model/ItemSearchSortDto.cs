using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// A sort criterion
  /// </summary>
  [DataContract]
  public class ItemSearchSortDto {
    /// <summary>
    /// The field to sort on. Supported fields are \"createdDate\", \"productName\", \"expectedShipTime\", \"itemId\", \"orderId\", \"promisedArrivalDate\", \"lastUpdateDate\".
    /// </summary>
    /// <value>The field to sort on. Supported fields are \"createdDate\", \"productName\", \"expectedShipTime\", \"itemId\", \"orderId\", \"promisedArrivalDate\", \"lastUpdateDate\".</value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field")]
    public string Field { get; set; }

    /// <summary>
    /// The direction of the sort. This can be either \"Ascending\" or \"Descending\". If not provided, the sort direction will be ascending
    /// </summary>
    /// <value>The direction of the sort. This can be either \"Ascending\" or \"Descending\". If not provided, the sort direction will be ascending</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemSearchSortDto {\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
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
