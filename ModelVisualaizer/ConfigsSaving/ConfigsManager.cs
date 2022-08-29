using System;
using System.Windows.Forms;

namespace ModelVisualaizer
{
    public static class ConfigsManager
    {
        private static readonly XmlObjectSerializer serializer = new XmlObjectSerializer();
        private static readonly FileBlobStorage storage = new FileBlobStorage();

        public static SaveFileDialog ConfigSaveDialog = new SaveFileDialog
        {
            DefaultExt = "xml",
            FileName = "config.xml",
            Filter = "Config (*.xml)|*.xml"
        };

        public static OpenFileDialog ConfigLoadDialog = new OpenFileDialog
        {
            DefaultExt = "xml",
            FileName = "config.xml",
            Filter = "Config (*.xml)|*.xml"
        };


        public static PositionsConfig LoadPos(string fileName)
        {
            return Load<PositionsConfig>(fileName);
        }

        public static SegmentsParametersConfig LoadParams(string fileName)
        {
            return Load<SegmentsParametersConfig>(fileName);
        }

        public static SettingsConfig LoadBaseSettings(string fileName)
        {
            return Load<SettingsConfig>(fileName);
        }

        private static T Load<T>(string fileName)
        {
            try
            {
                var data = storage.Get(fileName);
                if (data != null)
                    return serializer.Deserialize<T>(data);
                throw new Exception();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "не удалось загрузить настройки");
                return default(T);
            }
        }

        public static void Save<T>(T config, string fileName)
        {
            storage.Set(fileName, serializer.Serialize(config));
        }
    }
}