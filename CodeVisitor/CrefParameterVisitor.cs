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
        class CrefParameterVisitor : CSharpSyntaxRewriter
        {
            public CrefParameterVisitor()
            {
                Classes = new List<CrefParameterSyntax>();
            }

            public List<CrefParameterSyntax> Classes { get; set; }

            public override SyntaxNode VisitCrefParameter(CrefParameterSyntax node)
            {
                node = (CrefParameterSyntax)base.VisitCrefParameter(node);
                Classes.Add(node);
                return node;
            }
        }
    }