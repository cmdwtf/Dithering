using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * https://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015-2017 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

namespace cmdwtf.Dithering.Example
{
	internal sealed partial class AboutDialog : Form
	{
		#region Constructors

		public AboutDialog()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			FileVersionInfo versionInfo;

			versionInfo = FileVersionInfo.GetVersionInfo(typeof(MainForm).Assembly.Location);
			nameLabel.Text = versionInfo.ProductName;
			copyrightLabel.Text = versionInfo.LegalCopyright;
			descriptionLabel.Text = versionInfo.Comments;

			SetLink(ossLinkLabel, "GitHub", "https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox");
			SetLink(ossLinkLabel, "cyotek.com", "https://www.cyotek.com/blog/tag/imagebox");
			SetLink(ossLinkLabel, "another article", "https://www.cyotek.com/blog/creating-a-groupbox-containing-an-image-and-a-custom-display-rectangle");
			SetLink(ossLinkLabel, "README.md", "https://github.com/cmdwtf/Dithering/blob/main/example/README.md");
			SetLink(ossLinkLabel, "DHALF.TXT", "https://github.com/cmdwtf/Dithering/blob/main/resources/DHALF.TXT");
			SetLink(ossLinkLabel, "colour distance", "https://www.cyotek.com/blog/finding-nearest-colors-using-euclidean-distance");
		}

		private void closeButton_Click(object sender, EventArgs e) => Close();

		private static bool HasLink(LinkLabel.LinkCollection links, int position)
		{
			bool result;

			result = false;

			if (links.LinksAdded)
			{
				for (int i = 0; i < links.Count; i++)
				{
					LinkLabel.Link link;

					link = links[i];

					if (position >= link.Start && position <= link.Start + link.Length)
					{
						result = true;
						break;
					}
				}
			}

			return result;
		}

		private void ossLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => RunUrl((string)e.Link.LinkData);

		private void RunUrl(string url)
		{
			try
			{
				var psi = new ProcessStartInfo(url)
				{
					UseShellExecute = true,
					Verb = "open"
				};

				Process.Start(psi);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.GetBaseException().Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private static void SetLink(LinkLabel control, string match, string url)
		{
			int index = -1;
			do
			{
				index = control.Text.IndexOf(match, index + 1, StringComparison.Ordinal);
				// perhaps a .NET 5 issue with link label indexing?
				int whitespaceBefore = control.Text.Substring(0, index).Where(c => c == '\n').Count();
				index -= whitespaceBefore;
			} while (index != -1 && HasLink(control.Links, index));

			control.Links.Add(index, match.Length, url);
		}

		private void webLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => RunUrl((sender as Control)?.Tag as string);

		#endregion
	}
}
