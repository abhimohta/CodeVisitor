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
        class DocumentationCommentTriviaVisitor : CSharpSyntaxRewriter
        {
            public DocumentationCommentTriviaVisitor()
            {
                Classes = new List<DocumentationCommentTriviaSyntax>();
            }

            public List<DocumentationCommentTriviaSyntax> Classes { get; set; }

            public override SyntaxNode VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
            {
                node = (DocumentationCommentTriviaSyntax)base.VisitDocumentationCommentTrivia(node);
                Classes.Add(node);
                return node;
            }
        }
    }