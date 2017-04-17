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
        class ArrayRankSpecifierVisitor : CSharpSyntaxRewriter
        {
            public ArrayRankSpecifierVisitor()
            {
                Classes = new List<ArrayRankSpecifierSyntax>();
            }

            public List<ArrayRankSpecifierSyntax> Classes { get; set; }

            public override SyntaxNode VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
            {
                node = (ArrayRankSpecifierSyntax)base.VisitArrayRankSpecifier(node);
                Classes.Add(node);
                return node;
            }
        }
    }