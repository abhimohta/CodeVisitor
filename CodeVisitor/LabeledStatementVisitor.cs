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
        class LabeledStatementVisitor : CSharpSyntaxRewriter
        {
            public LabeledStatementVisitor()
            {
                Classes = new List<LabeledStatementSyntax>();
            }

            public List<LabeledStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitLabeledStatement(LabeledStatementSyntax node)
            {
                node = (LabeledStatementSyntax)base.VisitLabeledStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }