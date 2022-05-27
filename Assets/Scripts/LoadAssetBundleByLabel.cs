using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.IO;

public class LoadAssetBundleByLabel : MonoBehaviour
{
    public string lable = "mycube";
    public string name = "";
    async public void Start()
    {
        // var asset = await Addressables.LoadAssetAsync<GameObject>(lable).Task;
        // Debug.Log(asset);

        Addressables.InstantiateAsync(lable);
        Addressables.InstantiateAsync(name);
    }

    // async LoadAssetAsync(string path)
    // {
    //     yield return Addressables.LoadAssetAsync<GameObject>("mycube").Task;
    //     // AssetBundleCreateRequest createRequest = AssetBundle.LoadFromMemoryAsync(File.ReadAllBytes(path));
    //     // yield return createRequest;
    //     // AssetBundle bundle = createRequest.assetBundle;
    //     // var prefab = bundle.LoadAsset<GameObject>("cube");
    //     // Instantiate(prefab);
    // }

    // public void LoadAddressableAssetBundle()
    // {
    //     Debug.Log($"{Application.persistentDataPath + "/" + bundlePath}");

    //     var myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath, bundlePath));
    //     if (myLoadedAssetBundle == null)
    //     {
    //         Debug.Log("Failed to load AssetBundle!");
    //         return;
    //     }

    //     var asset = myLoadedAssetBundle.LoadAllAssets();
    //     Debug.Log(asset);
    // }
}