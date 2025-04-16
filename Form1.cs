using System;
using System.Drawing;
using System.Windows.Forms;

namespace N15__YP__Task_5_16._04._2025
{
    public partial class Form1 : Form
    {
        private Color currentBackColor = SystemColors.Control; // ������� ���� ����

        public Form1()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1; // �������� ������������ ���� � �����
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����� ����� ��� ��������� ����� ����� ���������� ������
            if (sender is ToolStripComboBox comboBox && comboBox.SelectedItem != null)
            {
                switch (comboBox.SelectedItem.ToString())
                {
                    case "�����":
                        BackColor = Color.White;
                        break;
                    case "�������":
                        BackColor = Color.Red;
                        break;
                    case "������":
                        BackColor = Color.Black;
                        break;
                    case "�����":
                        BackColor = Color.Blue;
                        break;
                    case "������":
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