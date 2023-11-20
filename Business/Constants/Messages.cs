using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Brand Messages
        public static string BrandAdded = "Brand Eklendi";
        public static string BrandDeleted="Brand Silindi";
        public static string BrandUpdated = "Brand Güncellendi";
        public static string BrandsListed = "Brand Listelendi";

        //Car Messages
        public static string CarAdded = "Car Eklendi";
        public static string CarDeleted = "Car Silindi";
        public static string CarUpdated = "Car GÜncellendi";
        public static string CarsListed = "Car Listelendi";

        //Color Messages
        public static string ColorAdded = "Color Eklendi";
        public static string ColorDeleted = "Color Silindi";
        public static string ColorUpdated = "Color Güncelledi";
        public static string ColorsListed = "Color Listelendi";

        //User Messages
        public static string UserAdded = "User Eklendi";
        public static string UserDeleted = "User Silindi";
        public static string UserUpdated = "User Güncelledi";
        public static string UsersListed = "User Listelendi";

        //Customer Messages
        public static string CustomerAdded = "Customer Eklendi";
        public static string CustomerDeleted = "Customer Silindi";
        public static string CustomerUpdated = "Customer Güncelledi";
        public static string CustomersListed = "Customer Listelendi";

        //Rental Messages
        public static string RentalAdded = "Rental Eklendi";
        public static string RentalNotAdded = "Rental Eklenmedi";
        public static string RentalDeleted = "Rental Silindi";
        public static string RentalUpdated = "Rental Güncelledi";
        public static string RentalsListed = "Rental Listelendi";

        public static string MaintenanceTime = "Sistem Bakımda";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
