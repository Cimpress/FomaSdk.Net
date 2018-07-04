using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// A simplified view of an item&#39;s status.
  /// </summary>
  [DataContract]
  public class SummaryStatus {
    /// <summary>
    /// Summary of when the item is 'new', that is, has not been accepted, started production, cancelled, rejected or shipped.
    /// </summary>
    /// <value>Summary of when the item is 'new', that is, has not been accepted, started production, cancelled, rejected or shipped.</value>
    [DataMember(Name="new", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "new")]
    public SummaryQuantityStatus _New { get; set; }

    /// <summary>
    /// Summary of items that are in progress at the fulfiller. That is, it's in 'accepted' or 'production' status.
    /// </summary>
    /// <value>Summary of items that are in progress at the fulfiller. That is, it's in 'accepted' or 'production' status.</value>
    [DataMember(Name="production", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "production")]
    public SummaryQuantityStatus Production { get; set; }

    /// <summary>
    /// Summary of items that have been completed, which includes 'shipped', but also 'cancelled' or 'rejected' items.
    /// </summary>
    /// <value>Summary of items that have been completed, which includes 'shipped', but also 'cancelled' or 'rejected' items.</value>
    [DataMember(Name="completed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed")]
    public SummaryQuantityStatus Completed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummaryStatus {\n");
      sb.Append("  _New: ").Append(_New).Append("\n");
      sb.Append("  Production: ").Append(Production).Append("\n");
      sb.Append("  Completed: ").Append(Completed).Append("\n");
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
