using System.Collections;
using System.Collections.Generic;
using ScriptableObjects.Girls;
using UnityEngine;

public class GirlPageModel : MonoBehaviour
{
    private GirlSO girlSO;

    public void SetGirlSO(GirlSO girlSO)
    {
        this.girlSO = girlSO;
    }
    
    public GirlSO GetGirlSO()
    {
        return girlSO;
    }
    
    
      
   
}
