﻿// **********************************
// 框架名称：BootstrapBlazor 
// 框架作者：Argo Zhang
// 开源地址：
// Gitee : https://gitee.com/LongbowEnterprise/BootstrapBlazor
// GitHub: https://github.com/ArgoZhang/BootstrapBlazor 
// 开源协议：LGPL-3.0 (https://gitee.com/LongbowEnterprise/BootstrapBlazor/blob/dev/LICENSE)
// **********************************

using BootstrapBlazor.Components;
using BootstrapBlazor.Shared.Common;
using BootstrapBlazor.Shared.Pages.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace BootstrapBlazor.Shared.Pages
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Buttons
    {
        /// <summary>
        /// 
        /// </summary>
        private Logger? Trace { get; set; }

        [NotNull]
        private Button? ButtonDisableDemo { get; set; }

        private bool IsDisable { get; set; }

        private void ClickButton1()
        {
            IsDisable = !IsDisable;
            StateHasChanged();
        }

        private Task ClickButton2()
        {
            IsDisable = false;
            ButtonDisableDemo.SetDisable(false);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        private void ButtonClick(MouseEventArgs e)
        {
            Trace?.Log($"Button Clicked");
        }

        private string ButtonText { get; set; } = "";

        private Task ClickButtonShowText(string text)
        {
            ButtonText = text;
            StateHasChanged();
            return Task.CompletedTask;
        }

        /// <summary>
        /// 获得事件方法
        /// </summary>
        /// <returns></returns>
        private IEnumerable<EventItem> GetEvents() => new EventItem[]
        {
            new EventItem()
            {
                Name = "OnClick",
                Description="点击按钮时触发此事件",
                Type ="EventCallback<MouseEventArgs>"
            },
            new EventItem()
            {
                Name = "OnClickWithoutRender",
                Description="点击按钮时触发此事件并且不刷新当前组件，用于提高性能时使用",
                Type ="Func<Task>"
            }
        };

        /// <summary>
        /// 获得属性方法
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AttributeItem> GetAttributes() => new AttributeItem[]
        {
            // TODO: 移动到数据库中
            new AttributeItem() {
                Name = "Color",
                Description = "颜色",
                Type = "Color",
                ValueList = "None / Active / Primary / Secondary / Success / Danger / Warning / Info / Light / Dark / Link",
                DefaultValue = "Primary"
            },
            new AttributeItem() {
                Name = "Icon",
                Description = "图标",
                Type = "string",
                ValueList = "",
                DefaultValue = ""
            },
            new AttributeItem() {
                Name = "Text",
                Description = "显示文字",
                Type = "string",
                ValueList = "",
                DefaultValue = ""
            },
            new AttributeItem() {
                Name = "Size",
                Description = "尺寸",
                Type = "Size",
                ValueList = "None / ExtraSmall / Small / Medium / Large / ExtraLarge",
                DefaultValue = "None"
            },
            new AttributeItem() {
                Name = "Class",
                Description = "样式",
                Type = "string",
                ValueList = " — ",
                DefaultValue = " — "
            },
            new AttributeItem() {
                Name = "IsBlock",
                Description = "填充按钮",
                Type = "boolean",
                ValueList = " — ",
                DefaultValue = "false"
            },
            new AttributeItem() {
                Name = "IsDisabled",
                Description = "是否禁用",
                Type = "boolean",
                ValueList = " — ",
                DefaultValue = "false"
            },
            new AttributeItem() {
                Name = "IsOutline",
                Description = "是否边框",
                Type = "boolean",
                ValueList = " — ",
                DefaultValue = "false"
            },
            new AttributeItem() {
                Name = "ChildContent",
                Description = "内容",
                Type = "RenderFragment",
                ValueList = " — ",
                DefaultValue = " — "
            },
            new AttributeItem() {
                Name = "ButtonStyle",
                Description = "按钮风格",
                Type = "ButtonStyle",
                ValueList = "None / Circle / Round",
                DefaultValue = "None"
            },
            new AttributeItem() {
                Name = "ButtonType",
                Description = "按钮类型",
                Type = "ButtonType",
                ValueList = "Button / Submit / Reset",
                DefaultValue = "Button"
            }
        };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<MethodItem> GetMethods() => new MethodItem[]
        {
            new MethodItem()
            {
                Name = "SetDisable",
                Description = "设置按钮是否可用",
                Parameters = "disable",
                ReturnValue = " — "
            }
        };
    }
}
