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
        }
        
        // public GirlSO GetGirlSO()
        // {
        //     return _girlSO;
        // }
        
        private void Start()
        {
            
        }
        // private void SetUpGirlInfo()
        // {
        //     girlSO = _presenter.GetGirlSO();
        //     girlName.text = girlSO.girlName;
        //     achivmentsCount.text = $"{girlSO.achivmentsCount} из 5";
        //     girlSprite.sprite = girlSO.girlSprite;
        //
        //     _isAchivmentUnlocked = girlSO.isAchivmentUnlocked;
        //     if (_isAchivmentUnlocked)
        //     {
        //         achivmentStatus.text = "Пройдено";
        //         achivmentSprite.gameObject.SetActive(true);
        //     }
        //     else
        //     {
        //         achivmentStatus.text = "Не пройдено";
        //         achivmentSprite.gameObject.SetActive(false);
        //     }
        //     
        //     _button.onClick.AddListener(() => _presenter.OnGirlClicked());  
        // }
        
        

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