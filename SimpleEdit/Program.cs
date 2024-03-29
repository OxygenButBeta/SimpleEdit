namespace SimpleEdit
{
    internal static class Program
    {
        public static EditorConfig editor;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            editor = EditorConfig.ReadLocalSettings();
            ApplicationConfiguration.Initialize();
            Application.Run(new Editor());
        }
    }
}