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
        class EndRegionDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public EndRegionDirectiveTriviaVisitor()
            {
                Classes = new List<EndRegionDirectiveTriviaSyntax>();
            }

            public List<EndRegionDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
            {
                node = (EndRegionDirectiveTriviaSyntax)base.VisitEndRegionDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }