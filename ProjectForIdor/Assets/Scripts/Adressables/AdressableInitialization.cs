    using System.Collections.Generic;
    using ScriptableObjects.Girls;
    using Unity.VisualScripting;
    using UnityEngine;
    using UnityEngine.AddressableAssets;
    using UnityEngine.ResourceManagement.AsyncOperations;

    public class AdressableInitialization : MonoBehaviour
    {
        [SerializeField] private List<AssetReference> girlSO;

        [SerializeField] private AssetReference girlPage;

        [SerializeField] private AssetReference girlPageCanvas;
        
        private GameObject _instanceRefrerence;
        
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
            girlPageCanvas.LoadAssetAsync<GameObject>().Completed += OnAddressableLoaded;
        }

        private void OnAddressableLoaded(AsyncOperationHandle<GameObject> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                //Instantiate(handle.Result);
                GameObject instantiatedObject = Instantiate(handle.Result);
                //instantiatedObjects.Add(instantiatedObject);
            }

            //_instanceRefrerence = handle.Result;
            else
            {
                Debug.LogError("Adressable was not loaded");
            }
                
        }
        
        private void OnGirlLoaded(AsyncOperationHandle<GirlSO> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                // Instantiate or process the loaded GirlSO asset here
                // For example:
                loadedGirlSOs.Add(handle.Result);
                //GirlSO girlSO = handle.Result;
                //Debug.Log("GirlSO loaded: " + girlSO.girlName);
            }
            else
            {
                Debug.LogError("GirlSO was not loaded");
            }
        }
    }
