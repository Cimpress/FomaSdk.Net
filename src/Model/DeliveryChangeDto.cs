using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Details of the changes related to delivery.
  /// </summary>
  [DataContract]
  public class DeliveryChangeDto {
    /// <summary>
    /// The new destination address in case the destination address has changed as part of the change request.
    /// </summary>
    /// <value>The new destination address in case the destination address has changed as part of the change request.</value>
    [DataMember(Name="destinationAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationAddress")]
    public AddressChangeDto DestinationAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeliveryChangeDto {\n");
      sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
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
