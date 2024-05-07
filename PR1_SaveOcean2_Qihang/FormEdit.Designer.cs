namespace PR1_SaveOcean2_Qihang
{
    partial class FormEdit
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
            dataGridAnimals = new DataGridView();
            labelMsgDB = new Label();
            btnHome = new Button();
            btnAdd = new Button();
            btnModify = new Button();
            groupBoxEdition = new GroupBox();
            comboFamily = new ComboBox();
            txtWeight = new TextBox();
            txtSpecies = new TextBox();
            txtName = new TextBox();
            lblWeight = new Label();
            lblSpecies = new Label();
            lblFamily = new Label();
            lblName = new Label();
            errorName = new ErrorProvider(components);
            errorFamily = new ErrorProvider(components);
            errorSpecies = new ErrorProvider(components);
            errorWeight = new ErrorProvider(components);
            groupBoxMsg = new GroupBox();
            lblUserMsg = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridAnimals).BeginInit();
            groupBoxEdition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorFamily).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorSpecies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorWeight).BeginInit();
            groupBoxMsg.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridAnimals
            // 
            dataGridAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAnimals.Location = new Point(35, 77);
            dataGridAnimals.Name = "dataGridAnimals";
            dataGridAnimals.Size = new Size(358, 345);
            dataGridAnimals.TabIndex = 0;
            dataGridAnimals.CellClick += dataGridAnimals_CellClick;
            // 
            // labelMsgDB
            // 
            labelMsgDB.AutoSize = true;
            labelMsgDB.Font = new Font("Segoe UI", 15F);
            labelMsgDB.Location = new Point(35, 33);
            labelMsgDB.Name = "labelMsgDB";
            labelMsgDB.Size = new Size(225, 28);
            labelMsgDB.TabIndex = 1;
            labelMsgDB.Text = "Animals in the Database:";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(471, 380);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(95, 42);
            btnHome.TabIndex = 2;
            btnHome.Text = "Return";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(572, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(673, 380);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(95, 42);
            btnModify.TabIndex = 4;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // groupBoxEdition
            // 
            groupBoxEdition.Controls.Add(comboFamily);
            groupBoxEdition.Controls.Add(txtWeight);
            groupBoxEdition.Controls.Add(txtSpecies);
            groupBoxEdition.Controls.Add(txtName);
            groupBoxEdition.Controls.Add(lblWeight);
            groupBoxEdition.Controls.Add(lblSpecies);
            groupBoxEdition.Controls.Add(lblFamily);
            groupBoxEdition.Controls.Add(lblName);
            groupBoxEdition.Font = new Font("Segoe UI", 14F);
            groupBoxEdition.Location = new Point(422, 63);
            groupBoxEdition.Name = "groupBoxEdition";
            groupBoxEdition.Size = new Size(346, 238);
            groupBoxEdition.TabIndex = 5;
            groupBoxEdition.TabStop = false;
            groupBoxEdition.Text = "Animal Data:";
            // 
            // comboFamily
            // 
            comboFamily.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFamily.Font = new Font("Segoe UI", 11F);
            comboFamily.FormattingEnabled = true;
            comboFamily.Items.AddRange(new object[] { "Cetacean", "Sea Bird", "Sea Turtle" });
            comboFamily.Location = new Point(150, 92);
            comboFamily.Name = "comboFamily";
            comboFamily.Size = new Size(137, 28);
            comboFamily.TabIndex = 12;
            comboFamily.Validating += comboFamily_Validating;
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Segoe UI", 11F);
            txtWeight.Location = new Point(150, 185);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(137, 27);
            txtWeight.TabIndex = 11;
            txtWeight.Validating += txtWeight_Validating;
            // 
            // txtSpecies
            // 
            txtSpecies.Font = new Font("Segoe UI", 11F);
            txtSpecies.Location = new Point(150, 139);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(137, 27);
            txtSpecies.TabIndex = 10;
            txtSpecies.Validating += txtSpecies_Validating;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(150, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(137, 27);
            txtName.TabIndex = 9;
            txtName.Validating += txtName_Validating;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 11F);
            lblWeight.Location = new Point(66, 188);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(59, 20);
            lblWeight.TabIndex = 8;
            lblWeight.Text = "Weight:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Font = new Font("Segoe UI", 11F);
            lblSpecies.Location = new Point(63, 142);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(62, 20);
            lblSpecies.TabIndex = 7;
            lblSpecies.Text = "Species:";
            // 
            // lblFamily
            // 
            lblFamily.AutoSize = true;
            lblFamily.Font = new Font("Segoe UI", 11F);
            lblFamily.Location = new Point(29, 95);
            lblFamily.Name = "lblFamily";
            lblFamily.Size = new Size(96, 20);
            lblFamily.TabIndex = 6;
            lblFamily.Text = "Super Family:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(73, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // errorName
            // 
            errorName.ContainerControl = this;
            // 
            // errorFamily
            // 
            errorFamily.ContainerControl = this;
            // 
            // errorSpecies
            // 
            errorSpecies.ContainerControl = this;
            // 
            // errorWeight
            // 
            errorWeight.ContainerControl = this;
            // 
            // groupBoxMsg
            // 
            groupBoxMsg.Controls.Add(lblUserMsg);
            groupBoxMsg.Font = new Font("Segoe UI", 11F);
            groupBoxMsg.Location = new Point(422, 307);
            groupBoxMsg.Name = "groupBoxMsg";
            groupBoxMsg.Size = new Size(346, 57);
            groupBoxMsg.TabIndex = 6;
            groupBoxMsg.TabStop = false;
            groupBoxMsg.Text = "Message:";
            // 
            // lblUserMsg
            // 
            lblUserMsg.AutoSize = true;
            lblUserMsg.Font = new Font("Segoe UI", 9F);
            lblUserMsg.ForeColor = Color.Red;
            lblUserMsg.Location = new Point(29, 23);
            lblUserMsg.Name = "lblUserMsg";
            lblUserMsg.Size = new Size(12, 15);
            lblUserMsg.TabIndex = 0;
            lblUserMsg.Text = "-";
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxMsg);
            Controls.Add(groupBoxEdition);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(btnHome);
            Controls.Add(labelMsgDB);
            Controls.Add(dataGridAnimals);
            Name = "FormEdit";
            Text = "Edition";
            Load += FormEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAnimals).EndInit();
            groupBoxEdition.ResumeLayout(false);
            groupBoxEdition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorFamily).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorSpecies).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorWeight).EndInit();
            groupBoxMsg.ResumeLayout(false);
            groupBoxMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridAnimals;
        private Label labelMsgDB;
        private Button btnHome;
        private Button btnAdd;
        private Button btnModify;
        private GroupBox groupBoxEdition;
        private Label lblName;
        private ComboBox comboFamily;
        private TextBox txtWeight;
        private TextBox txtSpecies;
        private TextBox txtName;
        private Label lblWeight;
        private Label lblSpecies;
        private Label lblFamily;
        private ErrorProvider errorName;
        private ErrorProvider errorFamily;
        private ErrorProvider errorSpecies;
        private ErrorProvider errorWeight;
        private GroupBox groupBoxMsg;
        private Label lblUserMsg;
    }
}