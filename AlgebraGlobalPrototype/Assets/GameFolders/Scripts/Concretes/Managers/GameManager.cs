using System;
using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Utilities;
using UnityEngine;

namespace AlgebraGlobalPrototype.Managers
{
    public class GameManager : SingletonObject<GameManager>
    {
        private void Awake()
        {
            SingletonThisObject(this);
        }
        
        
    }    
}

