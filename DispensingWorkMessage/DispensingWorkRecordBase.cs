using DispensingWorkMessage.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class DispensingWorkRecordBase
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public Header Header;

  [IgnoreDataMember]
  public Parties Parties;

  [IgnoreDataMember]
  public IEnumerable ProductGroup;

  [DataMember(EmitDefaultValue = false)]
  public List<TransportInformation> TransportInformation;

  [DataMember(EmitDefaultValue = false)]
  public List<AssociatedDocument> AssociatedDocument;

  [DataMember]
  public Identifier WorkOrderIdentifier;

  [DataMember]
  public DateTime WorkOrderCreationDateTime;

  [DataMember(EmitDefaultValue = false)]
  public List<Reference> Reference;

  [DataMember(EmitDefaultValue = false)]
  public int? NumberOfBatches;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit BatchAmount;

  [DataMember(EmitDefaultValue = false)]
  public PhysicalStates? PhysicalState;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit RequestedArea;

  [DataMember(EmitDefaultValue = false)]
  public List<Location> RequestedLocation;

  [DataMember(EmitDefaultValue = false)]
  public DateTime? DispensingStartDateTime;

  [DataMember(EmitDefaultValue = false)]
  public DateTime? DispensingEndDateTime;

  [DataMember(EmitDefaultValue = false)]
  public int? OrderLineNumber;

  [DataMember(EmitDefaultValue = false)]
  public string GroupPhase;

  [DataMember(EmitDefaultValue = false)]
  public string GroupName;

  [DataMember(EmitDefaultValue = false)]
  public string GroupDescription;

  [DataMember(EmitDefaultValue = false)]
  public List<Comment> Comments;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion

  #region Serialization Members
  /////////////////////////////////////////////////////////////////////////////////////////////

  /// <summary>
  /// Serializes this object into a specified JSON file.
  /// </summary>
  public void SerializeToFile(string file)
  { JsonUtilities.SerializeToFile(this, file); }

  /// <summary>
  /// Serializes this object into a JSON string.
  /// </summary>
  public string Serialize()
  { return JsonUtilities.Serialize(this); }

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
