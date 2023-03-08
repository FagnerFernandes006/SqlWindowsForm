namespace WindowsFormSql
{
    partial class Form1
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
            this.btnSend = new System.Windows.Forms.Button();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.listRegister = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(197, 201);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 37);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // campoNome
            // 
            this.campoNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.campoNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.campoNome.Location = new System.Drawing.Point(267, 145);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(203, 20);
            this.campoNome.TabIndex = 1;
            this.campoNome.TextChanged += new System.EventHandler(this.campoNome_TextChanged);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(312, 201);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(109, 37);
            this.select.TabIndex = 2;
            this.select.Text = "Consultar";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // listRegister
            // 
            this.listRegister.HideSelection = false;
            this.listRegister.Location = new System.Drawing.Point(240, 270);
            this.listRegister.Name = "listRegister";
            this.listRegister.Size = new System.Drawing.Size(241, 97);
            this.listRegister.TabIndex = 4;
            this.listRegister.UseCompatibleStateImageBehavior = false;
            this.listRegister.SelectedIndexChanged += new System.EventHandler(this.listRegister_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(426, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listRegister);
            this.Controls.Add(this.select);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.ListView listRegister;
        private System.Windows.Forms.Button btnDelete;
    }
}

