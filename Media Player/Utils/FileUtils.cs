using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Utils
{
    public static class FileUtils
    {
        /// <summary>
        /// Hàm đọc hết nội dung từng dòng của file text
        /// </summary>
        /// <param name="fileName">Đường dẫn đến file</param>
        /// <returns>Một list string, chứa dữ liệu từng dòng trong file.</returns>
        public static List<string> ReadAllLines(string fileName)
        {
            // Tạo một danh sách để lưu trữ nội dung của từng dòng
            List<string> lines = new List<string>();

            // Tạo một đối tượng đọc file bằng cách sử dụng lớp StreamReader
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Đọc từng dòng của file cho đến khi gặp kết thúc file
                while (!reader.EndOfStream)
                {
                    // Lấy nội dung của dòng hiện tại
                    string line = reader.ReadLine();

                    // Thêm nội dung của dòng vào danh sách
                    lines.Add(line);
                }
            }

            // Trả về danh sách nội dung của từng dòng
            return lines;
        }

        /// <summary>
        /// Hàm ghi list string vào file sẵn có
        /// </summary>
        /// <param name="fileName">Đường dẫn đến file text</param>
        /// <param name="lines">Dữ liệu cần ghi vào file</param>
        /// <param name="append">append = true tương ứng với chế độ ghi tiếp vào file. Ngược lại, append = false dùng để ghi đè nội dung file</param>
        public static void WriteAllLines(string fileName, List<string> lines, bool append)
        {
            // Tạo một đối tượng ghi file bằng cách sử dụng lớp StreamWriter
            // Tham số append quyết định chế độ ghi đè hoặc ghi tiếp vào file
            using (StreamWriter writer = new StreamWriter(fileName, append))
            {
                // Ghi từng phần tử của list string vào file
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        public static List<string> ReadResources(string resource_data)
        {
            string[] lines = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return lines.ToList();
        }

        public static void WriteResources(string resource_data, List<string> data)
        {

        }
    }
}
