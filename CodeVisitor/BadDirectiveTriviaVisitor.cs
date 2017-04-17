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
        class BadDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public BadDirectiveTriviaVisitor()
            {
                Classes = new List<BadDirectiveTriviaSyntax>();
            }

            public List<BadDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node)
            {
                node = (BadDirectiveTriviaSyntax)base.VisitBadDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }