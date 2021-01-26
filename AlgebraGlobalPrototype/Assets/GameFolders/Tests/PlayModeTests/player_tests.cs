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
    public class player_tests
    {
        [UnityTest]
        public IEnumerator player_can_touch_value_returns_true()
        {
            yield return TestHelpers.LoadMainSceneTest();

            yield return new WaitForSeconds(1f);

            PlayerController playerController = TestHelpers.GetEntity<PlayerController>();

            playerController.Input = Substitute.For<IPlayerInput>();

            playerController.Input.IsPress.Returns(true);

            Assert.AreEqual(playerController.Input.IsPress, true);
        }
    }
}