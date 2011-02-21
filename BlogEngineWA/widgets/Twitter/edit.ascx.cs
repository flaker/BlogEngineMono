// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   The edit.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using BlogEngineWA.CustomCode.Controls;
using System;
using System.Web;

namespace BlogEngineWA.widgets.Twitter
{
    /// <summary>
    /// The edit.
    /// </summary>
    public partial class Edit : WidgetEditBase
    {
        #region Public Methods

        /// <summary>
        /// Saves this the basic widget settings such as the Title.
        /// </summary>
        public override void Save()
        {
            var settings = this.GetSettings();
            settings[Widget.Twit_KeyFeedUrl] = this.txtUrl.Text;
            settings[Widget.Twit_KeyAccountUrl] = this.txtAccountUrl.Text;
            settings[Widget.Twit_KeyMaxItems] = this.txtTwits.Text;
            settings[Widget.Twit_KeyPollingInterval] = this.txtPolling.Text;
            settings[Widget.Twit_KeyFollowMeText] = this.txtFollowMe.Text;
            this.SaveSettings(settings);

			// Don't need to clear Feed out of cache because when the Settings are cleared,
            // the last modified date (i.e. TwitterSettings.LastModified) will reset to
            // DateTime.MinValue and Twitter will be re-queried.
			HttpRuntime.Cache.Remove(Widget.TwitterSettingsCacheKey);
		
        }

        #endregion

        #region Methods

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            var settings = this.GetSettings();
            if (settings.ContainsKey(Widget.Twit_KeyFeedUrl))
            {
                this.txtUrl.Text = settings[Widget.Twit_KeyFeedUrl];
                this.txtAccountUrl.Text = settings[Widget.Twit_KeyAccountUrl];
                this.txtTwits.Text = settings[Widget.Twit_KeyMaxItems];
                this.txtPolling.Text = settings[Widget.Twit_KeyPollingInterval];
                this.txtFollowMe.Text = settings[Widget.Twit_KeyFollowMeText];
            }

            base.OnInit(e);
        }

        #endregion
    }
}