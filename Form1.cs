using System;
using System.Drawing;
using System.Windows.Forms;

namespace N15__YP__Task_5_16._04._2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ����������� ContextMenuStrip ����� ��� ������ ����� ���
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedItem?.ToString())
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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // ���������, ��� ��� ���� ���������
                if (string.IsNullOrEmpty(toolStripTextBox1.Text) ||
                    string.IsNullOrEmpty(toolStripTextBox2.Text) ||
                    string.IsNullOrEmpty(toolStripTextBox3.Text))
                {
                    return; // ���� �����-���� ���� ������, ������� �� ������
                }

                int red = Convert.ToInt32(toolStripTextBox1.Text);
                int green = Convert.ToInt32(toolStripTextBox2.Text);
                int blue = Convert.ToInt32(toolStripTextBox3.Text);

                if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
                {
                    throw new ArgumentException("�������� ������ ���� � ��������� �� 0 �� 255");
                }

                BackColor = Color.FromArgb(red, green, blue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ���������� ����������� ���� ���� ��� ������
                BackColor = SystemColors.Control;
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