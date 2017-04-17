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
        class ElifDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public ElifDirectiveTriviaVisitor()
            {
                Classes = new List<ElifDirectiveTriviaSyntax>();
            }

            public List<ElifDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node)
            {
                node = (ElifDirectiveTriviaSyntax)base.VisitElifDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }