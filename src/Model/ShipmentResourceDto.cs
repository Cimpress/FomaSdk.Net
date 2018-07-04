using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// This is a reference to a shipment in shipment manager (https://shipment-manager.shipping.cimpress.io/api/v0/swagger)
  /// </summary>
  [DataContract]
  public class ShipmentResourceDto {
    /// <summary>
    /// The link relation which defines the schema of the shipment, only the Rel \"https://shipment-manager.shipping.cimpress.io/api/v1/shipments\" is valid.
    /// </summary>
    /// <value>The link relation which defines the schema of the shipment, only the Rel \"https://shipment-manager.shipping.cimpress.io/api/v1/shipments\" is valid.</value>
    [DataMember(Name="rel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rel")]
    public string Rel { get; set; }

    /// <summary>
    /// The url link to the actual shipment.
    /// </summary>
    /// <value>The url link to the actual shipment.</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentResourceDto {\n");
      sb.Append("  Rel: ").Append(Rel).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
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
