﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindRect
{
	public static class Tools
	{
		public static int IntRange(int value, int minval, int maxval)
		{
			if (value < minval)
				return minval;

			if (maxval < value)
				return maxval;

			return value;
		}

		public static int ParseInt(string str, int minval, int maxval, int defval)
		{
			try
			{
				return Tools.IntRange(int.Parse(str), minval, maxval);
			}
			catch
			{
				return defval;
			}
		}

		public static string ToHexToken(byte[] block)
		{
			StringBuilder sb = new StringBuilder();

			foreach (byte chr in block)
			{
				sb.Append(chr.ToString("x2"));
			}
			return "{" + sb + "}";
		}

		public static string EraseDq(string str)
		{
			while (str.StartsWith("\""))
				str = str.Substring(1);

			while (str.EndsWith("\""))
				str = str.Substring(0, str.Length - 1);

			return str;
		}

		public static string FontFilter(string font)
		{
			try
			{
				if (font == "")
					throw null;

				string tmp = new Font(font, 10, FontStyle.Regular).Name;

				if (font != tmp)
					throw null;
			}
			catch
			{
				font = Gnd.I.DEF_FONT;
			}
			return font;
		}

		// sync > @ PostShown

		public static void PostShown_GetAllControl(Form f, Action<Control> reaction)
		{
			Queue<Control.ControlCollection> controlTable = new Queue<Control.ControlCollection>();

			controlTable.Enqueue(f.Controls);

			while (1 <= controlTable.Count)
			{
				foreach (Control control in controlTable.Dequeue())
				{
					GroupBox gb = control as GroupBox;

					if (gb != null)
					{
						controlTable.Enqueue(gb.Controls);
					}
					TabControl tc = control as TabControl;

					if (tc != null)
					{
						foreach (TabPage tp in tc.TabPages)
						{
							controlTable.Enqueue(tp.Controls);
						}
					}
					SplitContainer sc = control as SplitContainer;

					if (sc != null)
					{
						controlTable.Enqueue(sc.Panel1.Controls);
						controlTable.Enqueue(sc.Panel2.Controls);
					}
					Panel p = control as Panel;

					if (p != null)
					{
						controlTable.Enqueue(p.Controls);
					}
					reaction(control);
				}
			}
		}

		public static void PostShown(Form f)
		{
			PostShown_GetAllControl(f, control =>
			{
				Control c = new Control[]
				{
					control as TextBox,
					control as NumericUpDown,
				}
				.FirstOrDefault(v => v != null);

				if (c != null)
				{
					if (c.ContextMenuStrip == null)
					{
						ContextMenuStrip menu = new ContextMenuStrip();

						{
							ToolStripMenuItem item = new ToolStripMenuItem();

#if false
							item.Text = "内容をクリップボードにコピー";
							item.Click += (sdr, ev) =>
							{
								try
								{
									Clipboard.SetText(c.Text ?? "");
								}
								catch
								{ }
							};
#else
							item.Text = "項目なし";
							item.Enabled = false;
#endif

							menu.Items.Add(item);
						}

						c.ContextMenuStrip = menu;
					}
				}
			});
		}

		// < sync

		public static IEnumerable<I4Rect> GetAllScreen()
		{
			foreach (Screen screen in Screen.AllScreens)
			{
				yield return new I4Rect()
				{
					L = screen.Bounds.Left,
					T = screen.Bounds.Top,
					W = screen.Bounds.Width,
					H = screen.Bounds.Height,
				};
			}
		}

		public static bool IsCrashed(I4Rect a, I4Rect b)
		{
			return
				a.L < b.R && b.L < a.R &&
				a.T < b.B && b.T < a.B;
		}

		public static I4Rect IntoScreen(I4Rect screen, I4Rect win)
		{
			if (screen.R < win.R)
				win.L = screen.R - win.W;

			if (win.L < screen.L)
				win.L = screen.L;

			if (screen.B < win.B)
				win.T = screen.B - win.H;

			if (win.T < screen.T)
				win.T = screen.T;

			return win;
		}
	}
}
