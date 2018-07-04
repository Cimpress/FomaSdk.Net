using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Provides detailed insight depending on the decoration technology.
  /// </summary>
  [DataContract]
  public class InsightDto {
    /// <summary>
    /// Insight for pad printing technology.
    /// </summary>
    /// <value>Insight for pad printing technology.</value>
    [DataMember(Name="padPrinting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "padPrinting")]
    public PadPrintingTechnologyInsightDto PadPrinting { get; set; }

    /// <summary>
    /// Insight for embroidery.
    /// </summary>
    /// <value>Insight for embroidery.</value>
    [DataMember(Name="embroidery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "embroidery")]
    public EmbroideryInsightDto Embroidery { get; set; }

    /// <summary>
    /// Insight for ink jet.
    /// </summary>
    /// <value>Insight for ink jet.</value>
    [DataMember(Name="inkJet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inkJet")]
    public InkJetTechnologyInsightDto InkJet { get; set; }

    /// <summary>
    /// Insight for screen print.
    /// </summary>
    /// <value>Insight for screen print.</value>
    [DataMember(Name="screenPrinting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "screenPrinting")]
    public ScreenPrintingTechnologyInsightDto ScreenPrinting { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InsightDto {\n");
      sb.Append("  PadPrinting: ").Append(PadPrinting).Append("\n");
      sb.Append("  Embroidery: ").Append(Embroidery).Append("\n");
      sb.Append("  InkJet: ").Append(InkJet).Append("\n");
      sb.Append("  ScreenPrinting: ").Append(ScreenPrinting).Append("\n");
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
