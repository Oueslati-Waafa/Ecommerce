using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce
{
    public class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;


        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "Adqihjd35QDJzVb0v8Y8cCvC7zQTpVWm-g5ymq-DSNeAqUZAZVM3xExAglOYbLJ3XFoUwjHCWrFl1w1k";
            clientSecret = "EJ8ngs9zC7BE09Q2I8oX652aLDEbrFb2hKkQ6-OZwlsPVtojt5ACdkTnWX309wZ40UbFD9ljUgVx4bxv";
        }

        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }

        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }
}