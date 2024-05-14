    using System.Collections.Generic;
    using ScriptableObjects.Girls;
    using UnityEngine;
    using UnityEngine.AddressableAssets;
    using UnityEngine.ResourceManagement.AsyncOperations;
    using UnityEngine.Serialization;

    public class AdressableInitialization : MonoBehaviour
    {
        [SerializeField] private AssetReference girlArchive;
        
        private GameObject _girlArchiveInstance;
        
        [SerializeField] private List<AssetReference> girlSO;
        
        private GameObject _girlPageInstance;

        [SerializeField] private AssetReference girlPage;
        
        private GameObject _instanceRefererence;
        
        private List<GirlSO> loadedGirlSOs = new List<GirlSO>();

        [SerializeField] private GameObject parentCanvas;
        
        private void Awake()
        {
            InstantiateGirlAcrhive();
        }
        

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
        

        public void InstantiateGirlAcrhive()
        {
            girlArchive.InstantiateAsync().Completed += OnGirlArchiveInstantiated;
        }

        public void ReleaseGirlAcrhive()
        {
            girlArchive.ReleaseInstance(_girlArchiveInstance);
        }
        
        public void InitializeGirlPageCanvas()
        {
            
                girlPage.InstantiateAsync().Completed += OnGirlPageInstantiated;
                
            
        }
        
        public void ReleaseGirlPage()
        {
            
                girlPage.ReleaseInstance(_instanceRefererence);
            
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
        
        private void OnGirlArchiveInstantiated(AsyncOperationHandle<GameObject> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                _girlArchiveInstance = handle.Result;
                _girlArchiveInstance.transform.SetParent(parentCanvas.transform, worldPositionStays: false);
                
            }
        }

        private void OnGirlPageInstantiated(AsyncOperationHandle<GameObject> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                _instanceRefererence = handle.Result;
                _instanceRefererence.transform.SetParent(parentCanvas.transform, worldPositionStays: false);
                
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
