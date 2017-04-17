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
        class XmlElementStartTagVisitor : CSharpSyntaxRewriter
        {
            public XmlElementStartTagVisitor()
            {
                Classes = new List<XmlElementStartTagSyntax>();
            }

            public List<XmlElementStartTagSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlElementStartTag(XmlElementStartTagSyntax node)
            {
                node = (XmlElementStartTagSyntax)base.VisitXmlElementStartTag(node);
                Classes.Add(node);
                return node;
            }
        }
    }