using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// The price that has been agreed to pay the fulfiller for producing this order.
  /// </summary>
  [DataContract]
  public class PricingInformationDetailsDto {
    /// <summary>
    /// The monetary value in the given currency.
    /// </summary>
    /// <value>The monetary value in the given currency.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// The currency being used for this transaction.
    /// </summary>
    /// <value>The currency being used for this transaction.</value>
    [DataMember(Name="currencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyCode")]
    public string CurrencyCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PricingInformationDetailsDto {\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
