﻿namespace Game.Ecs.Network.Shared.Components
{
    using System;

    /// <summary>
    /// mark entity as network client
    /// </summary>
#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif
    [Serializable]
    public struct NetworkClientIdComponent
    {
        public ulong Id;
    }
}