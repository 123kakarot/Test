namespace eHospital
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlQuanLyThietBi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanLyThietBi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlQuanLyThietBi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlQuanLyThietBi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1219, 481);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlQuanLyThietBi
            // 
            this.pnlQuanLyThietBi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuanLyThietBi.Controls.Add(this.panel2);
            this.pnlQuanLyThietBi.Controls.Add(this.panel1);
            this.pnlQuanLyThietBi.Location = new System.Drawing.Point(3, 3);
            this.pnlQuanLyThietBi.Name = "pnlQuanLyThietBi";
            this.pnlQuanLyThietBi.Size = new System.Drawing.Size(150, 180);
            this.pnlQuanLyThietBi.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuanLyThietBi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 148);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnQuanLyThietBi
            // 
            this.btnQuanLyThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuanLyThietBi.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThietBi.Image")));
            this.btnQuanLyThietBi.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyThietBi.Name = "btnQuanLyThietBi";
            this.btnQuanLyThietBi.Size = new System.Drawing.Size(148, 148);
            this.btnQuanLyThietBi.TabIndex = 0;
            this.btnQuanLyThietBi.UseVisualStyleBackColor = true;
            this.btnQuanLyThietBi.Click += new System.EventHandler(this.btnQuanLyThietBi_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thiết Bị";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1219, 481);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMenu_KeyUp);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlQuanLyThietBi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlQuanLyThietBi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanLyThietBi;
        private System.Windows.Forms.Label label1;
    }
}