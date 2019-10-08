using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DispensingWorkMessage
{
 [DataContract]
 public class Coordinates
 {
  #region Serializable Properties
  /////////////////////////////////////////////////////////////////////////////////////////////

  [DataMember]
  public CoordinateTypes CoordinateType;

  [DataMember]
  public List<Point> Point;

  /////////////////////////////////////////////////////////////////////////////////////////////
  #endregion
 }
}
