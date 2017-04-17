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
        class OmittedTypeArgumentVisitor : CSharpSyntaxRewriter
        {
            public OmittedTypeArgumentVisitor()
            {
                Classes = new List<OmittedTypeArgumentSyntax>();
            }

            public List<OmittedTypeArgumentSyntax> Classes { get; set; }

            public override SyntaxNode VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
            {
                node = (OmittedTypeArgumentSyntax)base.VisitOmittedTypeArgument(node);
                Classes.Add(node);
                return node;
            }
        }
    }