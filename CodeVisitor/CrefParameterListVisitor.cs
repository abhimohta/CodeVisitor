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
        class CrefParameterListVisitor : CSharpSyntaxRewriter
        {
            public CrefParameterListVisitor()
            {
                Classes = new List<CrefParameterListSyntax>();
            }

            public List<CrefParameterListSyntax> Classes { get; set; }

            public override SyntaxNode VisitCrefParameterList(CrefParameterListSyntax node)
            {
                node = (CrefParameterListSyntax)base.VisitCrefParameterList(node);
                Classes.Add(node);
                return node;
            }
        }
    }