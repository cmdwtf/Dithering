using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Cyotek.Windows.Forms.Design
{
	public class LineDesigner : ControlDesigner
	{
		#region Overridden Properties

		public override SelectionRules SelectionRules
		{
			get
			{
				SelectionRules result;

				result = SelectionRules.Visible | SelectionRules.Moveable;

				result |= ((Line)Control).Orientation switch
				{
					Orientation.Horizontal => (SelectionRules.RightSizeable | SelectionRules.LeftSizeable),
					_ => (SelectionRules.TopSizeable | SelectionRules.BottomSizeable),
				};
				return result;
			}
		}

		#endregion
	}
}
