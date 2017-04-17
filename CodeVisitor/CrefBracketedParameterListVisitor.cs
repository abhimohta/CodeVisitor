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
        class CrefBracketedParameterListVisitor : CSharpSyntaxRewriter
        {
            public CrefBracketedParameterListVisitor()
            {
                Classes = new List<CrefBracketedParameterListSyntax>();
            }

            public List<CrefBracketedParameterListSyntax> Classes { get; set; }

            public override SyntaxNode VisitCrefBracketedParameterList(CrefBracketedParameterListSyntax node)
            {
                node = (CrefBracketedParameterListSyntax)base.VisitCrefBracketedParameterList(node);
                Classes.Add(node);
                return node;
            }
        }
    }