using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjects.ImagesForPrefabs
{
    [CreateAssetMenu(fileName = "ImagesList", menuName = "Create New Images List", order = 0)]
    public class ImagesList : ScriptableObject
    {
        public Sprite activeRatingIcon;
        public Sprite passiveRatingIcon;
        public Sprite likeIcon;
        public Sprite likeNeutralIcon;
        public Sprite dislikeIcon;
        public Sprite dislikeNeutralIcon;
        public Sprite achivmentIcon;
        public Sprite achivmentNeutralIcon;
        public Sprite achivmentPuzzleIcon;
        public Sprite achivmentFinishedIcon;
    }
}