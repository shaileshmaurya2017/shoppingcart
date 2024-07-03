using ShoppingCart.Model.DB;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace ShoppingCart.Helper
{
    public class FileClass
    {
        public FileClass() { }
        public string Savefile(string data) {
            //string[] dat = data.Trim().Split('/');
          //  string[] newdat = dat[3].Split('=');
            // string newdaa = data.Substring(24);
            //string[] newdat2 = newdaa.Split('=');
            //   string converted = newdat2[0].Replace('-', '+');
            //  converted = converted.Replace('_', '/');

            //Console.WriteLine(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(newdat[0])));

            //string t2 = newdaa.Remove(newdaa.Length - 1, 1);
            //  string converted = data.Replace('-', '+');
            // converted = converted.Replace('_', '/');
            // StringBuilder sb = new StringBuilder();
            //// sb.Append(newdat[0]);
            //  sb.Append("=");
          //     File.WriteAllBytes(@"c:\yourfile\abcnormal.txt", Convert.FromBase64String(newdat[0]));
             // File.WriteAllBytes(@"c:\yourfile\abcnew.txt", Convert.FromBase64String(sb.ToString()));
             // File.WriteAllText(@"c:\yourfile\abctext.txt", data);
            File.WriteAllText(@"c:\yourfile\abctextpd.pdf", data);

            // File.WriteAllBytes(@"c:\yourfile\abc2.txt", Convert.FromBase64CharArray(data.ToCharArray(),0, data.Length));
            /*       Image image;
                   using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(converted))) 
                   {
                       image = Image.FromStream(ms);
                   }
                   image.Save(@"c:\yourfile\imgnormal.jpg", ImageFormat.Png);
            */
            string[] dat = data.Trim().Split(',');
            string[] newdat = dat[1].Split('=');
            string aa = newdat[0].Replace('-', '+').Replace('/', '_');
            byte[] bytes = Convert.FromBase64String(newdat[0]);
            System.IO.FileStream stream =
    new FileStream(@"c:\yourfile\file.pdf", FileMode.CreateNew);
            System.IO.BinaryWriter writer =
                new BinaryWriter(stream);
            writer.Write(bytes, 0, bytes.Length);
            writer.Close();

            return data; }
    }
}
