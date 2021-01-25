using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototyle.Inputs;
using UnityEngine;

namespace AlgebraGlobalPrototype.Controllers
{
    public class UnitController : MonoBehaviour
    {
        MyInput _input;
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
                Ray ray = Camera.main.ScreenPointToRay(screenCoordinated);
            
                if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
                {
                    Debug.Log(hit.collider.gameObject.name);
                }
                
                _isPress = false;
            }
        }
    }
}