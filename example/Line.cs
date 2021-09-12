using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Cyotek.Windows.Forms.Design;

namespace Cyotek.Windows.Forms
{
	[Designer(typeof(LineDesigner))]
	public class Line : Control
	{
		#region Instance Fields

		private FlatStyle _flatStyle = FlatStyle.Standard;

		private Color _lineColor;

		private Orientation _orientation;

		#endregion

		#region Public Constructors

		public Line()
		{
			SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.Selectable, false);
			LineColor = SystemColors.ControlDark;
		}

		#endregion

		#region Events

		public event EventHandler FlatStyleChanged;

		/// <summary>
		/// Occurs when the LineColor property value changes
		/// </summary>
		[Category("Property Changed")]
		public event EventHandler LineColorChanged;

		/// <summary>
		/// Occurs when the Orientation property value changes
		/// </summary>
		[Category("Property Changed")]
		public event EventHandler OrientationChanged;

		#endregion

		#region Overridden Properties

		protected override Size DefaultSize
		{
			get { return new Size(100, 2); }
		}

		#endregion

		#region Overridden Methods

		protected override void OnPaint(PaintEventArgs pe)
		{
			int x1;
			int y1;
			int x2;
			int y2;
			int xOffset;
			int yOffset;

			switch (Orientation)
			{
				case Orientation.Horizontal:
					x1 = 0;
					y1 = (Height / 2) - 1;
					x2 = Width;
					y2 = y1;
					xOffset = 0;
					yOffset = 1;
					break;
				default:
					x1 = (Width / 2) - 1;
					y1 = 0;
					x2 = x1;
					y2 = Height;
					xOffset = 1;
					yOffset = 0;
					break;
			}

			switch (FlatStyle)
			{
				case FlatStyle.System:
					using (var pen = new Pen(LineColor))
					{
						pe.Graphics.DrawLine(pen, x1, y1, x2, y2);
					}
					break;
				default:
					pe.Graphics.DrawLine(SystemPens.ControlDark, x1, y1, x2, y2);
					pe.Graphics.DrawLine(SystemPens.ControlLightLight, x1 + xOffset, y1 + yOffset, x2 + xOffset, y2 + yOffset);
					break;
			}
		}

		protected override void OnSystemColorsChanged(EventArgs e)
		{
			base.OnSystemColorsChanged(e);

			Invalidate();
		}

		#endregion

		#region Public Properties

		[Category("Appearance")]
		[DefaultValue(typeof(FlatStyle), "Standard")]
		public FlatStyle FlatStyle
		{
			get { return _flatStyle; }
			set
			{
				if (_flatStyle != value)
				{
					_flatStyle = value;

					OnFlatStyleChanged(EventArgs.Empty);
				}
			}
		}

		[Category("Appearance")]
		[DefaultValue(typeof(Color), "ControlDark")]
		public Color LineColor
		{
			get { return _lineColor; }
			set
			{
				if (LineColor != value)
				{
					_lineColor = value;

					OnLineColorChanged(EventArgs.Empty);
				}
			}
		}

		[Category("Appearance")]
		[DefaultValue(typeof(Orientation), "Horizontal")]
		public Orientation Orientation
		{
			get { return _orientation; }
			set
			{
				if (Orientation != value)
				{
					_orientation = value;

					OnOrientationChanged(EventArgs.Empty);
				}
			}
		}

		#endregion

		#region Protected Members

		/// <summary>
		/// Raises the <see cref="FlatStyleChangedChanged" /> event.
		/// </summary>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		protected virtual void OnFlatStyleChanged(EventArgs e)
		{
			EventHandler handler;

			handler = FlatStyleChanged;

			handler?.Invoke(this, e);
		}

		/// <summary>
		/// Raises the <see cref="LineColorChanged" /> event.
		/// </summary>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		protected virtual void OnLineColorChanged(EventArgs e)
		{
			EventHandler handler;

			Invalidate();

			handler = LineColorChanged;

			handler?.Invoke(this, e);
		}

		/// <summary>
		/// Raises the <see cref="OrientationChanged" /> event.
		/// </summary>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		protected virtual void OnOrientationChanged(EventArgs e)
		{
			EventHandler handler;

			Invalidate();

			handler = OrientationChanged;

			handler?.Invoke(this, e);
		}

		#endregion
	}
}
