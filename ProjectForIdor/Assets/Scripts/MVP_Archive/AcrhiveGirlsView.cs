using System.Collections.Generic;
using ScriptableObjects.Girls;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MVP_Archive
{
    public class AcrhiveGirlsView : MonoBehaviour
    {
        [SerializeField] private Image girlSprite;
        [SerializeField] private TextMeshProUGUI girlName;
        [SerializeField] private TextMeshProUGUI girlAdress;
        [SerializeField] private TextMeshProUGUI girlAge;
        
        [SerializeField] private List<Image> girlRating;
        
        [SerializeField] private TextMeshProUGUI girlDescription;

        
        
        [SerializeField] private TextMeshProUGUI achivmentsCount;
        [SerializeField] private TextMeshProUGUI achivmentStatus;
        [SerializeField] private Image achivmentSprite;


        
        
        [SerializeField] private List<TextMeshProUGUI> girlInterests;
        [SerializeField] private List<Image> girlInterestIcons;
        [SerializeField] private List<TextMeshProUGUI> girlDislikes;
        [SerializeField] private List<TextMeshProUGUI> girlAchivments;

        [SerializeField] private GirlSO girlSO;

        public UnityEvent OnGirlPageClicked;
        
        



        private bool _isAchivmentUnlocked;

        public void SetGirlSO(GirlSO girlSO)
        {
            girlSprite.sprite = girlSO.girlSprite;
            girlName.text = girlSO.girlName;
            achivmentsCount.text = $"{girlSO.achivmentsCount} из 5";
            _isAchivmentUnlocked = girlSO.isAchivmentUnlocked;
            if (_isAchivmentUnlocked)
            {
                achivmentStatus.text = "Пройдено";
                achivmentSprite.gameObject.SetActive(true);
            }
        }

    }


}  