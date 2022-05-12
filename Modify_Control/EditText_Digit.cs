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
    public partial class EditText_Digit : TextEdit
    {
        CustomValidationRule_Digit customValidationRule;

        public EditText_Digit()
        {
            InitializeComponent();
            customValidationRule = new CustomValidationRule_Digit();
            customValidationRule.ErrorText = "It must be a number include [ 0 - 9 ]";
            customValidationRule.ErrorType = ErrorType.Warning;
        }

        private void EditText_Digit_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            string str = (string)txt.EditValue;
            dxValidationProvider1.SetValidationRule(txt, customValidationRule);

            // 
            dxErrorProvider_Digit.SetIconAlignment(txt, ErrorIconAlignment.MiddleRight);
            dxValidationProvider1.SetIconAlignment(txt, ErrorIconAlignment.MiddleRight);
            if (String.IsNullOrEmpty(str))
            {
                dxErrorProvider_Digit.SetError(txt, "This infomation can not null !");
            }
            else
            {

                dxErrorProvider_Digit.ClearErrors();
                dxValidationProvider1.Validate();
            }
        }


        private void EditText_Digit_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            if (dxValidationProvider1.Validate())
                dxErrorProvider_Digit.ClearErrors();
        }
    }
    class CustomValidationRule_Digit : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            string str = (string)value;
            bool res = false;
            res = str.All(t => char.IsDigit(t));
            return res;
        }
    }
}
