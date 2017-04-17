using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace CodeVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileContents = System.IO.File.ReadAllText(args[0]);
            string outputString = String.Empty;
            Dictionary<string, int> outputDictionary = getSummaryOfClass(inputFileContents);
            var orderedDictionary = outputDictionary.OrderByDescending(x => x.Value);
            foreach (var dictionaryElement in orderedDictionary)
            {
                outputString += "\n" + (dictionaryElement.ToString());
            }

            outputString += "\nThrow statement details: \n";
            List<ThrowStatementSyntax> throwStatementsDetails = getThrowStatementDetails(inputFileContents);
            foreach(ThrowStatementSyntax throwStatementDetails in throwStatementsDetails)
            {
                outputString += (throwStatementDetails.Expression + "\n");
            }
            System.IO.File.WriteAllText(args[1], outputString);

        }

        public static List<ThrowStatementSyntax> getThrowStatementDetails(string inputFileContents)
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(inputFileContents);
            var root = (CompilationUnitSyntax)tree.GetRoot();
            var ThrowStatementVisitorCollector = new ThrowStatementVisitor();
            ThrowStatementVisitorCollector.Visit(root);
            List<ThrowStatementSyntax> list = ThrowStatementVisitorCollector.Classes;
            return list;
        }

        public static Dictionary<string, int> getSummaryOfClass(string inputFileContents)
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(inputFileContents);
            var root = (CompilationUnitSyntax)tree.GetRoot();
            Dictionary<string, int> output = getCountSummaryOfClass(root);
            return output;
        }

        public static Dictionary<string, int> getCountSummaryOfClass(CompilationUnitSyntax root)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            // AccessorDeclarationVisitorCollector
            var AccessorDeclarationVisitorCollector = new AccessorDeclarationVisitor();
            AccessorDeclarationVisitorCollector.Visit(root);
            map["AccessorDeclaration"] = AccessorDeclarationVisitorCollector.Classes.Count;

            // AccessorListVisitorCollector
            var AccessorListVisitorCollector = new AccessorListVisitor();
            AccessorListVisitorCollector.Visit(root);
            map["AccessorList"] = AccessorListVisitorCollector.Classes.Count;

            // AliasQualifiedNameVisitorCollector
            var AliasQualifiedNameVisitorCollector = new AliasQualifiedNameVisitor();
            AliasQualifiedNameVisitorCollector.Visit(root);
            map["AliasQualifiedName"] = AliasQualifiedNameVisitorCollector.Classes.Count;

            // AnonymousMethodExpressionVisitorCollector
            var AnonymousMethodExpressionVisitorCollector = new AnonymousMethodExpressionVisitor();
            AnonymousMethodExpressionVisitorCollector.Visit(root);
            map["AnonymousMethodExpression"] = AnonymousMethodExpressionVisitorCollector.Classes.Count;

            // AnonymousObjectCreationExpressionVisitorCollector
            var AnonymousObjectCreationExpressionVisitorCollector = new AnonymousObjectCreationExpressionVisitor();
            AnonymousObjectCreationExpressionVisitorCollector.Visit(root);
            map["AnonymousObjectCreationExpression"] = AnonymousObjectCreationExpressionVisitorCollector.Classes.Count;

            // AnonymousObjectMemberDeclaratorVisitorCollector
            var AnonymousObjectMemberDeclaratorVisitorCollector = new AnonymousObjectMemberDeclaratorVisitor();
            AnonymousObjectMemberDeclaratorVisitorCollector.Visit(root);
            map["AnonymousObjectMemberDeclarator"] = AnonymousObjectMemberDeclaratorVisitorCollector.Classes.Count;

            // ArgumentVisitorCollector
            var ArgumentVisitorCollector = new ArgumentVisitor();
            ArgumentVisitorCollector.Visit(root);
            map["Argument"] = ArgumentVisitorCollector.Classes.Count;

            // ArgumentListVisitorCollector
            var ArgumentListVisitorCollector = new ArgumentListVisitor();
            ArgumentListVisitorCollector.Visit(root);
            map["ArgumentList"] = ArgumentListVisitorCollector.Classes.Count;

            // ArrayCreationExpressionVisitorCollector
            var ArrayCreationExpressionVisitorCollector = new ArrayCreationExpressionVisitor();
            ArrayCreationExpressionVisitorCollector.Visit(root);
            map["ArrayCreationExpression"] = ArrayCreationExpressionVisitorCollector.Classes.Count;

            // ArrayRankSpecifierVisitorCollector
            var ArrayRankSpecifierVisitorCollector = new ArrayRankSpecifierVisitor();
            ArrayRankSpecifierVisitorCollector.Visit(root);
            map["ArrayRankSpecifier"] = ArrayRankSpecifierVisitorCollector.Classes.Count;

            // ArrayTypeVisitorCollector
            var ArrayTypeVisitorCollector = new ArrayTypeVisitor();
            ArrayTypeVisitorCollector.Visit(root);
            map["ArrayType"] = ArrayTypeVisitorCollector.Classes.Count;

            // ArrowExpressionClauseVisitorCollector
            var ArrowExpressionClauseVisitorCollector = new ArrowExpressionClauseVisitor();
            ArrowExpressionClauseVisitorCollector.Visit(root);
            map["ArrowExpressionClause"] = ArrowExpressionClauseVisitorCollector.Classes.Count;

            // AssignmentExpressionVisitorCollector
            var AssignmentExpressionVisitorCollector = new AssignmentExpressionVisitor();
            AssignmentExpressionVisitorCollector.Visit(root);
            map["AssignmentExpression"] = AssignmentExpressionVisitorCollector.Classes.Count;

            // AttributeVisitorCollector
            var AttributeVisitorCollector = new AttributeVisitor();
            AttributeVisitorCollector.Visit(root);
            map["Attribute"] = AttributeVisitorCollector.Classes.Count;

            // AttributeArgumentVisitorCollector
            var AttributeArgumentVisitorCollector = new AttributeArgumentVisitor();
            AttributeArgumentVisitorCollector.Visit(root);
            map["AttributeArgument"] = AttributeArgumentVisitorCollector.Classes.Count;

            // AttributeArgumentListVisitorCollector
            var AttributeArgumentListVisitorCollector = new AttributeArgumentListVisitor();
            AttributeArgumentListVisitorCollector.Visit(root);
            map["AttributeArgumentList"] = AttributeArgumentListVisitorCollector.Classes.Count;

            // AttributeListVisitorCollector
            var AttributeListVisitorCollector = new AttributeListVisitor();
            AttributeListVisitorCollector.Visit(root);
            map["AttributeList"] = AttributeListVisitorCollector.Classes.Count;

            // AttributeTargetSpecifierVisitorCollector
            var AttributeTargetSpecifierVisitorCollector = new AttributeTargetSpecifierVisitor();
            AttributeTargetSpecifierVisitorCollector.Visit(root);
            map["AttributeTargetSpecifier"] = AttributeTargetSpecifierVisitorCollector.Classes.Count;

            // AwaitExpressionVisitorCollector
            var AwaitExpressionVisitorCollector = new AwaitExpressionVisitor();
            AwaitExpressionVisitorCollector.Visit(root);
            map["AwaitExpression"] = AwaitExpressionVisitorCollector.Classes.Count;

            // BadDirectiveTriviaVisitorCollector
            var BadDirectiveTriviaVisitorCollector = new BadDirectiveTriviaVisitor();
            BadDirectiveTriviaVisitorCollector.Visit(root);
            map["BadDirectiveTrivia"] = BadDirectiveTriviaVisitorCollector.Classes.Count;

            // BaseExpressionVisitorCollector
            var BaseExpressionVisitorCollector = new BaseExpressionVisitor();
            BaseExpressionVisitorCollector.Visit(root);
            map["BaseExpression"] = BaseExpressionVisitorCollector.Classes.Count;

            // BaseListVisitorCollector
            var BaseListVisitorCollector = new BaseListVisitor();
            BaseListVisitorCollector.Visit(root);
            map["BaseList"] = BaseListVisitorCollector.Classes.Count;

            // BinaryExpressionVisitorCollector
            var BinaryExpressionVisitorCollector = new BinaryExpressionVisitor();
            BinaryExpressionVisitorCollector.Visit(root);
            map["BinaryExpression"] = BinaryExpressionVisitorCollector.Classes.Count;

            // BlockVisitorCollector
            var BlockVisitorCollector = new BlockVisitor();
            BlockVisitorCollector.Visit(root);
            map["Block"] = BlockVisitorCollector.Classes.Count;

            // BracketedArgumentListVisitorCollector
            var BracketedArgumentListVisitorCollector = new BracketedArgumentListVisitor();
            BracketedArgumentListVisitorCollector.Visit(root);
            map["BracketedArgumentList"] = BracketedArgumentListVisitorCollector.Classes.Count;

            // BracketedParameterListVisitorCollector
            var BracketedParameterListVisitorCollector = new BracketedParameterListVisitor();
            BracketedParameterListVisitorCollector.Visit(root);
            map["BracketedParameterList"] = BracketedParameterListVisitorCollector.Classes.Count;

            // BreakStatementVisitorCollector
            var BreakStatementVisitorCollector = new BreakStatementVisitor();
            BreakStatementVisitorCollector.Visit(root);
            map["BreakStatement"] = BreakStatementVisitorCollector.Classes.Count;

            // CaseSwitchLabelVisitorCollector
            var CaseSwitchLabelVisitorCollector = new CaseSwitchLabelVisitor();
            CaseSwitchLabelVisitorCollector.Visit(root);
            map["CaseSwitchLabel"] = CaseSwitchLabelVisitorCollector.Classes.Count;

            // CastExpressionVisitorCollector
            var CastExpressionVisitorCollector = new CastExpressionVisitor();
            CastExpressionVisitorCollector.Visit(root);
            map["CastExpression"] = CastExpressionVisitorCollector.Classes.Count;

            // CatchClauseVisitorCollector
            var CatchClauseVisitorCollector = new CatchClauseVisitor();
            CatchClauseVisitorCollector.Visit(root);
            map["CatchClause"] = CatchClauseVisitorCollector.Classes.Count;

            // CatchDeclarationVisitorCollector
            var CatchDeclarationVisitorCollector = new CatchDeclarationVisitor();
            CatchDeclarationVisitorCollector.Visit(root);
            map["CatchDeclaration"] = CatchDeclarationVisitorCollector.Classes.Count;

            // CatchFilterClauseVisitorCollector
            var CatchFilterClauseVisitorCollector = new CatchFilterClauseVisitor();
            CatchFilterClauseVisitorCollector.Visit(root);
            map["CatchFilterClause"] = CatchFilterClauseVisitorCollector.Classes.Count;

            // CheckedExpressionVisitorCollector
            var CheckedExpressionVisitorCollector = new CheckedExpressionVisitor();
            CheckedExpressionVisitorCollector.Visit(root);
            map["CheckedExpression"] = CheckedExpressionVisitorCollector.Classes.Count;

            // CheckedStatementVisitorCollector
            var CheckedStatementVisitorCollector = new CheckedStatementVisitor();
            CheckedStatementVisitorCollector.Visit(root);
            map["CheckedStatement"] = CheckedStatementVisitorCollector.Classes.Count;

            // ClassDeclarationVisitorCollector
            var ClassDeclarationVisitorCollector = new ClassDeclarationVisitor();
            ClassDeclarationVisitorCollector.Visit(root);
            map["ClassDeclaration"] = ClassDeclarationVisitorCollector.Classes.Count;

            // ClassOrStructConstraintVisitorCollector
            var ClassOrStructConstraintVisitorCollector = new ClassOrStructConstraintVisitor();
            ClassOrStructConstraintVisitorCollector.Visit(root);
            map["ClassOrStructConstraint"] = ClassOrStructConstraintVisitorCollector.Classes.Count;

            // CompilationUnitVisitorCollector
            var CompilationUnitVisitorCollector = new CompilationUnitVisitor();
            CompilationUnitVisitorCollector.Visit(root);
            map["CompilationUnit"] = CompilationUnitVisitorCollector.Classes.Count;

            // ConditionalAccessExpressionVisitorCollector
            var ConditionalAccessExpressionVisitorCollector = new ConditionalAccessExpressionVisitor();
            ConditionalAccessExpressionVisitorCollector.Visit(root);
            map["ConditionalAccessExpression"] = ConditionalAccessExpressionVisitorCollector.Classes.Count;

            // ConditionalExpressionVisitorCollector
            var ConditionalExpressionVisitorCollector = new ConditionalExpressionVisitor();
            ConditionalExpressionVisitorCollector.Visit(root);
            map["ConditionalExpression"] = ConditionalExpressionVisitorCollector.Classes.Count;

            // ConstructorConstraintVisitorCollector
            var ConstructorConstraintVisitorCollector = new ConstructorConstraintVisitor();
            ConstructorConstraintVisitorCollector.Visit(root);
            map["ConstructorConstraint"] = ConstructorConstraintVisitorCollector.Classes.Count;

            // ConstructorDeclarationVisitorCollector
            var ConstructorDeclarationVisitorCollector = new ConstructorDeclarationVisitor();
            ConstructorDeclarationVisitorCollector.Visit(root);
            map["ConstructorDeclaration"] = ConstructorDeclarationVisitorCollector.Classes.Count;

            // ConstructorInitializerVisitorCollector
            var ConstructorInitializerVisitorCollector = new ConstructorInitializerVisitor();
            ConstructorInitializerVisitorCollector.Visit(root);
            map["ConstructorInitializer"] = ConstructorInitializerVisitorCollector.Classes.Count;

            // ContinueStatementVisitorCollector
            var ContinueStatementVisitorCollector = new ContinueStatementVisitor();
            ContinueStatementVisitorCollector.Visit(root);
            map["ContinueStatement"] = ContinueStatementVisitorCollector.Classes.Count;

            // ConversionOperatorDeclarationVisitorCollector
            var ConversionOperatorDeclarationVisitorCollector = new ConversionOperatorDeclarationVisitor();
            ConversionOperatorDeclarationVisitorCollector.Visit(root);
            map["ConversionOperatorDeclaration"] = ConversionOperatorDeclarationVisitorCollector.Classes.Count;

            // ConversionOperatorMemberCrefVisitorCollector
            var ConversionOperatorMemberCrefVisitorCollector = new ConversionOperatorMemberCrefVisitor();
            ConversionOperatorMemberCrefVisitorCollector.Visit(root);
            map["ConversionOperatorMemberCref"] = ConversionOperatorMemberCrefVisitorCollector.Classes.Count;

            // CrefBracketedParameterListVisitorCollector
            var CrefBracketedParameterListVisitorCollector = new CrefBracketedParameterListVisitor();
            CrefBracketedParameterListVisitorCollector.Visit(root);
            map["CrefBracketedParameterList"] = CrefBracketedParameterListVisitorCollector.Classes.Count;

            // CrefParameterVisitorCollector
            var CrefParameterVisitorCollector = new CrefParameterVisitor();
            CrefParameterVisitorCollector.Visit(root);
            map["CrefParameter"] = CrefParameterVisitorCollector.Classes.Count;

            // CrefParameterListVisitorCollector
            var CrefParameterListVisitorCollector = new CrefParameterListVisitor();
            CrefParameterListVisitorCollector.Visit(root);
            map["CrefParameterList"] = CrefParameterListVisitorCollector.Classes.Count;

            // DefaultExpressionVisitorCollector
            var DefaultExpressionVisitorCollector = new DefaultExpressionVisitor();
            DefaultExpressionVisitorCollector.Visit(root);
            map["DefaultExpression"] = DefaultExpressionVisitorCollector.Classes.Count;

            // DefaultSwitchLabelVisitorCollector
            var DefaultSwitchLabelVisitorCollector = new DefaultSwitchLabelVisitor();
            DefaultSwitchLabelVisitorCollector.Visit(root);
            map["DefaultSwitchLabel"] = DefaultSwitchLabelVisitorCollector.Classes.Count;

            // DefineDirectiveTriviaVisitorCollector
            var DefineDirectiveTriviaVisitorCollector = new DefineDirectiveTriviaVisitor();
            DefineDirectiveTriviaVisitorCollector.Visit(root);
            map["DefineDirectiveTrivia"] = DefineDirectiveTriviaVisitorCollector.Classes.Count;

            // DelegateDeclarationVisitorCollector
            var DelegateDeclarationVisitorCollector = new DelegateDeclarationVisitor();
            DelegateDeclarationVisitorCollector.Visit(root);
            map["DelegateDeclaration"] = DelegateDeclarationVisitorCollector.Classes.Count;

            // DestructorDeclarationVisitorCollector
            var DestructorDeclarationVisitorCollector = new DestructorDeclarationVisitor();
            DestructorDeclarationVisitorCollector.Visit(root);
            map["DestructorDeclaration"] = DestructorDeclarationVisitorCollector.Classes.Count;

            // DocumentationCommentTriviaVisitorCollector
            var DocumentationCommentTriviaVisitorCollector = new DocumentationCommentTriviaVisitor();
            DocumentationCommentTriviaVisitorCollector.Visit(root);
            map["DocumentationCommentTrivia"] = DocumentationCommentTriviaVisitorCollector.Classes.Count;

            // DoStatementVisitorCollector
            var DoStatementVisitorCollector = new DoStatementVisitor();
            DoStatementVisitorCollector.Visit(root);
            map["DoStatement"] = DoStatementVisitorCollector.Classes.Count;

            // ElementAccessExpressionVisitorCollector
            var ElementAccessExpressionVisitorCollector = new ElementAccessExpressionVisitor();
            ElementAccessExpressionVisitorCollector.Visit(root);
            map["ElementAccessExpression"] = ElementAccessExpressionVisitorCollector.Classes.Count;

            // ElementBindingExpressionVisitorCollector
            var ElementBindingExpressionVisitorCollector = new ElementBindingExpressionVisitor();
            ElementBindingExpressionVisitorCollector.Visit(root);
            map["ElementBindingExpression"] = ElementBindingExpressionVisitorCollector.Classes.Count;

            // ElifDirectiveTriviaVisitorCollector
            var ElifDirectiveTriviaVisitorCollector = new ElifDirectiveTriviaVisitor();
            ElifDirectiveTriviaVisitorCollector.Visit(root);
            map["ElifDirectiveTrivia"] = ElifDirectiveTriviaVisitorCollector.Classes.Count;

            // ElseClauseVisitorCollector
            var ElseClauseVisitorCollector = new ElseClauseVisitor();
            ElseClauseVisitorCollector.Visit(root);
            map["ElseClause"] = ElseClauseVisitorCollector.Classes.Count;

            // ElseDirectiveTriviaVisitorCollector
            var ElseDirectiveTriviaVisitorCollector = new ElseDirectiveTriviaVisitor();
            ElseDirectiveTriviaVisitorCollector.Visit(root);
            map["ElseDirectiveTrivia"] = ElseDirectiveTriviaVisitorCollector.Classes.Count;

            // EmptyStatementVisitorCollector
            var EmptyStatementVisitorCollector = new EmptyStatementVisitor();
            EmptyStatementVisitorCollector.Visit(root);
            map["EmptyStatement"] = EmptyStatementVisitorCollector.Classes.Count;

            // EndIfDirectiveTriviaVisitorCollector
            var EndIfDirectiveTriviaVisitorCollector = new EndIfDirectiveTriviaVisitor();
            EndIfDirectiveTriviaVisitorCollector.Visit(root);
            map["EndIfDirectiveTrivia"] = EndIfDirectiveTriviaVisitorCollector.Classes.Count;

            // EndRegionDirectiveTriviaVisitorCollector
            var EndRegionDirectiveTriviaVisitorCollector = new EndRegionDirectiveTriviaVisitor();
            EndRegionDirectiveTriviaVisitorCollector.Visit(root);
            map["EndRegionDirectiveTrivia"] = EndRegionDirectiveTriviaVisitorCollector.Classes.Count;

            // EnumDeclarationVisitorCollector
            var EnumDeclarationVisitorCollector = new EnumDeclarationVisitor();
            EnumDeclarationVisitorCollector.Visit(root);
            map["EnumDeclaration"] = EnumDeclarationVisitorCollector.Classes.Count;

            // EnumMemberDeclarationVisitorCollector
            var EnumMemberDeclarationVisitorCollector = new EnumMemberDeclarationVisitor();
            EnumMemberDeclarationVisitorCollector.Visit(root);
            map["EnumMemberDeclaration"] = EnumMemberDeclarationVisitorCollector.Classes.Count;

            // EqualsValueClauseVisitorCollector
            var EqualsValueClauseVisitorCollector = new EqualsValueClauseVisitor();
            EqualsValueClauseVisitorCollector.Visit(root);
            map["EqualsValueClause"] = EqualsValueClauseVisitorCollector.Classes.Count;

            // ErrorDirectiveTriviaVisitorCollector
            var ErrorDirectiveTriviaVisitorCollector = new ErrorDirectiveTriviaVisitor();
            ErrorDirectiveTriviaVisitorCollector.Visit(root);
            map["ErrorDirectiveTrivia"] = ErrorDirectiveTriviaVisitorCollector.Classes.Count;

            // EventDeclarationVisitorCollector
            var EventDeclarationVisitorCollector = new EventDeclarationVisitor();
            EventDeclarationVisitorCollector.Visit(root);
            map["EventDeclaration"] = EventDeclarationVisitorCollector.Classes.Count;

            // EventFieldDeclarationVisitorCollector
            var EventFieldDeclarationVisitorCollector = new EventFieldDeclarationVisitor();
            EventFieldDeclarationVisitorCollector.Visit(root);
            map["EventFieldDeclaration"] = EventFieldDeclarationVisitorCollector.Classes.Count;

            // ExplicitInterfaceSpecifierVisitorCollector
            var ExplicitInterfaceSpecifierVisitorCollector = new ExplicitInterfaceSpecifierVisitor();
            ExplicitInterfaceSpecifierVisitorCollector.Visit(root);
            map["ExplicitInterfaceSpecifier"] = ExplicitInterfaceSpecifierVisitorCollector.Classes.Count;

            // ExpressionStatementVisitorCollector
            var ExpressionStatementVisitorCollector = new ExpressionStatementVisitor();
            ExpressionStatementVisitorCollector.Visit(root);
            map["ExpressionStatement"] = ExpressionStatementVisitorCollector.Classes.Count;

            // ExternAliasDirectiveVisitorCollector
            var ExternAliasDirectiveVisitorCollector = new ExternAliasDirectiveVisitor();
            ExternAliasDirectiveVisitorCollector.Visit(root);
            map["ExternAliasDirective"] = ExternAliasDirectiveVisitorCollector.Classes.Count;

            // FieldDeclarationVisitorCollector
            var FieldDeclarationVisitorCollector = new FieldDeclarationVisitor();
            FieldDeclarationVisitorCollector.Visit(root);
            map["FieldDeclaration"] = FieldDeclarationVisitorCollector.Classes.Count;

            // FinallyClauseVisitorCollector
            var FinallyClauseVisitorCollector = new FinallyClauseVisitor();
            FinallyClauseVisitorCollector.Visit(root);
            map["FinallyClause"] = FinallyClauseVisitorCollector.Classes.Count;

            // FixedStatementVisitorCollector
            var FixedStatementVisitorCollector = new FixedStatementVisitor();
            FixedStatementVisitorCollector.Visit(root);
            map["FixedStatement"] = FixedStatementVisitorCollector.Classes.Count;

            // ForEachStatementVisitorCollector
            var ForEachStatementVisitorCollector = new ForEachStatementVisitor();
            ForEachStatementVisitorCollector.Visit(root);
            map["ForEachStatement"] = ForEachStatementVisitorCollector.Classes.Count;

            // ForStatementVisitorCollector
            var ForStatementVisitorCollector = new ForStatementVisitor();
            ForStatementVisitorCollector.Visit(root);
            map["ForStatement"] = ForStatementVisitorCollector.Classes.Count;

            // FromClauseVisitorCollector
            var FromClauseVisitorCollector = new FromClauseVisitor();
            FromClauseVisitorCollector.Visit(root);
            map["FromClause"] = FromClauseVisitorCollector.Classes.Count;

            // GenericNameVisitorCollector
            var GenericNameVisitorCollector = new GenericNameVisitor();
            GenericNameVisitorCollector.Visit(root);
            map["GenericName"] = GenericNameVisitorCollector.Classes.Count;

            // GlobalStatementVisitorCollector
            var GlobalStatementVisitorCollector = new GlobalStatementVisitor();
            GlobalStatementVisitorCollector.Visit(root);
            map["GlobalStatement"] = GlobalStatementVisitorCollector.Classes.Count;

            // GotoStatementVisitorCollector
            var GotoStatementVisitorCollector = new GotoStatementVisitor();
            GotoStatementVisitorCollector.Visit(root);
            map["GotoStatement"] = GotoStatementVisitorCollector.Classes.Count;

            // GroupClauseVisitorCollector
            var GroupClauseVisitorCollector = new GroupClauseVisitor();
            GroupClauseVisitorCollector.Visit(root);
            map["GroupClause"] = GroupClauseVisitorCollector.Classes.Count;

            // IdentifierNameVisitorCollector
            var IdentifierNameVisitorCollector = new IdentifierNameVisitor();
            IdentifierNameVisitorCollector.Visit(root);
            map["IdentifierName"] = IdentifierNameVisitorCollector.Classes.Count;

            // IfDirectiveTriviaVisitorCollector
            var IfDirectiveTriviaVisitorCollector = new IfDirectiveTriviaVisitor();
            IfDirectiveTriviaVisitorCollector.Visit(root);
            map["IfDirectiveTrivia"] = IfDirectiveTriviaVisitorCollector.Classes.Count;

            // IfStatementVisitorCollector
            var IfStatementVisitorCollector = new IfStatementVisitor();
            IfStatementVisitorCollector.Visit(root);
            map["IfStatement"] = IfStatementVisitorCollector.Classes.Count;

            // ImplicitArrayCreationExpressionVisitorCollector
            var ImplicitArrayCreationExpressionVisitorCollector = new ImplicitArrayCreationExpressionVisitor();
            ImplicitArrayCreationExpressionVisitorCollector.Visit(root);
            map["ImplicitArrayCreationExpression"] = ImplicitArrayCreationExpressionVisitorCollector.Classes.Count;

            // ImplicitElementAccessVisitorCollector
            var ImplicitElementAccessVisitorCollector = new ImplicitElementAccessVisitor();
            ImplicitElementAccessVisitorCollector.Visit(root);
            map["ImplicitElementAccess"] = ImplicitElementAccessVisitorCollector.Classes.Count;

            // IncompleteMemberVisitorCollector
            var IncompleteMemberVisitorCollector = new IncompleteMemberVisitor();
            IncompleteMemberVisitorCollector.Visit(root);
            map["IncompleteMember"] = IncompleteMemberVisitorCollector.Classes.Count;

            // IndexerDeclarationVisitorCollector
            var IndexerDeclarationVisitorCollector = new IndexerDeclarationVisitor();
            IndexerDeclarationVisitorCollector.Visit(root);
            map["IndexerDeclaration"] = IndexerDeclarationVisitorCollector.Classes.Count;

            // IndexerMemberCrefVisitorCollector
            var IndexerMemberCrefVisitorCollector = new IndexerMemberCrefVisitor();
            IndexerMemberCrefVisitorCollector.Visit(root);
            map["IndexerMemberCref"] = IndexerMemberCrefVisitorCollector.Classes.Count;

            // InitializerExpressionVisitorCollector
            var InitializerExpressionVisitorCollector = new InitializerExpressionVisitor();
            InitializerExpressionVisitorCollector.Visit(root);
            map["InitializerExpression"] = InitializerExpressionVisitorCollector.Classes.Count;

            // InterfaceDeclarationVisitorCollector
            var InterfaceDeclarationVisitorCollector = new InterfaceDeclarationVisitor();
            InterfaceDeclarationVisitorCollector.Visit(root);
            map["InterfaceDeclaration"] = InterfaceDeclarationVisitorCollector.Classes.Count;

            // InterpolatedStringExpressionVisitorCollector
            var InterpolatedStringExpressionVisitorCollector = new InterpolatedStringExpressionVisitor();
            InterpolatedStringExpressionVisitorCollector.Visit(root);
            map["InterpolatedStringExpression"] = InterpolatedStringExpressionVisitorCollector.Classes.Count;

            // InterpolatedStringTextVisitorCollector
            var InterpolatedStringTextVisitorCollector = new InterpolatedStringTextVisitor();
            InterpolatedStringTextVisitorCollector.Visit(root);
            map["InterpolatedStringText"] = InterpolatedStringTextVisitorCollector.Classes.Count;

            // InterpolationVisitorCollector
            var InterpolationVisitorCollector = new InterpolationVisitor();
            InterpolationVisitorCollector.Visit(root);
            map["Interpolation"] = InterpolationVisitorCollector.Classes.Count;

            // InterpolationAlignmentClauseVisitorCollector
            var InterpolationAlignmentClauseVisitorCollector = new InterpolationAlignmentClauseVisitor();
            InterpolationAlignmentClauseVisitorCollector.Visit(root);
            map["InterpolationAlignmentClause"] = InterpolationAlignmentClauseVisitorCollector.Classes.Count;

            // InterpolationFormatClauseVisitorCollector
            var InterpolationFormatClauseVisitorCollector = new InterpolationFormatClauseVisitor();
            InterpolationFormatClauseVisitorCollector.Visit(root);
            map["InterpolationFormatClause"] = InterpolationFormatClauseVisitorCollector.Classes.Count;

            // InvocationExpressionVisitorCollector
            var InvocationExpressionVisitorCollector = new InvocationExpressionVisitor();
            InvocationExpressionVisitorCollector.Visit(root);
            map["InvocationExpression"] = InvocationExpressionVisitorCollector.Classes.Count;

            // JoinClauseVisitorCollector
            var JoinClauseVisitorCollector = new JoinClauseVisitor();
            JoinClauseVisitorCollector.Visit(root);
            map["JoinClause"] = JoinClauseVisitorCollector.Classes.Count;

            // JoinIntoClauseVisitorCollector
            var JoinIntoClauseVisitorCollector = new JoinIntoClauseVisitor();
            JoinIntoClauseVisitorCollector.Visit(root);
            map["JoinIntoClause"] = JoinIntoClauseVisitorCollector.Classes.Count;

            // LabeledStatementVisitorCollector
            var LabeledStatementVisitorCollector = new LabeledStatementVisitor();
            LabeledStatementVisitorCollector.Visit(root);
            map["LabeledStatement"] = LabeledStatementVisitorCollector.Classes.Count;

            // LetClauseVisitorCollector
            var LetClauseVisitorCollector = new LetClauseVisitor();
            LetClauseVisitorCollector.Visit(root);
            map["LetClause"] = LetClauseVisitorCollector.Classes.Count;

            // LineDirectiveTriviaVisitorCollector
            var LineDirectiveTriviaVisitorCollector = new LineDirectiveTriviaVisitor();
            LineDirectiveTriviaVisitorCollector.Visit(root);
            map["LineDirectiveTrivia"] = LineDirectiveTriviaVisitorCollector.Classes.Count;

            // LiteralExpressionVisitorCollector
            var LiteralExpressionVisitorCollector = new LiteralExpressionVisitor();
            LiteralExpressionVisitorCollector.Visit(root);
            map["LiteralExpression"] = LiteralExpressionVisitorCollector.Classes.Count;

            // LocalDeclarationStatementVisitorCollector
            var LocalDeclarationStatementVisitorCollector = new LocalDeclarationStatementVisitor();
            LocalDeclarationStatementVisitorCollector.Visit(root);
            map["LocalDeclarationStatement"] = LocalDeclarationStatementVisitorCollector.Classes.Count;

            // LockStatementVisitorCollector
            var LockStatementVisitorCollector = new LockStatementVisitor();
            LockStatementVisitorCollector.Visit(root);
            map["LockStatement"] = LockStatementVisitorCollector.Classes.Count;

            // MakeRefExpressionVisitorCollector
            var MakeRefExpressionVisitorCollector = new MakeRefExpressionVisitor();
            MakeRefExpressionVisitorCollector.Visit(root);
            map["MakeRefExpression"] = MakeRefExpressionVisitorCollector.Classes.Count;

            // MemberAccessExpressionVisitorCollector
            var MemberAccessExpressionVisitorCollector = new MemberAccessExpressionVisitor();
            MemberAccessExpressionVisitorCollector.Visit(root);
            map["MemberAccessExpression"] = MemberAccessExpressionVisitorCollector.Classes.Count;

            // MemberBindingExpressionVisitorCollector
            var MemberBindingExpressionVisitorCollector = new MemberBindingExpressionVisitor();
            MemberBindingExpressionVisitorCollector.Visit(root);
            map["MemberBindingExpression"] = MemberBindingExpressionVisitorCollector.Classes.Count;

            // MethodDeclarationVisitorCollector
            var MethodDeclarationVisitorCollector = new MethodDeclarationVisitor();
            MethodDeclarationVisitorCollector.Visit(root);
            map["MethodDeclaration"] = MethodDeclarationVisitorCollector.Classes.Count;

            // NameColonVisitorCollector
            var NameColonVisitorCollector = new NameColonVisitor();
            NameColonVisitorCollector.Visit(root);
            map["NameColon"] = NameColonVisitorCollector.Classes.Count;

            // NameEqualsVisitorCollector
            var NameEqualsVisitorCollector = new NameEqualsVisitor();
            NameEqualsVisitorCollector.Visit(root);
            map["NameEquals"] = NameEqualsVisitorCollector.Classes.Count;

            // NameMemberCrefVisitorCollector
            var NameMemberCrefVisitorCollector = new NameMemberCrefVisitor();
            NameMemberCrefVisitorCollector.Visit(root);
            map["NameMemberCref"] = NameMemberCrefVisitorCollector.Classes.Count;

            // NamespaceDeclarationVisitorCollector
            var NamespaceDeclarationVisitorCollector = new NamespaceDeclarationVisitor();
            NamespaceDeclarationVisitorCollector.Visit(root);
            map["NamespaceDeclaration"] = NamespaceDeclarationVisitorCollector.Classes.Count;

            // NullableTypeVisitorCollector
            var NullableTypeVisitorCollector = new NullableTypeVisitor();
            NullableTypeVisitorCollector.Visit(root);
            map["NullableType"] = NullableTypeVisitorCollector.Classes.Count;

            // ObjectCreationExpressionVisitorCollector
            var ObjectCreationExpressionVisitorCollector = new ObjectCreationExpressionVisitor();
            ObjectCreationExpressionVisitorCollector.Visit(root);
            map["ObjectCreationExpression"] = ObjectCreationExpressionVisitorCollector.Classes.Count;

            // OmittedArraySizeExpressionVisitorCollector
            var OmittedArraySizeExpressionVisitorCollector = new OmittedArraySizeExpressionVisitor();
            OmittedArraySizeExpressionVisitorCollector.Visit(root);
            map["OmittedArraySizeExpression"] = OmittedArraySizeExpressionVisitorCollector.Classes.Count;

            // OmittedTypeArgumentVisitorCollector
            var OmittedTypeArgumentVisitorCollector = new OmittedTypeArgumentVisitor();
            OmittedTypeArgumentVisitorCollector.Visit(root);
            map["OmittedTypeArgument"] = OmittedTypeArgumentVisitorCollector.Classes.Count;

            // OperatorDeclarationVisitorCollector
            var OperatorDeclarationVisitorCollector = new OperatorDeclarationVisitor();
            OperatorDeclarationVisitorCollector.Visit(root);
            map["OperatorDeclaration"] = OperatorDeclarationVisitorCollector.Classes.Count;

            // OperatorMemberCrefVisitorCollector
            var OperatorMemberCrefVisitorCollector = new OperatorMemberCrefVisitor();
            OperatorMemberCrefVisitorCollector.Visit(root);
            map["OperatorMemberCref"] = OperatorMemberCrefVisitorCollector.Classes.Count;

            // OrderByClauseVisitorCollector
            var OrderByClauseVisitorCollector = new OrderByClauseVisitor();
            OrderByClauseVisitorCollector.Visit(root);
            map["OrderByClause"] = OrderByClauseVisitorCollector.Classes.Count;

            // OrderingVisitorCollector
            var OrderingVisitorCollector = new OrderingVisitor();
            OrderingVisitorCollector.Visit(root);
            map["Ordering"] = OrderingVisitorCollector.Classes.Count;

            // ParameterVisitorCollector
            var ParameterVisitorCollector = new ParameterVisitor();
            ParameterVisitorCollector.Visit(root);
            map["Parameter"] = ParameterVisitorCollector.Classes.Count;

            // ParameterListVisitorCollector
            var ParameterListVisitorCollector = new ParameterListVisitor();
            ParameterListVisitorCollector.Visit(root);
            map["ParameterList"] = ParameterListVisitorCollector.Classes.Count;

            // ParenthesizedExpressionVisitorCollector
            var ParenthesizedExpressionVisitorCollector = new ParenthesizedExpressionVisitor();
            ParenthesizedExpressionVisitorCollector.Visit(root);
            map["ParenthesizedExpression"] = ParenthesizedExpressionVisitorCollector.Classes.Count;

            // ParenthesizedLambdaExpressionVisitorCollector
            var ParenthesizedLambdaExpressionVisitorCollector = new ParenthesizedLambdaExpressionVisitor();
            ParenthesizedLambdaExpressionVisitorCollector.Visit(root);
            map["ParenthesizedLambdaExpression"] = ParenthesizedLambdaExpressionVisitorCollector.Classes.Count;

            // PointerTypeVisitorCollector
            var PointerTypeVisitorCollector = new PointerTypeVisitor();
            PointerTypeVisitorCollector.Visit(root);
            map["PointerType"] = PointerTypeVisitorCollector.Classes.Count;

            // PostfixUnaryExpressionVisitorCollector
            var PostfixUnaryExpressionVisitorCollector = new PostfixUnaryExpressionVisitor();
            PostfixUnaryExpressionVisitorCollector.Visit(root);
            map["PostfixUnaryExpression"] = PostfixUnaryExpressionVisitorCollector.Classes.Count;

            // PragmaChecksumDirectiveTriviaVisitorCollector
            var PragmaChecksumDirectiveTriviaVisitorCollector = new PragmaChecksumDirectiveTriviaVisitor();
            PragmaChecksumDirectiveTriviaVisitorCollector.Visit(root);
            map["PragmaChecksumDirectiveTrivia"] = PragmaChecksumDirectiveTriviaVisitorCollector.Classes.Count;

            // PragmaWarningDirectiveTriviaVisitorCollector
            var PragmaWarningDirectiveTriviaVisitorCollector = new PragmaWarningDirectiveTriviaVisitor();
            PragmaWarningDirectiveTriviaVisitorCollector.Visit(root);
            map["PragmaWarningDirectiveTrivia"] = PragmaWarningDirectiveTriviaVisitorCollector.Classes.Count;

            // PredefinedTypeVisitorCollector
            var PredefinedTypeVisitorCollector = new PredefinedTypeVisitor();
            PredefinedTypeVisitorCollector.Visit(root);
            map["PredefinedType"] = PredefinedTypeVisitorCollector.Classes.Count;

            // PrefixUnaryExpressionVisitorCollector
            var PrefixUnaryExpressionVisitorCollector = new PrefixUnaryExpressionVisitor();
            PrefixUnaryExpressionVisitorCollector.Visit(root);
            map["PrefixUnaryExpression"] = PrefixUnaryExpressionVisitorCollector.Classes.Count;

            // PropertyDeclarationVisitorCollector
            var PropertyDeclarationVisitorCollector = new PropertyDeclarationVisitor();
            PropertyDeclarationVisitorCollector.Visit(root);
            map["PropertyDeclaration"] = PropertyDeclarationVisitorCollector.Classes.Count;

            // QualifiedCrefVisitorCollector
            var QualifiedCrefVisitorCollector = new QualifiedCrefVisitor();
            QualifiedCrefVisitorCollector.Visit(root);
            map["QualifiedCref"] = QualifiedCrefVisitorCollector.Classes.Count;

            // QualifiedNameVisitorCollector
            var QualifiedNameVisitorCollector = new QualifiedNameVisitor();
            QualifiedNameVisitorCollector.Visit(root);
            map["QualifiedName"] = QualifiedNameVisitorCollector.Classes.Count;

            // QueryBodyVisitorCollector
            var QueryBodyVisitorCollector = new QueryBodyVisitor();
            QueryBodyVisitorCollector.Visit(root);
            map["QueryBody"] = QueryBodyVisitorCollector.Classes.Count;

            // QueryContinuationVisitorCollector
            var QueryContinuationVisitorCollector = new QueryContinuationVisitor();
            QueryContinuationVisitorCollector.Visit(root);
            map["QueryContinuation"] = QueryContinuationVisitorCollector.Classes.Count;

            // QueryExpressionVisitorCollector
            var QueryExpressionVisitorCollector = new QueryExpressionVisitor();
            QueryExpressionVisitorCollector.Visit(root);
            map["QueryExpression"] = QueryExpressionVisitorCollector.Classes.Count;

            // ReferenceDirectiveTriviaVisitorCollector
            var ReferenceDirectiveTriviaVisitorCollector = new ReferenceDirectiveTriviaVisitor();
            ReferenceDirectiveTriviaVisitorCollector.Visit(root);
            map["ReferenceDirectiveTrivia"] = ReferenceDirectiveTriviaVisitorCollector.Classes.Count;

            // RefTypeExpressionVisitorCollector
            var RefTypeExpressionVisitorCollector = new RefTypeExpressionVisitor();
            RefTypeExpressionVisitorCollector.Visit(root);
            map["RefTypeExpression"] = RefTypeExpressionVisitorCollector.Classes.Count;

            // RefValueExpressionVisitorCollector
            var RefValueExpressionVisitorCollector = new RefValueExpressionVisitor();
            RefValueExpressionVisitorCollector.Visit(root);
            map["RefValueExpression"] = RefValueExpressionVisitorCollector.Classes.Count;

            // RegionDirectiveTriviaVisitorCollector
            var RegionDirectiveTriviaVisitorCollector = new RegionDirectiveTriviaVisitor();
            RegionDirectiveTriviaVisitorCollector.Visit(root);
            map["RegionDirectiveTrivia"] = RegionDirectiveTriviaVisitorCollector.Classes.Count;

            // ReturnStatementVisitorCollector
            var ReturnStatementVisitorCollector = new ReturnStatementVisitor();
            ReturnStatementVisitorCollector.Visit(root);
            map["ReturnStatement"] = ReturnStatementVisitorCollector.Classes.Count;

            // SelectClauseVisitorCollector
            var SelectClauseVisitorCollector = new SelectClauseVisitor();
            SelectClauseVisitorCollector.Visit(root);
            map["SelectClause"] = SelectClauseVisitorCollector.Classes.Count;

            // SimpleBaseTypeVisitorCollector
            var SimpleBaseTypeVisitorCollector = new SimpleBaseTypeVisitor();
            SimpleBaseTypeVisitorCollector.Visit(root);
            map["SimpleBaseType"] = SimpleBaseTypeVisitorCollector.Classes.Count;

            // SimpleLambdaExpressionVisitorCollector
            var SimpleLambdaExpressionVisitorCollector = new SimpleLambdaExpressionVisitor();
            SimpleLambdaExpressionVisitorCollector.Visit(root);
            map["SimpleLambdaExpression"] = SimpleLambdaExpressionVisitorCollector.Classes.Count;

            // SizeOfExpressionVisitorCollector
            var SizeOfExpressionVisitorCollector = new SizeOfExpressionVisitor();
            SizeOfExpressionVisitorCollector.Visit(root);
            map["SizeOfExpression"] = SizeOfExpressionVisitorCollector.Classes.Count;

            // SkippedTokensTriviaVisitorCollector
            var SkippedTokensTriviaVisitorCollector = new SkippedTokensTriviaVisitor();
            SkippedTokensTriviaVisitorCollector.Visit(root);
            map["SkippedTokensTrivia"] = SkippedTokensTriviaVisitorCollector.Classes.Count;

            // StackAllocArrayCreationExpressionVisitorCollector
            var StackAllocArrayCreationExpressionVisitorCollector = new StackAllocArrayCreationExpressionVisitor();
            StackAllocArrayCreationExpressionVisitorCollector.Visit(root);
            map["StackAllocArrayCreationExpression"] = StackAllocArrayCreationExpressionVisitorCollector.Classes.Count;

            // StructDeclarationVisitorCollector
            var StructDeclarationVisitorCollector = new StructDeclarationVisitor();
            StructDeclarationVisitorCollector.Visit(root);
            map["StructDeclaration"] = StructDeclarationVisitorCollector.Classes.Count;

            // SwitchSectionVisitorCollector
            var SwitchSectionVisitorCollector = new SwitchSectionVisitor();
            SwitchSectionVisitorCollector.Visit(root);
            map["SwitchSection"] = SwitchSectionVisitorCollector.Classes.Count;

            // SwitchStatementVisitorCollector
            var SwitchStatementVisitorCollector = new SwitchStatementVisitor();
            SwitchStatementVisitorCollector.Visit(root);
            map["SwitchStatement"] = SwitchStatementVisitorCollector.Classes.Count;

            // ThisExpressionVisitorCollector
            var ThisExpressionVisitorCollector = new ThisExpressionVisitor();
            ThisExpressionVisitorCollector.Visit(root);
            map["ThisExpression"] = ThisExpressionVisitorCollector.Classes.Count;

            // ThrowStatementVisitorCollector
            var ThrowStatementVisitorCollector = new ThrowStatementVisitor();
            ThrowStatementVisitorCollector.Visit(root);
            map["ThrowStatement"] = ThrowStatementVisitorCollector.Classes.Count;

            // TryStatementVisitorCollector
            var TryStatementVisitorCollector = new TryStatementVisitor();
            TryStatementVisitorCollector.Visit(root);
            map["TryStatement"] = TryStatementVisitorCollector.Classes.Count;

            // TypeArgumentListVisitorCollector
            var TypeArgumentListVisitorCollector = new TypeArgumentListVisitor();
            TypeArgumentListVisitorCollector.Visit(root);
            map["TypeArgumentList"] = TypeArgumentListVisitorCollector.Classes.Count;

            // TypeConstraintVisitorCollector
            var TypeConstraintVisitorCollector = new TypeConstraintVisitor();
            TypeConstraintVisitorCollector.Visit(root);
            map["TypeConstraint"] = TypeConstraintVisitorCollector.Classes.Count;

            // TypeCrefVisitorCollector
            var TypeCrefVisitorCollector = new TypeCrefVisitor();
            TypeCrefVisitorCollector.Visit(root);
            map["TypeCref"] = TypeCrefVisitorCollector.Classes.Count;

            // TypeOfExpressionVisitorCollector
            var TypeOfExpressionVisitorCollector = new TypeOfExpressionVisitor();
            TypeOfExpressionVisitorCollector.Visit(root);
            map["TypeOfExpression"] = TypeOfExpressionVisitorCollector.Classes.Count;

            // TypeParameterVisitorCollector
            var TypeParameterVisitorCollector = new TypeParameterVisitor();
            TypeParameterVisitorCollector.Visit(root);
            map["TypeParameter"] = TypeParameterVisitorCollector.Classes.Count;

            // TypeParameterConstraintClauseVisitorCollector
            var TypeParameterConstraintClauseVisitorCollector = new TypeParameterConstraintClauseVisitor();
            TypeParameterConstraintClauseVisitorCollector.Visit(root);
            map["TypeParameterConstraintClause"] = TypeParameterConstraintClauseVisitorCollector.Classes.Count;

            // TypeParameterListVisitorCollector
            var TypeParameterListVisitorCollector = new TypeParameterListVisitor();
            TypeParameterListVisitorCollector.Visit(root);
            map["TypeParameterList"] = TypeParameterListVisitorCollector.Classes.Count;

            // UndefDirectiveTriviaVisitorCollector
            var UndefDirectiveTriviaVisitorCollector = new UndefDirectiveTriviaVisitor();
            UndefDirectiveTriviaVisitorCollector.Visit(root);
            map["UndefDirectiveTrivia"] = UndefDirectiveTriviaVisitorCollector.Classes.Count;

            // UnsafeStatementVisitorCollector
            var UnsafeStatementVisitorCollector = new UnsafeStatementVisitor();
            UnsafeStatementVisitorCollector.Visit(root);
            map["UnsafeStatement"] = UnsafeStatementVisitorCollector.Classes.Count;

            // UsingDirectiveVisitorCollector
            var UsingDirectiveVisitorCollector = new UsingDirectiveVisitor();
            UsingDirectiveVisitorCollector.Visit(root);
            map["UsingDirective"] = UsingDirectiveVisitorCollector.Classes.Count;

            // UsingStatementVisitorCollector
            var UsingStatementVisitorCollector = new UsingStatementVisitor();
            UsingStatementVisitorCollector.Visit(root);
            map["UsingStatement"] = UsingStatementVisitorCollector.Classes.Count;

            // VariableDeclarationVisitorCollector
            var VariableDeclarationVisitorCollector = new VariableDeclarationVisitor();
            VariableDeclarationVisitorCollector.Visit(root);
            map["VariableDeclaration"] = VariableDeclarationVisitorCollector.Classes.Count;

            // VariableDeclaratorVisitorCollector
            var VariableDeclaratorVisitorCollector = new VariableDeclaratorVisitor();
            VariableDeclaratorVisitorCollector.Visit(root);
            map["VariableDeclarator"] = VariableDeclaratorVisitorCollector.Classes.Count;

            // WarningDirectiveTriviaVisitorCollector
            var WarningDirectiveTriviaVisitorCollector = new WarningDirectiveTriviaVisitor();
            WarningDirectiveTriviaVisitorCollector.Visit(root);
            map["WarningDirectiveTrivia"] = WarningDirectiveTriviaVisitorCollector.Classes.Count;

            // WhereClauseVisitorCollector
            var WhereClauseVisitorCollector = new WhereClauseVisitor();
            WhereClauseVisitorCollector.Visit(root);
            map["WhereClause"] = WhereClauseVisitorCollector.Classes.Count;

            // WhileStatementVisitorCollector
            var WhileStatementVisitorCollector = new WhileStatementVisitor();
            WhileStatementVisitorCollector.Visit(root);
            map["WhileStatement"] = WhileStatementVisitorCollector.Classes.Count;

            // XmlCDataSectionVisitorCollector
            var XmlCDataSectionVisitorCollector = new XmlCDataSectionVisitor();
            XmlCDataSectionVisitorCollector.Visit(root);
            map["XmlCDataSection"] = XmlCDataSectionVisitorCollector.Classes.Count;

            // XmlCommentVisitorCollector
            var XmlCommentVisitorCollector = new XmlCommentVisitor();
            XmlCommentVisitorCollector.Visit(root);
            map["XmlComment"] = XmlCommentVisitorCollector.Classes.Count;

            // XmlCrefAttributeVisitorCollector
            var XmlCrefAttributeVisitorCollector = new XmlCrefAttributeVisitor();
            XmlCrefAttributeVisitorCollector.Visit(root);
            map["XmlCrefAttribute"] = XmlCrefAttributeVisitorCollector.Classes.Count;

            // XmlElementVisitorCollector
            var XmlElementVisitorCollector = new XmlElementVisitor();
            XmlElementVisitorCollector.Visit(root);
            map["XmlElement"] = XmlElementVisitorCollector.Classes.Count;

            // XmlElementEndTagVisitorCollector
            var XmlElementEndTagVisitorCollector = new XmlElementEndTagVisitor();
            XmlElementEndTagVisitorCollector.Visit(root);
            map["XmlElementEndTag"] = XmlElementEndTagVisitorCollector.Classes.Count;

            // XmlElementStartTagVisitorCollector
            var XmlElementStartTagVisitorCollector = new XmlElementStartTagVisitor();
            XmlElementStartTagVisitorCollector.Visit(root);
            map["XmlElementStartTag"] = XmlElementStartTagVisitorCollector.Classes.Count;

            // XmlEmptyElementVisitorCollector
            var XmlEmptyElementVisitorCollector = new XmlEmptyElementVisitor();
            XmlEmptyElementVisitorCollector.Visit(root);
            map["XmlEmptyElement"] = XmlEmptyElementVisitorCollector.Classes.Count;

            // XmlNameVisitorCollector
            var XmlNameVisitorCollector = new XmlNameVisitor();
            XmlNameVisitorCollector.Visit(root);
            map["XmlName"] = XmlNameVisitorCollector.Classes.Count;

            // XmlNameAttributeVisitorCollector
            var XmlNameAttributeVisitorCollector = new XmlNameAttributeVisitor();
            XmlNameAttributeVisitorCollector.Visit(root);
            map["XmlNameAttribute"] = XmlNameAttributeVisitorCollector.Classes.Count;

            // XmlPrefixVisitorCollector
            var XmlPrefixVisitorCollector = new XmlPrefixVisitor();
            XmlPrefixVisitorCollector.Visit(root);
            map["XmlPrefix"] = XmlPrefixVisitorCollector.Classes.Count;

            // XmlProcessingInstructionVisitorCollector
            var XmlProcessingInstructionVisitorCollector = new XmlProcessingInstructionVisitor();
            XmlProcessingInstructionVisitorCollector.Visit(root);
            map["XmlProcessingInstruction"] = XmlProcessingInstructionVisitorCollector.Classes.Count;

            // XmlTextVisitorCollector
            var XmlTextVisitorCollector = new XmlTextVisitor();
            XmlTextVisitorCollector.Visit(root);
            map["XmlText"] = XmlTextVisitorCollector.Classes.Count;

            // XmlTextAttributeVisitorCollector
            var XmlTextAttributeVisitorCollector = new XmlTextAttributeVisitor();
            XmlTextAttributeVisitorCollector.Visit(root);
            map["XmlTextAttribute"] = XmlTextAttributeVisitorCollector.Classes.Count;

            // YieldStatementVisitorCollector
            var YieldStatementVisitorCollector = new YieldStatementVisitor();
            YieldStatementVisitorCollector.Visit(root);
            map["YieldStatement"] = YieldStatementVisitorCollector.Classes.Count;

            return map;
        }
    }
}
