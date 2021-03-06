﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        //Car
        public static string CarAdded = "Car added!";
        public static string CarDeleted = "Car deleted!";
        public static string CarUpdated = "Car updated!";
        public static string CarDetails = "Car details are shown.";
        public static string CarList = "Cars are listed.";
        //Brand
        public static string BrandAdded = "Brand added.";
        public static string BrandDeleted = "Brand deleted.";
        public static string BrandUpdated = "Brand updated.";
        public static string BrandList = "Brands are listed.";
        public static string BrandNameInvalid = "You cannot write a name less than 2 character. Please retry.";
        //Color
        public static string ColorAdded = "Color added.";
        public static string ColorDeleted = "Color deleted.";
        public static string ColorUpdated = "Color updated.";
        public static string ColorList = "Colors are listed.";
        //Rental
        public static string RentalAdded = "Rental added!";
        public static string RentalDeleted = "Rental deleted!";
        public static string RentalUpdated = "Rental updated!";
        public static string RentalList = "Rentals are listed.";
        public static string RentalInvalid = "The car has not returned yet.";
        //User
        public static string UserAdded = "User added!";
        public static string UserDeleted = "User deleted!";
        public static string UserUpdated = "User updated!";
        public static string UserList = "Users are listed.";
        //Customer
        public static string CustomerAdded = "Customer added!";
        public static string CustomerDeleted = "Customer deleted!";
        public static string CustomerUpdated = "Customer updated!";
        public static string CustomerList = "Customers are listed.";
        //CarImages
        internal static string CarImageLimitExceeded= "You cannot add more than 5 images.";
        //DailyPrice
        public static string DailyPriceNoZeroOrLess = "You cannot enter 0 or less for DailyPrice. Please retry.";
        //Maintenance
        public static string MaintenanceTime = "Maintenance has begun.";
        //Authorization and Registeration
        internal static string AuthorizationDenied = "Authorization has been denied.";
        internal static string UserRegistered = "User has been registered successfully.";
        internal static string SuccessfullyLogin = "Successful login.";
        internal static string IncorrectPassword = "Your password is incorrect.";
        internal static string UserAlreadyRegistered = "This user has already registered.";
        internal static string UserNotFound="This user did not found.";
        internal static string TokenCreated="Token created.";
        //Rental and Payments
        public static string Added = " has been added.";
        public static string Updated = " has been updated.";
        public static string Deleted = " has been deleted.";
        public static string NotExist = "There is no such a ";
    }
}
