using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Search by specifying fields and values to match date ranges.
  /// </summary>
  [DataContract]
  public class ItemSearchDateRangesDto {
    /// <summary>
    /// Search by item creation date-time.
    /// </summary>
    /// <value>Search by item creation date-time.</value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public List<ItemSearchDateRangeOperatorDto> CreatedDate { get; set; }

    /// <summary>
    /// Search by item expected ship time.
    /// </summary>
    /// <value>Search by item expected ship time.</value>
    [DataMember(Name="expectedShipTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expectedShipTime")]
    public List<ItemSearchDateRangeOperatorDto> ExpectedShipTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemSearchDateRangesDto {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  ExpectedShipTime: ").Append(ExpectedShipTime).Append("\n");
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
