using Sirenix.OdinInspector;

namespace YOGA.Modules.OdinToolkits.Schwapo.Editor.Examples
{
    [ResolvedParameterExample]
    public class InfoBoxExamples_VisibleIf
    {
        [FoldoutGroup("Attribute Expression Example")] [InfoBox("Ducks are awesome", VisibleIf = "@IsVisible")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Field Name Example")] [InfoBox("Ducks are awesome", VisibleIf = "IsVisible")]
        public string FieldNameExample;

        public bool IsVisible = true;

        [FoldoutGroup("Method Name Example")] [InfoBox("Ducks are awesome", VisibleIf = "GetVisibility")]
        public string MethodNameExample;

        [FoldoutGroup("Property Name Example")] [InfoBox("Ducks are awesome", VisibleIf = "IsVisibleProperty")]
        public string PropertyNameExample;

        public bool IsVisibleProperty => IsVisible;

        private bool GetVisibility()
        {
            return IsVisible;
        }
    }
    // End

    [ResolvedParameterExample]
    public class InfoBoxExamples_Message
    {
        [FoldoutGroup("Attribute Expression Example")] [InfoBox("@Message")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Field Name Example")] [InfoBox("$Message")]
        public string FieldNameExample;

        public string Message = "Ducks are awesome";

        [FoldoutGroup("Method Name Example")] [InfoBox("$GetMessage")]
        public string MethodNameExample;

        [FoldoutGroup("Property Name Example")] [InfoBox("$MessageProperty")]
        public string PropertyNameExample;

        public string MessageProperty => Message;

        private string GetMessage()
        {
            return Message;
        }
    }
    // End
}