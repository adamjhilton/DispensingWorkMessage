using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class Party
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public List<Identifier> Identifier;

  [DataMember(EmitDefaultValue = false)]
  public PartyTypes? PartyType;

  [DataMember(EmitDefaultValue = false)]
  public List<Address> Address;

  [DataMember(EmitDefaultValue = false)]
  public List<Location> Location;

  [DataMember(EmitDefaultValue = false)]
  public List<Contact> Contact;

  [DataMember(EmitDefaultValue = false)]
  public List<Image> Iamge;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
