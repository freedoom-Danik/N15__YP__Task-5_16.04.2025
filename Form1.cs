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

        private void textBoxRGB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // �������� �������� �� ��������� �����
                int red = string.IsNullOrEmpty(toolStripTextBox1.Text) ? 0 : Convert.ToInt32(toolStripTextBox1.Text);
                int green = string.IsNullOrEmpty(toolStripTextBox2.Text) ? 0 : Convert.ToInt32(toolStripTextBox2.Text);
                int blue = string.IsNullOrEmpty(toolStripTextBox3.Text) ? 0 : Convert.ToInt32(toolStripTextBox3.Text);

                // ���������, ��� ��� ���� ���������
                if (string.IsNullOrEmpty(toolStripTextBox1.Text) ||
                    string.IsNullOrEmpty(toolStripTextBox2.Text) ||
                    string.IsNullOrEmpty(toolStripTextBox3.Text))
                {
                    return; // ���� �����-���� ���� ������, ������ �� ������
                }

                // ��������� �������� ��������
                if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
                {
                    throw new ArgumentException("�������� ������ ���� � ��������� �� 0 �� 255");
                }

                // ��������� ���� ����
                currentBackColor = Color.FromArgb(red, green, blue);
                BackColor = currentBackColor;
            }
            catch (Exception ex)
            {
                // ��� ������ ���������� ��������� � ��������� ���������� ����
                MessageBox.Show($"������: {ex.Message}", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BackColor = currentBackColor; // ���������� ���������� ����
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