namespace ArduinoDebugTool
{
    using System.Drawing;
    using System.IO;

    internal class Resources
    {
        private static Bitmap _logoHan;

        internal static Bitmap logo_han
        {
            get
            {
                if (_logoHan == null)
                {
                    string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo_han.ico");
                    if (File.Exists(logoPath))
                    {
                        using (var icon = new Icon(logoPath))
                        {
                            _logoHan = icon.ToBitmap();
                        }
                    }
                }
                return _logoHan;
            }
        }
    }
}
