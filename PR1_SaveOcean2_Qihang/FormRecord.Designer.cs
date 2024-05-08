namespace PR1_SaveOcean2_Qihang
{
    partial class FormRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dataGridRecord = new DataGridView();
            lblCode = new Label();
            groupBoxRescue = new GroupBox();
            lblLocation = new Label();
            lblAG = new Label();
            lblAnimal = new Label();
            lblDate = new Label();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridRecord).BeginInit();
            groupBoxRescue.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F);
            lblTitle.Location = new Point(38, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(486, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Here is the game history:";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridRecord
            // 
            dataGridRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRecord.Location = new Point(55, 73);
            dataGridRecord.Name = "dataGridRecord";
            dataGridRecord.Size = new Size(161, 227);
            dataGridRecord.TabIndex = 1;
            dataGridRecord.CellClick += dataGridRecord_CellClick;
            // 
            // lblCode
            // 
            lblCode.Font = new Font("Segoe UI", 10F);
            lblCode.Location = new Point(21, 41);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(218, 23);
            lblCode.TabIndex = 2;
            lblCode.Text = "Code:";
            lblCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxRescue
            // 
            groupBoxRescue.Controls.Add(lblLocation);
            groupBoxRescue.Controls.Add(lblAG);
            groupBoxRescue.Controls.Add(lblAnimal);
            groupBoxRescue.Controls.Add(lblDate);
            groupBoxRescue.Controls.Add(lblCode);
            groupBoxRescue.Font = new Font("Segoe UI", 12F);
            groupBoxRescue.Location = new Point(254, 62);
            groupBoxRescue.Name = "groupBoxRescue";
            groupBoxRescue.Size = new Size(261, 238);
            groupBoxRescue.TabIndex = 3;
            groupBoxRescue.TabStop = false;
            groupBoxRescue.Text = "Rescue Data";
            // 
            // lblLocation
            // 
            lblLocation.Font = new Font("Segoe UI", 10F);
            lblLocation.Location = new Point(21, 181);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(218, 25);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location:";
            lblLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAG
            // 
            lblAG.Font = new Font("Segoe UI", 10F);
            lblAG.Location = new Point(21, 145);
            lblAG.Name = "lblAG";
            lblAG.Size = new Size(218, 25);
            lblAG.TabIndex = 5;
            lblAG.Text = "Affectation:";
            lblAG.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAnimal
            // 
            lblAnimal.Font = new Font("Segoe UI", 10F);
            lblAnimal.Location = new Point(21, 109);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(218, 23);
            lblAnimal.TabIndex = 4;
            lblAnimal.Text = "Animal:";
            lblAnimal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.Location = new Point(21, 75);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(218, 23);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date:";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(455, 319);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 33);
            btnHome.TabIndex = 4;
            btnHome.Text = "Return";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // FormRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(564, 364);
            Controls.Add(btnHome);
            Controls.Add(groupBoxRescue);
            Controls.Add(dataGridRecord);
            Controls.Add(lblTitle);
            Name = "FormRecord";
            Text = "Game history";
            Load += FormRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridRecord).EndInit();
            groupBoxRescue.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private DataGridView dataGridRecord;
        private Label lblCode;
        private GroupBox groupBoxRescue;
        private Label lblLocation;
        private Label lblAG;
        private Label lblAnimal;
        private Label lblDate;
        private Button btnHome;
    }
}