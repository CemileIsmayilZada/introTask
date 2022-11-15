//#region task1

//console.writeline("arrayin uzunlugunu yazin : ");
//int arrlength =int.parse(console.readline());
//if (arrlength == 0) { console.writeline("arraydeki eded sayi en azi 1 olmalidir!"); }
//else if (arrlength < 0) { console.writeline("arraydeki eded sayi menfi ola bilmez "); }
//else
//{
//    console.writeline("arrayin elementlerini bir bir daxil edin :");
//    int[] myarr = new int[arrlength]; 
//    int total = 0;
//    for (int i = 0; i < arrlength; i++)
//    {
//        console.writeline("arrayin " + (i + 1) + ". elementi yazin :");
//        myarr[i] = int.parse(console.readline());
//        if (myarr[i] % 2 == 0)
//        {

//            total += myarr[i];
//        }

//    }
//    console.writeline("bu arraydeki cut ededlerin cemi = " + total);
//}
//#endregion




#region Task2
Console.WriteLine("enter 1st word :");
string word1 = Console.ReadLine();
Console.WriteLine("enter 2st word :");
string word2 = Console.ReadLine();
Boolean check = false;
string longWord;
string shortWord;

if(word1.Length > word2.Length)
{
    longWord = word1;
    shortWord = word2;
}
else
{
    longWord = word2;
    shortWord = word1;
}

for(int i = 0; i < longWord.Length; i++)
{
    for(int j=0; j<shortWord.Length; j++)
    {
        if (longWord[i] == shortWord[j])
        {
            check = true;
        }
            
    }
}
if (check = false)
{
    Console.WriteLine("doesnt exist");
}
else
{
    Console.WriteLine("exist");
}






#endregion

