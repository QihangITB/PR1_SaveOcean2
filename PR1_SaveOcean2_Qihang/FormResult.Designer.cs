namespace PR1_SaveOcean2_Qihang
{
    partial class FormResult
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
            lblResult = new Label();
            btnSave = new Button();
            lblAffectation = new Label();
            lblExperience = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 20F);
            lblResult.Location = new Point(12, 31);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(534, 76);
            lblResult.TabIndex = 0;
            lblResult.Text = "CONGRATULATIONS, IT HAS BEEN A SUCCES";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(224, 188);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblAffectation
            // 
            lblAffectation.Font = new Font("Segoe UI", 12F);
            lblAffectation.Location = new Point(12, 120);
            lblAffectation.Name = "lblAffectation";
            lblAffectation.Size = new Size(534, 28);
            lblAffectation.TabIndex = 2;
            lblAffectation.Text = "Affectation grade:";
            lblAffectation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExperience
            // 
            lblExperience.Font = new Font("Segoe UI", 12F);
            lblExperience.Location = new Point(12, 148);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(534, 28);
            lblExperience.TabIndex = 3;
            lblExperience.Text = "Player experience:";
            lblExperience.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 250);
            Controls.Add(lblExperience);
            Controls.Add(lblAffectation);
            Controls.Add(btnSave);
            Controls.Add(lblResult);
            Name = "FormResult";
            Text = "Game result";
            Load += FormResult_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblResult;
        private Button btnSave;
        private Label lblAffectation;
        private Label lblExperience;
    }
}