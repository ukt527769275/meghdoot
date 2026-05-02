using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Security.Cryptography;
using System.Drawing;

namespace AGROMET_COMMON
{
    public class DocumentInfo
    {
        public string FileName { set; get; }
        public string ContentType { set; get; }
        public long ContentLength { get; set; }
        public byte[] ByteStream { set; get; }
        public Stream objStream { set; get; }
        public string base64 { set; get; }
        public string ContainerName { get; set; }
        public string EntityType { get; set; }
    }
    public class GetDocumentResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { set; get; }
        public string ErrorMessage { get; set; }
        public string ReturnURL { get; set; }
        public string LargeImgBlobURL { get; set; }
        public string LargeImgBlobFileName { set; get; }
        public string ThumbnailImgBlobURL { set; get; }
        public string ThumbnailImgBlobFileName { get; set; }
        public string AudioURL { get; set; }
        public byte[] AudioURL_bytes { get; set; }
        public byte[] ImageURl_bytes { get; set; }
        public byte[] ThumbnailURl_bytes { get; set; }
        public string AudioURLV1 { get; set; }
        public string AudioThumbnailURL { get; set; }
        public string videoURL { set; get; }
        public string videoThumbNailURL { get; set; }
        public string videoFileName { set; get; }
        public string videoThumbNailName { get; set; }
        public DocumentInfo objDocumentInfo { set; get; }
        public static string ImageNew = "";
        private static string GetSharedAccessSignature(string ContainerName)
        {
            Microsoft.WindowsAzure.Storage.CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Microsoft.Azure.CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(ContainerName);
            BlobContainerPermissions containerPermissions = new BlobContainerPermissions();
            containerPermissions.SharedAccessPolicies.Add(
               "mypolicy1", new SharedAccessBlobPolicy()
               {
                   SharedAccessStartTime = DateTime.UtcNow.AddMinutes(-1),
                   SharedAccessExpiryTime = DateTime.UtcNow.AddMinutes(20),
                   Permissions = SharedAccessBlobPermissions.Read
               });
            containerPermissions.PublicAccess = BlobContainerPublicAccessType.Off;
            container.SetPermissions(containerPermissions);
            return container.GetSharedAccessSignature(new SharedAccessBlobPolicy(), "mypolicy1");
        }
        public static string GetImageFromByte()
        {

            return ImageNew;
        }
        public string GetImageFromByteV1()
        {
            string Image = "";



            return Image;
        }
        public byte[] RetrieveDocumentUri_Bytes(string uri, string ContainerName)
        {
            string blobURL = string.Empty;
            byte[] blobURL_bytes = null;
            if (uri != string.Empty)
            {

                string sasToken = GetSharedAccessSignature(ContainerName);
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Microsoft.Azure.CloudConfigurationManager.GetSetting("StorageConnectionString"));
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClient.GetContainerReference(ContainerName);
                var blob = container.GetBlockBlobReference(uri);
                blobURL = blob.Uri.AbsoluteUri + sasToken;
                CloudBlob cloudBlob = container.GetBlockBlobReference(uri);
                // CloudBlob cloudBlob = blob.Uri.AbsoluteUri + sasToken;
                // CloudBlob cloudBlob = container.GetBlockBlobReference(uri);
                WebClient wc = new WebClient();
                blobURL_bytes = wc.DownloadData(blobURL);
                // string blobURL_bytes = wc.DownloadData(blobURL);
            }
            return blobURL_bytes;
        }
        
        public GetDocumentResponse()
        {
            this.objDocumentInfo = new DocumentInfo();
        }
    }
    public class Utilities
    {

        public static CloudBlobClient blobStorage { get; private set; }

        public static string storageAccountName = ConfigurationManager.AppSettings["AccountName"].ToString();
        public static string storageAccountKey = ConfigurationManager.AppSettings["AccountKey"].ToString();
        public static string ImageContainerName = ConfigurationManager.AppSettings["ImageContainerName"].ToString();
        public static string AudioContainerName = ConfigurationManager.AppSettings["AudioContainerName"].ToString();
        public static string VideoContainerName = ConfigurationManager.AppSettings["VideoContainerName"].ToString();
        public static string ThumbNailContainerName = ConfigurationManager.AppSettings["ThumbNailContainerName"].ToString();
        public static string DocumentContainerName = ConfigurationManager.AppSettings["documentcontainername"].ToString();
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        public static string Encrypt(string originalString)
        {
            if (String.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException
                       ("The string which needs to be encrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);

        }
        public static string Decrypt(string cryptedString)
        {
            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException
                   ("The string which needs to be decrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream
                    (Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }
        public static string RetrieveDocumentUri_Params(string URI, string ContainerName)
        {
            string blobURL = string.Empty;
            if (URI != string.Empty)
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Microsoft.Azure.CloudConfigurationManager.GetSetting("StorageConnectionString"));
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClient.GetContainerReference(ContainerName);
                //BlobContainerPermissions containerPermissions = new BlobContainerPermissions();
                //containerPermissions.PublicAccess = BlobContainerPublicAccessType.Off;
                //container.SetPermissions(containerPermissions);
                var blob = container.GetBlockBlobReference(URI);
                blobURL = blob.Uri.AbsoluteUri;

            }
            return blobURL;
        }
        static Size GetThumbnailSize(Image original)
        {
            // Maximum size of any dimension.
            const int maxPixels = 120;

            // Width and height.
            int originalWidth = original.Width;
            int originalHeight = original.Height;

            // Compute best factor to scale entire image based on larger dimension.
            double factor;
            if (originalWidth > originalHeight)
            {
                factor = (double)maxPixels / originalWidth;
            }
            else
            {
                factor = (double)maxPixels / originalHeight;
            }

            // Return thumbnail size.
            return new Size((int)(originalWidth * factor), (int)(originalHeight * factor));
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public static GetDocumentResponse SaveImageUpload(DocumentInfo objDocumentInfo)
        {
            GetDocumentResponse objResponse = new GetDocumentResponse();
            MemoryStream objMemeory = new MemoryStream();
            byte[] buffer = objDocumentInfo.ByteStream;         
            Stream InputStream = new MemoryStream(buffer);
            try
            {
                #region oldCode without SAS Token
                CloudStorageAccount storageAccount = new CloudStorageAccount(new StorageCredentials(storageAccountName, storageAccountKey), true);
                blobStorage = storageAccount.CreateCloudBlobClient();              
                CloudBlobContainer container = blobStorage.GetContainerReference(ImageContainerName);
                if (container.CreateIfNotExists())
                {
                    var permissions = container.GetPermissions();
                    permissions.PublicAccess = BlobContainerPublicAccessType.Container;
                    container.SetPermissions(permissions);
                }

                string uniqueBlobName = string.Format("image_{0}{1}", Guid.NewGuid().ToString(), Path.GetExtension(objDocumentInfo.ContentType));
                CloudBlockBlob blob = container.GetBlockBlobReference(uniqueBlobName);

                blob.Properties.ContentType = objDocumentInfo.ContentType;
                blob.UploadFromStream(InputStream);

                objResponse.LargeImgBlobURL = blob.Uri.ToString();
                objResponse.LargeImgBlobFileName = uniqueBlobName;

                #endregion                
                //  Thumbnail Image Code    

                #region Oldcode for ThumbNail Generating without SAS Token

                MemoryStream ms = new MemoryStream(buffer);
                Image objimage = System.Drawing.Image.FromStream(ms);

                Size thumbnailSize = GetThumbnailSize(objimage);
                Image thumbnailImg = objimage.GetThumbnailImage(thumbnailSize.Width, thumbnailSize.Height, null, IntPtr.Zero);
                Bitmap bm = new Bitmap(thumbnailImg);

                byte[] bytearrayformat = ImageToByte(thumbnailImg);
                Stream mss = new MemoryStream(bytearrayformat);

                //CloudBlobContainer containers = blobStorage.GetContainerReference("productimages");
                //   /*
                CloudBlobContainer containers = blobStorage.GetContainerReference(ThumbNailContainerName);
                if (containers.CreateIfNotExists())
                {
                    var permissions = containers.GetPermissions();
                    permissions.PublicAccess = BlobContainerPublicAccessType.Container;
                    containers.SetPermissions(permissions);
                }

                string uniqueBlobNames = string.Format("image_{0}{1}", Guid.NewGuid().ToString(), Path.GetExtension(objDocumentInfo.FileName));
                CloudBlockBlob blobs = containers.GetBlockBlobReference(uniqueBlobNames);
                blobs.Properties.ContentType = objDocumentInfo.ContentType;
                blobs.UploadFromStream(mss);
                objResponse.ThumbnailImgBlobURL = blobs.Uri.ToString();
                objResponse.ThumbnailImgBlobFileName = uniqueBlobNames;
              
                objResponse.ImageURl_bytes = bytearrayformat;

                #endregion
                
                objResponse.IsSuccessful = true;
                objResponse.SuccessMessage = "Success";

            }
            catch (Exception ex)
            {
                objResponse.IsSuccessful = false;
                objResponse.ErrorMessage = ex.Message;
            }
            return objResponse;
        }
        public static string GetResponse(string sURL)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL);
            request.MaximumAutomaticRedirections = 4;
            request.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string sResponse = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
                return sResponse;

            }
            catch
            {
                return "";
            }
        }
        public static void SendSMS(string Message, string MobileNumber)
        {
            string sUser = ConfigurationManager.AppSettings["smsuserName"];
            string spwd = ConfigurationManager.AppSettings["smsPassword"];
            string senderid = ConfigurationManager.AppSettings["smsSenderID"];
            string sNumber = MobileNumber;
            string url = "https://www.smsgateway.center/SMSApi/rest/send?userId=" + sUser + "&password=" + spwd + "&senderId=" + senderid + "&sendMethod=simpleMsg&msgType=TEXT&msg=" + Message + "&mobile=91" + MobileNumber + "&duplicateCheck=true&format=json";
            string sResponse = GetResponse(url);
        }
        public static void SendSMS_Lang(string Message, string MobileNumber)
        {
            string sUser = ConfigurationManager.AppSettings["smsuserName"];
            string spwd = ConfigurationManager.AppSettings["smsPassword"];
            string senderid = ConfigurationManager.AppSettings["smsSenderID"];
            string sNumber = MobileNumber;
            string url = "https://www.smsgateway.center/SMSApi/rest/send?userId=" + sUser + "&password=" + spwd + "&senderId=" + senderid + "&sendMethod=simpleMsg&msgType=UNICODE&msg=" + Message + "&mobile=91" + MobileNumber + "&duplicateCheck=true&format=json";
            string sResponse = GetResponse(url);
        }
    }
}
