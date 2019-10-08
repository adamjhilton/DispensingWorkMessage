using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class AssociatedDocument
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public List<Identifier> Identifier;

  [DataMember]
  public string Extension;

  [DataMember(EmitDefaultValue = false)]
  public string File;

  [DataMember(EmitDefaultValue = false)]
  public string FileName;

  [DataMember]
  public DocumentTypes DocumentType;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
