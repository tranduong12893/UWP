﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fried_Chicken.Adapters
{
    sealed class ApiURL
    {
        private readonly string baseURL = "http://foodgroup.herokuapp.com";

        private static ApiURL instance;

        private ApiURL()
        {

        }
        // singleton pattern -- "design pattern"
        public static ApiURL GetInstance()
        {
            if (instance == null)
            {
                instance = new ApiURL();
            }
            return instance;
        }
        public string GetApiCategories()
        {
            return String.Format(baseURL + "/api/menu");
        }
        public string GetApiTodaySpecial()
        {
            return String.Format(baseURL + "/api/today-special");
        }
        public string GetApiCategoryDetail(int id)
        {
            return String.Format(baseURL + "/api/category/" + Convert.ToString(id));
        }
        public string GetApiFoodDetail(int id)
        {
            return String.Format(baseURL + "/api/food/" + Convert.ToString(id));
        }
        public string GetApiProduct(int id)
        {
            return String.Format(baseURL + "/api/food/" + Convert.ToString(id));
        }
    }
}
