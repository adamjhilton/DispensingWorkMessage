using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class Comment
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public List<Identifier> Identifier;

  [DataMember]
  public CommentTypes CommentType;

  [DataMember]
  public string Value;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
