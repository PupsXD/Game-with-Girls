using System;
using GirlPanel;
using MVP_Archive;
using ScriptableObjects.Girls;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GirlPanelView : View
{
    
    [SerializeField] private GirlSO girlSO;
    
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
        gameObject.SetActive(true);
        _presenter = GetComponentInParent<GirlPanelPresenter>();
        _button = GetComponent<Button>();
        
        
    }

    private void Start()
    {
        girlSO = _presenter.GetGirlSO();
        girlName.text = girlSO.girlName;
        achivmentsCount.text = $"{girlSO.achivmentsCount} из 5";
        girlSprite.sprite = girlSO.girlSprite;

        _isAchivmentUnlocked = girlSO.isAchivmentUnlocked;
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

    public override void ObButtonClicked(int buttonNumber)
    {
        _presenter.OnGirlButtonClicked(buttonNumber);
    }
}