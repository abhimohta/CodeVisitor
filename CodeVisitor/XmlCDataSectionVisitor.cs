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
        class XmlCDataSectionVisitor : CSharpSyntaxRewriter
        {
            public XmlCDataSectionVisitor()
            {
                Classes = new List<XmlCDataSectionSyntax>();
            }

            public List<XmlCDataSectionSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlCDataSection(XmlCDataSectionSyntax node)
            {
                node = (XmlCDataSectionSyntax)base.VisitXmlCDataSection(node);
                Classes.Add(node);
                return node;
            }
        }
    }