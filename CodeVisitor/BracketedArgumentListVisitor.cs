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
        class BracketedArgumentListVisitor : CSharpSyntaxRewriter
        {
            public BracketedArgumentListVisitor()
            {
                Classes = new List<BracketedArgumentListSyntax>();
            }

            public List<BracketedArgumentListSyntax> Classes { get; set; }

            public override SyntaxNode VisitBracketedArgumentList(BracketedArgumentListSyntax node)
            {
                node = (BracketedArgumentListSyntax)base.VisitBracketedArgumentList(node);
                Classes.Add(node);
                return node;
            }
        }
    }