using System;

class NestedFor {
  public static void Run() 
  {
    //A NESTED for is simply a FOR loop within a FOR loop
    //This is useful for working with data in two dimensions
    //This will be useful for working with data in a two-dimensional array
    
    //OUTER LOOP
    //Controls the ieration  through the ROWS
    for(int i=0;i<10;i++)
    {
      //INNER LOOP
      //Controls the iteration through the columns
      for(int j=0;j<10;j++)
      {
        //This will print out the current value of both i and j along with separators all on the same line
        Console.Write(i +"," + j + "|");
      }
      //This will take the cursor to a new line
      Console.WriteLine();
    }
  }
}
