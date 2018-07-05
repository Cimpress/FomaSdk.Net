using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EmbroideryInsightDto {
    /// <summary>
    /// The thread colors of the stitch document.
    /// </summary>
    /// <value>The thread colors of the stitch document.</value>
    [DataMember(Name="threadColors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threadColors")]
    public List<ThreadColorDto> ThreadColors { get; set; }

    /// <summary>
    /// The total number of stitches of the stitch document.
    /// </summary>
    /// <value>The total number of stitches of the stitch document.</value>
    [DataMember(Name="numberOfStitches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfStitches")]
    public int? NumberOfStitches { get; set; }

    /// <summary>
    /// The size of the document.
    /// </summary>
    /// <value>The size of the document.</value>
    [DataMember(Name="boundingBoxSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boundingBoxSize")]
    public BoundingBoxDto BoundingBoxSize { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmbroideryInsightDto {\n");
      sb.Append("  ThreadColors: ").Append(ThreadColors).Append("\n");
      sb.Append("  NumberOfStitches: ").Append(NumberOfStitches).Append("\n");
      sb.Append("  BoundingBoxSize: ").Append(BoundingBoxSize).Append("\n");
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
