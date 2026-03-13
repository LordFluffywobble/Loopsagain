

using System.Net.NetworkInformation;

int input = int.Parse(Console.ReadLine());
string output = "";
   


// X
for (int i = 0; i < input; i++)
{   
    string a = "#";
    output   = "" ;

    for (int j = 1; j <= i; j++)
    {
        output += " ";

    }
   
    for (int k = 0; k <= i; k++)
    {
    }
        output += "#";
        Console.WriteLine(output);        
}





//Pyramid
// for (int i = 0; i < input; i++)
//     {
//      output = "";  
        
//     for (int j = 0; j < input - i - 1; j++)
//     {
//         output += " ";
//     }
//         for (int k = 0; k < (2 * i + 1) ; k++)
//     {
//         output += "#";
//     }
//     Console.WriteLine(output);
//     }







//Reverse Triangle
// for (int i = 0; i < input; i++)
// {   
//     output = "";
    
//     for (int j = 0; j < input - i- 1; j++)
//     {
//         output += " ";
//     }

//     for (int k = 0; k <= i; k++)
//     {
//         output += "#";
//     }
//     Console.WriteLine(output);
// }



//triangle1
// for (int i = 0; i < input; i++)
// {
//     // for(int j = 0; j <= i; j++)
//     // {
//     // }
//         output += "#";
//     Console.WriteLine(output);
// }



//square
// for(int i = 0; i < input; i++)
// {   output = "";                   //Resetter stringen til null så det ikke bygger på videre
//     for(int j = 0; j < input; j++)
//     {
//     output += "#";       
//     }
//     Console.WriteLine(output);
// }