using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// Address details
  /// </summary>
  [DataContract]
  public class AddressDto {
    /// <summary>
    /// ISO Alpha-2 Country Code.
    /// </summary>
    /// <value>ISO Alpha-2 Country Code.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Postal code.
    /// </summary>
    /// <value>Postal code.</value>
    [DataMember(Name="postalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    /// State or provence.
    /// </summary>
    /// <value>State or provence.</value>
    [DataMember(Name="stateOrProvince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateOrProvince")]
    public string StateOrProvince { get; set; }

    /// <summary>
    /// City or locale.
    /// </summary>
    /// <value>City or locale.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Company.
    /// </summary>
    /// <value>Company.</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// First name
    /// </summary>
    /// <value>First name</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Last name
    /// </summary>
    /// <value>Last name</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Middle name
    /// </summary>
    /// <value>Middle name</value>
    [DataMember(Name="middleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middleName")]
    public string MiddleName { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    /// <value>Phone</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Phone extension
    /// </summary>
    /// <value>Phone extension</value>
    [DataMember(Name="phoneExt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneExt")]
    public string PhoneExt { get; set; }

    /// <summary>
    /// Address line 1.
    /// </summary>
    /// <value>Address line 1.</value>
    [DataMember(Name="street1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street1")]
    public string Street1 { get; set; }

    /// <summary>
    /// Address line 2.
    /// </summary>
    /// <value>Address line 2.</value>
    [DataMember(Name="street2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street2")]
    public string Street2 { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    /// <value>Email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Door code.
    /// </summary>
    /// <value>Door code.</value>
    [DataMember(Name="doorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "doorCode")]
    public string DoorCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AddressDto {\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  PhoneExt: ").Append(PhoneExt).Append("\n");
      sb.Append("  Street1: ").Append(Street1).Append("\n");
      sb.Append("  Street2: ").Append(Street2).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  DoorCode: ").Append(DoorCode).Append("\n");
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
