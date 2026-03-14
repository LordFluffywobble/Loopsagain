

using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;

int input = int.Parse(Console.ReadLine());
string output = "";

//Reverse counting triangle
// int a = 0;

// for (int i = 0; i < input; i++)
// {
//     a += 1;
//     output = "";
    
//     for (int k = 0; k < (input - i - 1); k++)
//     {
//         output += " ";
//     }

//     for (int j = 0; j <= i; j++)
//     {
//     output += a.ToString();
//     }
    
//     Console.WriteLine(output);
// }




//Counting triangle
// int a = 0;


// for (int i = 0; i < input; i++)
// {
//     a += 1;
//     output = "";
    
//     for (int j = 0; j <= i; j++)
//     {
//     output += a.ToString();
//     }
    
//     Console.WriteLine(output);
// }




// X
// int row = 0;
// while (row < input)
// {
//     output= "";
//     for (int i = 0; i < input; i++)
//     {
//         if (i == row || i == (input - 1 - row))
//         {
//             output += "#";
//         }
//         else
//         {
//             output += " ";
//         }
//     }
//     Console.WriteLine(output);
//     row++;
// }





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