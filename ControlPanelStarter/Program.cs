using System.Diagnostics;

namespace ControlPanelStarter
{
  /// <summary>
  /// Help solve the problem of Control Panel view settings not being stored if it's
  /// pinned to start menu.
  /// Simple solution is to build a regular application that can be installed
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      Process.Start("control.exe");
    }
  }
}
