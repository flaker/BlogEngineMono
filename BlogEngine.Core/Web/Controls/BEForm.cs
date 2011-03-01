using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace BlogEngine.Core.Web.Controls
{
	public class BEForm : HtmlForm
	{
		public override string UniqueID {
			get { return "aspnetForm"; }
		}

		protected override void RenderAttributes (HtmlTextWriter writer)
		{
			using (TextWriter wr = new StringWriter ()) {
				using (HtmlTextWriter hackWr = new HtmlTextWriter (wr)) {
					base.RenderAttributes (hackWr);
					StringBuilder sb = new StringBuilder (wr.ToString ());
					
					if (sb.ToString().IndexOf("name=\"aspnetForm\"", StringComparison.OrdinalIgnoreCase) < 0)
					{
						sb = sb.Replace ("id=\"aspnetForm\"", "id=\"aspnetForm\" name=\"aspnetForm\"");
					}
					writer.Write (sb.ToString ());
				}
			}
		}
	}
}
