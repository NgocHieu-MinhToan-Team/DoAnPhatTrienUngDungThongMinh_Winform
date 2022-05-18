using System.Collections.Generic;
using System.Net.Http;
using DTO_PPL;

namespace CallAPI_PPL
{
    public class CallAPI
    {
        private  static ApiService _apiService = new ApiService();

        public static List<STAFF> GetWatchList()
        {
            var response = _apiService.GetResponse("api/Khoa/");
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<STAFF>>().Result;
            }
            return null;
        }
        //public bool PostKhoa(STAFF pKhoa)
        //{
        //    var response = _apiService.PostResponse("api/Khoa/", pKhoa);
        //    if (response == null)
        //        return false;
        //    else
        //        return true;
        //}
        //public bool XoaKhoa(Khoa pKhoa)
        //{
        //    var response = _apiService.PostResponse("api/Khoa/", pKhoa);
        //    if (response == null)
        //        return false;
        //    else
        //        return true;
        //}
    }
}
