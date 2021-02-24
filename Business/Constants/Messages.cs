using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Sistemimiz şu anda bakımdadır.";
        public static string ProductCountOfCategoryError="Kategorideki ürün sayısı limitini aştınız";

        public static string ProductNameAlreadyExists = "Aynı isimde bir ürün mevcut";
        public static string CategoryLimitExceded = "Kategori sayısı belirlenen limiti aştı";
        internal static string CategoriesListed="Kategoriler listelendi";
    }
}
