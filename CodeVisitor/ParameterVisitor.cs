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
        class ParameterVisitor : CSharpSyntaxRewriter
        {
            public ParameterVisitor()
            {
                Classes = new List<ParameterSyntax>();
            }

            public List<ParameterSyntax> Classes { get; set; }

            public override SyntaxNode VisitParameter(ParameterSyntax node)
            {
                node = (ParameterSyntax)base.VisitParameter(node);
                Classes.Add(node);
                return node;
            }
        }
    }