// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   The widget.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using BlogEngineWA.CustomCode.Controls;

namespace BlogEngineWA.Widgets.PageList
{
    /// <summary>
    /// The widget.
    /// </summary>
    public partial class Widget : WidgetBase
    {
        #region Properties

        /// <summary>
        /// Gets a value indicating whether IsEditable.
        /// </summary>
        public override bool IsEditable
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets Name.
        /// </summary>
        public override string Name
        {
            get
            {
                return "Page List";
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The load widget.
        /// </summary>
        public override void LoadWidget()
        {
            // Nothing to load
        }

        #endregion
    }
}