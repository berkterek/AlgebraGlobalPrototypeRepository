using System.Collections;
using System.Collections.Generic;
using AlgebraGlobalPrototype.Abstracts.Inputs;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace EditModeTests
{
    public class player_tests
    {
        [Test]
        public void player_input_is_press()
        {
            IPlayerInput input = Substitute.For<IPlayerInput>();

            input.IsPress.Returns(true);
            
            Assert.AreEqual(input.IsPress,true);
        }
    }
}
