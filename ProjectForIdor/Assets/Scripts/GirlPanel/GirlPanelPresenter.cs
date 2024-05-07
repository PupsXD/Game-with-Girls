using ScriptableObjects.Girls;
using UnityEngine;
using UnityEngine.Events;

namespace GirlPanel
{
    public class GirlPanelPresenter : MonoBehaviour
    {
        private GirlPanelModel _girlPanelModel;
        private GirlPanelView _girlPanelView;
        
        [SerializeField] private GirlSO _girlSO;
        
        private void Awake()
        {
            
            _girlPanelModel = GetComponent<GirlPanelModel>();
            _girlPanelView = GetComponent<GirlPanelView>();
            _girlSO = _girlPanelModel.GetGirlSO();
            
        }
        
        public GirlSO GetGirlSO()
        {
            return _girlSO;
        }

        public void OnGirlClicked()
        {
            //Что-то сделать
        }

        public void OnGirlButtonClicked(int girlNumber)
        {
            
        }
    }
    
}