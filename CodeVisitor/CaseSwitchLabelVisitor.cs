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
        class CaseSwitchLabelVisitor : CSharpSyntaxRewriter
        {
            public CaseSwitchLabelVisitor()
            {
                Classes = new List<CaseSwitchLabelSyntax>();
            }

            public List<CaseSwitchLabelSyntax> Classes { get; set; }

            public override SyntaxNode VisitCaseSwitchLabel(CaseSwitchLabelSyntax node)
            {
                node = (CaseSwitchLabelSyntax)base.VisitCaseSwitchLabel(node);
                Classes.Add(node);
                return node;
            }
        }
    }