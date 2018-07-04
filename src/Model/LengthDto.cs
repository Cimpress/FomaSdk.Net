using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// The size
  /// </summary>
  [DataContract]
  public class LengthDto {
    /// <summary>
    /// The value of the length.
    /// </summary>
    /// <value>The value of the length.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public double? Value { get; set; }

    /// <summary>
    /// The unit of the length.
    /// </summary>
    /// <value>The unit of the length.</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public string Unit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LengthDto {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
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
