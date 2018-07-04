using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Model {

  /// <summary>
  /// The details of the shipment to be created.
  /// </summary>
  [DataContract]
  public class ShipmentCreationRequestDto {
    /// <summary>
    /// The list of items in this shipment. This list is required, but optionally allows specifying the quantity that is actually going to be shipped.  * For high quantity items, there may be more than one shipment, this tells the platform that the part of the item that was shipped in this shipment.  * The list of items is necessary to understanding uniquely which part of the order has been shipped.
    /// </summary>
    /// <value>The list of items in this shipment. This list is required, but optionally allows specifying the quantity that is actually going to be shipped.  * For high quantity items, there may be more than one shipment, this tells the platform that the part of the item that was shipped in this shipment.  * The list of items is necessary to understanding uniquely which part of the order has been shipped.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<ShippedItemDto> Items { get; set; }

    /// <summary>
    /// The carrier service that has been used. It's preferred to use a value from the \"Registry of Carrier Services\",  which can be found at https://recs.qp.cimpress.io/api/v1/carrierServices
    /// </summary>
    /// <value>The carrier service that has been used. It's preferred to use a value from the \"Registry of Carrier Services\",  which can be found at https://recs.qp.cimpress.io/api/v1/carrierServices</value>
    [DataMember(Name="carrierService", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierService")]
    public string CarrierService { get; set; }

    /// <summary>
    /// Carrier specific tracking information in the form of a string. Used to uniquely identify the shipment for a carrier.  Can be used to look up the shipment at a later point.
    /// </summary>
    /// <value>Carrier specific tracking information in the form of a string. Used to uniquely identify the shipment for a carrier.  Can be used to look up the shipment at a later point.</value>
    [DataMember(Name="trackingId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackingId")]
    public string TrackingId { get; set; }

    /// <summary>
    /// Carrier specific tracking information in the form of a url link. Used to uniquely identify the shipment for a carrier.  This url works to see shipment information from the carrier.
    /// </summary>
    /// <value>Carrier specific tracking information in the form of a url link. Used to uniquely identify the shipment for a carrier.  This url works to see shipment information from the carrier.</value>
    [DataMember(Name="trackingUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackingUrl")]
    public string TrackingUrl { get; set; }

    /// <summary>
    /// This is an optional field to specify a custom identitifier for the shipment.  This field can be anything that helps to look up this shipment later.
    /// </summary>
    /// <value>This is an optional field to specify a custom identitifier for the shipment.  This field can be anything that helps to look up this shipment later.</value>
    [DataMember(Name="externalShipmentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalShipmentId")]
    public string ExternalShipmentId { get; set; }

    /// <summary>
    /// The fulfillement location id is the identifier from the shipping location. When shipping, there may be more than one possible location for a fulfiller.  * This tells the platform which location a shipment was shipped from.  * When a fulfiller only has one location, this field is optional.
    /// </summary>
    /// <value>The fulfillement location id is the identifier from the shipping location. When shipping, there may be more than one possible location for a fulfiller.  * This tells the platform which location a shipment was shipped from.  * When a fulfiller only has one location, this field is optional.</value>
    [DataMember(Name="fulfillmentLocationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfillmentLocationId")]
    public string FulfillmentLocationId { get; set; }

    /// <summary>
    /// The URL to the delivery details. This can only be set if the item is being shipped to multiple addresses.  If the item is shipped to multiple addresses, it's a required flag to identify which part of the ordered  item gets shipped.
    /// </summary>
    /// <value>The URL to the delivery details. This can only be set if the item is being shipped to multiple addresses.  If the item is shipped to multiple addresses, it's a required flag to identify which part of the ordered  item gets shipped.</value>
    [DataMember(Name="deliveryDetailsUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryDetailsUrl")]
    public string DeliveryDetailsUrl { get; set; }

    /// <summary>
    /// The weight of the package that is being sent.
    /// </summary>
    /// <value>The weight of the package that is being sent.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public WeightDto Weight { get; set; }

    /// <summary>
    /// The size of the package that is being sent.
    /// </summary>
    /// <value>The size of the package that is being sent.</value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public Size3DDto Size { get; set; }

    /// <summary>
    /// Shipment related links.
    /// </summary>
    /// <value>Shipment related links.</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public ShipmentLinksDto Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentCreationRequestDto {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  CarrierService: ").Append(CarrierService).Append("\n");
      sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
      sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
      sb.Append("  ExternalShipmentId: ").Append(ExternalShipmentId).Append("\n");
      sb.Append("  FulfillmentLocationId: ").Append(FulfillmentLocationId).Append("\n");
      sb.Append("  DeliveryDetailsUrl: ").Append(DeliveryDetailsUrl).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
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
