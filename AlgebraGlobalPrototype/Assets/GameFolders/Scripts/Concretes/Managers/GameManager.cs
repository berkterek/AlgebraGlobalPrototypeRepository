using System;
using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlgebraGlobalPrototype.Managers
{
    public class GameManager : SingletonObject<GameManager>
    {
        private void Awake()
        {
            SingletonThisObject(this);
        }

        private IEnumerator Start()
        {
            yield return SceneManager.LoadSceneAsync("SplashScene");
        }
    }    
}

