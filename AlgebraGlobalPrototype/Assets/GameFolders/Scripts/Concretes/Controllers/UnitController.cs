using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Controllers;
using AlgebraGlobalPrototype.Abstracts.Movements;
using AlgebraGlobalPrototype.Movements;
using UnityEngine;

namespace AlgebraGlobalPrototype.Controllers
{
    [RequireComponent(typeof(Collider))]
    public class UnitController : MonoBehaviour , IUnitController
    {
        [SerializeField] float _jumpForce = 100f;

        PhysicMaterial _bouncing;
        Rigidbody _rigidbody;
        IJump _jump;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _bouncing = GetComponent<Collider>().material;
            _jump = new JumpWithForce(this);
        }

        public void Bouncing()
        {
            if (_rigidbody.velocity.magnitude == 0)
            {
                _jump.JumpAction(_jumpForce);
                _bouncing.bounceCombine = PhysicMaterialCombine.Maximum;    
            }
            else
            {
                _bouncing.bounceCombine = PhysicMaterialCombine.Average;
            }
        }
    }
}