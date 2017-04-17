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
        class WarningDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public WarningDirectiveTriviaVisitor()
            {
                Classes = new List<WarningDirectiveTriviaSyntax>();
            }

            public List<WarningDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)
            {
                node = (WarningDirectiveTriviaSyntax)base.VisitWarningDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }