using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototyle.Inputs;
using AlgebraGlobalPrototype.Abstracts.Controllers;
using AlgebraGlobalPrototype.Abstracts.Inputs;
using AlgebraGlobalPrototype.Abstracts.Movements;
using AlgebraGlobalPrototype.Movements;
using UnityEngine;

namespace AlgebraGlobalPrototype.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        IPlayerInput _input;
        ISelectedObject _selectedObject;
        Vector3 _screenPosition;
        bool _isPress;

        private void Awake()
        {
            _input = new MyInput();
            _selectedObject = new SelectedObject(Camera.main);
        }

        private void Update()
        {
            if (_input.IsPress)
            {
                _screenPosition = _input.ClickPosition;
                _isPress = true;
            }
        }

        private void FixedUpdate()
        {
            if (_isPress)
            {
                Collider collider = _selectedObject.GetCollider(_screenPosition);

                if (collider != null)
                {
                    IUnitController unitController = collider.GetComponent<IUnitController>();

                    if (unitController != null)
                    {
                        unitController.Bouncing();
                    }    
                }

                _isPress = false;
            }
        }
    }
}