using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlgebraGlobalPrototype.Abstracts.Inputs
{
    public interface IPlayerInput
    {
        Vector2 ClickPosition { get; }
        bool IsPress { get; }
    }    
}

