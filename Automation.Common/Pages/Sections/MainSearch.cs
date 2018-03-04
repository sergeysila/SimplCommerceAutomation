using Automation.Common.DataModels;
using Epam.JDI.Core.Interfaces.Common;
using Epam.JDI.Core.Interfaces.Complex;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Composite;

namespace Automation.Common.Pages.Sections
{
    public sealed class MainSearch : Search
    {
        [FindBy(Css = ".search-input input")]
        public ITextField SearchInput;

        [FindBy(Id = "Category")]
        public ISelector<SearchCategories> SearchCategorySelector;

        [FindBy(Css = ".search-btn")]
        public IButton SearchButon;
    }
}