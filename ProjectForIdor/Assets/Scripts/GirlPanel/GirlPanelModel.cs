using System.Collections.Generic;
using MVP_Archive;
using ScriptableObjects.Girls;
using UnityEngine;

namespace GirlPanel
{
    public class GirlPanelModel : Model
    {
        [SerializeField] private GirlSO girlSO;
        
        [SerializeField] private List<GirlSO> girlSOList = new List<GirlSO>();
        
        private AdressableInitialization _adressableInitialization;
        
        [SerializeField] private List<GameObject> girlList = new List<GameObject>();

        private void Awake()
        {
            girlList.AddRange(GameObject.FindGameObjectsWithTag("Girl"));
            _adressableInitialization = GameObject.FindGameObjectsWithTag("Instantiator")[0]
                .GetComponent<AdressableInitialization>();
            _adressableInitialization.InitializeGirls();
            SetGirlSO();
        }
        
        private void Start()
        {
            
        }

        private void SetGirlSO()
        {
            girlSOList = _adressableInitialization.GetInstantiatedGirls(); // Retrieve loaded GirlSOs
        }

        public List<GirlSO> GetGirlSOList()
        {
            return girlSOList;
        }
        
        
    }
}