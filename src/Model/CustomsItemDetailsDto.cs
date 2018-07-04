using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Various shiping detail on a per item basis.
  /// </summary>
  [DataContract]
  public class CustomsItemDetailsDto {
    /// <summary>
    /// Customs related informations
    /// </summary>
    /// <value>Customs related informations</value>
    [DataMember(Name="listPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listPrice")]
    public PriceDto ListPrice { get; set; }

    /// <summary>
    /// Gets or Sets PricePaid
    /// </summary>
    [DataMember(Name="pricePaid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pricePaid")]
    public PriceDto PricePaid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomsItemDetailsDto {\n");
      sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
      sb.Append("  PricePaid: ").Append(PricePaid).Append("\n");
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
