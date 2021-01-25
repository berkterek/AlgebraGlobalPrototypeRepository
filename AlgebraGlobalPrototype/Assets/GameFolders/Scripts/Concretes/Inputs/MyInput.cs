using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Inputs;
using UnityEngine;

namespace AlgebraGlobalPrototyle.Inputs
{
    public class MyInput : IPlayerInput
    {
        MyInputAction _inputAction;

        public Vector2 ClickPosition { get; private set; }
        public bool IsPress { get; private set; }

        public MyInput()
        {
            _inputAction = new MyInputAction();

            _inputAction.OnFoot.Click.started += context => IsPress = true;
            _inputAction.OnFoot.Click.canceled += context => IsPress = false;
            _inputAction.OnFoot.ClickPosition.performed += context => ClickPosition = context.ReadValue<Vector2>();
            
            _inputAction.Enable();
        }
    }
}