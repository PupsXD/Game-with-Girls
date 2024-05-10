using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ScriptableObjects.Girls;
using UnityEngine;

public class GirlsManager : MonoBehaviour
{
    
   [SerializeField] private List<GameObject> _girls;
   
   

   private void Awake()
   {
       _girls = new List<GameObject>();
       _girls.AddRange(GameObject.FindGameObjectsWithTag("Girl"));
       
   }
}
