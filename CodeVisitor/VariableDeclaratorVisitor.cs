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
        class VariableDeclaratorVisitor : CSharpSyntaxRewriter
        {
            public VariableDeclaratorVisitor()
            {
                Classes = new List<VariableDeclaratorSyntax>();
            }

            public List<VariableDeclaratorSyntax> Classes { get; set; }

            public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
            {
                node = (VariableDeclaratorSyntax)base.VisitVariableDeclarator(node);
                Classes.Add(node);
                return node;
            }
        }
    }