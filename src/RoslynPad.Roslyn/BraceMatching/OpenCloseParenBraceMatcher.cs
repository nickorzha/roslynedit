﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace RoslynPad.Roslyn.BraceMatching;

[ExportBraceMatcher(LanguageNames.CSharp)]
internal class OpenCloseParenBraceMatcher : AbstractCSharpBraceMatcher
{
    public OpenCloseParenBraceMatcher()
        : base(SyntaxKind.OpenParenToken, SyntaxKind.CloseParenToken)
    {
    }
}
