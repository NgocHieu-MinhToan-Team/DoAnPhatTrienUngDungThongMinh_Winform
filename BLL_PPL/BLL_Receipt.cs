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
        public static List<RECEIPT> getList()
        {
            return DAL_Receipt.getList();
        }
        public static List<FPGrowth_Item> getListForFPGrowth()
        {
            List<RECEIPT> listSrc = DAL_Receipt.getListForFPGrowth();

            List<FPGrowth_Item> listFPG = new List<FPGrowth_Item>();
            foreach(RECEIPT itemSrc in listSrc)
            {
                List<DETAIL_RECEIPT> listSrcDetail = DAL_Receipt.getDetailReceiptList(itemSrc.ID_RECEIPT);
                FPGrowth_Item itemFPG = new FPGrowth_Item();
                string note = "";
                foreach(DETAIL_RECEIPT itemSrcDetail in listSrcDetail)
                {
                    note += itemSrcDetail.ID_PRODUCT + ",";
                }
                itemFPG.id_receipt = itemSrc.ID_RECEIPT;
                itemFPG.detail = note.Remove(note.Length - 1, 1);
                listFPG.Add(itemFPG);
            }
            return listFPG;
        }

        public static List<DETAIL_RECEIPT> getDetailReceiptList(string ID)
        {
            return DAL_Receipt.getDetailReceiptList(ID);
        }

        //lay data join tu sql
        public static bool insertReceipt(RECEIPT data)
        {
            return DAL_Receipt.insertReceipt(data);
        }

        public static bool insertDetailReceipt(DETAIL_RECEIPT data)
        {
            return DAL_Receipt.insertDetailReceipt(data);
        }
        public static void export_ReceiptToWord(string id_receipt)
        {
            List< RECEIPT_FULL> listData= DAL_Receipt.getReceiptsJoin(id_receipt);
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

            // get list detail receipt
            List<DETAILRECEIPT_JOIN> listDetail = DAL_Receipt.getDetailReceiptsJoin(id_receipt);
            Table bangThongTinGiaDinh = baoCao.GetChild(NodeType.Table, 0, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;
            bangThongTinGiaDinh.InsertRows(hangHienTai, hangHienTai, 2);
            for (int i = 1; i <= listDetail.Count; i++)
            {
                //bangThongTinGiaDinh.PutValue(hangHienTai, 0, i.ToString());//Cột STT
                bangThongTinGiaDinh.PutValue(hangHienTai, 0, listDetail[i-1].QUANTITY.ToString());// so luong
                bangThongTinGiaDinh.PutValue(hangHienTai, 1, listDetail[i-1].NAME_PRODUCT_VN);//ten mon
                bangThongTinGiaDinh.PutValue(hangHienTai, 2, listDetail[i-1].PRICE.ToString());// don gia
                hangHienTai++;
            }

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("Report.doc");
        }


        public static void export_ReceiptToExcel(){}


        public static bool deleteReceipt(RECEIPT_FULL data)
        {
            try
            {
                if (DAL_Receipt.deleteReceipt(data))
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
    }
}
