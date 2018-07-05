using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ItemSearchRequestDto {
    /// <summary>
    /// Search by specifying fields and values to match exactly.
    /// </summary>
    /// <value>Search by specifying fields and values to match exactly.</value>
    [DataMember(Name="terms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terms")]
    public ItemSearchTermsDto Terms { get; set; }

    /// <summary>
    /// Search by specifying fields and values to match date ranges.
    /// </summary>
    /// <value>Search by specifying fields and values to match date ranges.</value>
    [DataMember(Name="dateRanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateRanges")]
    public ItemSearchDateRangesDto DateRanges { get; set; }

    /// <summary>
    /// List of full text queries
    /// </summary>
    /// <value>List of full text queries</value>
    [DataMember(Name="fulltext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulltext")]
    public List<string> Fulltext { get; set; }

    /// <summary>
    /// The preferred number of results to return. The default is 10. The maximum is 1000.
    /// </summary>
    /// <value>The preferred number of results to return. The default is 10. The maximum is 1000.</value>
    [DataMember(Name="pageSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// The offset of results to return. Results prior to the offset will be skipped. The default is 0. The maximum supported PageSize + Offset is 10000.  You can make your queries more specific to not need to page beyond 10000 records.
    /// </summary>
    /// <value>The offset of results to return. Results prior to the offset will be skipped. The default is 0. The maximum supported PageSize + Offset is 10000.  You can make your queries more specific to not need to page beyond 10000 records.</value>
    [DataMember(Name="offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// A list of sort criteria. By default sorts by Accending on \"createdDate\"
    /// </summary>
    /// <value>A list of sort criteria. By default sorts by Accending on \"createdDate\"</value>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public List<ItemSearchSortDto> Sort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemSearchRequestDto {\n");
      sb.Append("  Terms: ").Append(Terms).Append("\n");
      sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
      sb.Append("  Fulltext: ").Append(Fulltext).Append("\n");
      sb.Append("  PageSize: ").Append(PageSize).Append("\n");
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
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
