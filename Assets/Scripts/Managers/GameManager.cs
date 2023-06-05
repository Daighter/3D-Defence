using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEditor.EditorTools;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const string DefaultName = "Manager";

    private static GameManager instance;
    private static DataManager dataManager;
    private static ResourceManager resourceManager;
    private static PoolManager poolManager;

    public static GameManager Instance { get { return instance; } }
    public static DataManager DataManager { get { return dataManager; } }
    public static ResourceManager Resource { get { return resourceManager; } }
    public static PoolManager Pool { get { return poolManager; } }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("GameInstance: valid instance already registered.");
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);
        InitManagers();
    }

    private void OnDestroy()
    {
        if (instance == this)
            instance = null;
    }

    private void InitManagers()
    {
        // Manager init
        GameObject dataObj = new GameObject() { name = "DataManager" };
        dataObj.transform.SetParent(transform);
        dataManager = dataObj.GetComponent<DataManager>();

        GameObject resourceObj = new GameObject() { name = "ResourceManager" };
        resourceObj.transform.SetParent(transform);
        resourceManager = resourceObj.AddComponent<ResourceManager>();

        GameObject poolObj = new GameObject() { name = "PoolManager" };
        poolObj.transform.SetParent(transform);
        poolManager = poolObj.AddComponent<PoolManager>();
    }
}
