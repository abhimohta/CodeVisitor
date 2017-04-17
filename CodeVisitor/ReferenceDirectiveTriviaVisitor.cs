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
        class ReferenceDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public ReferenceDirectiveTriviaVisitor()
            {
                Classes = new List<ReferenceDirectiveTriviaSyntax>();
            }

            public List<ReferenceDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)
            {
                node = (ReferenceDirectiveTriviaSyntax)base.VisitReferenceDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }