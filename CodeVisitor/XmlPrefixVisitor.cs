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
        class XmlPrefixVisitor : CSharpSyntaxRewriter
        {
            public XmlPrefixVisitor()
            {
                Classes = new List<XmlPrefixSyntax>();
            }

            public List<XmlPrefixSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlPrefix(XmlPrefixSyntax node)
            {
                node = (XmlPrefixSyntax)base.VisitXmlPrefix(node);
                Classes.Add(node);
                return node;
            }
        }
    }