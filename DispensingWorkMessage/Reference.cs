using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class Reference
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public ReferenceTypes ReferenceType;

  [DataMember]
  public string Value;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
