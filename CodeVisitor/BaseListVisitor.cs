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
        class BaseListVisitor : CSharpSyntaxRewriter
        {
            public BaseListVisitor()
            {
                Classes = new List<BaseListSyntax>();
            }

            public List<BaseListSyntax> Classes { get; set; }

            public override SyntaxNode VisitBaseList(BaseListSyntax node)
            {
                node = (BaseListSyntax)base.VisitBaseList(node);
                Classes.Add(node);
                return node;
            }
        }
    }