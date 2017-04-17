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
        class QualifiedNameVisitor : CSharpSyntaxRewriter
        {
            public QualifiedNameVisitor()
            {
                Classes = new List<QualifiedNameSyntax>();
            }

            public List<QualifiedNameSyntax> Classes { get; set; }

            public override SyntaxNode VisitQualifiedName(QualifiedNameSyntax node)
            {
                node = (QualifiedNameSyntax)base.VisitQualifiedName(node);
                Classes.Add(node);
                return node;
            }
        }
    }