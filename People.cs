using System;
namespace Project
{
    public class People
    {
        public string Fullname { get; set; }
        public string Sex { get; set; }
        public string Birthday { get; set; }

        public People()
        {
        }

        public virtual void Input() {
            Console.WriteLine("Nhap Ten: ");
            Fullname = Console.ReadLine();

            Console.WriteLine("Nhap Gioi Tinh: ");
            Sex = Console.ReadLine();

            Console.WriteLine("Nhap Ngay Sinh: ");
            Birthday = Console.ReadLine();
        }

        public virtual void Display() {
            Console.Write("Ten: {0}, Gioi Tinh: {1}, Ngay Sinh: {2}", Fullname, Sex, Birthday);
        }

     
        public void Running() {
            Console.WriteLine("{0} dang chay", Fullname);
        }


        public void Running(string msg)
        {
            Console.WriteLine("{0} dang chay >> {1}", Fullname, msg);
        }
    }
}
