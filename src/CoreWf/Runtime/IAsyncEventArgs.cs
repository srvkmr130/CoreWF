// This file is part of Core WF which is licensed under the MIT license.
// See LICENSE file in the project root for full license information.

using System;

namespace CoreWf.Runtime
{
    internal interface IAsyncEventArgs
    {
        object AsyncState { get; }

        Exception Exception { get; }
    }
}
