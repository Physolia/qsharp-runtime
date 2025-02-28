﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;
using Xunit;
using Microsoft.Quantum.Simulation.XUnit;
using Microsoft.Quantum.Simulation.Simulators.Tests.Circuits;

namespace Microsoft.Quantum.Simulation.Simulators.Tests
{
    public partial class QuantumSimulatorTests
    {
        [OperationDriver(TestCasePrefix ="QSim", TestNamespace = "Microsoft.Quantum.Simulation.Simulators.Tests.Circuits")]
        public void QSimTestTarget( TestOperation op )
        {
            var simulators = new CommonNativeSimulator[] { 
                new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true),
                new SparseSimulator(throwOnReleasingQubitsNotInZeroState: true)
            };

            foreach (var sim in simulators)
            {
                try
                {
                    op.TestOperationRunner(sim);
                }
                finally
                {
                    sim.Dispose();
                }
            }
        }
    }
}
