// C#'DA OOP KONUSUNA GİRİS YAPACAGIM
//Proje ekle kısmından bir yeni class eklemesi yaparız.

using Csharp_oop_calisma;

Car car1 = new Car("Ford","Ranger",4,15000); // car1 Car class'ından türetilen bir aractır.


Car car2 = new Car();
car2.marka = "Fiat";
car2.model = "Egea";  //Farklı nesne tanımlama yöntemi
car2.engine = 4;
car2.km = 90000;

Console.WriteLine(car1.marka + " "+ car1.model); //Class elemanlarına göre cagrım yapabiliriz.
Console.WriteLine(car1.marka); //Yapıcı metodumuzun nesnesini cagırdık.





Console.ReadLine();