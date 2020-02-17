/********************************************************************************
SEARCH BAR COMPONENT                    
---------------------------------------------------------------------------------
Description:
    When this component is invoked (from "_Layout.cshtml") it returns the
    view-component in the path "Views/Shared/Components/SearhBar/Default.cshtml".

    The view-component is a form with one input field and a button. When the 
    button is pressed the form is routed to controller=Movie/action=List.

    The List action searches the movie repository and displays the result on its
    own view (Views/Movie/List.cshtml).

Requirements:
    Corresponding view (Views/Shared/Components/SearhBar/Default.cshtml)

*********************************************************************************/

using Microsoft.AspNetCore.Mvc;

namespace DotNetFlix.Web.Components
{
    public class SearchBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
