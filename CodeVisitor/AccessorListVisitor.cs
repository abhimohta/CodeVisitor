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
        class AccessorListVisitor : CSharpSyntaxRewriter
        {
            public AccessorListVisitor()
            {
                Classes = new List<AccessorListSyntax>();
            }

            public List<AccessorListSyntax> Classes { get; set; }

            public override SyntaxNode VisitAccessorList(AccessorListSyntax node)
            {
                node = (AccessorListSyntax)base.VisitAccessorList(node);
                Classes.Add(node);
                return node;
            }
        }
    }