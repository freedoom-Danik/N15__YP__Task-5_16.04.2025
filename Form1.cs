using System;
using System.Drawing;
using System.Windows.Forms;

namespace N15__YP__Task_5_16._04._2025
{
    public partial class Form1 : Form
    {
        private Color currentBackColor = SystemColors.Control; // Текущий цвет фона

        public Form1()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1; // Привязка контекстного меню к форме
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Общий метод для изменения цвета через выпадающий список
            if (sender is ToolStripComboBox comboBox && comboBox.SelectedItem != null)
            {
                switch (comboBox.SelectedItem.ToString())
                {
                    case "белый":
                        BackColor = Color.White;
                        break;
                    case "красный":
                        BackColor = Color.Red;
                        break;
                    case "черный":
                        BackColor = Color.Black;
                        break;
                    case "синий":
                        BackColor = Color.Blue;
                        break;
                    case "желтый":
                        BackColor = Color.Yellow;
                        break;
                    default:
                        BackColor = SystemColors.Control;
                        break;
                }
            }
        }

        private void textBoxRGB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                int red = string.IsNullOrEmpty(toolStripTextBox1.Text) ? 0 : Convert.ToInt32(toolStripTextBox1.Text);
                int green = string.IsNullOrEmpty(toolStripTextBox2.Text) ? 0 : Convert.ToInt32(toolStripTextBox2.Text);
                int blue = string.IsNullOrEmpty(toolStripTextBox3.Text) ? 0 : Convert.ToInt32(toolStripTextBox3.Text);

                // Проверяем, что все поля заполнены
                if (string.IsNullOrEmpty(toolStripTextBox1.Text) ||
                    string.IsNullOrEmpty(toolStripTextBox2.Text) ||
                    string.IsNullOrEmpty(toolStripTextBox3.Text))
                {
                    return; // Если какое-либо поле пустое, ничего не делаем
                }

                // Проверяем диапазон значений
                if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
                {
                    throw new ArgumentException("Значения должны быть в диапазоне от 0 до 255");
                }

                // Обновляем цвет фона
                currentBackColor = Color.FromArgb(red, green, blue);
                BackColor = currentBackColor;
            }
            catch (Exception ex)
            {
                // При ошибке показываем сообщение и сохраняем предыдущий цвет
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BackColor = currentBackColor; // Возвращаем предыдущий цвет
            }
        }

        private void toolStripMenuItemRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void toolStripMenuItemGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void toolStripMenuItemBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}