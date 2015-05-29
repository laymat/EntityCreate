namespace EntityCreate
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.lbl_connectionString = new System.Windows.Forms.Label();
            this.btn_createEntity = new System.Windows.Forms.Button();
            this.rtbx_showCreateState = new System.Windows.Forms.RichTextBox();
            this.lal_nameSpaces = new System.Windows.Forms.Label();
            this.tbx_nameSpaces = new System.Windows.Forms.TextBox();
            this.tbx_appLoaction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radbt_oracle = new System.Windows.Forms.RadioButton();
            this.radbt_mysql = new System.Windows.Forms.RadioButton();
            this.radbt_mssql = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_connectionString
            // 
            this.lbl_connectionString.AutoSize = true;
            this.lbl_connectionString.Location = new System.Drawing.Point(3, 82);
            this.lbl_connectionString.Name = "lbl_connectionString";
            this.lbl_connectionString.Size = new System.Drawing.Size(77, 12);
            this.lbl_connectionString.TabIndex = 0;
            this.lbl_connectionString.Text = "链接字符串：";
            // 
            // btn_createEntity
            // 
            this.btn_createEntity.Location = new System.Drawing.Point(705, 202);
            this.btn_createEntity.Name = "btn_createEntity";
            this.btn_createEntity.Size = new System.Drawing.Size(75, 29);
            this.btn_createEntity.TabIndex = 2;
            this.btn_createEntity.Text = "生成";
            this.btn_createEntity.UseVisualStyleBackColor = true;
            this.btn_createEntity.Click += new System.EventHandler(this.btn_createEntity_Click);
            // 
            // rtbx_showCreateState
            // 
            this.rtbx_showCreateState.BackColor = System.Drawing.Color.White;
            this.rtbx_showCreateState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbx_showCreateState.Location = new System.Drawing.Point(12, 107);
            this.rtbx_showCreateState.Name = "rtbx_showCreateState";
            this.rtbx_showCreateState.Size = new System.Drawing.Size(766, 89);
            this.rtbx_showCreateState.TabIndex = 3;
            this.rtbx_showCreateState.Text = "";
            // 
            // lal_nameSpaces
            // 
            this.lal_nameSpaces.AutoSize = true;
            this.lal_nameSpaces.Location = new System.Drawing.Point(15, 18);
            this.lal_nameSpaces.Name = "lal_nameSpaces";
            this.lal_nameSpaces.Size = new System.Drawing.Size(65, 12);
            this.lal_nameSpaces.TabIndex = 4;
            this.lal_nameSpaces.Text = "命名空间：";
            // 
            // tbx_nameSpaces
            // 
            this.tbx_nameSpaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_nameSpaces.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_nameSpaces.Location = new System.Drawing.Point(75, 12);
            this.tbx_nameSpaces.Multiline = true;
            this.tbx_nameSpaces.Name = "tbx_nameSpaces";
            this.tbx_nameSpaces.Size = new System.Drawing.Size(696, 25);
            this.tbx_nameSpaces.TabIndex = 5;
            // 
            // tbx_appLoaction
            // 
            this.tbx_appLoaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_appLoaction.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_appLoaction.Location = new System.Drawing.Point(75, 43);
            this.tbx_appLoaction.Multiline = true;
            this.tbx_appLoaction.Name = "tbx_appLoaction";
            this.tbx_appLoaction.Size = new System.Drawing.Size(696, 25);
            this.tbx_appLoaction.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "程序集：";
            // 
            // radbt_oracle
            // 
            this.radbt_oracle.AutoSize = true;
            this.radbt_oracle.Location = new System.Drawing.Point(86, 78);
            this.radbt_oracle.Name = "radbt_oracle";
            this.radbt_oracle.Size = new System.Drawing.Size(59, 16);
            this.radbt_oracle.TabIndex = 8;
            this.radbt_oracle.TabStop = true;
            this.radbt_oracle.Text = "Oracle";
            this.radbt_oracle.UseVisualStyleBackColor = true;
            // 
            // radbt_mysql
            // 
            this.radbt_mysql.AutoSize = true;
            this.radbt_mysql.Location = new System.Drawing.Point(210, 78);
            this.radbt_mysql.Name = "radbt_mysql";
            this.radbt_mysql.Size = new System.Drawing.Size(53, 16);
            this.radbt_mysql.TabIndex = 9;
            this.radbt_mysql.TabStop = true;
            this.radbt_mysql.Text = "Mysql";
            this.radbt_mysql.UseVisualStyleBackColor = true;
            // 
            // radbt_mssql
            // 
            this.radbt_mssql.AutoSize = true;
            this.radbt_mssql.Location = new System.Drawing.Point(151, 78);
            this.radbt_mssql.Name = "radbt_mssql";
            this.radbt_mssql.Size = new System.Drawing.Size(53, 16);
            this.radbt_mssql.TabIndex = 10;
            this.radbt_mssql.TabStop = true;
            this.radbt_mssql.Text = "Mssql";
            this.radbt_mssql.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 243);
            this.Controls.Add(this.radbt_mssql);
            this.Controls.Add(this.radbt_mysql);
            this.Controls.Add(this.radbt_oracle);
            this.Controls.Add(this.tbx_appLoaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nameSpaces);
            this.Controls.Add(this.lal_nameSpaces);
            this.Controls.Add(this.rtbx_showCreateState);
            this.Controls.Add(this.btn_createEntity);
            this.Controls.Add(this.lbl_connectionString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entity Create Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_connectionString;
        private System.Windows.Forms.Button btn_createEntity;
        private System.Windows.Forms.RichTextBox rtbx_showCreateState;
        private System.Windows.Forms.Label lal_nameSpaces;
        private System.Windows.Forms.TextBox tbx_nameSpaces;
        private System.Windows.Forms.TextBox tbx_appLoaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radbt_oracle;
        private System.Windows.Forms.RadioButton radbt_mysql;
        private System.Windows.Forms.RadioButton radbt_mssql;
    }
}

