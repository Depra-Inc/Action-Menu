using UnityEngine;
using UnityEngine.SceneManagement;

namespace FD.Common
{
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        public bool keepAlive = true;

        protected int instancesInScene;

        protected static T instance;

        public static T Instance
        {
            get
            {
                if (instance != null)
                    return instance;

                return FindObjectOfType<T>();
            }
        }

        #region Unity methods

        protected virtual void Awake()
        {
            instancesInScene++;

            if (Init(Instance, GetComponentName()))
                instance = (T)this;
        }

        protected virtual void Start()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        protected virtual void OnDestroy()
        {
            var numComponents = GetComponentsInChildren<Component>().Length;

            if (transform.childCount == 0 && numComponents <= 2)
                Destroy(gameObject);

            instancesInScene--;

            SceneManager.sceneLoaded -= OnSceneLoaded;

            if (Instance == this)
                instance = null;
        }

        #endregion

        protected virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            if (instancesInScene < 2)
            {
                if (!keepAlive)
                    DisposeInternal();
            }
            else
            {
                if (!keepAlive && Instance != this)
                    DisposeInternal();
            }
        }

        protected virtual bool Init(T instance, string detectorName)
        {
            if (instance != null && instance != this && instance.keepAlive)
            {
                DisposeInternal();
                return false;
            }

            DontDestroyOnLoad(transform.parent != null ? transform.root.gameObject : gameObject);

            return true;
        }

        protected virtual void DisposeInternal()
        {
            Destroy(this);
        }

        protected abstract string GetComponentName();
    }
}
