using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modify_Control
{
    public partial class EditText_DigitOrLetter : TextEdit
    {
        CustomValidationRule_DigitOrLetter customValidationRule;
        public EditText_DigitOrLetter()
        {
            InitializeComponent();

            customValidationRule = new CustomValidationRule_DigitOrLetter();
            customValidationRule.ErrorText = "Please enter a valid person name";
            customValidationRule.ErrorType = ErrorType.Warning;

        }


        private void EditText_DigitOrLetter_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            string str = (string)txt.EditValue;
            dxValidationProvider1.SetValidationRule(txt, customValidationRule);

            // 
            dxErrorProvider1.SetIconAlignment(txt, ErrorIconAlignment.MiddleRight);
            dxValidationProvider1.SetIconAlignment(txt, ErrorIconAlignment.MiddleRight);

            if (String.IsNullOrEmpty(str))
            {
                dxErrorProvider1.SetError(txt, "This infomation can not null !");
            }
            else
            {
                dxErrorProvider1.ClearErrors();
                dxValidationProvider1.Validate();
            }
        }

        private void EditText_DigitOrLetter_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            if (dxValidationProvider1.Validate())
                dxErrorProvider1.ClearErrors();
        }
    }
    class CustomValidationRule_DigitOrLetter : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            string str = (string)value;
            bool res = false;
            res = str.All(t => char.IsLetterOrDigit(t));
            return res;
        }
    }
}
