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
        class ElseDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public ElseDirectiveTriviaVisitor()
            {
                Classes = new List<ElseDirectiveTriviaSyntax>();
            }

            public List<ElseDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node)
            {
                node = (ElseDirectiveTriviaSyntax)base.VisitElseDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }