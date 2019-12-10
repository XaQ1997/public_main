using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsaweryWawrzyniakLab3Zadanie
{
    public partial class FormMain : Form
    {
        private Button buttonStart;
        private Button buttonRecords;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(211, 55);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(304, 139);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START GRY";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRecords
            // 
            this.buttonRecords.Location = new System.Drawing.Point(211, 245);
            this.buttonRecords.Name = "buttonRecords";
            this.buttonRecords.Size = new System.Drawing.Size(304, 139);
            this.buttonRecords.TabIndex = 1;
            this.buttonRecords.Text = "Lista partii";
            this.buttonRecords.UseVisualStyleBackColor = true;
            this.buttonRecords.Click += new System.EventHandler(this.buttonRecords_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(744, 447);
            this.Controls.Add(this.buttonRecords);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormMain";
            this.ResumeLayout(false);

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormPlay formPlay = new FormPlay();
            formPlay.ShowDialog();
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            FormRecords formRecords = new FormRecords();
            formRecords.ShowDialog();
        }
    }
}
