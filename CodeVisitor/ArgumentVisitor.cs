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
        class ArgumentVisitor : CSharpSyntaxRewriter
        {
            public ArgumentVisitor()
            {
                Classes = new List<ArgumentSyntax>();
            }

            public List<ArgumentSyntax> Classes { get; set; }

            public override SyntaxNode VisitArgument(ArgumentSyntax node)
            {
                node = (ArgumentSyntax)base.VisitArgument(node);
                Classes.Add(node);
                return node;
            }
        }
    }