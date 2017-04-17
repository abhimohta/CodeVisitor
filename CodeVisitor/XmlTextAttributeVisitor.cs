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
        class XmlTextAttributeVisitor : CSharpSyntaxRewriter
        {
            public XmlTextAttributeVisitor()
            {
                Classes = new List<XmlTextAttributeSyntax>();
            }

            public List<XmlTextAttributeSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlTextAttribute(XmlTextAttributeSyntax node)
            {
                node = (XmlTextAttributeSyntax)base.VisitXmlTextAttribute(node);
                Classes.Add(node);
                return node;
            }
        }
    }