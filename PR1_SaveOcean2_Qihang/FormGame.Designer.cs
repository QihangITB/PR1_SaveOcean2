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
            dataGridView1 = new DataGridView();
            groupBoxRescue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMsgNarrator
            // 
            lblMsgNarrator.Font = new Font("Segoe UI", 14F);
            lblMsgNarrator.Location = new Point(25, 30);
            lblMsgNarrator.Name = "lblMsgNarrator";
            lblMsgNarrator.Size = new Size(732, 64);
            lblMsgNarrator.TabIndex = 0;
            lblMsgNarrator.Text = "Hello! The 112 has recieved a call of warning to rescue an animal. The information that they  give us is the next:";
            // 
            // groupBoxRescue
            // 
            groupBoxRescue.Controls.Add(dataGridView1);
            groupBoxRescue.Font = new Font("Segoe UI", 20F);
            groupBoxRescue.Location = new Point(25, 114);
            groupBoxRescue.Name = "groupBoxRescue";
            groupBoxRescue.Size = new Size(732, 182);
            groupBoxRescue.TabIndex = 1;
            groupBoxRescue.TabStop = false;
            groupBoxRescue.Text = "Rescue Information";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(694, 107);
            dataGridView1.TabIndex = 0;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRescue);
            Controls.Add(lblMsgNarrator);
            Name = "FormGame";
            Text = "Save the Ocean! 2 (Game)";
            Load += FormGame_Load;
            groupBoxRescue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMsgNarrator;
        private GroupBox groupBoxRescue;
        private DataGridView dataGridView1;
    }
}