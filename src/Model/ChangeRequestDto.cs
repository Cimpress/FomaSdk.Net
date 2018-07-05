using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// The change details.
  /// </summary>
  [DataContract]
  public class ChangeRequestDto {
    /// <summary>
    /// Changes related to the delivery. Set if the change request is related to delivery changes.
    /// </summary>
    /// <value>Changes related to the delivery. Set if the change request is related to delivery changes.</value>
    [DataMember(Name="deliveryChangeDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryChangeDetails")]
    public DeliveryChangeDto DeliveryChangeDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChangeRequestDto {\n");
      sb.Append("  DeliveryChangeDetails: ").Append(DeliveryChangeDetails).Append("\n");
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
