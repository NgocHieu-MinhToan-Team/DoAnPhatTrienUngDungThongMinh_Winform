using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using DAL_PPL;
// lib for firebase "fileSharp"

// export, import  excel 
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

using System.Collections;
using System.Windows;

namespace BLL_PPL
{
    public class BLL_Staff
    {

        public BLL_Staff() { }

        public static  List<STAFF> getStaffs()
        {
            return DAL_Staff.getStaffs();
        }


        public static List<GROUP_USER> readGroupUser()
        {
            return DAL_Staff.getGroupUsers();
        }

        public static bool validateCreateStaff(STAFF staff)
        {

            if (GeneralMethods.isLetterOrDigit(staff.USERNAME_STAFF, false)
                && GeneralMethods.isLetterOrDigit(staff.PASSWORD_STAFF, false)
                && GeneralMethods.isLetter(staff.SURNAME_STAFF, true)
                && GeneralMethods.isLetter(staff.NAME_STAFF, true)
                && GeneralMethods.isDigit(staff.NUMBER_PHONE, false)
                && GeneralMethods.isLetter(staff.ADDRESS_STAFF, true)
               )
            {
                if (!staff.DATE_OF_BIRTH.HasValue) 
                { 
                    MessageBox.Show("Date of birth is not selected !");
                    return false;
                }
                if (staff.GENDER_STAFF < 0) 
                { 
                    MessageBox.Show("gender is not selected !");
                    return false;
                }
                if (staff.ID_GROUP == null) 
                { 
                    MessageBox.Show("gender is not selected !");
                    return false; 
                }
                return true;
            }
            else
            {
                MessageBox.Show("please fill full infomation !");
                return false;
            }
        }

        public static bool insertStaff(STAFF data)
        {
            try
            {
                if (DAL_Staff.insertStaff(data))
                {
                    MessageBox.Show("Insert Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Insert Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool deleteStaff(STAFF data)
        {
            try
            {
                if (DAL_Staff.deleteStaff(data))
                {
                    MessageBox.Show("Delete Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Delete Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool updateStaff(STAFF data)
        {
            try
            {
                if (DAL_Staff.updateStaff(data))
                {
                    MessageBox.Show("Update Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Update Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool checkPrimaryKey(string s)
        {
            try
            {
                List<STAFF> list = DAL_Staff.getStaffs();
                foreach(STAFF item in list)
                {
                    if (item.USERNAME_STAFF == s)
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool checkLogin(string username,string password)
        {
            try
            {
                if (GeneralMethods.isLetterOrDigit(username, false) && GeneralMethods.isLetterOrDigit(password,false))
                {
                    List<STAFF> list = BLL_Staff.getStaffs();
                    STAFF account = list.SingleOrDefault(t => t.USERNAME_STAFF == username && t.PASSWORD_STAFF == password);
                    if (account != null)
                        return true;
                }
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
