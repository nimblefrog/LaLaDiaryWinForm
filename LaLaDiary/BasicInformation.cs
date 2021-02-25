using System;
using System.Drawing;
using System.Windows.Forms;
using LaLaDiary.Model;
using LaLaDiary.ViewModel;

namespace LaLaDiary
{
    public partial class BasicInformation : Form
    {
        public BasicInformation()
        {
            InitializeComponent();

            var basicInfo = BasicInfoViewModel.ViewModel;
            txtNowWt.Text = basicInfo.CurrentWeight.ToString();
            txtTargetWt.Text = basicInfo.TargetWeight.ToString();
            txtDiffWt.Text = basicInfo.DiffWeight.ToString();
            txtDiffWt.ForeColor = Color.Red;
            txtDailyP.Text = basicInfo.TargetP.ToString();
            txtDailyF.Text = basicInfo.TargetF.ToString();
            txtDailyC.Text = basicInfo.TargetC.ToString();
            txtDailyCal.Text = basicInfo.TargetCal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicInfoViewModel.ViewModel = new BasicInfo
            {
                CurrentWeight = float.Parse(txtNowWt.Text),
                TargetWeight = float.Parse(txtTargetWt.Text),
                TargetP = int.Parse(txtDailyP.Text),
                TargetF = int.Parse(txtDailyF.Text),
                TargetC = int.Parse(txtDailyC.Text),
                TargetCal = int.Parse(txtDailyCal.Text)
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
