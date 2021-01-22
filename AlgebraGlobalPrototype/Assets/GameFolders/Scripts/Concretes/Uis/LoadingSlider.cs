using System;
using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace AlgebraGlobalPrototype.Uis
{
    public class LoadingSlider : MonoBehaviour
    {
        Slider _slider;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
        }

        private void OnEnable()
        {
            GameManager.Instance.OnDelayTimeChanged += InstanceOnOnDelayTimeChanged;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnDelayTimeChanged -= InstanceOnOnDelayTimeChanged;
        }

        private void InstanceOnOnDelayTimeChanged(float currentDelayTime, float maxDelayTime)
        {
            _slider.value = currentDelayTime / maxDelayTime;
        }
    }    
}

