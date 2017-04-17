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
        class PragmaChecksumDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public PragmaChecksumDirectiveTriviaVisitor()
            {
                Classes = new List<PragmaChecksumDirectiveTriviaSyntax>();
            }

            public List<PragmaChecksumDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)
            {
                node = (PragmaChecksumDirectiveTriviaSyntax)base.VisitPragmaChecksumDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }