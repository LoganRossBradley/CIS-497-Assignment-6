
/*
 * Logan Ross
 * Assignment 6
 * singleton example
 */

using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T instance;

        public static T Instacne
        {
            get { return instance; }
        }

        public static bool IsInitialized
        {
            get { return instance != null;  }
        }

        private void Awake()
        {
            if (instance != null)
            {
                Debug.LogError("[Singleton] Trying to instantiate a second instance of a singleton class");
            }
            else
            {
                instance = (T)this;
            }
        }

        protected virtual void OnDestroy()
        {
            //if destroyed allow new one to be made
            if (instance == this)
                instance = null;
        }
    }
}