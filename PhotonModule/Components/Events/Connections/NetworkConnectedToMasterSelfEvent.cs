﻿namespace Girand.Ecs.GameSettings.Components.Events
{
    using System;

    /// <summary>
    /// connected to photon network event.
    /// </summary>
#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif
    [Serializable]
    public struct NetworkConnectedToMasterSelfEvent
    {
        
    }
}