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
        class QualifiedCrefVisitor : CSharpSyntaxRewriter
        {
            public QualifiedCrefVisitor()
            {
                Classes = new List<QualifiedCrefSyntax>();
            }

            public List<QualifiedCrefSyntax> Classes { get; set; }

            public override SyntaxNode VisitQualifiedCref(QualifiedCrefSyntax node)
            {
                node = (QualifiedCrefSyntax)base.VisitQualifiedCref(node);
                Classes.Add(node);
                return node;
            }
        }
    }