using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "The system is under maintenance";
        public static string ProductsListed ="Products listed";
        public static string CategoryAdded = "Category added";
        public static string ProductCountofCategoryError= "You exceeded the product limit in the category";
        public static string ProductUpdated="Products updated";
        public static string ProductNameAlreadyExist="Product Name already exists";
        public static string CategoryCountofCategoryError= "New products cannot be added because the category limit is exceeded";
        public static string AuthorizationDenied= "Authorization Denied";
        public static string UserRegistered="User registered";
        public static string UserNotFound="User not found";
        public static string PasswordError="Password Error";
        public static string SuccessfulLogin="Login Success";
        internal static string AccessTokenCreated="AccessToken created";
        internal static string UserAlreadyExists="User already exists";
    }
}
