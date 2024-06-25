namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {


            //tbDisp.Text = "ÅZÅZì˙ñ⁄";
            var today = DateTime.Today;
            TimeSpan diff = today.Date - dtpDate.Value.Date;
            tbDisp.Text = dtpDate.Value.ToString("ê∂Ç‹ÇÍÇƒÇ©ÇÁ" + (diff.Days + 1) + "ì˙ñ⁄Ç≈Ç∑");

        }



        private void btDayBefore_Click(object sender, EventArgs e) {
            var past = dtpDate.Value.AddDays((double)-nudDay.Value);
            tbDisp.Text = past.ToString("D");
        }

        private void btDayAfter_Click_1(object sender, EventArgs e) {
            var future = dtpDate.Value.AddDays((double)nudDay.Value);
            tbDisp.Text = future.ToString("D");
        }

        private void btage_Click(object sender, EventArgs e) {
            var birthday = dtpDate.Value;
            var today = DateTime.Today;
            int age = GetAge(birthday, today);
            tbDisp.Text = age.ToString("D");
        }

        public static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age).AddDays(-1)) {
                age--;
            }
            return age;
        }
    }
}
