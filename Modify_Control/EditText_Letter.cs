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
    public partial class EditText_Letter : TextEdit
    {
        CustomValidationRule_Letter customValidationRule;
        public EditText_Letter()
        {
            InitializeComponent();
            customValidationRule = new CustomValidationRule_Letter();
            customValidationRule.ErrorText = "It must be a character include [ a - z , A - Z ]";
            customValidationRule.ErrorType = ErrorType.Warning;
        }

        private void EditText_Letter_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            string str = (string)txt.EditValue;
            dxValidationProvider1.SetValidationRule(txt, customValidationRule);

            // 
            dxErrorProvider_letter.SetIconAlignment(txt, ErrorIconAlignment.MiddleRight);
            dxValidationProvider1.SetIconAlignment(txt, ErrorIconAlignment.MiddleRight);
            if (String.IsNullOrEmpty(str))
            {
                dxErrorProvider_letter.SetError(txt, "This infomation can not null !");
            }
            else
            {

                dxErrorProvider_letter.ClearErrors();
                dxValidationProvider1.Validate();
            }
        }

        private void EditText_Letter_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            if (dxValidationProvider1.Validate())
                dxErrorProvider_letter.ClearErrors();
        }
    }
    class CustomValidationRule_Letter : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            string str = (string)value;
            bool res = false;
            res = str.All(t => char.IsLetter(t));
            return res;
        }
    }
}
