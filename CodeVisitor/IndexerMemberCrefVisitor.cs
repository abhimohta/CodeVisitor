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
        class IndexerMemberCrefVisitor : CSharpSyntaxRewriter
        {
            public IndexerMemberCrefVisitor()
            {
                Classes = new List<IndexerMemberCrefSyntax>();
            }

            public List<IndexerMemberCrefSyntax> Classes { get; set; }

            public override SyntaxNode VisitIndexerMemberCref(IndexerMemberCrefSyntax node)
            {
                node = (IndexerMemberCrefSyntax)base.VisitIndexerMemberCref(node);
                Classes.Add(node);
                return node;
            }
        }
    }