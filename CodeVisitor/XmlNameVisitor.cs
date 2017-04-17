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
        class XmlNameVisitor : CSharpSyntaxRewriter
        {
            public XmlNameVisitor()
            {
                Classes = new List<XmlNameSyntax>();
            }

            public List<XmlNameSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlName(XmlNameSyntax node)
            {
                node = (XmlNameSyntax)base.VisitXmlName(node);
                Classes.Add(node);
                return node;
            }
        }
    }