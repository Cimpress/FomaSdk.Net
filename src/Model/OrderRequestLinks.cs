using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// The Links associated with the order request
  /// </summary>
  [DataContract]
  public class OrderRequestLinks {
    /// <summary>
    /// The fulfiller to create the order request for.
    /// </summary>
    /// <value>The fulfiller to create the order request for.</value>
    [DataMember(Name="fulfiller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfiller")]
    public LinkDto Fulfiller { get; set; }

    /// <summary>
    /// If the items are sourced elsewhere, this is an optional link to that resource.
    /// </summary>
    /// <value>If the items are sourced elsewhere, this is an optional link to that resource.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public LinkDto Source { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderRequestLinks {\n");
      sb.Append("  Fulfiller: ").Append(Fulfiller).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
