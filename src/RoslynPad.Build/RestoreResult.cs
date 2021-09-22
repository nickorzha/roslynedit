﻿using System;

namespace RoslynPad.Build
{
    internal class RestoreResult
    {
        public static RestoreResult SuccessResult { get; } = new RestoreResult(success: true, errors: null);

        public static RestoreResult FromErrors(string[] errors) => new RestoreResult(success: false, errors);

        private RestoreResult(bool success, string[]? errors)
        {
            Success = success;
            Errors = errors ?? Array.Empty<string>();
        }

        public bool Success { get; }
        public string[] Errors { get; }
    }
}
