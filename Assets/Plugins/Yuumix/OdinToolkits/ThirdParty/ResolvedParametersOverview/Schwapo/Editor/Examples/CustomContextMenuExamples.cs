using Sirenix.OdinInspector;
using UnityEngine;

namespace YOGA.Modules.OdinToolkits.Schwapo.Editor.Examples
{
    [ResolvedParameterExample]
    public class CustomContextMenuExamples_Action
    {
        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("Right click the field label to execute the context menu item")]
        [CustomContextMenu("Log", "@Debug.Log($value)")]
        public string AttributeExpressionExample = "Peace";

        [FoldoutGroup("Method Name Example")]
        [InfoBox("Right click the field label to execute the context menu item")]
        [CustomContextMenu("Log", "Log")]
        public string MethodNameExample = "Love";

        private void Log(string value)
        {
            Debug.Log(value);
        }
    }
    // End
}