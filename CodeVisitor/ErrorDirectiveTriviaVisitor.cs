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
        class ErrorDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public ErrorDirectiveTriviaVisitor()
            {
                Classes = new List<ErrorDirectiveTriviaSyntax>();
            }

            public List<ErrorDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node)
            {
                node = (ErrorDirectiveTriviaSyntax)base.VisitErrorDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }