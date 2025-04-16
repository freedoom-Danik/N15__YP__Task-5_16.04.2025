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