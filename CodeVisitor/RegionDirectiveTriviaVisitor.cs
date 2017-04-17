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
        class RegionDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public RegionDirectiveTriviaVisitor()
            {
                Classes = new List<RegionDirectiveTriviaSyntax>();
            }

            public List<RegionDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
            {
                node = (RegionDirectiveTriviaSyntax)base.VisitRegionDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }