﻿using System;
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


namespace BLL_PPL
{
    public class BLL_Staff
    {
        DAL_Staff dalStaff = new DAL_Staff();

        public BLL_Staff() { }

        public  List<STAFF> readStaff()
        {
            return dalStaff.readStaff();
        }


        public List<GROUP_USER> readGroupUser()
        {
            return dalStaff.readGroupUser();
        }

        public static bool validateCreateStaff(STAFF staff)
        {
            if (staff.USERNAME_STAFF != null
              && staff.PASSWORD_STAFF != null
              && staff.SURNAME_STAFF != null
              && staff.NAME_STAFF != null
              && staff.NUMBER_PHONE != null
              && staff.ADDRESS_STAFF != null
               )
            {
                return true;
            }

            return false;
        }

        public  bool createStaff(STAFF staff)
        {
            return dalStaff.createStaff(staff);
        }

       


    }
}