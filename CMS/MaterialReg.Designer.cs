namespace CMS
{
    partial class MaterialReg
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
            this.components = new System.ComponentModel.Container();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblmname = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaterial.Location = new System.Drawing.Point(216, 24);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(89, 25);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Material";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(209, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblmname
            // 
            this.lblmname.AutoSize = true;
            this.lblmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmname.Location = new System.Drawing.Point(91, 87);
            this.lblmname.Name = "lblmname";
            this.lblmname.Size = new System.Drawing.Size(53, 17);
            this.lblmname.TabIndex = 2;
            this.lblmname.Text = "Name :";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(195, 84);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(213, 20);
            this.txtmname.TabIndex = 3;
            this.txtmname.Validating += new System.ComponentModel.CancelEventHandler(this.txtmname_Validating);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(195, 125);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(213, 103);
            this.txtComments.TabIndex = 4;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(91, 162);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(82, 17);
            this.lblComments.TabIndex = 5;
            this.lblComments.Text = "Comments :";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // MaterialReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 318);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.lblmname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMaterial);
            this.Name = "MaterialReg";
            this.Text = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblmname;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}