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
        class XmlElementEndTagVisitor : CSharpSyntaxRewriter
        {
            public XmlElementEndTagVisitor()
            {
                Classes = new List<XmlElementEndTagSyntax>();
            }

            public List<XmlElementEndTagSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlElementEndTag(XmlElementEndTagSyntax node)
            {
                node = (XmlElementEndTagSyntax)base.VisitXmlElementEndTag(node);
                Classes.Add(node);
                return node;
            }
        }
    }