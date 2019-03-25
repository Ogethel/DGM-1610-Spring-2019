using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : MonoBehaviour
{
   public List<Object> CollectionList;
   
   public void Collect(GameObject obj)
   {
      CollectionList.Add(obj);
   }
}
