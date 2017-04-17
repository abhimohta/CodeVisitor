using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace CodeVisitor
    {
        class PragmaWarningDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public PragmaWarningDirectiveTriviaVisitor()
            {
                Classes = new List<PragmaWarningDirectiveTriviaSyntax>();
            }

            public List<PragmaWarningDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)
            {
                node = (PragmaWarningDirectiveTriviaSyntax)base.VisitPragmaWarningDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }