using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="MecanicData")]
public class MecanicData : ScriptableObject
{
   [SerializeField]List<MecanicImplementation> mecanics;

   public void SetAllMecanics(MonoBehaviour objectReference)
   {
       foreach(var mec in mecanics)
           mec.SetMecanic(objectReference);
       
   }

   public void CheckAllMecanics()
   {
       foreach(var mec in mecanics)
           mec.CheckMecanic();
       
   }
}
