﻿namespace SemtechLib.Devices.SX1231.Events
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [Serializable, ComVisible(true)]
    public delegate void ListenEndEventHandler(object sender, ListenEndEventArg e);
}

