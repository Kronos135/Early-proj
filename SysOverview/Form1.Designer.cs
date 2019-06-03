namespace SysOverview
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iProcessor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iVideo = new System.Windows.Forms.Label();
            this.iBaseboard = new System.Windows.Forms.Label();
            this.iRam = new System.Windows.Forms.Label();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveIn = new System.Windows.Forms.ToolStripMenuItem();
            this.Lang = new System.Windows.Forms.ToolStripMenuItem();
            this.Rus = new System.Windows.Forms.ToolStripMenuItem();
            this.Eng = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iProcessor
            // 
            resources.ApplyResources(this.iProcessor, "iProcessor");
            this.iProcessor.Name = "iProcessor";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // iVideo
            // 
            resources.ApplyResources(this.iVideo, "iVideo");
            this.iVideo.Name = "iVideo";
            // 
            // iBaseboard
            // 
            resources.ApplyResources(this.iBaseboard, "iBaseboard");
            this.iBaseboard.Name = "iBaseboard";
            // 
            // iRam
            // 
            resources.ApplyResources(this.iRam, "iRam");
            this.iRam.Name = "iRam";
            // 
            // MainStrip
            // 
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu});
            resources.ApplyResources(this.MainStrip, "MainStrip");
            this.MainStrip.Name = "MainStrip";
            // 
            // MainMenu
            // 
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveIn,
            this.Lang,
            this.Info,
            this.Exit});
            this.MainMenu.Name = "MainMenu";
            resources.ApplyResources(this.MainMenu, "MainMenu");
            // 
            // SaveIn
            // 
            this.SaveIn.Name = "SaveIn";
            resources.ApplyResources(this.SaveIn, "SaveIn");
            // 
            // Lang
            // 
            this.Lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rus,
            this.Eng});
            this.Lang.Name = "Lang";
            resources.ApplyResources(this.Lang, "Lang");
            // 
            // Rus
            // 
            this.Rus.Name = "Rus";
            resources.ApplyResources(this.Rus, "Rus");
            this.Rus.Click += new System.EventHandler(this.РусскийToolStripMenuItem1_Click);
            // 
            // Eng
            // 
            this.Eng.Name = "Eng";
            resources.ApplyResources(this.Eng, "Eng");
            this.Eng.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // Info
            // 
            this.Info.Name = "Info";
            resources.ApplyResources(this.Info, "Info");
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainStrip);
            this.Controls.Add(this.iRam);
            this.Controls.Add(this.iBaseboard);
            this.Controls.Add(this.iVideo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iProcessor);
            this.MainMenuStrip = this.MainStrip;
            this.Name = "Form1";
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iProcessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label iVideo;
        private System.Windows.Forms.Label iBaseboard;
        private System.Windows.Forms.Label iRam;
        private System.Windows.Forms.MenuStrip MainStrip;
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveIn;
        private System.Windows.Forms.ToolStripMenuItem Lang;
        private System.Windows.Forms.ToolStripMenuItem Rus;
        private System.Windows.Forms.ToolStripMenuItem Eng;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}

