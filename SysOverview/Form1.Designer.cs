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
            this.iRam = new System.Windows.Forms.Label();
            this.Ram = new System.Windows.Forms.Label();
            this.iBaseboard = new System.Windows.Forms.Label();
            this.Baseboard = new System.Windows.Forms.Label();
            this.iVideo = new System.Windows.Forms.Label();
            this.Video = new System.Windows.Forms.Label();
            this.iProcessor = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveIn = new System.Windows.Forms.ToolStripMenuItem();
            this.Lang = new System.Windows.Forms.ToolStripMenuItem();
            this.Rus = new System.Windows.Forms.ToolStripMenuItem();
            this.Eng = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iRam
            // 
            resources.ApplyResources(this.iRam, "iRam");
            this.iRam.Name = "iRam";
            // 
            // Ram
            // 
            resources.ApplyResources(this.Ram, "Ram");
            this.Ram.Name = "Ram";
            // 
            // iBaseboard
            // 
            resources.ApplyResources(this.iBaseboard, "iBaseboard");
            this.iBaseboard.Name = "iBaseboard";
            // 
            // Baseboard
            // 
            resources.ApplyResources(this.Baseboard, "Baseboard");
            this.Baseboard.Name = "Baseboard";
            // 
            // iVideo
            // 
            resources.ApplyResources(this.iVideo, "iVideo");
            this.iVideo.Name = "iVideo";
            // 
            // Video
            // 
            resources.ApplyResources(this.Video, "Video");
            this.Video.Name = "Video";
            // 
            // iProcessor
            // 
            resources.ApplyResources(this.iProcessor, "iProcessor");
            this.iProcessor.Name = "iProcessor";
            // 
            // Processor
            // 
            resources.ApplyResources(this.Processor, "Processor");
            this.Processor.Name = "Processor";
            // 
            // MainLabel
            // 
            resources.ApplyResources(this.MainLabel, "MainLabel");
            this.MainLabel.Name = "MainLabel";
            // 
            // MainStrip
            // 
            resources.ApplyResources(this.MainStrip, "MainStrip");
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu});
            this.MainStrip.Name = "MainStrip";
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveIn,
            this.Lang,
            this.Info,
            this.Exit});
            this.MainMenu.Name = "MainMenu";
            // 
            // SaveIn
            // 
            resources.ApplyResources(this.SaveIn, "SaveIn");
            this.SaveIn.Name = "SaveIn";
            this.SaveIn.Click += new System.EventHandler(this.SaveToItem_Click);
            // 
            // Lang
            // 
            resources.ApplyResources(this.Lang, "Lang");
            this.Lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rus,
            this.Eng});
            this.Lang.Name = "Lang";
            // 
            // Rus
            // 
            resources.ApplyResources(this.Rus, "Rus");
            this.Rus.Name = "Rus";
            this.Rus.Click += new System.EventHandler(this.RusItem1_Click);
            // 
            // Eng
            // 
            resources.ApplyResources(this.Eng, "Eng");
            this.Eng.Name = "Eng";
            this.Eng.Click += new System.EventHandler(this.EngItem_Click);
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainStrip);
            this.Controls.Add(this.iRam);
            this.Controls.Add(this.Ram);
            this.Controls.Add(this.iBaseboard);
            this.Controls.Add(this.Baseboard);
            this.Controls.Add(this.iVideo);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.iProcessor);
            this.Controls.Add(this.Processor);
            this.Controls.Add(this.MainLabel);
            this.MainMenuStrip = this.MainStrip;
            this.Name = "Form1";
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iRam;
        private System.Windows.Forms.Label Ram;        
        private System.Windows.Forms.Label iBaseboard;        
        private System.Windows.Forms.Label Baseboard;
        private System.Windows.Forms.Label iVideo;
        private System.Windows.Forms.Label Video;
        private System.Windows.Forms.Label iProcessor;
        private System.Windows.Forms.Label Processor;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.MenuStrip MainStrip;              
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveIn;
        private System.Windows.Forms.ToolStripMenuItem Lang;
        private System.Windows.Forms.ToolStripMenuItem Rus;
        private System.Windows.Forms.ToolStripMenuItem Eng;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

