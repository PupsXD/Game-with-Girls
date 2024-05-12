using System;
using System.Collections.Generic;
using ScriptableObjects.Girls;
using UnityEngine;

namespace Achivments
{
    public class AchievementsModel 
    {
        public enum Type {achivment, achivmentPuzzle, achivmentFinished}; 
        public Type achievementType; 
        public string AchivmentDescription; 
        public bool isAchieved; 

        
       
    }
    public class AchivmentManager : MonoBehaviour
    {
        [SerializeField] private AchivmentView achivmentView;

        [SerializeField] private AchievementsModel achivmentModel = new AchievementsModel();
        
        [SerializeField] private GirlSO girlSO;
        
        private bool dataLoaded = false;
        
        private void Awake()
        {
            achivmentView = GetComponent<AchivmentView>();
        }


        private void Update()
        {
            if (dataLoaded)
            {
                achivmentView.SetAchivmentData(achivmentModel);
            }
        }


        public void SetAchivmentInfo(GirlSO girl, int index)
        {
            achivmentModel.AchivmentDescription = girl.girlAchivments[index];
            //achivmentModel.achivmentType = girl.girlAchivmentStatus[index];
            achivmentModel.isAchieved = girl.isAchivmentUnlocked;
            dataLoaded = true;
            
            

            

        }
        
        public void InitializeAchivment() 
        {
            
        }
    }
}