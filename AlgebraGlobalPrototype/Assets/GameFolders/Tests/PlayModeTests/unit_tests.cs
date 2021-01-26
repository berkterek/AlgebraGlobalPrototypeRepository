using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Inputs;
using AlgebraGlobalPrototype.Controllers;
using AlgebraGlobalPrototype.Tests;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace PlayModeTests
{
    public class unit_tests
    {
        [UnityTest]
        public IEnumerator unit_can_bounce()
        {
            yield return TestHelpers.LoadMainSceneTest();

            UnitController unitController = TestHelpers.GetEntity<UnitController>();

            float origin = unitController.Velocity;
            
            unitController.Bouncing();

            yield return new WaitForSeconds(1f);
            
            Assert.AreNotEqual(origin,unitController.Velocity);
        }
        
        [UnityTest]
        public IEnumerator unit_can_bounce_after_steady()
        {
            yield return TestHelpers.LoadMainSceneTest();

            UnitController unitController = TestHelpers.GetEntity<UnitController>();

            float origin = unitController.Velocity;
            
            unitController.Bouncing();

            yield return new WaitForSeconds(3f);
            
            unitController.Bouncing();

            yield return new WaitForSeconds(3f);
            
            Assert.AreEqual(origin, unitController.Velocity);
        }
    }
}