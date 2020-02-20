using System.IO;
using System.Web;

namespace CF.Common.Tools
{
    public class ImageUtility
    {
        public static string Upload(string serverPath, string imageName, HttpPostedFileBase file)
        {
            serverPath = serverPath.Replace("~", string.Empty); //Gelen dosya yolunda bulunan ~ karakterini kaldırıyoruz.

            if (file != null) //Gelen dosya boş mu diye kontrol ediyoruz
            {
                
                string[] fileArray = file.FileName.Split('.'); //Gelen dosya adında noktadan öncesini ve sonrasını dizi içerisine alıyoruz. Böyle uzantısını elde ediyoruz.
                string extension = fileArray[fileArray.Length - 1].ToLower(); //Alınan dosya uzantısını tamamen büyük harfe çeviriyoruz.
                string fileName = CharUtility.Replace(imageName.ToLower()) + "." + extension; //Dosya adı için bir Guid oluşturup sonuna dosya uzantısını iliştiriyoruz.

                if (extension == "jpg" || extension == "png" || extension == "gif" || extension == "jpeg") //Dosya uzantı kontrolü yapıyoruz.
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath + fileName))) //Aynı isimde bir dosya var mı kontrolü yapıyoruz.
                    {
                        return "0"; //Dosya mevcut ise geriye 0 dönderiyoruz.
                    }
                    else
                    {
                        //Gelen isimde bir dosya yoksa sunucu tarafına dosyayı kaydediyoruz.
                        var filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);
                        file.SaveAs(filePath);
                        return serverPath + fileName;
                    }
                }
                else
                {
                    return "1"; //Dosya uzantısı geçersiz ise geriye 1 dönderiyoruz.
                }
            }
            else
            {
                return serverPath + "noimage.jpg";
            }
        }

        public static void Delete(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }
    }
}