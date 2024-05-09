using System.Collections.Generic;
using GirlPanel;
using ScriptableObjects.Girls;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MVP_Archive
{
    public class AcrhiveGirlsView : View
    {
        [SerializeField] private Image girlSprite;
        [SerializeField] private TextMeshProUGUI aboutGirl;
        //[SerializeField] private TextMeshProUGUI girlName;
        //[SerializeField] private TextMeshProUGUI girlAdress;
        //[SerializeField] private TextMeshProUGUI girlAge;
        
        [SerializeField] private List<Image> girlRating;
        
        [SerializeField] private TextMeshProUGUI girlDescription;

        
        
        [SerializeField] private TextMeshProUGUI achivmentsCount;
        [SerializeField] private TextMeshProUGUI achivmentStatus;
        [SerializeField] private Image achivmentSprite;


        
        
        [SerializeField] private List<TextMeshProUGUI> girlInterests;
        [SerializeField] private List<Image> girlInterestIcons;
        [SerializeField] private List<TextMeshProUGUI> girlDislikes;
        [SerializeField] private List<Image> girlDislikeIcons;
        [SerializeField] private List<Image> girlAchivmentIcons;
        [SerializeField] private List<TextMeshProUGUI> girlAchivments;

        [SerializeField] private GirlSO girlSO;

        public UnityEvent OnGirlPageCloseButtonClicked;
        
        
        private GirlPanelPresenter _presenter;

        private void Start()
        {

            _presenter = GameObject.FindGameObjectsWithTag("MVP")[0].GetComponent<GirlPanelPresenter>();
            OnGirlPageCloseButtonClicked.AddListener(_presenter.CloseGirlPage);
        }





        private bool _isAchivmentUnlocked;

        public void SetGirlSO(GirlSO newGirlSO)
        {
            girlSO = newGirlSO;
            girlSprite.sprite = girlSO.girlSprite;
            aboutGirl.text = $"{girlSO.girlName}, {girlSO.girlAge} лет, {girlSO.girlAdress}";
            
            
        }

        public override void OnButtonClicked(int buttonNumber)
        {
            throw new System.NotImplementedException();
        }

        public override void CloseButtonClicked()
        {
            OnGirlPageCloseButtonClicked.Invoke();
            Debug.Log("Closed");
          // _presenter.OnCloseButtonClicked(gameObject); тут дело в том, что скрипт на MVP page
        }
    }


}  