using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainInit : MonoBehaviour
{
    private void Awake()
    {
        //���HotUpdatePrefab.prefab���ڵ�AssetBundle
        AssetBundle prefabAb = null; 
        GameObject hotUpdatePrefab = Instantiate(prefabAb.LoadAsset<GameObject>("HybirdCLREntrance.prefab"));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
