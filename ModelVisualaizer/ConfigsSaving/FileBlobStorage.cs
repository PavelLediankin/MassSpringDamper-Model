using System.IO;

namespace ModelVisualaizer
{
    public class FileBlobStorage
    {
        public byte[] Get(string name)
        {
            return File.Exists(name) ? File.ReadAllBytes(name) : null;
        }

        public void Set(string name, byte[] content)
        {
            File.WriteAllBytes(name, content);
        }
    }
}