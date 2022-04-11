// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Quantum.Simulation.Core;

namespace Microsoft.Quantum.Intrinsic.Interfaces
{
    public interface IIntrinsicApplyUncontrolledXY : IOperationFactory
    {
        void Body(Qubit qubit1, Qubit qubit2);
    }
}