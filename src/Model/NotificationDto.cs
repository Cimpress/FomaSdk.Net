using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Details of a notification.
  /// </summary>
  [DataContract]
  public class NotificationDto {
    /// <summary>
    /// The Id of the notification, this is not the same as the order or item Ids.
    /// </summary>
    /// <value>The Id of the notification, this is not the same as the order or item Ids.</value>
    [DataMember(Name="notificationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notificationId")]
    public string NotificationId { get; set; }

    /// <summary>
    /// The type of notification. See NotoficationTypes endpoint to see full list of possible types.
    /// </summary>
    /// <value>The type of notification. See NotoficationTypes endpoint to see full list of possible types.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The status of notification. Possible values are NEW, ACCEPTED, and REJECTED.
    /// </summary>
    /// <value>The status of notification. Possible values are NEW, ACCEPTED, and REJECTED.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Date the notification was created.
    /// </summary>
    /// <value>Date the notification was created.</value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Simplified details of the order.
    /// </summary>
    /// <value>Simplified details of the order.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public OrderSummaryDto Order { get; set; }

    /// <summary>
    /// The Fulfiller information associated with this notification
    /// </summary>
    /// <value>The Fulfiller information associated with this notification</value>
    [DataMember(Name="fulfiller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfiller")]
    public FulfillerInfo Fulfiller { get; set; }

    /// <summary>
    /// List of items that belong to that order. Simplified details only.
    /// </summary>
    /// <value>List of items that belong to that order. Simplified details only.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<NotificationItemDto> Items { get; set; }

    /// <summary>
    /// Further links that are relevant for this notification.
    /// </summary>
    /// <value>Further links that are relevant for this notification.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }

    /// <summary>
    /// The change request details if the notification is of type ChangeRequest.
    /// </summary>
    /// <value>The change request details if the notification is of type ChangeRequest.</value>
    [DataMember(Name="changeRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changeRequest")]
    public ChangeRequestDto ChangeRequest { get; set; }

    /// <summary>
    /// The retry order request details if the notification is of type RetryOrderRequest.
    /// </summary>
    /// <value>The retry order request details if the notification is of type RetryOrderRequest.</value>
    [DataMember(Name="retryOrderRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retryOrderRequest")]
    public RetryDetailsDto RetryOrderRequest { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationDto {\n");
      sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Fulfiller: ").Append(Fulfiller).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  ChangeRequest: ").Append(ChangeRequest).Append("\n");
      sb.Append("  RetryOrderRequest: ").Append(RetryOrderRequest).Append("\n");
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
