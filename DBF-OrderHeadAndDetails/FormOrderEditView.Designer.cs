namespace DBF_OrderHeadAndDetails
{
    partial class FormOrderEditView
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
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnOpenOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(215, 180);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(53, 13);
            this.lblOrderID.TabIndex = 6;
            this.lblOrderID.Text = "OrderID : ";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(284, 177);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 5;
            // 
            // btnOpenOrder
            // 
            this.btnOpenOrder.Location = new System.Drawing.Point(412, 175);
            this.btnOpenOrder.Name = "btnOpenOrder";
            this.btnOpenOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOrder.TabIndex = 4;
            this.btnOpenOrder.Text = "Open Order";
            this.btnOpenOrder.UseVisualStyleBackColor = true;
            this.btnOpenOrder.Click += new System.EventHandler(this.btnOpenOrder_Click);
            // 
            // FormOrderEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.btnOpenOrder);
            this.Name = "FormOrderEditView";
            this.Text = "FormOrderEditView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnOpenOrder;
    }
}