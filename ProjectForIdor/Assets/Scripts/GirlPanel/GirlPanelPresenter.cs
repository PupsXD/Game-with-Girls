using System.Collections.Generic;
using MVP_Archive;
using ScriptableObjects.Girls;
using UnityEngine;
using UnityEngine.Events;

namespace GirlPanel
{
    public class GirlPanelPresenter : Presenter
    {
        private GirlPanelModel _girlPanelModel;
        private GirlPanelView _girlPanelView;
        
        //[SerializeField] private GirlSO _girlSO;
        [SerializeField] private List<GirlSO> girlSOList = new List<GirlSO>();
        [SerializeField] private List<GameObject> girlList = new List<GameObject>();
        
        private void Awake()
        {
            _girlPanelModel = GetComponent<GirlPanelModel>();
            //_girlPanelModel = GetComponent<GirlPanelModel>();
            //_girlPanelView = GetComponent<GirlPanelView>();
            //_girlSO = _girlPanelModel.GetGirlSO();
            
        }
        
        // public GirlSO GetGirlSO()
        // {
        //     return _girlSO;
        // }
        
        private void Start()
        {
            
        }

        public void SetGirlSO(List<GirlSO> girlSOListLoaded)
        {
            girlSOList = girlSOListLoaded;
        }

        public void OnGirlClicked()
        {
            //Что-то сделать
        }

        public void OnGirlButtonClicked(int girlNumber)
        {
            
        }
    }
    
}