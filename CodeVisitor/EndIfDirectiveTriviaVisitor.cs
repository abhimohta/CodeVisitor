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
        class EndIfDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public EndIfDirectiveTriviaVisitor()
            {
                Classes = new List<EndIfDirectiveTriviaSyntax>();
            }

            public List<EndIfDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
            {
                node = (EndIfDirectiveTriviaSyntax)base.VisitEndIfDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }