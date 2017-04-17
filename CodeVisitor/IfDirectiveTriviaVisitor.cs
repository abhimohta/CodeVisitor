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
        class IfDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public IfDirectiveTriviaVisitor()
            {
                Classes = new List<IfDirectiveTriviaSyntax>();
            }

            public List<IfDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
            {
                node = (IfDirectiveTriviaSyntax)base.VisitIfDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }