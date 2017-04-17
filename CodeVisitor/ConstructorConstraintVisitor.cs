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
        class ConstructorConstraintVisitor : CSharpSyntaxRewriter
        {
            public ConstructorConstraintVisitor()
            {
                Classes = new List<ConstructorConstraintSyntax>();
            }

            public List<ConstructorConstraintSyntax> Classes { get; set; }

            public override SyntaxNode VisitConstructorConstraint(ConstructorConstraintSyntax node)
            {
                node = (ConstructorConstraintSyntax)base.VisitConstructorConstraint(node);
                Classes.Add(node);
                return node;
            }
        }
    }