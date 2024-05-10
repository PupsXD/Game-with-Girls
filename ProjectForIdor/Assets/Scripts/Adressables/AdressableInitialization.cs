    using System.Collections.Generic;
    using ScriptableObjects.Girls;
    using UnityEngine;
    using UnityEngine.AddressableAssets;
    using UnityEngine.ResourceManagement.AsyncOperations;

    public class AdressableInitialization : MonoBehaviour
    {
        [SerializeField] private List<AssetReference> girlSO;

        [SerializeField] private AssetReference girlPage;
        
        private GameObject _girlPageInstance;

        [SerializeField] private AssetReference girlPageCanvas;
        
        private GameObject _instanceRefererence;
        
        private List<GirlSO> loadedGirlSOs = new List<GirlSO>();
        
        
        

        public void InitializeGirls( )
        {
            foreach (var girlRef in girlSO)
            {
                girlRef.LoadAssetAsync<GirlSO>().Completed += OnGirlLoaded;
            }
        }

        public List<GirlSO> GetInstantiatedGirls()
        {
            return loadedGirlSOs;
        }
        
        public void InitializeGirlPage()
        {
            girlPage.LoadAssetAsync<GameObject>().Completed += OnAddressableLoaded;
        }
        
        public void InitializeGirlPageCanvas()
        {
            
                girlPageCanvas.InstantiateAsync().Completed += OnGirlPageInstantiated;
                
            
        }
        
        public void ReleaseGirlPage()
        {
            
                girlPageCanvas.ReleaseInstance(_instanceRefererence);
            
        }

        private void OnAddressableLoaded(AsyncOperationHandle<GameObject> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                
                GameObject instantiatedObject = Instantiate(handle.Result);
                
            }

            
            else
            {
                Debug.LogError("Adressable was not loaded");
            }
                
        }

        private void OnGirlPageInstantiated(AsyncOperationHandle<GameObject> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                _instanceRefererence = handle.Result;
            }
        }
        
        private void OnGirlLoaded(AsyncOperationHandle<GirlSO> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                loadedGirlSOs.Add(handle.Result);
            }
            else
            {
                Debug.LogError("GirlSO was not loaded");
            }
        }
    }
