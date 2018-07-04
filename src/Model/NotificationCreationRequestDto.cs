using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// A request to create a new notification.
  /// </summary>
  [DataContract]
  public class NotificationCreationRequestDto {
    /// <summary>
    /// Type of notification request that is being made. This drives the required fields.
    /// </summary>
    /// <value>Type of notification request that is being made. This drives the required fields.</value>
    [DataMember(Name="notificationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notificationType")]
    public string NotificationType { get; set; }

    /// <summary>
    /// Item information for this creation request.
    /// </summary>
    /// <value>Item information for this creation request.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<NotificationRequestItemDto> Items { get; set; }

    /// <summary>
    /// Must be appended to \"RetryOrderRequest\" notifications, which contains details of the retry.
    /// </summary>
    /// <value>Must be appended to \"RetryOrderRequest\" notifications, which contains details of the retry.</value>
    [DataMember(Name="retryDetailsDto", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retryDetailsDto")]
    public RetryDetailsDto RetryDetailsDto { get; set; }

    /// <summary>
    /// Must be appended to \"ItemRejected\" notifications, which contains details of the rejection.
    /// </summary>
    /// <value>Must be appended to \"ItemRejected\" notifications, which contains details of the rejection.</value>
    [DataMember(Name="rejectionDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rejectionDetails")]
    public RejectionDto RejectionDetails { get; set; }

    /// <summary>
    /// Can be added to \"Informational\" notifications, which contains additional information.
    /// </summary>
    /// <value>Can be added to \"Informational\" notifications, which contains additional information.</value>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, Object> Attributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationCreationRequestDto {\n");
      sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  RetryDetailsDto: ").Append(RetryDetailsDto).Append("\n");
      sb.Append("  RejectionDetails: ").Append(RejectionDetails).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
