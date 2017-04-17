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
        class TypeConstraintVisitor : CSharpSyntaxRewriter
        {
            public TypeConstraintVisitor()
            {
                Classes = new List<TypeConstraintSyntax>();
            }

            public List<TypeConstraintSyntax> Classes { get; set; }

            public override SyntaxNode VisitTypeConstraint(TypeConstraintSyntax node)
            {
                node = (TypeConstraintSyntax)base.VisitTypeConstraint(node);
                Classes.Add(node);
                return node;
            }
        }
    }