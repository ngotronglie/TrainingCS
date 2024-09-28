using System; // Thư viện cơ bản cung cấp các lớp và phương thức cho các thao tác nhập/xuất, như Console.

/*
 * Các chỉ thị using cho phép sử dụng các lớp và thành phần từ các thư viện mà không cần chỉ định đầy đủ tên của chúng.
 * Ví dụ: using System; cho phép sử dụng các lớp trong thư viện System, chẳng hạn như Console.
 */

namespace ConsoleApp1 // Namespace: Tạo một không gian tên để tổ chức các lớp và tránh xung đột tên giữa các lớp khác nhau.
{
    class Hello // Khai báo lớp Hello, có thể chứa các phương thức và dữ liệu.
    {
        public static void HelloClass() // Phương thức tĩnh HelloClass, có thể được gọi mà không cần tạo đối tượng từ lớp Hello.
        {
            Console.WriteLine("This is Hello class"); // In ra màn hình dòng chữ "This is Hello class".
        }
    }

    internal class Program // Lớp chính chứa hàm Main và các phương thức khác, nơi bắt đầu thực thi chương trình.
    {
        /*
         * Phương thức Main là điểm khởi đầu của chương trình. Mọi chương trình C# đều cần có phương thức Main.
         * internal: Lớp Program chỉ có thể được truy cập từ trong cùng một assembly.
         * static: Phương thức Main có thể được gọi mà không cần tạo đối tượng của lớp Program.
         * string[] args: Một mảng chuỗi chứa các tham số dòng lệnh được truyền khi khởi chạy ứng dụng (trong ví dụ này không sử dụng).
         */
        private static int Sum(int x, int y) // Phương thức tĩnh Sum, nhận hai tham số x, y và trả về tổng của chúng.
        {
            return x + y; // Trả về tổng của x và y.
        }

        static void KieuDuLieu() // Phương thức tĩnh KieuDuLieu để minh họa việc sử dụng các kiểu dữ liệu khác nhau.
        {
            int a = 1; // Biến kiểu int lưu trữ số nguyên.
            float _float = 2f; // Biến kiểu float lưu trữ số thực với hậu tố 'f' để chỉ định float.
            double _double = 3f; // Biến kiểu double lưu trữ số thực với độ chính xác cao hơn float.

            string _string = "this is class KieuDuLieu string"; // Biến kiểu string để lưu trữ chuỗi ký tự.
            bool _bool = true; // Biến kiểu bool để lưu trữ giá trị logic (true/false).

            char KituA = 'a'; // Biến kiểu char lưu trữ một ký tự đơn.

            object myObject = new object();  // Khởi tạo một đối tượng mới từ lớp object, là lớp cơ bản nhất trong C#.
            var _varInt = 1; // Sử dụng từ khóa var để khai báo biến kiểu int mà không cần chỉ định kiểu rõ ràng.
            var _varString = "var string"; // Sử dụng từ khóa var để khai báo biến kiểu string mà không cần chỉ định kiểu.
        }

        static void NhapXuatDuLieu() // Phương thức tĩnh NhapXuatDuLieu minh họa cách nhập/xuất dữ liệu từ người dùng.
        {
            Console.ForegroundColor = ConsoleColor.Green; // Đặt màu chữ là màu xanh lá cây.
            Console.BackgroundColor = ConsoleColor.Red; // Đặt màu nền là màu đỏ.
            Console.WriteLine("Đây là dòng có thể xuống dòng"); // In ra màn hình và tự động xuống dòng.
            Console.Title = "This is title"; // Đặt tiêu đề của cửa sổ Console.

            Console.Write("Dòng này không xuống dòng "); // In ra màn hình nhưng không xuống dòng.
            Console.Write("1,2,3"); // In thêm một chuỗi nữa mà không xuống dòng.

            // Nhập và xử lý số thực a và b từ người dùng.
            float a, b;
            string sInput;

            // Nhập giá trị cho biến a.
            Console.WriteLine("Hãy nhập tham số a: ");
            sInput = Console.ReadLine(); // Đọc giá trị nhập từ người dùng.
            a = float.Parse(sInput); // Chuyển chuỗi nhập được thành kiểu float.

            // Nhập giá trị cho biến b.
            Console.WriteLine("Hãy nhập tham số b: ");
            sInput = Console.ReadLine(); // Đọc giá trị nhập từ người dùng.
            b = Convert.ToSingle(sInput); // Chuyển chuỗi nhập được thành kiểu float.

            // Hiển thị giá trị của a và b.
            Console.WriteLine("Số a = {0}, Số b = {1}", a, b); // In ra giá trị của a và b.
        }

        static void ToanTuSoHoc()
        {
            int a = 13;
            int b = 4;
            Console.WriteLine("{0} + {1} = {2}", a,b, a+ b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);

            int x = 5;

            // Sử dụng toán tử tăng tiền tố
            Console.WriteLine("Giá trị của x trước khi tăng (tiền tố): " + ++x); // Tăng x lên 1 và in giá trị (6)

            // Sử dụng toán tử tăng hậu tố
            Console.WriteLine("Giá trị của x sau khi tăng (hậu tố): " + x++); // In giá trị (6), rồi tăng x lên 1
            Console.WriteLine("Giá trị của x bây giờ là: " + x); // In giá trị của x sau khi tăng (7)

            // Reset giá trị của x
            x = 5;

            // Sử dụng toán tử giảm tiền tố
            Console.WriteLine("Giá trị của x trước khi giảm (tiền tố): " + --x); // Giảm x xuống 1 và in giá trị (4)

            // Sử dụng toán tử giảm hậu tố
            Console.WriteLine("Giá trị của x sau khi giảm (hậu tố): " + x--); // In giá trị (4), rồi giảm x xuống 1
            Console.WriteLine("Giá trị của x bây giờ là: " + x); // In giá trị của x sau khi giảm (3)

        }
        static void toanTuNangCao()
        {
            // ----- toan tu so sanh -------
            int a = 10; // Khai báo biến a với giá trị 10
            int b = 20; // Khai báo biến b với giá trị 20

            // Sử dụng toán tử so sánh và in kết quả
            Console.WriteLine("a == b: " + (a == b)); // In ra false vì a không bằng b
            Console.WriteLine("a != b: " + (a != b)); // In ra true vì a khác b
            Console.WriteLine("a > b: " + (a > b));   // In ra false vì a không lớn hơn b
            Console.WriteLine("a < b: " + (a < b));   // In ra true vì a nhỏ hơn b
            Console.WriteLine("a >= b: " + (a >= b)); // In ra false vì a không lớn hơn hoặc bằng b
            Console.WriteLine("a <= b: " + (a <= b)); // In ra true vì a nhỏ hơn hoặc bằng b

            // Thay đổi giá trị của a
            a = 20;

            // Kiểm tra lại các điều kiện
            Console.WriteLine("\nSau khi thay đổi a thành 20:");
            Console.WriteLine("a == b: " + (a == b)); // In ra true vì a bằng b
            Console.WriteLine("a != b: " + (a != b)); // In ra false vì a không khác b
            Console.WriteLine("a > b: " + (a > b));   // In ra false vì a không lớn hơn b
            Console.WriteLine("a < b: " + (a < b));   // In ra false vì a không nhỏ hơn b
            Console.WriteLine("a >= b: " + (a >= b)); // In ra true vì a lớn hơn hoặc bằng b
            Console.WriteLine("a <= b: " + (a <= b)); // In ra true vì a lớn hơn hoặc bằng b


            // ------- toán tử logic ------

            bool condition1 = true;  // Biểu thức điều kiện 1
            bool condition2 = false; // Biểu thức điều kiện 2

            // Sử dụng toán tử AND (&&)
            Console.WriteLine("condition1 && condition2: " + (condition1 && condition2)); // In ra false
                                                                                          // Chỉ in ra true nếu cả condition1 và condition2 đều true

            // Sử dụng toán tử OR (||)
            Console.WriteLine("condition1 || condition2: " + (condition1 || condition2)); // In ra true
                                                                                          // In ra true nếu ít nhất một trong hai điều kiện là true

            // Sử dụng toán tử NOT (!)
            Console.WriteLine("!condition1: " + !condition1); // In ra false
                                                              // In ra true nếu condition1 là false và ngược lại

            // Kiểm tra điều kiện kết hợp
            int h = 5;
            int l = 10;

            // Sử dụng toán tử logic trong điều kiện
            if (h < 10 && l > 5)
            {
                Console.WriteLine("Cả hai điều kiện đều đúng!"); // In ra nếu cả hai điều kiện đều đúng
            }

            if (h < 5 || l > 5)
            {
                Console.WriteLine("Ít nhất một điều kiện đúng!"); // In ra vì b > 5 là đúng
            }

            // Sử dụng toán tử NOT trong điều kiện
            if (!(h == l)) // Nếu a không bằng b
            {
                Console.WriteLine("a và l không bằng nhau!"); // In ra vì a và b không bằng nhau
            }
        }

        
        static void Main(string[] args)
        {
            toanTuNangCao();
            //ToanTuSoHoc();
            // Nhập và xuất dữ liệu từ người dùng
            // NhapXuatDuLieu(); // Gọi phương thức NhapXuatDuLieu để thực thi các thao tác nhập và xuất dữ liệu.
            Console.ReadLine(); // Dừng màn hình console lại để người dùng có thể xem kết quả.
        }
    }
}
