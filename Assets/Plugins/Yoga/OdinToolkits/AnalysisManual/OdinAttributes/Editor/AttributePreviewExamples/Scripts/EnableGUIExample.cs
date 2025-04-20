using Sirenix.OdinInspector;

namespace YOGA.OdinToolkits.AnalysisManual.OdinAttributes.Editor
{
    [IsChineseAttributeExample]
    public class EnableGUIExample : ExampleScriptableObject
    {
        [PropertyOrder(0)]
        [InfoBox("正常字段，没有添加多余特性，不是灰色显示的")]
        public string enableGUI1 = "";

        [PropertyOrder(1)]
        [ReadOnly]
        [InfoBox("只读字段，它将是灰色显示")]
        public string enableGUI2 = "";

        [PropertyOrder(5)]
        [ReadOnly]
        [EnableGUI]
        [InfoBox("只读字段，但是标记了 [EnableGUI] ，强制启用，可以获取焦点，在 Inspector 上修改会警告")]
        public string enableGUI3 = "";

        [PropertyOrder(10)]
        [ShowInInspector]
        [InfoBox("没有 set 的属性，是灰色显示的，通过 [ShowInInspector] 特性绘制，无法保存")]
        public int EnableGUI4Property
        {
            get => 10;
        }

        [PropertyOrder(15)]
        [ShowInInspector]
        [EnableGUI]
        [InfoBox("没有 set 的属性，通过 [ShowInInspector] 和 [EnableGUI] 特性绘制，无法保存，但可以获取焦点，在 Inspector 上修改会警告")]
        public int EnableGUI5Property
        {
            get => 10;
        }

        public override void SetDefaultValue()
        {
            enableGUI1 = "enableGUI1";
            enableGUI2 = "enableGUI2";
            enableGUI3 = "enableGUI3";
        }
    }
}
