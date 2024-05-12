using System.Collections.Generic;
using Achivments;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchivmentView : MonoBehaviour
{
    private AchivmentModel _achivmentModel;
    [SerializeField] private Image achivmentMarker;
    [SerializeField] private Image achivmentDone;
    [SerializeField] private TextMeshProUGUI achivmentText;

    [SerializeField] private Image achivmentImage;
    [SerializeField] private Image puzzleImage;
    [SerializeField] private Image achivmentFinished;
    
    private bool isAchivmentUnlocked = false;

    public void SetAchivmentData(AchivmentModel achivement)
    {
        _achivmentModel = achivement;
        achivmentText.text = _achivmentModel.AchivmentDescription;
        if (_achivmentModel.isAchivmentUnlocked)
        {
            isAchivmentUnlocked = true;
            if (isAchivmentUnlocked)
            {
                achivmentMarker.gameObject.SetActive(false);
                achivmentDone.gameObject.SetActive(true);
            }
        }

        if (_achivmentModel.achivmentType == AchivmentModel.AchivmentType.achivment)
        {
            achivmentImage.gameObject.SetActive(true);
        }
        else if (_achivmentModel.achivmentType == AchivmentModel.AchivmentType.achivmentPuzzle)
        {
            achivmentImage.gameObject.SetActive(false);
            puzzleImage.gameObject.SetActive(true);
        }
        else if (_achivmentModel.achivmentType == AchivmentModel.AchivmentType.achivmentFinished)
        {
            achivmentImage.gameObject.SetActive(false);
            achivmentFinished.gameObject.SetActive(true);
        }
        
    }
    
}
