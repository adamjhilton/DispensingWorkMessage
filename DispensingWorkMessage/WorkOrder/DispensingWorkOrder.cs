using DispensingWorkMessage.Utilities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage.WorkOrder
{
 [DataContract]
 public class DispensingWorkOrder : DispensingWorkRecordBase
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember(EmitDefaultValue = false)]
  public new Parties Parties
  {
   get => base.Parties;
   set => base.Parties = value;
  }

  [DataMember]
  public new List<OrderProductGroup> ProductGroup
  {
   get => (List<OrderProductGroup>)base.ProductGroup;
   set => base.ProductGroup = value;
  }

  [DataMember]
  public WorkOrderTypes WorkOrderType;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion

  #region Serialization Members
  /////////////////////////////////////////////////////////////////////////////////////////////

  /// <summary>
  /// Deserializes a specified JSON file into an instance of this class.
  /// </summary>
  public static DispensingWorkOrder DeserializeFromFile(string filePathAndName)
  { return JsonUtilities.DeserializeFromFile<DispensingWorkOrder>(filePathAndName); }

  /// <summary>
  /// Deserializes a JSON string into an instance of this class.
  /// </summary>
  public static DispensingWorkOrder Deserialize(string json)
  { return JsonUtilities.Deserialize<DispensingWorkOrder>(json); }

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
