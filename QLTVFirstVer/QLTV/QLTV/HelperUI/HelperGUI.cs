using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using app = Microsoft.Office.Interop.Excel.Application;

namespace Desktop.HelperUI
{
    class HelperGUI
    {
        #region Instance
        private static HelperGUI instance;

        internal static HelperGUI Instance
        {
            get
            {
                if (instance == null) instance = new HelperGUI(); return HelperUI.HelperGUI.instance;
            }

            private set
            {
                HelperUI.HelperGUI.instance = value;
            }
        }
        #endregion
        #region Format control
        //Kiểm tra họ tên độc giả
        public string KiemTraHoTen(string HoTenDG)
        {
            string kq="";
            HoTenDG = HoTenDG.Trim().ToLower();
            for (int i = 0; i < HoTenDG.Length; i++)
            {
                if (i == 0)
                    kq += HoTenDG[i].ToString().ToUpper();
                else
                    kq += HoTenDG[i];
                if (HoTenDG[i] == ' ')
                {
                    while (HoTenDG[i] == ' ')
                    {
                        i++;
                    }
                    kq += HoTenDG[i].ToString().ToUpper();
                }
            }
                return kq.ToString();
        }
        //kiểm tra Email đúng đinh dạng
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
            (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

            bool valid = false;
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(email);
            }
            return valid;
        }
        //check không cho nhập số
        public void CheckKiTu(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = int.TryParse(e.KeyChar.ToString(), out isNumber);
        }
        //check Email có nhiều hơn 4 kí tự
        public bool checkIsMail(TextBox Email)
        {
            if (HelperGUI.Instance.IsValidEmail(Email.Text) == true)
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (Email.Text[i] == '@')
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        //Hàm ResetAllControls
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.Text = null;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.ResetText();
                }
                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Hide();
                }
            }
        }
        //Kiểm tra kiểu int đúng định dạng
        public void CheckInt(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public decimal checkMoney(Decimal Tien, TextBox Money)
        {
            int a = int.Parse(Money.Text.ToString());
            Tien = Convert.ToDecimal(String.Format("{0:0,0}", a));
            return Tien;
        }
        #endregion
        #region ExportCSV
        public void ExportExcel(DataGridView dgv_DL)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    //sfd.Title = "Save an Excel File";
                    //sfd.ShowDialog();
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult dlg = MessageBox.Show("Bạn có chắc chắn xuất CSV!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        app obj = new app();
                        obj.Application.Workbooks.Add(Type.Missing);
                        obj.Columns.ColumnWidth = 25;

                        for (int i = 1; i < dgv_DL.Columns.Count + 1; i++)
                            obj.Cells[1, i] = dgv_DL.Columns[i - 1].HeaderText;

                        for (int i = 0; i < dgv_DL.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv_DL.Columns.Count; j++)
                            {
                                if (dgv_DL.Rows[i].Cells[j].Value != null)
                                    obj.Cells[i + 2, j + 1] = dgv_DL.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        obj.ActiveWorkbook.SaveCopyAs(sfd.FileName.ToString());
                        obj.ActiveWorkbook.Saved = true;
                        obj.Quit();
                        MessageBox.Show("Xuất File Thành Công!");
                    }
                }
            }
            catch
            {

            }
        }
        #endregion
    }
}
