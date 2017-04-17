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
        class XmlElementVisitor : CSharpSyntaxRewriter
        {
            public XmlElementVisitor()
            {
                Classes = new List<XmlElementSyntax>();
            }

            public List<XmlElementSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlElement(XmlElementSyntax node)
            {
                node = (XmlElementSyntax)base.VisitXmlElement(node);
                Classes.Add(node);
                return node;
            }
        }
    }