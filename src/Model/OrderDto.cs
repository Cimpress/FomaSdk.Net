using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Details regaring the order.
  /// </summary>
  [DataContract]
  public class OrderDto {
    /// <summary>
    /// The unique order Id.
    /// </summary>
    /// <value>The unique order Id.</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// The Fulfiller information associated with this notification
    /// </summary>
    /// <value>The Fulfiller information associated with this notification</value>
    [DataMember(Name="fulfiller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfiller")]
    public FulfillerInfo Fulfiller { get; set; }

    /// <summary>
    /// The time stamp when the order has been created in the Mass Customization Platform.
    /// </summary>
    /// <value>The time stamp when the order has been created in the Mass Customization Platform.</value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The date when the order has been promised to arrive at the customer. The date is already converted to the customer's time zone.
    /// </summary>
    /// <value>The date when the order has been promised to arrive at the customer. The date is already converted to the customer's time zone.</value>
    [DataMember(Name="promisedArrivalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "promisedArrivalDate")]
    public DateTime? PromisedArrivalDate { get; set; }

    /// <summary>
    /// Information regarding the merchant including contact options to request support for the order.
    /// </summary>
    /// <value>Information regarding the merchant including contact options to request support for the order.</value>
    [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantInformation")]
    public MerchantOrderInfoDto MerchantInformation { get; set; }

    /// <summary>
    /// The destination address where all items in this order should be shipped to.
    /// </summary>
    /// <value>The destination address where all items in this order should be shipped to.</value>
    [DataMember(Name="destinationAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationAddress")]
    public AddressDto DestinationAddress { get; set; }

    /// <summary>
    /// Links collection related to this order.
    /// </summary>
    /// <value>Links collection related to this order.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderDto {\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Fulfiller: ").Append(Fulfiller).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  PromisedArrivalDate: ").Append(PromisedArrivalDate).Append("\n");
      sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
      sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
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
