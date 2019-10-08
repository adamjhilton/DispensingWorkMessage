using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class Product
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public List<Identifier> Identifier;

  [DataMember(EmitDefaultValue = false)]
  public int? MixSequence;

  [DataMember(EmitDefaultValue = false)]
  public bool? IsCarrier;

  [DataMember(EmitDefaultValue = false)]
  public PhysicalStates? PhysicalState;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit Density;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit RequestedQuantity;

  [DataMember(EmitDefaultValue = false)]
  public string Crop;

  [DataMember(EmitDefaultValue = false)]
  public string Dot;

  [DataMember(EmitDefaultValue = false)]
  public string Epa;

  [DataMember(EmitDefaultValue = false)]
  public string Permit;

  [DataMember(EmitDefaultValue = false)]
  public string PreviousCrop;

  [IgnoreDataMember]
  public IEnumerable SourceContainer;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
