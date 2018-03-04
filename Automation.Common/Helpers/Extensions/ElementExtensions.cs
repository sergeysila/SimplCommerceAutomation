using System.Collections.Generic;
using System.Linq;
using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Behaviors.Traits;
using Ipreo.AutomationFramework.UI.Components.Search;
using Ipreo.AutomationFramework.UI.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Automation.Common.Helpers.Extensions
{
    public static class ElementExtensions
    {
        public static void ScrollIntoView(this IElement element)
            => Driver.ExecuteScript("window.scrollTo(arguments[0], arguments[1]);",
                element.GetWebElement().Location.X, element.GetWebElement().Location.Y);

        public static IWebElement GetWebElement(this IElement element)
            => element.ElementDecorator.Eval<IWebElement, IWebElement>(e => e);

        public static string GetTrimmedText(this ITextReadable element)
            => element.GetText().Trim();

        public static void Hover(this Element element)
            => new Actions(Driver.WebDriver).MoveToElement(element.GetWebElement()).Perform();

        public static void ScrollIntoViewAndClick(this Element element)
        {
            element.ScrollIntoView();
            element.Click();
        }

        public static void RemoveFocus(this Element element)
            => Driver.ExecuteScript("document.activeElement.blur();");

        public static List<string> GetDropDownOptions(this HtmlDropDown dropDown)
            => dropDown.FindAll<HtmlLabel>()
                .FindBy(How.CssSelector, "option:not([disabled])")
                .Select(o => o.GetText())
                .ToList();

        public static T GetContainer<T>(this Element element) where T : IContainer, new()
            => PageService.Create<T>(element);

        public static void SendKeys(this HtmlTextField textField, string keys)
            => textField.GetWebElement().SendKeys(keys);

        public static bool HasAttribute(this Element element, string attribute)
            => Driver.ExecuteScript<bool>($"return arguments[0].hasAttribute(\"{attribute}\");",
                element.GetWebElement());

        public static Cell GetExistingCell(this HtmlTable table, int index, string columnName)
        {
            var cell = table.GetCell(index, columnName);
            return cell.Exists ? cell : null;
        }

        public static bool IsNull(this object o)
            => o == null;
    }
}