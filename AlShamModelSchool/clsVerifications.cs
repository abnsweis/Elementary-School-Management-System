using BusinessLogicLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
 
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool
{
    internal class clsVerifications
    {
        // Validate Field With Label
        static public bool ValidateFieldWithLabel(Guna2TextBox Field, Label lable)
        {
            lable.Text = $"{lable.Tag} Required";
            if (string.IsNullOrEmpty(Field.Text.Trim()) || string.IsNullOrWhiteSpace(Field.Text.Trim()))
            {

                Field.BorderColor = Color.Red;
                lable.Visible = true;
                Field.FocusedState.BorderColor = Color.Red;
                Field.Focus();
                return false;
            } else
            {

                Field.BorderColor = Color.Silver;
                Field.FocusedState.BorderColor = Color.Silver;
                lable.Visible = false;
                return true;
            }

        }
 
        static public bool IsValidEmail(Guna2TextBox EmailTextBox, Label lable)
        {
            if (!EmailTextBox.Text.Trim().EndsWith("@gmail.com"))
            {
                SetErrorToField(EmailTextBox,lable, "Invalid Email Address",true);

 
                return false;
            }
             else
            {
                SetErrorToField(EmailTextBox, lable, "", false);
  
                return true;
            }
        }
        static public bool IsEmailAlreadyExists(Guna2TextBox EmailTextBox, Label lable)
        {
            if (clsPerson.IsPersonExist(EmailTextBox.Text.Trim()))
            {
                SetErrorToField(EmailTextBox, lable, "Email is Already exists", true);
                return true;
            } else
            {
                SetErrorToField(EmailTextBox, lable, "", false);

                return false;
            }
              
        }
        static public bool IsValidNationalID(Guna2TextBox NationalIDTextBox, Label lable)
        {
            if (!NationalIDTextBox.Text.Trim().StartsWith("SY"))
            {
                SetErrorToField(NationalIDTextBox, lable, "National ID must start with (SY).", true);

 
                return false;
            }
            else   
            {
                SetErrorToField(NationalIDTextBox, lable, "", false);
                return true;
            }
        }
        
        static public bool IsNationalIDAlreadyExists(Guna2TextBox NationalIDTextBox, Label lable)
        {
            if (clsPerson.IsPersonExistByNationalID(NationalIDTextBox.Text.Trim()))
            {

                SetErrorToField(NationalIDTextBox, lable, "National ID is Already exists", true);

                return true;
            } else   
            {
                SetErrorToField(NationalIDTextBox, lable, "", false);
                return false;
            }
        }

        static public bool IsValidUsername(Guna2TextBox UsernameTextBox, Label lable)
        {
            if (!ValidateFieldWithLabel(UsernameTextBox, lable)) return false;


            if (clsUser.IsUserExist(UsernameTextBox.Text.Trim()))
            {
                SetErrorToField(UsernameTextBox, lable, "Username is Already exists", true);
                 
                return false;
            } else
            {
                SetErrorToField(UsernameTextBox, lable, "", false);
                return true;
            }
        }

        // Is Matched Password
        static public bool IsMatchedPassword(Guna2TextBox TextBoxPassword, Guna2TextBox TextBoxConfirmPassword, Label lable)
        {
            if (string.IsNullOrWhiteSpace(TextBoxConfirmPassword.Text.Trim()))
            {
                lable.Text = $"{TextBoxConfirmPassword.Tag} Requierd ";
                TextBoxConfirmPassword.BorderColor = Color.Red;
                lable.Visible = true;
                TextBoxConfirmPassword.FocusedState.BorderColor = Color.Red;
                TextBoxConfirmPassword.Focus();
                return false;
            }

            if (TextBoxPassword.Text.Trim() != TextBoxConfirmPassword.Text.Trim())
            {
                lable.Text = $"{TextBoxConfirmPassword.Tag} Not Matched ";
                TextBoxConfirmPassword.BorderColor = Color.Red;
                lable.Visible = true;
                TextBoxConfirmPassword.FocusedState.BorderColor = Color.Red;
                TextBoxConfirmPassword.Focus();
                return false;
            } else
            {

                TextBoxConfirmPassword.BorderColor = Color.Silver;
                TextBoxConfirmPassword.FocusedState.BorderColor = Color.Silver;
                lable.Visible = false;
                return true;
            }

        }



        public static void SetErrorToField(Guna2TextBox Field, Label lable, string ErrorMessage, bool ActiveError = true)
        {

            if (ActiveError)
            {

                lable.Text = ErrorMessage;
                Field.BorderColor = Color.Red;
                lable.Visible = true;
                Field.FocusedState.BorderColor = Color.Red;
                Field.Focus();

            } else
            {
                ClearError(Field, lable);
            }
        }

        public static void ClearError(Guna2TextBox Field, Label lable)
        {
            lable.Text = "";
            Field.BorderColor = Color.Silver;
            Field.FocusedState.BorderColor = Color.Silver;
            lable.Visible = false;
        }
        

    }
}
