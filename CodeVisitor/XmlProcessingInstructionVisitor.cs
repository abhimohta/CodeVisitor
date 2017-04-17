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
        class XmlProcessingInstructionVisitor : CSharpSyntaxRewriter
        {
            public XmlProcessingInstructionVisitor()
            {
                Classes = new List<XmlProcessingInstructionSyntax>();
            }

            public List<XmlProcessingInstructionSyntax> Classes { get; set; }

            public override SyntaxNode VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
            {
                node = (XmlProcessingInstructionSyntax)base.VisitXmlProcessingInstruction(node);
                Classes.Add(node);
                return node;
            }
        }
    }