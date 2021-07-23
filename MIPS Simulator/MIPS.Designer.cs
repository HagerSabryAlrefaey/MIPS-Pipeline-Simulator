namespace MIPS_Simulator
{
    partial class MIPS
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
            this.runCycleBtn = new System.Windows.Forms.Button();
            this.StartPCTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inializeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MipsRegisterGrid = new System.Windows.Forms.DataGridView();
            this.PiplineGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.UserCodetxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MipsRegisterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiplineGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // runCycleBtn
            // 
            this.runCycleBtn.Location = new System.Drawing.Point(529, 433);
            this.runCycleBtn.Name = "runCycleBtn";
            this.runCycleBtn.Size = new System.Drawing.Size(145, 57);
            this.runCycleBtn.TabIndex = 43;
            this.runCycleBtn.Text = "Run 1 cycle";
            this.runCycleBtn.UseVisualStyleBackColor = true;
            this.runCycleBtn.Click += new System.EventHandler(this.runCycleBtn_Click);
            // 
            // StartPCTxt
            // 
            this.StartPCTxt.Location = new System.Drawing.Point(45, 449);
            this.StartPCTxt.Name = "StartPCTxt";
            this.StartPCTxt.Size = new System.Drawing.Size(100, 20);
            this.StartPCTxt.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "PC:";
            // 
            // inializeBtn
            // 
            this.inializeBtn.Location = new System.Drawing.Point(245, 433);
            this.inializeBtn.Name = "inializeBtn";
            this.inializeBtn.Size = new System.Drawing.Size(145, 57);
            this.inializeBtn.TabIndex = 42;
            this.inializeBtn.Text = "Inisialize";
            this.inializeBtn.UseVisualStyleBackColor = true;
            this.inializeBtn.Click += new System.EventHandler(this.inializeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pipline registers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "MIPS registers";
            // 
            // MipsRegisterGrid
            // 
            this.MipsRegisterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MipsRegisterGrid.Location = new System.Drawing.Point(358, 53);
            this.MipsRegisterGrid.Name = "MipsRegisterGrid";
            this.MipsRegisterGrid.Size = new System.Drawing.Size(224, 373);
            this.MipsRegisterGrid.TabIndex = 44;
            // 
            // PiplineGrid
            // 
            this.PiplineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PiplineGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.PiplineGrid.Location = new System.Drawing.Point(642, 54);
            this.PiplineGrid.Name = "PiplineGrid";
            this.PiplineGrid.ReadOnly = true;
            this.PiplineGrid.Size = new System.Drawing.Size(492, 373);
            this.PiplineGrid.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Register";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "User Code";
            // 
            // UserCodetxt
            // 
            this.UserCodetxt.Location = new System.Drawing.Point(12, 54);
            this.UserCodetxt.Multiline = true;
            this.UserCodetxt.Name = "UserCodetxt";
            this.UserCodetxt.Size = new System.Drawing.Size(311, 373);
            this.UserCodetxt.TabIndex = 35;
            // 
            // MIPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 511);
            this.Controls.Add(this.runCycleBtn);
            this.Controls.Add(this.StartPCTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inializeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MipsRegisterGrid);
            this.Controls.Add(this.PiplineGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserCodetxt);
            this.Name = "MIPS";
            this.Text = "MIPS Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.MipsRegisterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiplineGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runCycleBtn;
        private System.Windows.Forms.TextBox StartPCTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button inializeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MipsRegisterGrid;
        private System.Windows.Forms.DataGridView PiplineGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserCodetxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

