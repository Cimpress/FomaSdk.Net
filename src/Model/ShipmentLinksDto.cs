using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Links to other resources which are related to this shipment
  /// </summary>
  [DataContract]
  public class ShipmentLinksDto {
    /// <summary>
    /// Alternative shipment resource which contains the shipment information. Shipment must exist in https://shipment-manager.logint.cimpress.io
    /// </summary>
    /// <value>Alternative shipment resource which contains the shipment information. Shipment must exist in https://shipment-manager.logint.cimpress.io</value>
    [DataMember(Name="shipments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipments")]
    public ShipmentResourceDto Shipments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentLinksDto {\n");
      sb.Append("  Shipments: ").Append(Shipments).Append("\n");
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
