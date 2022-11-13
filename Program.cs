using PhoneBookApplication.Controllers;
using PhoneBookApplication.Models;
using System;

namespace PhoneBookApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Doğukan", "Sevinç", "123"));
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Özge", "Or", "456"));
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Kamil", "Yazıcı", "789"));
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Mustafa", "Yılmaz", "345"));
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Yasin", "Ergen", "852"));


            OperationController.StartMethods();
            Console.WriteLine("Çıkmak İçin Herhangi Bir Tuşa Basınız...");
            Console.ReadKey();

        }
    }
}