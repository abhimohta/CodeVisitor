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
        class ArgumentListVisitor : CSharpSyntaxRewriter
        {
            public ArgumentListVisitor()
            {
                Classes = new List<ArgumentListSyntax>();
            }

            public List<ArgumentListSyntax> Classes { get; set; }

            public override SyntaxNode VisitArgumentList(ArgumentListSyntax node)
            {
                node = (ArgumentListSyntax)base.VisitArgumentList(node);
                Classes.Add(node);
                return node;
            }
        }
    }