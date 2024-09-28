using System; // Thư viện cơ bản cho các thao tác nhập xuất, như Console

/*
 * Các chỉ thị using cho phép bạn sử dụng các lớp và thành phần từ các thư viện mà không cần phải chỉ định đầy đủ tên của chúng. 
 * Ví dụ: 
 *      using System; cho phép sử dụng các lớp trong thư viện System, chẳng hạn như Console.
 */

namespace ConsoleApp1 // Namespace: Định nghĩa một không gian tên để nhóm các lớp liên quan lại với nhau, giúp tránh xung đột tên.
{
    class Hello // Khai báo lớp Hello
    {
        public static void HelloClass() // Phương thức tĩnh HelloClass, có thể gọi mà không cần tạo đối tượng từ lớp Hello
        {
            Console.WriteLine("This is Hello class"); // In ra dòng chữ "This is Hello class"
        }
    }

    class KieuDuLieu
    {
        int a = 1;
        float _float = 2f ;   
        double _double = 3f;

        string _string = "this is class KieuDuLieu string";
        bool _bool = true ;

        char KituA = 'a';
        // float myFloat;   // Đặt tên biến theo quy tắc đặt tên chuẩn
        // myFloat = 6.7f;  // Sử dụng hậu tố 'f' để chỉ định giá trị là float

        object _object = new object 


    }


    internal class Program // Lớp chính chứa hàm Main
    {

        private static int Sum(int x, int y)
        {
            return x + y;
        }

        
        /*
         * internal: Lớp này chỉ có thể được truy cập từ trong cùng một assembly.
         * class Program: Khai báo lớp Program chứa phương thức chính của chương trình.
         */

        static void Main(string[] args) // Phương thức Main là điểm bắt đầu của chương trình.
        {
            /*
             * static: Phương thức Main có thể được gọi mà không cần tạo đối tượng của lớp Program.
             * string[] args: Đây là một mảng các tham số dòng lệnh, tuy nhiên không sử dụng trong ví dụ này.
             */

            Console.WriteLine("Hello world"); // In ra màn hình dòng chữ "Hello world"

            int a = 4; // Khai báo biến số nguyên a và khởi tạo giá trị 0
            int  b = 6; // Khai báo biến số thực b và khởi tạo giá trị 0

            Console.WriteLine(Sum(a, b));
            // In giá trị của biến b (0.0) và a (0) ra màn hình
            Console.WriteLine($"Giá trị của b là: {b}");
            Console.WriteLine($"Giá trị của a là: {a}");

            // Gọi phương thức HelloClass từ lớp Hello
            Hello.HelloClass();

            // Dừng chương trình lại để có thể xem kết quả
            Console.ReadLine();
        }


        

    }
}
