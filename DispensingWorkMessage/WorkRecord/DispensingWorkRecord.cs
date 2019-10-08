using DispensingWorkMessage.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage.WorkRecord
{
 [DataContract]
 public class DispensingWorkRecord : DispensingWorkRecordBase
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember(EmitDefaultValue = false)]
  public new RecordParties Parties
  {
   get => (RecordParties)base.Parties;
   set => base.Parties = value;
  }

  [DataMember]
  public new List<RecordProductGroup> ProductGroup
  {
   get => (List<RecordProductGroup>)base.ProductGroup;
   set => base.ProductGroup = value;
  }

  [DataMember]
  public Identifier WorkRecordIdentifier;

  [DataMember]
  public DateTime WorkRecordCreationDateTime;

  [DataMember(EmitDefaultValue = false)]
  public int? BatchNumber;

  [DataMember(EmitDefaultValue = false)]
  public ValueUnit ActualArea;

  [DataMember(EmitDefaultValue = false)]
  public List<Location> ActualLocation;

  [DataMember(EmitDefaultValue = false)]
  public OrderStatuses OrderStatus;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion

  #region Serialization Members
  /////////////////////////////////////////////////////////////////////////////////////////////

  /// <summary>
  /// Deserializes a specified JSON file into an instance of this class.
  /// </summary>
  public static DispensingWorkRecord DeserializeFromFile(string filePathAndName)
  { return JsonUtilities.DeserializeFromFile<DispensingWorkRecord>(filePathAndName); }

  /// <summary>
  /// Deserializes a JSON string into an instance of this class.
  /// </summary>
  public static DispensingWorkRecord Deserialize(string json)
  { return JsonUtilities.Deserialize<DispensingWorkRecord>(json); }

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
