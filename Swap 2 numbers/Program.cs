﻿int numbers1, numbers2, tempVariable;
Console.Write("\nInput the First Number : ");
numbers1 = Convert.ToInt32((Console.ReadLine()));
Console.Write("\nInput the Second Number : ");
numbers2 = Convert.ToInt32((Console.ReadLine()));
tempVariable = numbers1;
numbers1 = numbers2;
numbers2 = tempVariable;
Console.Write("\nAfter Swapping : ");
Console.Write("\nFirst Number : " + numbers1);
Console.Write("\nSecond Number : " + numbers2);
Console.Read();
//just created my first code