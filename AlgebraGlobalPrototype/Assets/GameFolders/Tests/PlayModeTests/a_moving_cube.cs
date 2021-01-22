using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace PlayModeTests
{
    public class a_moving_cube
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator moving_forward_changes_position()
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = Vector3.zero;

            for (int i = 0; i < 10; i++)
            {
                cube.transform.position += Vector3.forward;
                yield return new WaitForSeconds(0.5f);
            }

            Assert.AreEqual(10f,cube.transform.position.z);
            
            yield return null;
        }
    }
}