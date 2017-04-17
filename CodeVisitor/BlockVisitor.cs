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
        class BlockVisitor : CSharpSyntaxRewriter
        {
            public BlockVisitor()
            {
                Classes = new List<BlockSyntax>();
            }

            public List<BlockSyntax> Classes { get; set; }

            public override SyntaxNode VisitBlock(BlockSyntax node)
            {
                node = (BlockSyntax)base.VisitBlock(node);
                Classes.Add(node);
                return node;
            }
        }
    }