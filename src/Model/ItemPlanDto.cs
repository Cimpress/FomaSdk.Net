using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// The optimized suggested best plan for an item, including production and shipping.  This is not a contractual plan, but instead an up to date calculation on when the optimal time to produce  and ship an item is.  Use this better schedule the usage of physical resources.
  /// </summary>
  [DataContract]
  public class ItemPlanDto {
    /// <summary>
    /// The production plan, if available. This will only be available if the item hasn't been shipped yet.  The production plan offsets the start of production with the configured  Production Time SLA https://productiontime.dnj.cimpress.io. If production has not started the optimal production time is calculated from the optimal ship date found in the OrderManager.Controllers.SimpleApi.Items.Plan.ItemPlanDto.ShippingPlans.
    /// </summary>
    /// <value>The production plan, if available. This will only be available if the item hasn't been shipped yet.  The production plan offsets the start of production with the configured  Production Time SLA https://productiontime.dnj.cimpress.io. If production has not started the optimal production time is calculated from the optimal ship date found in the OrderManager.Controllers.SimpleApi.Items.Plan.ItemPlanDto.ShippingPlans.</value>
    [DataMember(Name="production", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "production")]
    public ProductionPlanDto Production { get; set; }

    /// <summary>
    /// The shipping plan, if available. This will only be available if the item hasn't been shipped yet.  This shipping plan is not a contract, but rather a live plan based on the configurations  of the Production Time and the Carrier Quoter Configuration https://qcm.qp.cimpress.io.  Use these configurations to improve the plan reliability.
    /// </summary>
    /// <value>The shipping plan, if available. This will only be available if the item hasn't been shipped yet.  This shipping plan is not a contract, but rather a live plan based on the configurations  of the Production Time and the Carrier Quoter Configuration https://qcm.qp.cimpress.io.  Use these configurations to improve the plan reliability.</value>
    [DataMember(Name="shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping")]
    public ShippingPlanDto Shipping { get; set; }

    /// <summary>
    /// In the case wehere there are multiple delivery configurations, there are multiple plans for each of the destination addresses for the item.  See \"shipping\" property for additional information.
    /// </summary>
    /// <value>In the case wehere there are multiple delivery configurations, there are multiple plans for each of the destination addresses for the item.  See \"shipping\" property for additional information.</value>
    [DataMember(Name="shippingPlans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingPlans")]
    public Dictionary<string, ShippingPlanDto> ShippingPlans { get; set; }

    /// <summary>
    /// A hyperlink to this plan or known as the \"self\" link relation.
    /// </summary>
    /// <value>A hyperlink to this plan or known as the \"self\" link relation.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemPlanDto {\n");
      sb.Append("  Production: ").Append(Production).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  ShippingPlans: ").Append(ShippingPlans).Append("\n");
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
