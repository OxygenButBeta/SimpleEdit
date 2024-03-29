using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SimpleEdit
{
    public class EditorConfig
    {
        #region Properties
        private const string SettingsFilePath = "Editor.jconfig";
        public float PreviewScale { get; set; } = 0.5f;
        public bool DrawCursorGrid { get; set; } = false;
        public Color CursorLineColor { get; set; } = ColorTranslator.FromHtml("#000000");
        public int CursorLineTickness { get; set; } = 1;
        public bool AutoPreviewScale { get; set; } = true;
        public PictureBoxSizeMode CanvasSizeMode { get; set; } = PictureBoxSizeMode.Zoom;
        public Color CanvasBackgroundColor { get; set; } = Color.White;
        public string LastFilePath { get; set; } = string.Empty;
        #endregion

        #region IO
        public static EditorConfig ReadLocalSettings()
        {
            if (!File.Exists(SettingsFilePath))
                return new EditorConfig();

            using (var sr = new StreamReader(SettingsFilePath))
            {
                var editor = JsonConvert.DeserializeObject<EditorConfig>(sr.ReadToEnd());
                sr.Close();
                return editor;
            }
        }
        public static void SaveToLocal(EditorConfig editor)
        {
            using (var sw = new StreamWriter(SettingsFilePath))
            {
                sw.Write(JsonConvert.SerializeObject(editor));
                sw.Close();
            }
        }
        #endregion
    }

}
