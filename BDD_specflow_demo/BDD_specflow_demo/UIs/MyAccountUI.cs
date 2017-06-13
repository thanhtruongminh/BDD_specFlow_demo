﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_specflow_demo.UIs
{
    class MyAccountUI
    {
        public static string MY_ACCOUNT_URL = "http://live.guru99.com/index.php/customer/account/login/";
        public static string USERNAME_TXT = "//*[@id='email']";
        public static string PASSWORD_TXT = "//*[@id='pass']";
        public static string LOGIN_BTN = "//*[@id='send2']";
        public static string INVALID_ERROR_MSG = "//li[@class='error-msg']//span[contains(text(),'Invalid login or password.')]";
    }
}
