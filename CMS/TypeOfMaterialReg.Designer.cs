namespace CMS
{
    partial class TypeOfMaterialReg
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
            this.lblTypeOfMaterial = new System.Windows.Forms.Label();
            this.cmBoxMaterial = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtTypeofMaterial = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblmaterialType = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeOfMaterial
            // 
            this.lblTypeOfMaterial.AutoSize = true;
            this.lblTypeOfMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfMaterial.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTypeOfMaterial.Location = new System.Drawing.Point(270, 22);
            this.lblTypeOfMaterial.Name = "lblTypeOfMaterial";
            this.lblTypeOfMaterial.Size = new System.Drawing.Size(184, 25);
            this.lblTypeOfMaterial.TabIndex = 0;
            this.lblTypeOfMaterial.Text = "Type Of Materials";
            // 
            // cmBoxMaterial
            // 
            this.cmBoxMaterial.FormattingEnabled = true;
            this.cmBoxMaterial.Items.AddRange(new object[] {
            "--Select--"});
            this.cmBoxMaterial.Location = new System.Drawing.Point(332, 75);
            this.cmBoxMaterial.Name = "cmBoxMaterial";
            this.cmBoxMaterial.Size = new System.Drawing.Size(266, 21);
            this.cmBoxMaterial.TabIndex = 1;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(164, 83);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(66, 17);
            this.lblMaterial.TabIndex = 2;
            this.lblMaterial.Text = "Material :";
            // 
            // txtTypeofMaterial
            // 
            this.txtTypeofMaterial.Location = new System.Drawing.Point(332, 136);
            this.txtTypeofMaterial.Name = "txtTypeofMaterial";
            this.txtTypeofMaterial.Size = new System.Drawing.Size(266, 20);
            this.txtTypeofMaterial.TabIndex = 3;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(332, 207);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(256, 130);
            this.txtComments.TabIndex = 4;
            // 
            // lblmaterialType
            // 
            this.lblmaterialType.AutoSize = true;
            this.lblmaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaterialType.Location = new System.Drawing.Point(164, 139);
            this.lblmaterialType.Name = "lblmaterialType";
            this.lblmaterialType.Size = new System.Drawing.Size(102, 17);
            this.lblmaterialType.TabIndex = 5;
            this.lblmaterialType.Text = "Material Type :";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(164, 248);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(82, 17);
            this.lblComments.TabIndex = 6;
            this.lblComments.Text = "Comments :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(204, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(456, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TypeOfMaterialReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 442);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblmaterialType);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtTypeofMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cmBoxMaterial);
            this.Controls.Add(this.lblTypeOfMaterial);
            this.Name = "TypeOfMaterialReg";
            this.Text = "TypeOfMaterialReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeOfMaterial;
        private System.Windows.Forms.ComboBox cmBoxMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox txtTypeofMaterial;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblmaterialType;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}