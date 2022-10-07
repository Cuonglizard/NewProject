using System;
namespace Project
{
    public class Student : People
    {
        public string MSSV { get; set; }

        public Student()
        {
        }

        public override void Input() {
            base.Input();

            Console.WriteLine("Nhap MSV: ");
            MSSV = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.Write(", MSV: {0}", MSSV);
            Console.WriteLine("");
        }

        public void ShowMessage() {
            Console.WriteLine("Minh la sinh Vien DHBK");
        }
    }
}
