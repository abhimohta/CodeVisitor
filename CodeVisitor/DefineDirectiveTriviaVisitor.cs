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
        class DefineDirectiveTriviaVisitor : CSharpSyntaxRewriter
        {
            public DefineDirectiveTriviaVisitor()
            {
                Classes = new List<DefineDirectiveTriviaSyntax>();
            }

            public List<DefineDirectiveTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node)
            {
                node = (DefineDirectiveTriviaSyntax)base.VisitDefineDirectiveTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }