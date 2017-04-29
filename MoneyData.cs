using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MoneyControl
{
    static class MoneyData
    {
        /// <summary>
        /// Завантаження даних з файлу формату CSV.
        /// </summary>
        public static void Load(DataGridView dgv)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Відкриття файлу...";
                openFileDialog.Filter = "CSV-файл|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        using (var sr = new StreamReader(fs, Encoding.UTF8))
                        {
                            sr.ReadLine();
                            while (!sr.EndOfStream)
                            {
                                var str = sr.ReadLine().Split(';');
                                //дороби! не хоче додавати, бо таблиця прив'язана до БД
                                //dgv.Rows.Add(Convert.ToDateTime(str[0]), Convert.ToString(str[1]), Convert.ToDecimal(str[2]));
                            }
                            sr.Close();
                        }
                        fs.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Збереження даних у файл з форматом CSV, TXT, HTML.
        /// </summary>
        public static void Save(DataGridView dgv)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Збереження файлу...";
                saveFileDialog.Filter = "CSV-файл|*.csv|Текстовий файл |*.txt|HTML-файл|*.html";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        using (var sw = new StreamWriter(fs, Encoding.UTF8))
                        {
                            var data = dgv.Rows;
                            int position = 1;

                            switch (saveFileDialog.FilterIndex)
                            {
                                case 1: //csv

                                    sw.WriteLine("Дата і час;Об'єкт(и);Потрачено");

                                    foreach (DataGridViewRow item in data)
                                    {
                                        if (item.Cells[0].Value != null)
                                        {
                                            sw.WriteLine(item.Cells[0].Value.ToString() + ";" +
                                                item.Cells[1].Value.ToString() + ";" +
                                                item.Cells[2].Value.ToString());
                                        }
                                    }
                                    break;

                                case 2: //txt

                                    sw.WriteLine("№. Дата і час ### Об'єкт(и) ### Потрачено");

                                    foreach (DataGridViewRow item in data)
                                    {
                                        if (item.Cells[0].Value != null)
                                        {
                                            sw.WriteLine(position.ToString() + ". " + item.Cells[0].Value.ToString() +
                                            " ### " + item.Cells[1].Value.ToString() + " ### " + item.Cells[2].Value.ToString());
                                            position++;
                                        }
                                    }
                                    break;
                                case 3: //html

                                    sw.WriteLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/></head><body><table border=\"1\" style=\"width:98%;\">");
                                    sw.WriteLine("<tr><td>Номер п/п</td><td>Дата і час</td><td>Об'єкт(и)</td><td>Потрачено</td></tr>");

                                    foreach (DataGridViewRow item in data)
                                    {
                                        if (item.Cells[0].Value != null)
                                        {
                                            sw.WriteLine("<tr><td>" + position.ToString() + "</td><td>" + item.Cells[0].Value.ToString() +
                                            "</td><td>" + item.Cells[1].Value.ToString() + "</td><td>" + item.Cells[2].Value.ToString() + "</td></tr>");
                                            position++;
                                        }
                                    }

                                    sw.WriteLine("</table></body></hyml>");
                                    break;
                            }
                            sw.Close();
                        }
                        fs.Close();
                    }
                }
            }
        }
    }
}
