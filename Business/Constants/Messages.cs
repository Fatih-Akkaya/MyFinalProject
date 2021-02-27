using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CategoriesListed = "Kategoriler listelendi";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
