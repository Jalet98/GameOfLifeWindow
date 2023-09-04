using GoLLibrary;
using System.Diagnostics;

namespace GameOfLife
{
    public partial class GameOfLifeUi : Form
    {
        private bool[,] boolArray;
        public GameOfLifeUi()
        {
            InitializeComponent();

            boolArray = life.reality.field;
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            StartStop = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            globlBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)globlBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(908, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 28);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(908, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 28);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(908, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 28);
            textBox3.TabIndex = 2;
            // 
            // StartStop
            // 
            StartStop.Location = new Point(908, 581);
            StartStop.Name = "StartStop";
            StartStop.Size = new Size(100, 43);
            StartStop.TabIndex = 3;
            StartStop.Text = "Start";
            StartStop.UseVisualStyleBackColor = true;
            StartStop.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(821, 76);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(821, 132);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(821, 187);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "delay";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1014, 187);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 7;
            label4.Text = "ms";
            // 
            // globlBindingSource
            // 
            globlBindingSource.DataSource = typeof(globl);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.Size = new Size(805, 655);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // GameOfLifeUi
            // 
            BackColor = Color.DimGray;
            ClientSize = new Size(1077, 655);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartStop);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameOfLifeUi";
            ShowIcon = false;
            Text = "game of life";
            ((System.ComponentModel.ISupportInitialize)globlBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PopulateDataGridView()
        {
            // Set the number of rows and columns in the DataGridView
            dataGridView1.RowCount = life.numRows;
            dataGridView1.ColumnCount = life.numCols;

            for (int j = 0; j < life.numCols; j++)
            {
                for (int i = 0; i < life.numRows; i++)
                {
                    // Set cell value (True/False)
                    dataGridView1[j, i].Value = life.reality.field[i, j];

                    // Set cell background color
                    dataGridView1[j, i].Style.BackColor = life.reality.field[i, j] ? System.Drawing.Color.White : System.Drawing.Color.Black;
                    DataGridViewCell cell = dataGridView1.Rows[i].Cells[j];
                    cell.Style.ForeColor = cell.Style.BackColor;

                }
                dataGridView1.Columns[j].Width = 20;
            }
        }

        private Thread loopThread;




        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private BindingSource globlBindingSource;
        private System.ComponentModel.IContainer components;
        private DataGridView dataGridView1;
        private Button StartStop;
        private void StartLoop()
        {
            /*
            var watch = Stopwatch.StartNew();
            for (int gk = 0; gk < 1000; gk++)
            {
                life.pass();
                PopulateDataGridView();
                
            }
            watch.Stop();
            MessageBox.Show($"the execution time of the program is:{watch.ElapsedMilliseconds}ms");
            */

            while (life.running)
            {
                life.pass();
                PopulateDataGridView();

                Thread.Sleep(life.delay);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!life.running)
            {
                life.running = true;
                try
                {
                    life.delay = Convert.ToInt32(textBox3.Text);
                }
                catch { }

                loopThread = new Thread(StartLoop);
                loopThread.Start();

                StartStop.Text = "Stop";
            }
            else
            {
                life.running = false;
                loopThread.Join(); // Wait for the loop thread to finish
                StartStop.Text = "Start";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Rowmaybe = Convert.ToInt32(textBox1.Text);
                int Colmaybe = Convert.ToInt32(textBox2.Text);
                life.initiateField(Rowmaybe, Colmaybe);
                PopulateDataGridView();
            }
            catch { };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Rowmaybe = Convert.ToInt32(textBox1.Text);
                int Colmaybe = Convert.ToInt32(textBox2.Text);
                life.initiateField(Rowmaybe, Colmaybe);
                PopulateDataGridView();
            }
            catch { };
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!life.running)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;
                life.reality.field[rowIndex, columnIndex] = !life.reality.field[rowIndex, columnIndex];
                PopulateDataGridView();
            }
            dataGridView1.ClearSelection();
        }

    }
}