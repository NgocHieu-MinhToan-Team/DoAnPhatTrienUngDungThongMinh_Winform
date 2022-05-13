using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL_PPL;
using DTO_PPL;
using FireBase_PPL;
// lib for export file word
using Aspose.Words;
using Aspose.Words.Tables;
using System.Windows;

namespace BLL_PPL
{
    public class BLL_Receipt
    {
        
        public BLL_Receipt()
        {

        }
        //lay data tu sql
        public static List<RECEIPT> read_Receipt()
        {
            return DAL_Receipt.readReceipt();
        }

        public static void export_ReceiptToWord(string id_receipt)
        {
            List< RECEIPT_FULL> listData= DAL_Receipt.readReceiptToExport();
            RECEIPT_FULL data = listData.FirstOrDefault(t => t.ID_RECEIPT == id_receipt);
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("Templates\\Export.doc");
            //Bước 2: Điền các thông tin cố định
          
            baoCao.MailMerge.Execute(new[] { "day" }, new[] { homNay.Day.ToString() });
            baoCao.MailMerge.Execute(new[] { "month" }, new[] { homNay.Month.ToString() });
            baoCao.MailMerge.Execute(new[] { "year" }, new[] { homNay.Year.ToString() });
            baoCao.MailMerge.Execute(new[] { "hour" }, new[] { homNay.Hour.ToString() });
            baoCao.MailMerge.Execute(new[] { "minute" }, new[] { homNay.Minute.ToString() });
            baoCao.MailMerge.Execute(new[] { "second" }, new[] { homNay.Second.ToString() });
            baoCao.MailMerge.Execute(new[] { "total_dish" }, new[] { data.TOTAL_PRODUCT.ToString() });
            baoCao.MailMerge.Execute(new[] { "name_customer" }, new[] { data.NAME_CUSTOMER });
            baoCao.MailMerge.Execute(new[] { "total_price" }, new[] { data.TOTAL_PRICE.ToString() });
            baoCao.MailMerge.Execute(new[] { "method_pay" }, new[] { data.NAME_METHOD });

            //Bước 3: Điền thông tin lên bảng
            //Table bangThongTinGiaDinh = baoCao.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            //int hangHienTai = 1;
            //bangThongTinGiaDinh.InsertRows(hangHienTai, hangHienTai, 3);
            //for (int i = 1; i <= 4; i++)
            //{
            //    bangThongTinGiaDinh.PutValue(hangHienTai, 0, i.ToString());//Cột STT
            //    bangThongTinGiaDinh.PutValue(hangHienTai, 1, "Nguyễn Văn A");//Cột Họ và tên
            //    bangThongTinGiaDinh.PutValue(hangHienTai, 2, "Bố đẻ");//Cột quan hệ
            //    bangThongTinGiaDinh.PutValue(hangHienTai, 3, "0123456789");//Cột Số điện thoại
            //    hangHienTai++;
            //}

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("Report.doc");
        }


        public static void export_ReceiptToExcel()
        {
            
        }

        //public async Task<List<RECEIPT>> getReceiptFromFirebase()
        //{
        //    try
        //    {
        //        List<RECEIPT> list = await FB_Receipt.getListReceipt("Database/Receipt/HD01/");
        //        if (list == null) { return null; }
        //        else
        //            return list;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //lay danh sach hoa don tu firebase
        public static async Task<List<RECEIPT>> getReceiptFromFirebase()
        {
            try
            {
                List<RECEIPT> listFromSql = DAL_Receipt.readReceipt();
                List<RECEIPT> list = await FB_Receipt.getListReceipt("Database/Receipt/", listFromSql);
                if (list == null) { return null; }
                else
                    return list;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static bool insertReceiptsToFirebase()
        {
            try
            {
                List<RECEIPT> listFromSql = DAL_Receipt.readReceipt();
                //ConnectFireBase.FirebaseInsertData(listFromSql, "Database/Receipt/");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
