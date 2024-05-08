namespace PR1_SaveOcean2_Qihang
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGameTitle = new Label();
            btnPlay = new Button();
            btnExit = new Button();
            btnEdit = new Button();
            btnHistorial = new Button();
            SuspendLayout();
            // 
            // lblGameTitle
            // 
            lblGameTitle.AutoSize = true;
            lblGameTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblGameTitle.ForeColor = Color.CornflowerBlue;
            lblGameTitle.Location = new Point(126, 65);
            lblGameTitle.Name = "lblGameTitle";
            lblGameTitle.Size = new Size(400, 54);
            lblGameTitle.TabIndex = 0;
            lblGameTitle.Text = "SAVE THE OCEAN! 2";
            lblGameTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 15F);
            btnPlay.Location = new Point(250, 155);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(145, 40);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.Location = new Point(250, 293);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 15F);
            btnEdit.Location = new Point(250, 201);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 40);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Font = new Font("Segoe UI", 15F);
            btnHistorial.Location = new Point(250, 247);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(145, 40);
            btnHistorial.TabIndex = 4;
            btnHistorial.Text = "RECORD";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = PR1_SaveOcean2_Qihang.Properties.Resources.ocean;
            ClientSize = new Size(656, 378);
            Controls.Add(btnHistorial);
            Controls.Add(btnEdit);
            Controls.Add(btnExit);
            Controls.Add(btnPlay);
            Controls.Add(lblGameTitle);
            Name = "FormMenu";
            Text = "Save the Ocean! 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameTitle;
        private Button btnPlay;
        private Button btnExit;
        private Button btnEdit;
        private Button btnHistorial;
    }
}
