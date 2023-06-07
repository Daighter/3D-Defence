using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEditor.EditorTools;
using UnityEngine;

namespace Report230607
{
    public class GameManager : MonoBehaviour
    {
        public const string DefaultName = "Manager";

        private static GameManager instance;
        private static ResourceManager resourceManager;
        private static PoolManager poolManager;
        private static UIManager uiManager;

        public static GameManager Instance { get { return instance; } }
        public static ResourceManager Resource { get { return resourceManager; } }
        public static PoolManager Pool { get { return poolManager; } }
        public static UIManager UI { get { return uiManager; } }

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
            GameObject resourceObj = new GameObject() { name = "ResourceManager" };
            resourceObj.transform.SetParent(transform);
            resourceManager = resourceObj.AddComponent<ResourceManager>();

            GameObject poolObj = new GameObject() { name = "PoolManager" };
            poolObj.transform.SetParent(transform);
            poolManager = poolObj.AddComponent<PoolManager>();

            GameObject uiObj = new GameObject() { name = "UIManager" };
            uiObj.transform.SetParent(transform);
            uiManager = uiObj.AddComponent<UIManager>();
        }
    }
}
