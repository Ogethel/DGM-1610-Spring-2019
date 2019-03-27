using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{
   public List<Object> CollectionList;
   
   public void Collect(GameObject obj)
   {
      CollectionList.Add(obj);
   }

   public void CollectionInfo()
   {
      foreach (var obj in CollectionList)
      {
         Debug.Log(obj);
      }
   }
}
