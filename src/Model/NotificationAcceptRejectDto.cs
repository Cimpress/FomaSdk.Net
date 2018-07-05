using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Specifies details of accepting / rejecting notifications.
  /// </summary>
  [DataContract]
  public class NotificationAcceptRejectDto {
    /// <summary>
    /// Whether costs have incurred or not. This is only relevant if it's a response to a cancellation request.  If the value is omitted, false is assumed.
    /// </summary>
    /// <value>Whether costs have incurred or not. This is only relevant if it's a response to a cancellation request.  If the value is omitted, false is assumed.</value>
    [DataMember(Name="costsIncurred", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "costsIncurred")]
    public bool? CostsIncurred { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationAcceptRejectDto {\n");
      sb.Append("  CostsIncurred: ").Append(CostsIncurred).Append("\n");
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
