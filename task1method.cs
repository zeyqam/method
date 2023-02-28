

int[] array = {6,5,9,4,3,2,1};
int number = 8;
searching(array, number);
void searching(int[]array, int number)
{
    for (int i = 0; i < array.Length; i++) ;
    {
        if (array[1] == number)
        {
            Console.WriteLine(number + "exist in array given");

        }



        else if (array[1] != number)  
        {
            Console.WriteLine(number + "doesnt exist");
        }
        }

    }