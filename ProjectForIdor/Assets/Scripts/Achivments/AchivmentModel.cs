using UnityEngine;

namespace Achivments
{
    public class AchivmentModel 
    {
        public enum AchivmentType {achivment, achivmentPuzzle, achivmentFinished}
        public AchivmentType achivmentType;
        public string AchivmentDescription;
        public bool isAchivmentUnlocked;

        public AchivmentModel(AchivmentType type ,string description, bool isUnlocked)
        {
            achivmentType = type;
            AchivmentDescription = description;
            isAchivmentUnlocked = isUnlocked;
        }
    }
}