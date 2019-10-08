using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class Identifier
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember(EmitDefaultValue = false)]
  public string Name;

  [DataMember(EmitDefaultValue = false)]
  public string Description;

  [DataMember]
  public string Number;

  [DataMember(EmitDefaultValue = false)]
  public string Id;

  [DataMember]
  public AgencyTypes Agency;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
