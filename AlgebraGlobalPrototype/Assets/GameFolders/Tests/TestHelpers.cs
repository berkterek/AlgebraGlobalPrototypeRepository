using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Controllers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlgebraGlobalPrototype.Tests
{
    public static class TestHelpers 
    {
        public static T GetEntity<T>() where T: Component,IEntityController
        {
            return GameObject.FindObjectOfType<T>();
        }

        public static IEnumerator LoadMainSceneTest()
        {
            yield return SceneManager.LoadSceneAsync("MainSceneTest");
        }
    }    
}

