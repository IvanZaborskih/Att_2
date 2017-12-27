using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace _9._2._15_46_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Задаём начальные пути для диалогов открытия/сохранения файла
            this.LoadFileDialog.InitialDirectory = Environment.CurrentDirectory;
            this.SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            DataGridViewUtils.InitGridForArr(inputDataGridView, 40, false, true, true, true, true);
           // DataGridViewUtils.InitGridForArr(outputDataGridView, 40, true, true, true, true, true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs ev)
        {
            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Читаем содержимое выбранного файла и преобразуем его в массив
                    string arrText = FilesUtils.Read(LoadFileDialog.FileName);
                    int[,] arr = DataConverter.StrToArray2D<int>(arrText);

                    // Копируем полученный массив в DataGridView
                    DataGridViewUtils.Array2ToGrid(inputDataGridView, arr);

                    MessagesUtils.Show("Данные загружены");
                }
                catch (Exception e)
                {
                    MessagesUtils.ShowError("Ошибка загрузки данных");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs ev)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Преобразуем содержимое DataGridView в массив
                    int[,] arr = DataGridViewUtils.GridToArray2<int>(inputDataGridView);

                    // Записываем полученный массив в файл, предварительно
                    // преобразовав его в строку
                    FilesUtils.Write(SaveFileDialog.FileName, DataConverter.Array2DToStr<int>(arr));

                    MessagesUtils.Show("Данные сохранены");
                }
                catch (Exception e)
                {
                    MessagesUtils.ShowError("Ошибка сохранения данных");
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                // Преобразуем содержимое нашего DataGridView в массив
                int[,] arr = DataGridViewUtils.GridToArray2<int>(inputDataGridView);
                // Создаём объект класса Array2DUtils для выполнения
                // различных операций над двумерными массивами
                WorkWith2DArrays arrayUtils = new WorkWith2DArrays(arr);
                outputText.Text = arrayUtils.AmountOfEven(arr);
            }
            catch (Exception exc)
            {
                // Если во время выполнения действий с массивом произошла ошибка,
                // то выводим её текст
                MessagesUtils.ShowError(exc.Message);
            }
        }
    }
}
