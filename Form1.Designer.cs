
namespace ToDoList
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panel1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 296);

            textBox1.Location = new Point(14, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "İşin başlığı";
            textBox1.Size = new Size(647, 27);

            textBox2.Location = new Point(14, 62);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "İşin təsviri";
            textBox2.Size = new Size(647, 27);

            dateTimePicker1.Location = new Point(14, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(647, 27);

            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(14, 170);
            button1.Name = "button1";
            button1.Size = new Size(647, 55);
            button1.Text = "Əlavə Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(0, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 212);

            Column1.HeaderText = "İşin başlanğıcı";
            Column1.Width = 150;

            Column2.HeaderText = "İşin təsviri";
            Column2.Width = 150;

            Column3.HeaderText = "Tarix";
            Column3.Width = 150;

            Column4.HeaderText = "Tamamlanmış";
            Column4.Width = 150;

            ClientSize = new Size(700, 550);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "To Do List";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}
