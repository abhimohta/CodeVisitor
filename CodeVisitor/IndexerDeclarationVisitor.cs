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
        class IndexerDeclarationVisitor : CSharpSyntaxRewriter
        {
            public IndexerDeclarationVisitor()
            {
                Classes = new List<IndexerDeclarationSyntax>();
            }

            public List<IndexerDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitIndexerDeclaration(IndexerDeclarationSyntax node)
            {
                node = (IndexerDeclarationSyntax)base.VisitIndexerDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }