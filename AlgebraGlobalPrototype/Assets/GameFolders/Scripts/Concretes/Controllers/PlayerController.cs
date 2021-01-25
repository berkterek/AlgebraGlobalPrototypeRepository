using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototyle.Inputs;
using AlgebraGlobalPrototype.Abstracts.Controllers;
using AlgebraGlobalPrototype.Abstracts.Inputs;
using UnityEngine;

namespace AlgebraGlobalPrototype.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        IPlayerInput _input;
        Vector3 _screenPosition;
        Camera _camera;
        bool _isPress;
        
        private void Awake()
        {
            _input = new MyInput();
            _camera = Camera.main;
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
                Vector3 screenCoordinated = new Vector3(_screenPosition.x, _screenPosition.y,_camera.nearClipPlane);
                Ray ray = _camera.ScreenPointToRay(screenCoordinated);
            
                if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
                {
                    IUnitController unitController = hit.collider.GetComponent<IUnitController>();

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