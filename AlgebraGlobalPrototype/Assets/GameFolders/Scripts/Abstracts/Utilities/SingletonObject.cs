using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlgebraGlobalPrototype.Abstracts.Utilities
{
    public abstract class SingletonObject<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }

        protected void SingletonThisObject(T instance)
        {
            if (Instance == null)
            {
                Instance = instance;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }    
}
