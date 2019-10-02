﻿using System;
using System.Collections.Generic;

namespace NTMiner.Core {
    public interface IMineContext {
        Guid Id { get; }
        bool IsRestart { get; }
        string MinerName { get; }
        ICoin MainCoin { get; }
        IPool MainCoinPool { get; }
        IKernel Kernel { get; }
        ICoinKernel CoinKernel { get; }
        string MainCoinWallet { get; }
        int AutoRestartKernelCount { get; set; }
        int KernelSelfRestartCount { get; set; }
        string LogFileFullName { get; }
        KernelProcessType KernelProcessType { get; }
        string CommandLine { get; }

        DateTime CreatedOn { get; }
        Dictionary<string, string> Parameters { get; }
        Dictionary<Guid, string> Fragments { get; }
        Dictionary<Guid, string> FileWriters { get; }
    }
}