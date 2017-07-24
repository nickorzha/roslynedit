﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.LanguageServices;
using Microsoft.CodeAnalysis.Shared.Extensions;

namespace RoslynPad.Roslyn
{
    public static class DocumentExtensions
    {
        public static TLanguageService GetLanguageService<TLanguageService>(this Document document)
            where TLanguageService : class, ILanguageService
        {
            return document?.Project?.LanguageServices?.GetService<TLanguageService>();
        }

        public static async Task<SyntaxToken> GetTouchingWordAsync(this Document document, int position, CancellationToken cancellationToken, bool findInsideTrivia = false)
        {
            var syntaxTree = await document.GetSyntaxTreeAsync(cancellationToken).ConfigureAwait(false);
            var syntaxFacts = document.GetLanguageService<ISyntaxFactsService>();
            return await syntaxTree.GetTouchingTokenAsync(position, syntaxFacts.IsWord, cancellationToken, findInsideTrivia).ConfigureAwait(false);
        }
    }
}