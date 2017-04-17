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
        class ImplicitElementAccessVisitor : CSharpSyntaxRewriter
        {
            public ImplicitElementAccessVisitor()
            {
                Classes = new List<ImplicitElementAccessSyntax>();
            }

            public List<ImplicitElementAccessSyntax> Classes { get; set; }

            public override SyntaxNode VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
            {
                node = (ImplicitElementAccessSyntax)base.VisitImplicitElementAccess(node);
                Classes.Add(node);
                return node;
            }
        }
    }