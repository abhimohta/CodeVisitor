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
        class UndefDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public UndefDirectiveTriviaVisitor()
            {
                Classes = new List<UndefDirectiveTriviaSyntax>();
            }

            public List<UndefDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)
            {
                node = (UndefDirectiveTriviaSyntax)base.VisitUndefDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }