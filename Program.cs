using System;
using System.IO;
using System.Windows.Forms;

namespace MoneyControl
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }

    /// <summary>
    /// Клас для збереження тексту запиту.
    /// </summary>
    static class Query
    {
        public static string queryText;
    }

    static class Options
    {
        public static int windowNumber = 1;
        public static string password;
        public static int saveMode = 1;
        public static bool allowAddRows = true;
        public static bool allowDeleteRows = true;

        public static void SaveOptions()
        {
            if (!File.Exists("config.bin"))
                File.Create("config.bin");

            using (var fs = new FileStream("config.bin", FileMode.Create))
            {
                using (var bw = new BinaryWriter(fs))
                {
                    bw.Write(Options.saveMode);
                    bw.Write(Options.allowAddRows);
                    bw.Write(Options.allowDeleteRows);
                    if (Options.password != null)
                        bw.Write(Options.password);
                    bw.Close();
                }
                fs.Close();
            }
        }

        public static void LoadOptions()
        {
            using (var fs = new FileStream("config.bin", FileMode.Open))
            {
                using (var br = new BinaryReader(fs))
                {
                    Options.saveMode = br.ReadInt32();
                    Options.allowAddRows = br.ReadBoolean();
                    Options.allowDeleteRows = br.ReadBoolean();
                    try
                    {
                        Options.password = br.ReadString();
                    }
                    catch (Exception)
                    {
                        Options.password = null;
                    }
                    br.Close();
                }
                fs.Close();
            }
        }
    }
}
