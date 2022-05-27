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
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void SpawnThing()
	{
		baseCube.InstantiateAsync();
        Addressables.InstantiateAsync(labelRef.labelString);
        Addressables.InstantiateAsync(gameObjectRef);
	}
}
