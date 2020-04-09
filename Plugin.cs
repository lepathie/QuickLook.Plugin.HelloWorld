using System.IO;
using System.Windows;
using System.Windows.Controls;
using QuickLook.Common.Plugin;

namespace QuickLook.Plugin.UrlViewer
{
    public class Plugin : IViewer
    {
        public int Priority => 1;

        public void Init()
        {
        }

        public bool CanHandle(string path)
        {
            return !Directory.Exists(path) && path.ToLower().EndsWith(".url");
        }

        public void Prepare(string path, ContextObject context)
        {
            context.PreferredSize = new Size { Width = 368, Height = 508.167 };
            context.CanResize = false;
        }

        public void View(string path, ContextObject context)
        {
            var launcher = new Launcher();

            context.ViewerContent = launcher;
            context.Title = $"{Path.GetFileName(path)}";

            context.IsBusy = false;
        }

        public void Cleanup()
        {
        }
    }
}