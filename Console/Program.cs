
using DataAccess.Concrete.EntityFrameWork;
using Business.Concrete;
using Entity.Abstract;
using Entity.Concrete;


PhoneManager phoneManager = new (new PhoneDal());

Phone phone = new Phone();
phone.Name = "Iphone 8Plus";
phone.Count = 15;
phone.Price = 3500;
phone.Pixel = "1960x2160";
phone.IsDelete = false;

phoneManager.Add(phone);
/*phoneManager.Delete(phone);//Eger phone-da vereceyimiz ID table-mizda varsa silir


foreach (var item in AllPhones)
{
    if (item.Id == 9)
    {
        item.Pixel = "500-1000";
        phoneManager.Delete(item);
    }
}*///Bu ise UI terefinden silinmedir.Cunki biz vereceyimiz ID -e esasen table-i silir


var AllPhones = phoneManager.GetAll();
foreach (var item in AllPhones)
{
    Console.WriteLine(item.Name);
}
/*Computer computer = new Computer();
computer.Id = 1;
computer.Name = "Acer";
computer.Count = 45;
computer.CPU = "12GB";
computer.Price = 2500;
computer.IsDelete = true;*/
/*
Console.WriteLine($"   PHONES       \nId -si: {phone.Id} ,  \nAdi : {phone.Name} \nSayi :{phone.Count} , \nQiymeti: {phone.Price} ");
Console.WriteLine($"   Computers    \nId -si: {computer.Id} ,  \nAdi : {computer.Name} \nSayi :{computer.Count} , \nQiymeti: {computer.Price} ");
Console.WriteLine("    %    \n   % %   \n  % % %  \n % % % % \n% % % % %");*/
