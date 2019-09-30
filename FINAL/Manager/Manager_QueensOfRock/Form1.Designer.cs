namespace Manager_QueensOfRock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btCamping = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.Button();
            this.btLeave = new System.Windows.Forms.Button();
            this.btBorrow = new System.Windows.Forms.Button();
            this.btManager = new System.Windows.Forms.Button();
            this.btShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCamping
            // 
            this.btCamping.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCamping.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btCamping.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCamping.Location = new System.Drawing.Point(12, 12);
            this.btCamping.Name = "btCamping";
            this.btCamping.Size = new System.Drawing.Size(126, 45);
            this.btCamping.TabIndex = 0;
            this.btCamping.Text = "Camping";
            this.btCamping.UseVisualStyleBackColor = false;
            this.btCamping.Click += new System.EventHandler(this.btCamping_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbInfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbInfo.Location = new System.Drawing.Point(144, 91);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(154, 68);
            this.tbInfo.TabIndex = 1;
            this.tbInfo.Text = "Data about event";
            this.tbInfo.UseVisualStyleBackColor = false;
            this.tbInfo.Click += new System.EventHandler(this.tbInfo_Click);
            // 
            // btLeave
            // 
            this.btLeave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLeave.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btLeave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLeave.Location = new System.Drawing.Point(12, 165);
            this.btLeave.Name = "btLeave";
            this.btLeave.Size = new System.Drawing.Size(286, 45);
            this.btLeave.TabIndex = 2;
            this.btLeave.Text = "Leave event";
            this.btLeave.UseVisualStyleBackColor = false;
            this.btLeave.Click += new System.EventHandler(this.btLeave_Click);
            // 
            // btBorrow
            // 
            this.btBorrow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBorrow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btBorrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBorrow.Location = new System.Drawing.Point(144, 12);
            this.btBorrow.Name = "btBorrow";
            this.btBorrow.Size = new System.Drawing.Size(154, 68);
            this.btBorrow.TabIndex = 3;
            this.btBorrow.Text = "Borrow/Return Items";
            this.btBorrow.UseVisualStyleBackColor = false;
            this.btBorrow.Click += new System.EventHandler(this.btBorrow_Click);
            // 
            // btManager
            // 
            this.btManager.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btManager.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btManager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btManager.Location = new System.Drawing.Point(12, 63);
            this.btManager.Name = "btManager";
            this.btManager.Size = new System.Drawing.Size(126, 45);
            this.btManager.TabIndex = 4;
            this.btManager.Text = "Enter/ATM\r\n";
            this.btManager.UseVisualStyleBackColor = false;
            this.btManager.Click += new System.EventHandler(this.btManager_Click);
            // 
            // btShop
            // 
            this.btShop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btShop.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btShop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShop.Location = new System.Drawing.Point(12, 114);
            this.btShop.Name = "btShop";
            this.btShop.Size = new System.Drawing.Size(126, 45);
            this.btShop.TabIndex = 5;
            this.btShop.Text = "Shop";
            this.btShop.UseVisualStyleBackColor = false;
            this.btShop.Click += new System.EventHandler(this.btShop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Manager_QueensOfRock.Properties.Resources.backgr;
            this.ClientSize = new System.Drawing.Size(313, 222);
            this.Controls.Add(this.btShop);
            this.Controls.Add(this.btManager);
            this.Controls.Add(this.btBorrow);
            this.Controls.Add(this.btLeave);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btCamping);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCamping;
        private System.Windows.Forms.Button tbInfo;
        private System.Windows.Forms.Button btLeave;
        private System.Windows.Forms.Button btBorrow;
        private System.Windows.Forms.Button btManager;
        private System.Windows.Forms.Button btShop;
    }
}

