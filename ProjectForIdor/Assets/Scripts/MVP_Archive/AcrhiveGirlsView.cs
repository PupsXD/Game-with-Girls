using System.Collections.Generic;
using GirlPanel;
using ScriptableObjects.Girls;
using ScriptableObjects.ImagesForPrefabs;
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
        
        [SerializeField] private List<TextMeshProUGUI> girlInterests;
        [SerializeField] private List<Image> girlInterestIcons;
        [SerializeField] private List<TextMeshProUGUI> girlDislikes;
        [SerializeField] private List<Image> girlDislikeIcons;
        [SerializeField] private List<Image> girlAchivmentIcons;
        [SerializeField] private List<TextMeshProUGUI> girlAchivments;

        [SerializeField] private GirlSO girlSO;
        
        [SerializeField] private ImagesList imagesList; //Сделал, чтобы не прописывать сложную логику, а просто раскидать нужные спрайты и подставлять куда нужно, сори, можно было умнее
        

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
            for (int i = 0; i < girlSO.girlRating.Length; i++)
            {
                girlRating[i].sprite = imagesList.activeRatingIcon;
            }

            girlDescription.text = girlSO.girlDescription;

            for (int i = 0; i < girlSO.girlInterests.Count; i++)
            {
                girlInterests[i].text = girlSO.girlInterests[i];
            }
            
            for (int i = 0; i < girlSO.girlDislikes.Count; i++)
            {
                girlDislikes[i].text = girlSO.girlDislikes[i];
            }
            
            for (int i = 0; i < girlSO.girlAchivments.Count; i++)
            {
                girlAchivments[i].text = girlSO.girlAchivments[i];
            }
            
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