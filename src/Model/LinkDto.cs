using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Link relations relevant for an object.
  /// </summary>
  [DataContract]
  public class LinkDto {
    /// <summary>
    /// The location where to find the related object.
    /// </summary>
    /// <value>The location where to find the related object.</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// The HTTP methods that are supported on the related link. Can be multiply, typically in a PUT/GET combination.
    /// </summary>
    /// <value>The HTTP methods that are supported on the related link. Can be multiply, typically in a PUT/GET combination.</value>
    [DataMember(Name="methods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "methods")]
    public List<string> Methods { get; set; }

    /// <summary>
    /// What the relation means.
    /// </summary>
    /// <value>What the relation means.</value>
    [DataMember(Name="rel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rel")]
    public string Rel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LinkDto {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Methods: ").Append(Methods).Append("\n");
      sb.Append("  Rel: ").Append(Rel).Append("\n");
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
