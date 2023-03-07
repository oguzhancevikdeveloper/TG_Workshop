using System.Collections;
using System.Security.Cryptography;

// C# da LINQ kullanarak integer ve string değerleri olan bir array listesinde sadece stringleri gösteren bir kod geliştirmeni istiyoruz.
Object[] list = { "James", 5, "Steve", "Robert", 9, "Kirk", 2 };
var intQuery = from item in list where item.GetType() == typeof(int) select item;
var stringQuery = from item in list where item.GetType() == typeof(string) select item;



// C# da string bir array list içerisinde yazılan numaraları linq kullanarak sıralama yapan bir kod geliştirmeni istiyoruz.
string[] list2 = { "7", "1", "4", "3", "9", "0" };
var sortList = from item in list2 orderby item.Length, item select item;

