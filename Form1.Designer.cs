namespace Puzzle
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_Picture = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_count = new System.Windows.Forms.Label();
            this.lab_time = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Originalpic = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lab_result = new System.Windows.Forms.Label();
            this.btn_sta = new System.Windows.Forms.Button();
            this.btn_Changepic = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl_Picture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_continue);
            this.splitContainer1.Panel2.Controls.Add(this.btn_pause);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lable);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lab_count);
            this.splitContainer1.Panel2.Controls.Add(this.lab_time);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Reset);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Originalpic);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel2.Controls.Add(this.lab_result);
            this.splitContainer1.Panel2.Controls.Add(this.btn_sta);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Changepic);
            this.splitContainer1.Panel2.Controls.Add(this.btn_import);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1219, 740);
            this.splitContainer1.SplitterDistance = 829;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnl_Picture
            // 
            this.pnl_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Picture.Location = new System.Drawing.Point(0, 0);
            this.pnl_Picture.Name = "pnl_Picture";
            this.pnl_Picture.Size = new System.Drawing.Size(829, 740);
            this.pnl_Picture.TabIndex = 0;
            this.pnl_Picture.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(68, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "是否开启挑战模式";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(284, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "否";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_continue.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_continue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_continue.Location = new System.Drawing.Point(224, 442);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(108, 44);
            this.btn_continue.TabIndex = 21;
            this.btn_continue.Text = "继续";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pause.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_pause.Location = new System.Drawing.Point(72, 442);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(110, 44);
            this.btn_pause.TabIndex = 20;
            this.btn_pause.Text = "暂停";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(68, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "步数";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable.Location = new System.Drawing.Point(220, 382);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(30, 20);
            this.lable.TabIndex = 18;
            this.lable.Text = "步";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(68, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "倒计时";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "难度";
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_count.Location = new System.Drawing.Point(194, 382);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(20, 20);
            this.lab_count.TabIndex = 15;
            this.lab_count.Text = "0";
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_time.Location = new System.Drawing.Point(194, 342);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(42, 20);
            this.lab_time.TabIndex = 10;
            this.lab_time.Text = "0 s";
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Location = new System.Drawing.Point(224, 191);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(108, 39);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "图片重排";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Originalpic
            // 
            this.btn_Originalpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Originalpic.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Originalpic.Location = new System.Drawing.Point(72, 110);
            this.btn_Originalpic.Name = "btn_Originalpic";
            this.btn_Originalpic.Size = new System.Drawing.Size(110, 44);
            this.btn_Originalpic.TabIndex = 0;
            this.btn_Originalpic.Text = "查看原图";
            this.btn_Originalpic.UseVisualStyleBackColor = true;
            this.btn_Originalpic.Click += new System.EventHandler(this.btn_Originalpic_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(150, 33);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 25);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lab_result
            // 
            this.lab_result.AutoSize = true;
            this.lab_result.Font = new System.Drawing.Font("方正粗黑宋简体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_result.Location = new System.Drawing.Point(67, 505);
            this.lab_result.Name = "lab_result";
            this.lab_result.Size = new System.Drawing.Size(0, 29);
            this.lab_result.TabIndex = 5;
            // 
            // btn_sta
            // 
            this.btn_sta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sta.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sta.Location = new System.Drawing.Point(224, 280);
            this.btn_sta.Name = "btn_sta";
            this.btn_sta.Size = new System.Drawing.Size(45, 30);
            this.btn_sta.TabIndex = 4;
            this.btn_sta.Text = "是";
            this.btn_sta.UseVisualStyleBackColor = true;
            this.btn_sta.Click += new System.EventHandler(this.btn_sta_Click);
            // 
            // btn_Changepic
            // 
            this.btn_Changepic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Changepic.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Changepic.Location = new System.Drawing.Point(72, 192);
            this.btn_Changepic.Name = "btn_Changepic";
            this.btn_Changepic.Size = new System.Drawing.Size(110, 38);
            this.btn_Changepic.TabIndex = 2;
            this.btn_Changepic.Text = "切换图片";
            this.btn_Changepic.UseVisualStyleBackColor = true;
            this.btn_Changepic.Click += new System.EventHandler(this.btn_Changepic_Click);
            // 
            // btn_import
            // 
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_import.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_import.Location = new System.Drawing.Point(222, 110);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(110, 40);
            this.btn_import.TabIndex = 1;
            this.btn_import.Text = "试玩新图";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 740);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "myPuzzle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnl_Picture;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_Originalpic;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Changepic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_sta;
        private System.Windows.Forms.Label lab_result;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lab_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

