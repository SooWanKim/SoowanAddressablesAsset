using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.Networking;

public class LoadAssetRemotePath : MonoBehaviour
{
    public string addressableName = "";
    public string remoteAssetPath = "";
    IResourceLocation _remotePath;

    private IList<IResourceLocation> _locations;
    private void Start()
    {
        // Addressables.LoadResourceLocationsAsync(addressableName).Completed += (handle) =>
        // {
        //     var locations = handle.Result;
        //     Addressables.InstantiateAsync(locations[0]);
        // };

        // Addressables.LoadResourceLocationsAsync(remoteAssetPath).Completed += (handle)=>
        // {
        //     var locations = handle.Result;
        //     Debug.Log(locations[0].PrimaryKey);
        //     Debug.Log(locations[0].Data);
        //     Debug.Log(locations[0].InternalId);
        //     Debug.Log(locations[0]);
        //     Addressables.InstantiateAsync(locations[0]);
        // };

        LoadRemotePath();
    }

    public void LoadRemotePath()
    {
        Addressables.GetDownloadSizeAsync(remoteAssetPath).Completed += (handle) =>
        {
           Debug.Log(handle.Result.ToString());
        };

        Addressables.LoadResourceLocationsAsync(remoteAssetPath).Completed += (handle) =>
        {
            _locations = handle.Result;
            _remotePath = _locations[0];
            Addressables.InstantiateAsync(_locations[0]);
        };
    }

    void OnGUI()
    {
        GUIStyle guiStyle = new GUIStyle();
        guiStyle.fontSize = 30;

        if (_remotePath != null)
        {
            GUI.Label(new Rect(0, 50, 400, 400), _remotePath.ToString());
            GUI.Label(new Rect(0, 100, 400, 500), _remotePath.PrimaryKey);
            GUI.Label(new Rect(0, 150, 400, 600), _remotePath.InternalId);
        }
    }
}