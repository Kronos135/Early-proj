using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOverview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iProcessor.Text = Logic.GetComponent("Win32_Processor", "Name");
            iVideo.Text = Logic.GetComponent("Win32_VideoController", "Name");
            iBaseboard.Text = Logic.GetComponent("Win32_BaseBoard", "Manufacturer") + " " + Logic.GetComponent("Win32_BaseBoard", "Product");
            iRam.Text = Logic.GetPhysicalMemory();
        }



        private void SaveToItem_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog1_HelpRequest(sender, e);
            StringBuilder BLa = new StringBuilder();

            foreach (var item in this.Controls)
            {
                if (item is System.Windows.Forms.Label)
                {
                    BLa.AppendLine((item as Label).Text);
                    
                }
            }
            Logic.Writer(BLa);
        }

        private void EngItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }
        private void RusItem1_Click(object sender, EventArgs e)
        {
            ChangeLanguage("");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();

        }

        private void Info_Click(object sender, EventArgs e)
        {
            var F2 = new Form2();
            F2.ShowDialog();
          
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ChangeLanguage(string newLanguageString)
        {
            var resources = new ComponentResourceManager(typeof(Form1));

            CultureInfo newCultureInfo = new CultureInfo(newLanguageString);

            //Применяем для каждого контрола на форме новую культуру
            foreach (Control c in this.Controls)
            { 
                if(c.Name[0]!='i')
                    resources.ApplyResources(c, c.Name, newCultureInfo);
            }

            //Отдельно меняем для тайтла самой формы локализацию
            resources.ApplyResources(this, "$this", newCultureInfo);

            resources.ApplyResources(this.MainMenu, "MainMenu", newCultureInfo);

            //Для элементов статус стрипа устанавливаем также установки локализации
            foreach (var item in this.MainMenu.DropDownItems.Cast<ToolStripItem>())
            {
                resources.ApplyResources(item, item.Name, newCultureInfo);
            }
            /*
                        //Устанавливаем текст на кнопке, которая была изображена на скриншоте раньше название локализации
                        TSDD_Language.Text = newCultureInfo.NativeName;
                        xcbb
                        //Устанавливаем флаг на активной локализации (см. функцию ниже)
                        SetCurrenLanguageButtonChecked();
                        */
        }


    }

}
