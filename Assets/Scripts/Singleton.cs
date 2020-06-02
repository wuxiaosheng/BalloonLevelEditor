using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class Singleton<T> where T : new()
    {
        private static T _instance;
        public static T getInstance() {
            if (_instance == null) {
                _instance = new T();
            }
            return _instance;
        }
    }

    public class SingleMono<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        public static T getInstance()
        {
            if (_instance == null)
            {
                _instance = new GameObject().AddComponent<T>();
            }
            return _instance;
        }
    }

