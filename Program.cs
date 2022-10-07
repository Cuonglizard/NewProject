using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tinh ke thua + bao dong.
            Student std = new Student();
            std.Fullname = "Tran Van A";
            std.Input();
            std.Display();

            //Tinh da hinh
            People people = new Student();
            if(people is Student) {
                ((Student)people).ShowMessage();
            }

            //Tinh truu tuong
            // 1 cach tong quat hoa
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.ShowSound();
            dog.ShowSound();
        }
    }
}
