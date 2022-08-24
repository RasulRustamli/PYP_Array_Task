
//Tum Tasklar Array Sinifi olucak
#region TaskException
string[] arr = { "eleman1", "eleman2", "eleman3", "array", "array2 " };
string[] arr2 = { "car", "bmw", "mercedes" };
Console.WriteLine(MoreThanElement(arr));
Console.WriteLine(ArrayContainElement(arr, "eleman1"));
GetArrayElement(arr);
GetArrayStarElment(arr, "a");
int[] a = { 1, 3, 4, 2, 4, 2 };
int[] b = { 3, 1, 5, 6, 7 };
CreateDiffirentElementArray(a, b);
#endregion


#region Task1
// bir dizi içerisinde bir eleman birden fazla olup olmadığını kontrol eden bir kod bloğu

bool MoreThanElement(string[] array)
{
    var result = Array.Exists(array, e => array.Count(val => val == e) > 1);

    return result;
}

#endregion

#region Task2
//dizi içerisinde bir elemanın var olup olmadığını kontrol ediniz, bu değer bool tipinde olacak
bool ArrayContainElement(string[] array, string element)
{
    return Array.Exists(array, e => array.Contains(element));

}
#endregion

#region Task3
// içerisinde birden fazla eleman tanımladığınız dizi içerisindeki elemanları, for, foreach, while, do-while döngüsü kullanmadan ekrana yazdırınız


void GetArrayElement(string[] array, int i = 0)
{

    if (array.Length != i)
    {
        Console.WriteLine(array[i]);
        i++;
        GetArrayElement(array, i);
    }

}
#endregion


#region Task4
//metinsel bir dizi içerisindeki değerlerde,  verdiğiniz değer ile başlayan tüm elemanları ekrana yazdırınız.

void GetArrayStarElment(string[] array, string startelemt)
{
    string[] result = Array.FindAll(array, element => element.StartsWith(startelemt));
    GetArrayElement(result);

}
#endregion

#region Task5
//var olan 2 dizinin elemanlarını ekrana yazdırınız.
void GetTwoArrayElment(string[] arr, string[] arr2)
{
    Array.ForEach(arr, element => Console.WriteLine(element));
    Array.ForEach(arr2, element => Console.WriteLine(element));

}
#endregion

#region Task 6
// sayısal 2 dizi içerisinde yer alan farklı elemanları yeni bir diziye, aynı olanları yeni bir diziye ekleyiniz.

void CreateDiffirentElementArray(int[] arr, int[] arr2)
{
    int[] someResult;
    

    int[] diffirent = arr.Union(arr2).Except(arr.Intersect(arr2)).ToArray();
    
    if (arr.Length > arr2.Length)
    {
        someResult = Array.FindAll(arr, element =>
       Array.Exists(arr2, element2 => element.Equals(element2)));



    }
    else
    {
        someResult = Array.FindAll(arr2, element =>
      Array.Exists(arr, element2 => element.Equals(element2)));



       
    }



    Array.ForEach(someResult, element => Console.WriteLine(element));
    Console.WriteLine("------------------------------------------------");

    Array.ForEach(diffirent.ToArray(), element => Console.WriteLine(element));

}

#endregion





