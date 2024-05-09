using UnityEngine;

namespace MVP_Archive
{
    public abstract class View : MonoBehaviour
    {
        public abstract void OnButtonClicked(int buttonNumber);
        
        public abstract void CloseButtonClicked();
    }
}