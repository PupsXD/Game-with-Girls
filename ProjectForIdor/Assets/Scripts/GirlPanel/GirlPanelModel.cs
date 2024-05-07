using MVP_Archive;
using ScriptableObjects.Girls;
using UnityEngine;

namespace GirlPanel
{
    public class GirlPanelModel : Model
    {
        [SerializeField] private GirlSO girlSO;

        private void Awake()
        {
            
        }
        
        private void Start()
        {
            
        }

        public void SetGirlSO(GirlSO girlSO)
        {
            
        }

        public GirlSO GetGirlSO()
        {
            return girlSO;
        }
        
        
    }
}