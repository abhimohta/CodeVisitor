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
        class ParameterListVisitor : CSharpSyntaxRewriter
        {
            public ParameterListVisitor()
            {
                Classes = new List<ParameterListSyntax>();
            }

            public List<ParameterListSyntax> Classes { get; set; }

            public override SyntaxNode VisitParameterList(ParameterListSyntax node)
            {
                node = (ParameterListSyntax)base.VisitParameterList(node);
                Classes.Add(node);
                return node;
            }
        }
    }