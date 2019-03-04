﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using RoslynPad.Runtime;

namespace RoslynPad.Hosting
{
    internal interface IExecutionHost : IDisposable
    {
        ExecutionPlatform Platform { get; set; }

        event Action<IList<CompilationErrorResultObject>> CompilationErrors;
        event Action<string> Disassembled;
        event Action<ResultObject> Dumped;
        event Action<ExceptionResultObject> Error;

        Task ExecuteAsync(string code, bool disassemble, OptimizationLevel? optimizationLevel);
        Task ResetAsync();
        Task Update(InitializationParameters parameters);
    }
}