using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Controllers;
using AlgebraGlobalPrototype.Abstracts.Movements;
using UnityEngine;

namespace AlgebraGlobalPrototype.Movements
{
    public class JumpWithForce : IJump
    {
        Rigidbody _rigidbody;

        public JumpWithForce(IEntityController entityController)
        {
            _rigidbody = entityController.transform.GetComponent<Rigidbody>();
        }

        public void JumpAction(float jumpForce)
        {
            _rigidbody.AddForce(Vector3.up * jumpForce * Time.deltaTime);
        }
    }    
}

