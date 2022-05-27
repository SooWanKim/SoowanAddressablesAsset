using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.IO;

public class LoadAssetByLabel : MonoBehaviour
{
    public string addressableLable = "mycube";
    public string addressableName = "";
    public void Start()
    {
        Addressables.InstantiateAsync(addressableLable);
        Addressables.InstantiateAsync(addressableName);
    }
}