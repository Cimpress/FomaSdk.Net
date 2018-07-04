using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DeliveryDetailsDto {
    /// <summary>
    /// The type for which this set of delivery details stands for.
    /// </summary>
    /// <value>The type for which this set of delivery details stands for.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The quantity for this delivery request, representing a sub-quantity of the overall item's quantity.
    /// </summary>
    /// <value>The quantity for this delivery request, representing a sub-quantity of the overall item's quantity.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Links to additional resources for this item. Specified rels are:  * self: Link to these delivery details.
    /// </summary>
    /// <value>Links to additional resources for this item. Specified rels are:  * self: Link to these delivery details.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, LinkDto> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeliveryDetailsDto {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
