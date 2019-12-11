using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class TransportInformation
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public List<Identifier> Identifier;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit GrossWeight;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit TareWeight;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
