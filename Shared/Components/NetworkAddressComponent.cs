﻿namespace Game.Ecs.Network.Shared.Components
{
    using System;
    using UnityEngine.Serialization;

    /// <summary>
    /// address of network object
    /// </summary>
#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif
    [Serializable]
    public struct NetworkAddressComponent
    {
        public string Address;
        public int Port;
    }
}