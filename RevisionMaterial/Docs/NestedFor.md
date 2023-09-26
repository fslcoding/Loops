# Nested `For Loops`

This is a short breakdown of the [NestedFor.cs](https://github.com/fslcoding/Loops/blob/main/RevisionMaterial/NestedFor.cs) class.

+ The word _nested_ refers to a `loop` inside another `loop`.
+ This is useful when working with [2D arrays](https://github.com/fslcoding/Arrays).

First, let's look at the first `loop`:

```cs
for(int i = 0; i < 10; i++) {
    // Second for loop here
}
```

The above code will run 10 times. It will control the iteration through the _rows_.

Second, let's look at the second `loop`.

```cs
for(int j = 0; j < 10; j++) {
    // Code here
}
```

The inner `loop` will run 10 times each _iteration_. It will control the iteration through the _columns_.

Finally, let's add some code inside the second `loop` to print out `i` and `j`:

```cs
Console.WriteLine(i + ',' + j);
```

Alltogether, the code looks like this:

```cs
for(int i = 0; i < 10; i++) {
    for(int j = 0; j < 10; j++) {
        Console.WriteLine(i + ',' + j);
    }
}
```

### Working with `arrays`

Let's create a 2D `array`:

```cs
string[,] names = new string[2,2] {
    { "Joshua", "Coulter" },
    { "Cosmin", "Ursache" }
};
```
This creates a 2D `array` which will store first and second names.

To `loop` through the `array`, we should use a `nested for loop`:

```cs
for(int i = 0; i < names.GetLength(0); i++) {
    for(int j = 0; j < names.GetLength(1); j++) {
        Console.Write(i + "," + j);
    }
}
```

+ The _outer_ loop controls the _rows_
+ The _inner_ loop controls the _columns_

Now we can access all the elements inside the array.