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
        class CompilationUnitVisitor : CSharpSyntaxRewriter
        {
            public CompilationUnitVisitor()
            {
                Classes = new List<CompilationUnitSyntax>();
            }

            public List<CompilationUnitSyntax> Classes { get; set; }

            public override SyntaxNode VisitCompilationUnit(CompilationUnitSyntax node)
            {
                node = (CompilationUnitSyntax)base.VisitCompilationUnit(node);
                Classes.Add(node);
                return node;
            }
        }
    }