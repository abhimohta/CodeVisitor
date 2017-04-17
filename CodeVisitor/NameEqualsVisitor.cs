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
        class NameEqualsVisitor : CSharpSyntaxRewriter
        {
            public NameEqualsVisitor()
            {
                Classes = new List<NameEqualsSyntax>();
            }

            public List<NameEqualsSyntax> Classes { get; set; }

            public override SyntaxNode VisitNameEquals(NameEqualsSyntax node)
            {
                node = (NameEqualsSyntax)base.VisitNameEquals(node);
                Classes.Add(node);
                return node;
            }
        }
    }