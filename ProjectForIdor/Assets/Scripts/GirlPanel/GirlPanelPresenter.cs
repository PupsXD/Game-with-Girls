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
        [SerializeField] private List<GirlPanelView> _girlPanelView = new List<GirlPanelView>();
        
        //[SerializeField] private GirlSO _girlSO;
        [SerializeField] private List<GirlSO> girlSOList = new List<GirlSO>();
        [SerializeField] private List<GameObject> girlList = new List<GameObject>();
        
        [SerializeField] private AcrhiveGirlsView archiveGirlsView;
        
        private void Awake()
        {
            _girlPanelModel = GetComponent<GirlPanelModel>();
            girlList.AddRange(GameObject.FindGameObjectsWithTag("Girl"));
            _girlPanelView.AddRange(GameObject.FindGameObjectsWithTag("Girl")[0].GetComponents<GirlPanelView>());
            //_girlPanelModel = GetComponent<GirlPanelModel>();
            //_girlPanelView = GetComponent<GirlPanelView>();
            //_girlSO = _girlPanelModel.GetGirlSO();
            
        }
        
        private void Update()
        {
            if (girlSOList.Count != 0 && _girlPanelView.Count != 0)
            {
                for (int i = girlList.Count - 1; i >= 0; i--)
                {
                    girlList[i].GetComponent<GirlPanelView>().SetGirlSO(girlSOList[i]);
                }
            }
            archiveGirlsView = GameObject.FindGameObjectsWithTag("MVP_GirlPage")[0].GetComponent<AcrhiveGirlsView>();
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

        public void OnCloseButtonClicked(GameObject girlPage)
        {
            girlPage.SetActive(false);
        }
    }
    
}