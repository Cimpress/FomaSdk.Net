using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// The detailed shipping plan.
  /// </summary>
  [DataContract]
  public class ShippingPlanDto {
    /// <summary>
    /// When the item should be shipped, according to the production times for the fulfiller and SKU, adhering to shipping requirements.  This is optimized based on fulfiller's configuration  and is not a contractual plan.
    /// </summary>
    /// <value>When the item should be shipped, according to the production times for the fulfiller and SKU, adhering to shipping requirements.  This is optimized based on fulfiller's configuration  and is not a contractual plan.</value>
    [DataMember(Name="expectedShipTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expectedShipTime")]
    public DateTime? ExpectedShipTime { get; set; }

    /// <summary>
    /// The carrier service which can ship at the OrderManager.Controllers.SimpleApi.Items.Plan.ShippingPlanDto.ExpectedShipTime. This is an optional field provided if there is Quoter configuration https://qcm.qp.cimpress.io.
    /// </summary>
    /// <value>The carrier service which can ship at the OrderManager.Controllers.SimpleApi.Items.Plan.ShippingPlanDto.ExpectedShipTime. This is an optional field provided if there is Quoter configuration https://qcm.qp.cimpress.io.</value>
    [DataMember(Name="expectedCarrierService", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expectedCarrierService")]
    public CarrierServiceDto ExpectedCarrierService { get; set; }

    /// <summary>
    /// Whether the shipment will arrive late at the customer, assuming it will be shipped at OrderManager.Controllers.SimpleApi.Items.Plan.ShippingPlanDto.ExpectedShipTime.
    /// </summary>
    /// <value>Whether the shipment will arrive late at the customer, assuming it will be shipped at OrderManager.Controllers.SimpleApi.Items.Plan.ShippingPlanDto.ExpectedShipTime.</value>
    [DataMember(Name="expectedShipTimeIsLate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expectedShipTimeIsLate")]
    public bool? ExpectedShipTimeIsLate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingPlanDto {\n");
      sb.Append("  ExpectedShipTime: ").Append(ExpectedShipTime).Append("\n");
      sb.Append("  ExpectedCarrierService: ").Append(ExpectedCarrierService).Append("\n");
      sb.Append("  ExpectedShipTimeIsLate: ").Append(ExpectedShipTimeIsLate).Append("\n");
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
