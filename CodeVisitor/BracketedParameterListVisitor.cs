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
        class BracketedParameterListVisitor : CSharpSyntaxRewriter
        {
            public BracketedParameterListVisitor()
            {
                Classes = new List<BracketedParameterListSyntax>();
            }

            public List<BracketedParameterListSyntax> Classes { get; set; }

            public override SyntaxNode VisitBracketedParameterList(BracketedParameterListSyntax node)
            {
                node = (BracketedParameterListSyntax)base.VisitBracketedParameterList(node);
                Classes.Add(node);
                return node;
            }
        }
    }