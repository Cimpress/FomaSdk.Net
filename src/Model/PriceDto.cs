using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Pricing details.
  /// </summary>
  [DataContract]
  public class PriceDto {
    /// <summary>
    /// The price of the product.
    /// </summary>
    /// <value>The price of the product.</value>
    [DataMember(Name="basePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basePrice")]
    public double? BasePrice { get; set; }

    /// <summary>
    /// The price to ship the product.
    /// </summary>
    /// <value>The price to ship the product.</value>
    [DataMember(Name="shippingPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingPrice")]
    public double? ShippingPrice { get; set; }

    /// <summary>
    /// The currency code used for the values.
    /// </summary>
    /// <value>The currency code used for the values.</value>
    [DataMember(Name="currencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyCode")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The taxes of OrderManager.Controllers.SimpleApi.Orders.ShippingDetails.PriceDto.BasePrice.
    /// </summary>
    /// <value>The taxes of OrderManager.Controllers.SimpleApi.Orders.ShippingDetails.PriceDto.BasePrice.</value>
    [DataMember(Name="baseTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseTax")]
    public double? BaseTax { get; set; }

    /// <summary>
    /// The taxes of OrderManager.Controllers.SimpleApi.Orders.ShippingDetails.PriceDto.ShippingPrice.
    /// </summary>
    /// <value>The taxes of OrderManager.Controllers.SimpleApi.Orders.ShippingDetails.PriceDto.ShippingPrice.</value>
    [DataMember(Name="shippingTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingTax")]
    public double? ShippingTax { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PriceDto {\n");
      sb.Append("  BasePrice: ").Append(BasePrice).Append("\n");
      sb.Append("  ShippingPrice: ").Append(ShippingPrice).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  BaseTax: ").Append(BaseTax).Append("\n");
      sb.Append("  ShippingTax: ").Append(ShippingTax).Append("\n");
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
