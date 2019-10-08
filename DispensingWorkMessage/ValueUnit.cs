using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class ValueUnit
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public double Value;

  [DataMember]
  public string Uom;

  [DataMember]
  public AgencyTypes Agency;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
