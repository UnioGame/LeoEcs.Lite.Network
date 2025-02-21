﻿namespace Game.Ecs.Network.UnityNetcode.Components
{
    using System;
    using UnityEngine;

    /// <summary>
    /// shared rpc component gameobject target
    /// </summary>
#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif
    [Serializable]
    public struct NetcodeSharedRPCComponent
    {
        public GameObject Value;
    }
}