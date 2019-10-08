using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class Container
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public List<Identifier> Identifier;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit Capacity;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit RequestedQuantity;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
