namespace TeamExplorerExtSample
{
	using System;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Drawing;
	using Microsoft.TeamFoundation.Controls;

	[TeamExplorerNavigationItem("C9B2CF74-0C87-4CEA-ACA9-8CC1C816D7F3", 1800)]
	public class NotepadNavigationItem : ITeamExplorerNavigationItem2
	{
		public bool IsEnabled => true;

		public int ArgbColor => 0;

		public object Icon => null;

		public string Text => "Open Notepad";

		public Image Image => null;

		public bool IsVisible => true;

		public event PropertyChangedEventHandler PropertyChanged;

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Execute()
		{
			Process.Start("notepad.exe");
		}

		public void Invalidate()
		{
		}
	}
}