using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Required additional fields explaning why a \&quot;OrderRequest\&quot; notification is being created.
  /// </summary>
  [DataContract]
  public class OrderDetailsDto {
    /// <summary>
    /// The Links associated with the order request
    /// </summary>
    /// <value>The Links associated with the order request</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public OrderRequestLinks Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderDetailsDto {\n");
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
