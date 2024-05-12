using System.Collections.Generic;
using Achivments;
using ScriptableObjects.Girls;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchivmentView : MonoBehaviour
{
    private AchievementsModel _achivmentModel;
    [SerializeField] private Image achivmentMarker;
    [SerializeField] private Image achivmentDone;
    [SerializeField] private TextMeshProUGUI achivmentText;

    [SerializeField] private Image achivmentImage;
    [SerializeField] private Image puzzleImage;
    [SerializeField] private Image achivmentFinished;
    
    private bool isAchivmentUnlocked = false;

    public void SetAchivmentData(AchievementsModel achivement)
    {
        _achivmentModel = achivement;
        achivmentText.text = _achivmentModel.AchivmentDescription;
        if (_achivmentModel.isAchieved)
        {
            isAchivmentUnlocked = true;
            if (isAchivmentUnlocked)
            {
                achivmentMarker.gameObject.SetActive(false);
                achivmentDone.gameObject.SetActive(true);
            }
        }

        if (_achivmentModel.achievementType == AchievementsModel.Type.achivment)
        {
            achivmentImage.gameObject.SetActive(true);
        }
        else if (_achivmentModel.achievementType == AchievementsModel.Type.achivmentPuzzle)
        {
            achivmentImage.gameObject.SetActive(false);
            puzzleImage.gameObject.SetActive(true);
        }
        else if (_achivmentModel.achievementType == AchievementsModel.Type.achivmentFinished)
        {
            achivmentImage.gameObject.SetActive(false);
            achivmentFinished.gameObject.SetActive(true);
        }
        
    }
    
}
