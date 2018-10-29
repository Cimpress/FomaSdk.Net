using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Detailed status information of an item.
  /// </summary>
  [DataContract]
  public class DetailStatus {
    /// <summary>
    /// Details if the item has been canceled.
    /// </summary>
    /// <value>Details if the item has been canceled.</value>
    [DataMember(Name="cancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancelled")]
    public DetailQuantityStatus Cancelled { get; set; }

    /// <summary>
    /// Details if the item has been rejected by the fulfiller.
    /// </summary>
    /// <value>Details if the item has been rejected by the fulfiller.</value>
    [DataMember(Name="rejected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rejected")]
    public DetailQuantityStatus Rejected { get; set; }

    /// <summary>
    /// Details if the item has been shipped.
    /// </summary>
    /// <value>Details if the item has been shipped.</value>
    [DataMember(Name="shipped", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipped")]
    public DetailQuantityStatusWithShipmentLinks Shipped { get; set; }

    /// <summary>
    /// Details if the item has been accepted.
    /// </summary>
    /// <value>Details if the item has been accepted.</value>
    [DataMember(Name="accepted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accepted")]
    public DetailQuantityStatus Accepted { get; set; }

    /// <summary>
    /// Details if the item has started production.
    /// </summary>
    /// <value>Details if the item has started production.</value>
    [DataMember(Name="production", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "production")]
    public DetailQuantityStatus Production { get; set; }

    /// <summary>
    /// Details if the state of the item is unknown. This should be a rare case.
    /// </summary>
    /// <value>Details if the state of the item is unknown. This should be a rare case.</value>
    [DataMember(Name="unknown", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unknown")]
    public DetailQuantityStatus Unknown { get; set; }

    /// <summary>
    /// Details if the status of the item is 'new'.
    /// </summary>
    /// <value>Details if the status of the item is 'new'.</value>
    [DataMember(Name="new", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "new")]
    public DetailQuantityStatus _New { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailStatus {\n");
      sb.Append("  Cancelled: ").Append(Cancelled).Append("\n");
      sb.Append("  Rejected: ").Append(Rejected).Append("\n");
      sb.Append("  Shipped: ").Append(Shipped).Append("\n");
      sb.Append("  Accepted: ").Append(Accepted).Append("\n");
      sb.Append("  Production: ").Append(Production).Append("\n");
      sb.Append("  Unknown: ").Append(Unknown).Append("\n");
      sb.Append("  _New: ").Append(_New).Append("\n");
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
