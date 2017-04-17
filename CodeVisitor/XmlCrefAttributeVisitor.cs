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
        class XmlCrefAttributeVisitor : CSharpSyntaxRewriter
        {
            public XmlCrefAttributeVisitor()
            {
                Classes = new List<XmlCrefAttributeSyntax>();
            }

            public List<XmlCrefAttributeSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
            {
                node = (XmlCrefAttributeSyntax)base.VisitXmlCrefAttribute(node);
                Classes.Add(node);
                return node;
            }
        }
    }