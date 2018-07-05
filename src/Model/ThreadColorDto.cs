using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Details of an embroidery thread color.
  /// </summary>
  [DataContract]
  public class ThreadColorDto {
    /// <summary>
    /// The stitch number this color applies to.
    /// </summary>
    /// <value>The stitch number this color applies to.</value>
    [DataMember(Name="stitchNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stitchNumber")]
    public int? StitchNumber { get; set; }

    /// <summary>
    /// The manufacturer of the color.
    /// </summary>
    /// <value>The manufacturer of the color.</value>
    [DataMember(Name="colorManufacturer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colorManufacturer")]
    public string ColorManufacturer { get; set; }

    /// <summary>
    /// The ID of the color.
    /// </summary>
    /// <value>The ID of the color.</value>
    [DataMember(Name="colorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colorId")]
    public string ColorId { get; set; }

    /// <summary>
    /// The name of the color.
    /// </summary>
    /// <value>The name of the color.</value>
    [DataMember(Name="colorName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colorName")]
    public string ColorName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ThreadColorDto {\n");
      sb.Append("  StitchNumber: ").Append(StitchNumber).Append("\n");
      sb.Append("  ColorManufacturer: ").Append(ColorManufacturer).Append("\n");
      sb.Append("  ColorId: ").Append(ColorId).Append("\n");
      sb.Append("  ColorName: ").Append(ColorName).Append("\n");
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
