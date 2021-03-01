using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string SystemMaintenance = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductMaxCountOfCategory = "Bir kategoride en fazla 10 tane ürün olabilir.";
        public static string ProductNameAlreadyExist = "Aynı isimde bir ürün eklenemez.";
        public static string MaxCategoryCount = "Mevcut kategori sayısı 15'i geçtiği için ürün eklenemez.";
        public static string AuthorizationDenied = "Bu işlem için yetkiniz bulunmuyor.";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı şifre.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Bu token zaten oluşturuldu.";
    }
}
