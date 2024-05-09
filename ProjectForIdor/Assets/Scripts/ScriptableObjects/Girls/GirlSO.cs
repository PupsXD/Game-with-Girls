using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Girls
{
    [CreateAssetMenu(fileName = "GirlData", menuName = "Create Passion/Create New Girl", order = 0)]
    public class GirlSO : ScriptableObject
    {
        public int girlIndex;
        
        public Sprite girlSprite;
        public string girlName;
        public int achivmentsCount;
        public int girlAge;
        public string girlAdress;
        public string girlDescription;
        public List<string> girlInterests;
        public List<string> girlDislikes;
        public List<string> girlAchivments;
        
        public int[] girlRating = new int[3] {0, 1, 2};
        
        public bool isAchivmentUnlocked = false;
        public Sprite achivmentSprite;
    }
}