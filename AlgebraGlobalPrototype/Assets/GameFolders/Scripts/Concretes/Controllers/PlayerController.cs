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
    public class PlayerController : MonoBehaviour, IEntityController
    {
        ISelectedObject _selectedObject;
        Vector3 _screenPosition;
        bool _isPress;
        
        public IPlayerInput Input { get; set; }

        private void Awake()
        {
            Input = new MyInput();
            _selectedObject = new SelectedObject(Camera.main);
        }

        private void Update()
        {
            if (Input.IsPress)
            {
                _screenPosition = Input.ClickPosition;
                _isPress = true;
            }
        }

        private void FixedUpdate()
        {
            PressProcess();
        }

        private void PressProcess()
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