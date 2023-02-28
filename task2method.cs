


int x = Sum(12, 13, 10,78,65,102);

int Sum(params object[] ListNumber)
{
    int max  = 0;
    foreach (int item in ListNumber)
    {
        if (item > max) max = item;
    }
    return max ;
}
