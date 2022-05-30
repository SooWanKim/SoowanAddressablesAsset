using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;

public class LoadAssetByRef : MonoBehaviour
{
    public AssetLabelReference labelRef;
    public AssetReference baseCube;
    public AssetReferenceGameObject gameObjectRef;

    public void SpawnThing()
    {
        baseCube.InstantiateAsync();
        Addressables.InstantiateAsync(labelRef.labelString);
        // Addressables.InstantiateAsync(gameObjectRef);

        if (gameObjectRef.IsValid() == false)
        {
            gameObjectRef.LoadAssetAsync<GameObject>().Completed += (ob) =>
            {
                // GameObject.Instantiate(gameObjectRef.Asset);
                // Addressables.InstantiateAsync(ob);
                gameObjectRef.Instantiate();
            };
        }
        else
        {
            gameObjectRef.Instantiate();
        }
    }
}
