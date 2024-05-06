namespace PR1_SaveOcean2_Qihang
{
    partial class FormRegister
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
            components = new System.ComponentModel.Container();
            labelMsgRole = new Label();
            btnTechnical = new Button();
            btnVet = new Button();
            lblMsgName = new Label();
            txtName = new TextBox();
            errorName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorName).BeginInit();
            SuspendLayout();
            // 
            // labelMsgRole
            // 
            labelMsgRole.AutoSize = true;
            labelMsgRole.Font = new Font("Segoe UI", 15F);
            labelMsgRole.Location = new Point(37, 157);
            labelMsgRole.Name = "labelMsgRole";
            labelMsgRole.Size = new Size(165, 28);
            labelMsgRole.TabIndex = 0;
            labelMsgRole.Text = "Choose your role:";
            // 
            // btnTechnical
            // 
            btnTechnical.Location = new Point(37, 200);
            btnTechnical.Name = "btnTechnical";
            btnTechnical.Size = new Size(111, 44);
            btnTechnical.TabIndex = 1;
            btnTechnical.Text = "Technical";
            btnTechnical.UseVisualStyleBackColor = true;
            btnTechnical.Click += btnTechnical_Click;
            // 
            // btnVet
            // 
            btnVet.Location = new Point(168, 200);
            btnVet.Name = "btnVet";
            btnVet.Size = new Size(111, 44);
            btnVet.TabIndex = 2;
            btnVet.Text = "Vet";
            btnVet.UseVisualStyleBackColor = true;
            btnVet.Click += btnVet_Click;
            // 
            // lblMsgName
            // 
            lblMsgName.AutoSize = true;
            lblMsgName.Font = new Font("Segoe UI", 15F);
            lblMsgName.Location = new Point(37, 38);
            lblMsgName.Name = "lblMsgName";
            lblMsgName.Size = new Size(163, 28);
            lblMsgName.TabIndex = 3;
            lblMsgName.Text = "Enter your Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F);
            txtName.Location = new Point(37, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 34);
            txtName.TabIndex = 4;
            txtName.Validating += txtName_Validating;
            // 
            // errorName
            // 
            errorName.ContainerControl = this;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(320, 285);
            Controls.Add(txtName);
            Controls.Add(lblMsgName);
            Controls.Add(btnVet);
            Controls.Add(btnTechnical);
            Controls.Add(labelMsgRole);
            Name = "FormRegister";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)errorName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMsgRole;
        private Button btnTechnical;
        private Button btnVet;
        private Label lblMsgName;
        private TextBox txtName;
        private ErrorProvider errorName;
    }
}