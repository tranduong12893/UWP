using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Fried_Chicken.Adapters;
using Fried_Chicken.Models.Entity;


namespace Fried_Chicken.Services
{
    class ApiService
    {
        public async Task<Categories> GetCategories()
        {
            HttpClient client = new HttpClient();// lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiCategories()); // lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string rsContent = await rs.Content.ReadAsStringAsync();// chuyeenr dữ liệu thành 1 string
                // timf cách convert string ở trên thành 1 object Categories
                Categories categories = JsonConvert.DeserializeObject<Categories>(rsContent);
                return categories;
            }
            return null;
        }

        public async Task<CategoryDetail> CategoryDetail(Category category)
        {
            HttpClient client = new HttpClient();// lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiCategoryDetail(category.id)); // lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string rsContent = await rs.Content.ReadAsStringAsync();// chuyeenr dữ liệu thành 1 string
                                                                        // timf cách convert string ở trên thành 1 object Categories
                CategoryDetail detail = JsonConvert.DeserializeObject<CategoryDetail>(rsContent);
                return detail;
            }
            return null;
        }
        //public async Task<FoodList> FoodDetail(Food food)
        //{
        //    HttpClient client = new HttpClient();// lo việc kết nối api và lấy dữ liệu về (shipper)
        //    ApiURL uRL = ApiURL.GetInstance();
        //    var rs = await client.GetAsync(uRL.GetApiFoodDetail(food.id)); // lấy data từ api về
        //    if (rs.StatusCode == HttpStatusCode.OK)
        //    {
        //        string rsContent = await rs.Content.ReadAsStringAsync();// chuyeenr dữ liệu thành 1 string
        //                                                                // timf cách convert string ở trên thành 1 object Categories
        //        FoodList detail = JsonConvert.DeserializeObject<FoodList>(rsContent);
        //        return detail;
        //    }
        //    return null;
        //}
        public async Task<todaySpecial> GetTodaySpecial()
        {
            HttpClient client = new HttpClient();// lo việc kết nối api và lấy dữ liệu về (shipper)
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiTodaySpecial()); // lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string rsContent = await rs.Content.ReadAsStringAsync();// chuyeenr dữ liệu thành 1 string
                // timf cách convert string ở trên thành 1 object Categories
                todaySpecial food = JsonConvert.DeserializeObject<todaySpecial>(rsContent);
                return food;
            }
            return null;
        }
    }
}
