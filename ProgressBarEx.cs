using System.Runtime.InteropServices;

namespace DisksizeWatcher
{
	/// <summary>
	/// Provides extended functionality for the ProgressBar control.
	/// </summary>
	internal static class ProgressBarEx
	{
		/// <summary>
		/// User-defined message base value.
		/// </summary>
		private const int WM_USER = 0x400;

		/// <summary>
		/// Message to set the state of the ProgressBar.
		/// </summary>
		private const int PBM_SETSTATE = WM_USER + 16;

		/// <summary>
		/// Message to get the state of the ProgressBar.
		/// </summary>
		private const int PBM_GETSTATE = WM_USER + 17;

		/// <summary>
		/// Sends a message to the specified window.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose window procedure will receive the message.</param>
		/// <param name="Msg">The message to be sent.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport(dllName: "user32.dll", CharSet = CharSet.Unicode)]
		private static extern nint SendMessage(nint hWnd, uint Msg, nint wParam, nint lParam);

		/// <summary>
		/// Represents the state of the ProgressBar.
		/// </summary>
		public enum ProgressBarStateEnum : int
		{
			Normal = 1,
			Error = 2,
			Paused = 3,
		}

		/// <summary>
		/// Gets the current state of the ProgressBar.
		/// </summary>
		/// <param name="pBar">The ProgressBar control.</param>
		/// <returns>The current state of the ProgressBar.</returns>
		public static ProgressBarStateEnum GetState(this ProgressBar pBar)
		{
			return (ProgressBarStateEnum)(int)SendMessage(hWnd: pBar.Handle, Msg: PBM_GETSTATE, wParam: IntPtr.Zero, lParam: IntPtr.Zero);
		}

		/// <summary>
		/// Sets the state of the ProgressBar.
		/// </summary>
		/// <param name="pBar">The ProgressBar control.</param>
		/// <param name="state">The state to set.</param>
		public static void SetState(this ProgressBar pBar, ProgressBarStateEnum state)
		{
			_ = SendMessage(hWnd: pBar.Handle, Msg: PBM_SETSTATE, wParam: (IntPtr)state, lParam: IntPtr.Zero);
		}
	}
}
