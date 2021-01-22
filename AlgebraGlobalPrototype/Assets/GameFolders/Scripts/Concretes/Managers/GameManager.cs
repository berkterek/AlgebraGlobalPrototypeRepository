using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlgebraGlobalPrototype.Managers
{
    public class GameManager : SingletonObject<GameManager>
    {
        [SerializeField] float _maxDelayTime = 5f;
        [SerializeField] float _currentDelaytime;

        public event System.Action<float, float> OnDelayTimeChanged;
        
        private void Awake()
        {
            SingletonThisObject(this);
        }

        // private IEnumerator Start()
        // {
        //     var loadOperation = SceneManager.LoadSceneAsync("SplashScene");
        //     
        //     while (!loadOperation.isDone)
        //     {
        //         yield return null;
        //     }
        //     
        //     loadOperation.completed += Oncompleted;
        // }

        private void Oncompleted(AsyncOperation obj)
        {
            StartCoroutine(LoadGameSceneAsync(obj));
        }

        private IEnumerator LoadGameSceneAsync(AsyncOperation obj)
        {
            yield return new WaitForSeconds(1f);
            
            while (_currentDelaytime <= _maxDelayTime)
            {
                _currentDelaytime += Time.deltaTime;
                OnDelayTimeChanged?.Invoke(_currentDelaytime,_maxDelayTime);
                yield return new WaitForEndOfFrame();
            }
            
            yield return new WaitForSeconds(1f);
            
            obj.completed -= Oncompleted;
            _currentDelaytime = 0f;

            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1,
                LoadSceneMode.Additive).completed += operation => SceneManager.UnloadSceneAsync("SplashScene");
        }
    }    
}

