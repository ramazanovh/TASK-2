//TASKin serti

//"MyClass" class-ı yaradırsınız.Aşağıdakı metodları olmalıdır:
//1.Add(T obj) - dərsdə yazmışıq
//2. ShowAll() - dərsdə yazmışdıq
//3. int FindİndexOf(T obj) - bir obyekt qəbul edir və ilk bu obyektə bərabər arrayin hər hansı bir dəyərini tapırsa onun index-sini geri qaytarır. Tapmasa -1
//4. void Remove(T obj) - qəbul etdiyi parameter-ə uyğun object varsa remove etsin.

MyClass<int> myClass = new();
myClass.Add(1);
myClass.Add(2);
myClass.Add(2);
myClass.Add(2);
myClass.Add(3);
myClass.Remove(8);
myClass.ShowAll();
Console.WriteLine(myClass.FirstIndex(2));
