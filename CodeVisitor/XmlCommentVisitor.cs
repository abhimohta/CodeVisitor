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
        class XmlCommentVisitor : CSharpSyntaxRewriter
        {
            public XmlCommentVisitor()
            {
                Classes = new List<XmlCommentSyntax>();
            }

            public List<XmlCommentSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlComment(XmlCommentSyntax node)
            {
                node = (XmlCommentSyntax)base.VisitXmlComment(node);
                Classes.Add(node);
                return node;
            }
        }
    }