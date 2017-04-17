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
        class XmlTextVisitor : CSharpSyntaxRewriter
        {
            public XmlTextVisitor()
            {
                Classes = new List<XmlTextSyntax>();
            }

            public List<XmlTextSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlText(XmlTextSyntax node)
            {
                node = (XmlTextSyntax)base.VisitXmlText(node);
                Classes.Add(node);
                return node;
            }
        }
    }