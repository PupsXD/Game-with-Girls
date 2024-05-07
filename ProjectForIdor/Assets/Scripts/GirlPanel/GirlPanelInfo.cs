using GirlPanel;
using ScriptableObjects.Girls;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GirlPanelInfo : MonoBehaviour
{
    
    [SerializeField] private GirlSO GirlSO;
    
    [SerializeField] private TextMeshProUGUI girlName;
    [SerializeField] private TextMeshProUGUI achivmentsCount;
    [SerializeField] private Image girlSprite;
    
    [SerializeField] private TextMeshProUGUI achivmentStatus;
    [SerializeField] private Image achivmentSprite;
    private bool _isAchivmentUnlocked;
    
    private Button _button;
    
    private GirlPanelPresenter _presenter;
    
    private void Awake()
    {
        _presenter = GetComponentInParent<GirlPanelPresenter>();
        _button = GetComponent<Button>();
        girlName.text = GirlSO.girlName;
        achivmentsCount.text = $"{GirlSO.achivmentsCount} из 5";
        girlSprite.sprite = GirlSO.girlSprite;

        _isAchivmentUnlocked = GirlSO.isAchivmentUnlocked;
        if (_isAchivmentUnlocked)
        {
            achivmentStatus.text = "Пройдено";
            achivmentSprite.gameObject.SetActive(true);
        }
        else
        {
            achivmentStatus.text = "Не пройдено";
            achivmentSprite.gameObject.SetActive(false);
        }
        
        _button.onClick.AddListener(() => _presenter.OnGirlClicked());   
    }

    public void OnGirlClicked(int girlNumber)
    {
        _presenter.OnGirlButtonClicked(girlNumber);
    }
}
