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
        class LineDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public LineDirectiveTriviaVisitor()
            {
                Classes = new List<LineDirectiveTriviaSyntax>();
            }

            public List<LineDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)
            {
                node = (LineDirectiveTriviaSyntax)base.VisitLineDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }