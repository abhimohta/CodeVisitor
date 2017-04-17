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
        class SwitchSectionVisitor : CSharpSyntaxRewriter
        {
            public SwitchSectionVisitor()
            {
                Classes = new List<SwitchSectionSyntax>();
            }

            public List<SwitchSectionSyntax> Classes { get; set; }

            public override SyntaxNode VisitSwitchSection(SwitchSectionSyntax node)
            {
                node = (SwitchSectionSyntax)base.VisitSwitchSection(node);
                Classes.Add(node);
                return node;
            }
        }
    }