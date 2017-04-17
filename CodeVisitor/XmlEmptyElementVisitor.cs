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
        class XmlEmptyElementVisitor : CSharpSyntaxRewriter
        {
            public XmlEmptyElementVisitor()
            {
                Classes = new List<XmlEmptyElementSyntax>();
            }

            public List<XmlEmptyElementSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlEmptyElement(XmlEmptyElementSyntax node)
            {
                node = (XmlEmptyElementSyntax)base.VisitXmlEmptyElement(node);
                Classes.Add(node);
                return node;
            }
        }
    }