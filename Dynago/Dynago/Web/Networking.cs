using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dynago
{
    class Networking
    {      
        public static string ShareUpload(string type, string data) {
            try {
                using (WebClient web = new WebClient()) {
                    web.Headers.Add("user-agent", "Dynago");
                    web.NullifyProxy();
                    NameValueCollection values = new NameValueCollection();
                    values["type"] = type;
                    values["data"] = data;
                    byte[] responseBytes = web.UploadValues(Program.url_share_upload, values);
                    string response = Encoding.Default.GetString(responseBytes);
                    if (response.Contains("success")) 
                        return response.Replace("success: ", "");
                }
            } catch (Exception) { }
            return string.Empty;
        }
        
        public static string ShareDownload(string type, string id) {
            try {
                using (WebClient web = new WebClient()) {
                    web.Headers.Add("user-agent", "Dynago");
                    web.NullifyProxy();
                    NameValueCollection values = new NameValueCollection();
                    values["type"] = type;
                    values["id"] = id;
                    byte[] responseBytes = web.UploadValues(Program.url_share_download, values);
                    string response = Encoding.Default.GetString(responseBytes);
                    if (response.Contains("success"))
                        return response;
                }
            } catch (Exception) { }
            return string.Empty;
        }
        
        public static void DownloadFile(string url, string path) {
            // Make sure the directory I'm downloading the file to exists.
            string dirPath = Path.GetDirectoryName(path);
            if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
            using (WebClient web = new WebClient()) {
                web.Headers.Add("user-agent", "Dynago");
                web.NullifyProxy();
                web.DownloadFile(url, path);
            }
        }
        
        public static bool Notify(string title, string message, string username = "N/A") {
            try {
                using (WebClient web = new WebClient()) {
                    web.Headers.Add("user-agent", "Dynago");
                    web.NullifyProxy();
                    NameValueCollection values = new NameValueCollection();
                    values["title"] = title;
                    values["message"] = message;
                    values["username"] = username;
                    values["version"] = Program.currentVersion;
                    web.UploadValues(Program.url_notify, values);
                    return true;
                }
            } catch (Exception) { }
            return false;
        }
   
        public static string GetData(string name)
        {
            string responseString = string.Empty;
            using (WebClient web = new WebClient())
            {
                web.Headers.Add("user-agent", "Dynago");
                web.NullifyProxy();
                NameValueCollection values = new NameValueCollection();
                values["name"] = name;
                byte[] responseArray = web.UploadValues(Program.url_data, values);
                responseString = Encoding.Default.GetString(responseArray);
            }
            try
            {
                dynamic ResultData = JsonConvert.DeserializeObject(responseString);
                if (ResultData.status == "successful") return ResultData.result;
            } catch (Exception) { }
            return string.Empty;
        }
       
        public static dynamic Login(string username, string password)
        {
            string responseString = string.Empty;
            using (WebClient web = new WebClient())
            {
                web.Headers.Add("user-agent", "Dynago");
                web.NullifyProxy();
                NameValueCollection values = new NameValueCollection();
                values["username"] = username;
                values["password"] = password;
                byte[] responseArray = web.UploadValues(Program.url_login, values);
                responseString = Encoding.Default.GetString(responseArray);
            }
            dynamic ResultData = null;
            try
            {
                ResultData = JsonConvert.DeserializeObject(responseString);
                return ResultData;
            }
            catch (Exception) { return null; }
        }
        
        public static dynamic Register(string username, string password1, string password2)
        {
            if (password1 != password2)
            {
                string jsonInfo = "{\"status\":\"failed\",\"detail\":\"password mismatch\"}";
                return JsonConvert.DeserializeObject(jsonInfo);
            }
            string responseString = string.Empty;
            using (WebClient web = new WebClient())
            {
                web.Headers.Add("user-agent", "Dynago");
                web.NullifyProxy();
                NameValueCollection values = new NameValueCollection();
                values["username"] = username;
                values["password"] = password1;
                byte[] responseArray = web.UploadValues(Program.url_register, values);
                responseString = Encoding.Default.GetString(responseArray);
            }
            dynamic ResultData = null;
            try
            {
                ResultData = JsonConvert.DeserializeObject(responseString);
                return ResultData;
            }
            catch (Exception ex) {
                return JsonConvert.DeserializeObject($"{{\"status\":\"failed\",\"detail\":\"{ex.StackTrace.Replace("\\", "")}\"}}");
            }
        }
    }
}
