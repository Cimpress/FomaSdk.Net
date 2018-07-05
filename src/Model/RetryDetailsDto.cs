using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Required additional fields explaning why a \&quot;RetryOrderRequest\&quot; notification is being created.
  /// </summary>
  [DataContract]
  public class RetryDetailsDto {
    /// <summary>
    /// The reason an \"RetryOrderRequest\" notification is being created.
    /// </summary>
    /// <value>The reason an \"RetryOrderRequest\" notification is being created.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// An optional message further explaning.
    /// </summary>
    /// <value>An optional message further explaning.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RetryDetailsDto {\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
