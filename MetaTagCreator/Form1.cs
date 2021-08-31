using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaTagCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string charset = "<meta charset=\"" + textBoxCharset.Text + "\"/>";
            string viewport = "<meta name=\"viewport\" content=\"" + textBoxViewport.Text + "\"/>";
            string keywords = "<meta name=\"keywords\" content=\"" + textBoxKeywords.Text + "\"/>";
            string author = "<meta name=\"author\" content=\""+ textBox5.Text +"\"/>";
            string publisher = "<meta name=\"publisher\" content=\"" + textBox4.Text + "\"/>";
            string description = "<meta name=\"description\" content=\"" + textBox1.Text + "\"/>";
            string abstrat = "<meta name=\"abstract\" content=\"" + textBox1.Text + "\"/>";
            string contentLanguage = "<meta http-equiv=\"content-language\" content=\"" + textBox3.Text + "\"/>";
            string title = "<title>"+ textBox6.Text +"</title>";
            string siteUrl = textBox7.Text;
            textBox2.Text = "";
            textBox2.Text += charset + "\n";
            textBox2.Text += viewport + "\n";
            textBox2.Text += "<meta name=\"robots\" content=\"index, follow\" />" + "\n";
            textBox2.Text += keywords + "\n";
            textBox2.Text += author + "\n";
            textBox2.Text += publisher + "\n";
            textBox2.Text += description + "\n";
            textBox2.Text += abstrat + "\n";
            textBox2.Text += contentLanguage + "\n";
            if (checkBox1.Checked)
            {
                string twCard = "<meta name=\"twitter:card\" content=\"" + title + "\"/>";
                string twUrl = "<meta name=\"twitter:url\" content=\"" + siteUrl + "\"/>";
                string twSite = "<meta name=\"twitter:site\" content=\"" + title + "\"/>";
                string twTitle = "<meta name=\"twitter:title\" content=\"" + title + "\"/>";
                string twDesc = "<meta name=\"twitter:description\" content=\"" + description + "\"/>";
                textBox2.Text += twCard + "\n";
                textBox2.Text += twUrl + "\n";
                textBox2.Text += twSite + "\n";
                textBox2.Text += twTitle + "\n";
                textBox2.Text += twDesc + "\n";
            }

            if (checkBox2.Checked)
            {
                string fbTitle = "<meta name=\"og:title\" content=\"" + title + "\"/>";
                string fbSiteName = "<meta name=\"og:site_name\" content=\"" + siteUrl + "\"/>";
                string fbType = "<meta name=\"og:type\" content=\"" + "website" + "\"/>";
                string fbUrl = "<meta name=\"og:url\" content=\"" + siteUrl + "\"/>";
                string fbDesc = "<meta name=\"og:description\" content=\"" + description + "\"/>";
                textBox2.Text += fbTitle + "\n";
                textBox2.Text += fbSiteName + "\n";
                textBox2.Text += fbType + "\n";
                textBox2.Text += fbUrl + "\n";
                textBox2.Text += fbDesc + "\n";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }
    }
}
