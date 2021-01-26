using AlgebraGlobalPrototype.Abstracts.Movements;
using UnityEngine;

namespace AlgebraGlobalPrototype.Movements
{
    public class SelectedObject : ISelectedObject
    {
        Camera _camera;

        public SelectedObject(Camera camera)
        {
            _camera = camera;
        }

        public Collider GetCollider(Vector3 screenPoint)
        {
            Vector3 screenCoordinated = new Vector3(screenPoint.x, screenPoint.y, _camera.nearClipPlane);
            Ray ray = _camera.ScreenPointToRay(screenCoordinated);

            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {
                return hit.collider;    
            }

            return null;
        }
    }
}