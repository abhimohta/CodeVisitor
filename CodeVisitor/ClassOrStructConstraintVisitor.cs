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
        class ClassOrStructConstraintVisitor : CSharpSyntaxRewriter
        {
            public ClassOrStructConstraintVisitor()
            {
                Classes = new List<ClassOrStructConstraintSyntax>();
            }

            public List<ClassOrStructConstraintSyntax> Classes { get; set; }

            public override SyntaxNode VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
            {
                node = (ClassOrStructConstraintSyntax)base.VisitClassOrStructConstraint(node);
                Classes.Add(node);
                return node;
            }
        }
    }