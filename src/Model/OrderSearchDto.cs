using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Simplified details regarding the order.
  /// </summary>
  [DataContract]
  public class OrderSearchDto {
    /// <summary>
    /// The time when this item is promised to arrive at the customer.
    /// </summary>
    /// <value>The time when this item is promised to arrive at the customer.</value>
    [DataMember(Name="promisedArrivalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "promisedArrivalDate")]
    public DateTime? PromisedArrivalDate { get; set; }

    /// <summary>
    /// The unique order Id.
    /// </summary>
    /// <value>The unique order Id.</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// List of links that are related to this order.
    /// </summary>
    /// <value>List of links that are related to this order.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderSearchDto {\n");
      sb.Append("  PromisedArrivalDate: ").Append(PromisedArrivalDate).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
