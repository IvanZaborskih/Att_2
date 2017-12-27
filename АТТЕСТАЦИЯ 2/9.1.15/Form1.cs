using System;
using System.Windows.Forms;
using BL;
using Utils;

namespace _9._1._15
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
            DataGridViewUtils.InitGridForArr(outputDataGridView, 40, true, true, true, true, true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Matrix obj = new Matrix(DataGridViewUtils.GridToArray2<int>(inputDataGridView));
            int[,] ansMatrix = obj.Sdvig(Convert.ToInt32(nTextBox.Text));
            DataGridViewUtils.Array2ToGrid<int>(outputDataGridView, ansMatrix);
        }

        private void MainMeneFileOpen_Click(object sender, EventArgs ev)
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

        private void MainMeneFileClose_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }

        private void MainMeneFileSave_Click(object sender, EventArgs ev)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Преобразуем содержимое DataGridView в массив
                    int[,] arr = DataGridViewUtils.GridToArray2<int>(outputDataGridView);

                    // Записываем полученный массив в файл, предварительно
                    // преобразовав его в строку
                    FilesUtils.Write(SaveFileDialog.FileName, DataConverter.Array2DToStr<int>(arr));

                    MessagesUtils.Show("Данные сохранены");
                }
                catch (Exception e) {
                    MessagesUtils.ShowError("Ошибка сохранения данных");
                }
            }
        }
    }
}
