namespace ClientDatabase
{
    partial class ServiceForm
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
            this.dtService = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddClientSv = new System.Windows.Forms.Button();
            this.btnOkEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtService)).BeginInit();
            this.SuspendLayout();
            // 
            // dtService
            // 
            this.dtService.AllowUserToAddRows = false;
            this.dtService.AllowUserToDeleteRows = false;
            this.dtService.AllowUserToOrderColumns = true;
            this.dtService.AllowUserToResizeRows = false;
            this.dtService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtService.Location = new System.Drawing.Point(352, 12);
            this.dtService.MultiSelect = false;
            this.dtService.Name = "dtService";
            this.dtService.ReadOnly = true;
            this.dtService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtService.Size = new System.Drawing.Size(638, 268);
            this.dtService.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(80, 17);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(250, 21);
            this.cbClients.TabIndex = 3;
            this.cbClients.SelectedIndexChanged += new System.EventHandler(this.cbClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serviço:";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(80, 111);
            this.txtService.Multiline = true;
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(250, 111);
            this.txtService.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(80, 85);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(12, 228);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(159, 23);
            this.btnAddService.TabIndex = 8;
            this.btnAddService.Text = "Adicionar ";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnEditService
            // 
            this.btnEditService.Location = new System.Drawing.Point(12, 257);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(159, 23);
            this.btnEditService.TabIndex = 9;
            this.btnEditService.Text = "Editar Serviço";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(171, 228);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(159, 23);
            this.btnDeleteService.TabIndex = 10;
            this.btnDeleteService.Text = "Deletar Serviço";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnAddClientSv
            // 
            this.btnAddClientSv.Location = new System.Drawing.Point(80, 44);
            this.btnAddClientSv.Name = "btnAddClientSv";
            this.btnAddClientSv.Size = new System.Drawing.Size(250, 23);
            this.btnAddClientSv.TabIndex = 11;
            this.btnAddClientSv.Text = "Adicionar Cliente";
            this.btnAddClientSv.UseVisualStyleBackColor = true;
            this.btnAddClientSv.Click += new System.EventHandler(this.btnAddClientSv_Click);
            // 
            // btnOkEdit
            // 
            this.btnOkEdit.Location = new System.Drawing.Point(171, 257);
            this.btnOkEdit.Name = "btnOkEdit";
            this.btnOkEdit.Size = new System.Drawing.Size(159, 23);
            this.btnOkEdit.TabIndex = 12;
            this.btnOkEdit.Text = "Edição Concluida";
            this.btnOkEdit.UseVisualStyleBackColor = true;
            this.btnOkEdit.Click += new System.EventHandler(this.btnOkEdit_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 294);
            this.Controls.Add(this.btnOkEdit);
            this.Controls.Add(this.btnAddClientSv);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnEditService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceForm";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAddClientSv;
        private System.Windows.Forms.Button btnOkEdit;
    }
}