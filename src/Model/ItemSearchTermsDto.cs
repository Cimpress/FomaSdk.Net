using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Search by specifying fields and values to match exactly.  FulfillerId is mandatory, the rest is optional.
  /// </summary>
  [DataContract]
  public class ItemSearchTermsDto {
    /// <summary>
    /// The ID of the fulfiller to retrieve items from. This field is required.
    /// </summary>
    /// <value>The ID of the fulfiller to retrieve items from. This field is required.</value>
    [DataMember(Name="fulfillerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfillerId")]
    public string FulfillerId { get; set; }

    /// <summary>
    /// Restricting items to a given status. Supported status values are 'new', 'accepted', 'production', 'shipped', 'completed', 'rejected', and 'cancelled'.  Multiple statuses need to be separated by comma, e.g. 'new,accepted'.
    /// </summary>
    /// <value>Restricting items to a given status. Supported status values are 'new', 'accepted', 'production', 'shipped', 'completed', 'rejected', and 'cancelled'.  Multiple statuses need to be separated by comma, e.g. 'new,accepted'.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Filter items which are forecasted to be delivered late.
    /// </summary>
    /// <value>Filter items which are forecasted to be delivered late.</value>
    [DataMember(Name="forecastedLate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forecastedLate")]
    public bool? ForecastedLate { get; set; }

    /// <summary>
    /// Filter items which have a plan and the ExpectedShipTime is specified for the item
    /// </summary>
    /// <value>Filter items which have a plan and the ExpectedShipTime is specified for the item</value>
    [DataMember(Name="planScheduled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planScheduled")]
    public bool? PlanScheduled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemSearchTermsDto {\n");
      sb.Append("  FulfillerId: ").Append(FulfillerId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ForecastedLate: ").Append(ForecastedLate).Append("\n");
      sb.Append("  PlanScheduled: ").Append(PlanScheduled).Append("\n");
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
