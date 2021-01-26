using UnityEngine;

namespace AlgebraGlobalPrototype.Abstracts.Movements
{
    public interface ISelectedObject
    {
        Collider GetCollider(Vector3 screenPoint);
    }
}