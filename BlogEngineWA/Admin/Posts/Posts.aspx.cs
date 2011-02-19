using System;
using BlogEngineWA.CustomCode;

namespace BlogEngineWA.Admin.Posts
{
    public partial class Posts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebUtils.CheckRightsForAdminPostPages(false);
        }
    }
}