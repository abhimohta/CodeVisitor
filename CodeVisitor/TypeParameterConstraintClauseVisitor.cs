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
        class TypeParameterConstraintClauseVisitor : CSharpSyntaxRewriter
        {
            public TypeParameterConstraintClauseVisitor()
            {
                Classes = new List<TypeParameterConstraintClauseSyntax>();
            }

            public List<TypeParameterConstraintClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
            {
                node = (TypeParameterConstraintClauseSyntax)base.VisitTypeParameterConstraintClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }