using Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Common.Editor;
using Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Editor.AttributePreviewExamples.Scripts;
using System.Collections.Generic;

namespace Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Editor.AttributeContainers.Scripts
{
    public class InlinePropertyContainer : AbsContainer
    {
        protected override string SetHeader()
        {
            return "InlineProperty";
        }

        protected override string SetBrief()
        {
            return "将通常需要折叠的 Property 重新绘制在一行中";
        }

        protected override List<string> SetTip()
        {
            return new List<string>
            {
                "参数设置的是自定义类或者结构体中的子 properties 的宽度"
            };
        }

        protected override List<ParamValue> SetParamValues()
        {
            return new List<ParamValue>
            {
                new()
                {
                    returnType = "int",
                    paramName = "LabelWidth",
                    paramDescription = "所有子 properties 的宽度"
                }
            };
        }

        protected override string SetOriginalCode()
        {
            return ReadCodeWithoutNamespace(typeof(InlinePropertyExample));
        }
    }
}