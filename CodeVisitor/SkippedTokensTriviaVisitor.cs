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
        class SkippedTokensTriviaVisitor : CSharpSyntaxRewriter
        {
            public SkippedTokensTriviaVisitor()
            {
                Classes = new List<SkippedTokensTriviaSyntax>();
            }

            public List<SkippedTokensTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
            {
                node = (SkippedTokensTriviaSyntax)base.VisitSkippedTokensTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }