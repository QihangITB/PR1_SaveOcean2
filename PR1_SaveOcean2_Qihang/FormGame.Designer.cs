namespace PR1_SaveOcean2_Qihang
{
    partial class FormGame
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
            lblMsgNarrator = new Label();
            groupBoxRescue = new GroupBox();
            dataGridRescue = new DataGridView();
            groupBoxAnimal = new GroupBox();
            dataGridAnimal = new DataGridView();
            lblMsgNarratorTwo = new Label();
            btnHome = new Button();
            btnHeal = new Button();
            btnMove = new Button();
            lblAffectation = new Label();
            groupBoxRescue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRescue).BeginInit();
            groupBoxAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAnimal).BeginInit();
            SuspendLayout();
            // 
            // lblMsgNarrator
            // 
            lblMsgNarrator.Font = new Font("Segoe UI", 14F);
            lblMsgNarrator.Location = new Point(25, 30);
            lblMsgNarrator.Name = "lblMsgNarrator";
            lblMsgNarrator.Size = new Size(732, 56);
            lblMsgNarrator.TabIndex = 0;
            lblMsgNarrator.Text = "Hello! The 112 has recieved a call of warning to rescue an animal. The information that they  give us is the next:";
            // 
            // groupBoxRescue
            // 
            groupBoxRescue.Controls.Add(dataGridRescue);
            groupBoxRescue.Font = new Font("Segoe UI", 15F);
            groupBoxRescue.Location = new Point(25, 99);
            groupBoxRescue.Name = "groupBoxRescue";
            groupBoxRescue.Size = new Size(732, 114);
            groupBoxRescue.TabIndex = 1;
            groupBoxRescue.TabStop = false;
            groupBoxRescue.Text = "Rescue Information";
            // 
            // dataGridRescue
            // 
            dataGridRescue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRescue.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridRescue.BackgroundColor = Color.White;
            dataGridRescue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRescue.Dock = DockStyle.Fill;
            dataGridRescue.Enabled = false;
            dataGridRescue.GridColor = SystemColors.GrayText;
            dataGridRescue.Location = new Point(3, 30);
            dataGridRescue.Name = "dataGridRescue";
            dataGridRescue.Size = new Size(726, 81);
            dataGridRescue.TabIndex = 0;
            // 
            // groupBoxAnimal
            // 
            groupBoxAnimal.Controls.Add(dataGridAnimal);
            groupBoxAnimal.Font = new Font("Segoe UI", 15F);
            groupBoxAnimal.Location = new Point(25, 219);
            groupBoxAnimal.Name = "groupBoxAnimal";
            groupBoxAnimal.Size = new Size(732, 114);
            groupBoxAnimal.TabIndex = 2;
            groupBoxAnimal.TabStop = false;
            groupBoxAnimal.Text = "Animal Data Sheet";
            // 
            // dataGridAnimal
            // 
            dataGridAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAnimal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridAnimal.BackgroundColor = Color.White;
            dataGridAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAnimal.Dock = DockStyle.Fill;
            dataGridAnimal.Enabled = false;
            dataGridAnimal.GridColor = SystemColors.GrayText;
            dataGridAnimal.Location = new Point(3, 30);
            dataGridAnimal.Name = "dataGridAnimal";
            dataGridAnimal.Size = new Size(726, 81);
            dataGridAnimal.TabIndex = 0;
            // 
            // lblMsgNarratorTwo
            // 
            lblMsgNarratorTwo.Font = new Font("Segoe UI", 14F);
            lblMsgNarratorTwo.Location = new Point(25, 342);
            lblMsgNarratorTwo.Name = "lblMsgNarratorTwo";
            lblMsgNarratorTwo.Size = new Size(732, 38);
            lblMsgNarratorTwo.TabIndex = 3;
            lblMsgNarratorTwo.Text = "You want to heal him here or move it to a medic center?";
            lblMsgNarratorTwo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(653, 446);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(101, 30);
            btnHome.TabIndex = 4;
            btnHome.Text = "Return";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnHeal
            // 
            btnHeal.Font = new Font("Segoe UI", 11F);
            btnHeal.Location = new Point(263, 411);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(112, 46);
            btnHeal.TabIndex = 5;
            btnHeal.Text = "HEAL";
            btnHeal.UseVisualStyleBackColor = true;
            btnHeal.Click += btnHeal_Click;
            // 
            // btnMove
            // 
            btnMove.Font = new Font("Segoe UI", 11F);
            btnMove.Location = new Point(401, 411);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(112, 46);
            btnMove.TabIndex = 6;
            btnMove.Text = "MOVE";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // lblAffectation
            // 
            lblAffectation.Font = new Font("Segoe UI", 12F);
            lblAffectation.ForeColor = Color.Red;
            lblAffectation.Location = new Point(25, 371);
            lblAffectation.Name = "lblAffectation";
            lblAffectation.Size = new Size(732, 37);
            lblAffectation.TabIndex = 7;
            lblAffectation.Text = "Affectation grade:";
            lblAffectation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(792, 488);
            Controls.Add(lblAffectation);
            Controls.Add(btnMove);
            Controls.Add(btnHeal);
            Controls.Add(btnHome);
            Controls.Add(lblMsgNarratorTwo);
            Controls.Add(groupBoxAnimal);
            Controls.Add(groupBoxRescue);
            Controls.Add(lblMsgNarrator);
            Name = "FormGame";
            Text = "Save the Ocean! 2 (Game)";
            Load += FormGame_Load;
            groupBoxRescue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridRescue).EndInit();
            groupBoxAnimal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAnimal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMsgNarrator;
        private GroupBox groupBoxRescue;
        private DataGridView dataGridRescue;
        private GroupBox groupBoxAnimal;
        private DataGridView dataGridAnimal;
        private Label lblMsgNarratorTwo;
        private Button btnHome;
        private Button btnHeal;
        private Button btnMove;
        private Label lblAffectation;
    }
}