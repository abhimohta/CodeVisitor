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
        class DefaultSwitchLabelVisitor : CSharpSyntaxRewriter
        {
            public DefaultSwitchLabelVisitor()
            {
                Classes = new List<DefaultSwitchLabelSyntax>();
            }

            public List<DefaultSwitchLabelSyntax> Classes { get; set; }

            public override SyntaxNode VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node)
            {
                node = (DefaultSwitchLabelSyntax)base.VisitDefaultSwitchLabel(node);
                Classes.Add(node);
                return node;
            }
        }
    }