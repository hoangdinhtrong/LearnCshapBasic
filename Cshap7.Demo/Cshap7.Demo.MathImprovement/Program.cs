using System.Numerics;

// Generic Number
var result = Add(1.1, 2);
Console.WriteLine(result);
T Add<T>(T frist, T secound) where T: INumber<T>
{
    T result = T.Zero;
    result = frist + secound;
    return result;
}

// End Generic Number

int[] items = new[] { 1, 2, 3, 4 };

// if(items is [1,2,3,4]) Console.WriteLine("Correct"); // => Correct
// if(items is [1,2,3,5]) Console.WriteLine("Correct"); // => Empty
// if(items is [1,2,3,_]) Console.WriteLine("Correct"); // => _ mean anything => correct
// if(items is [_,var secound,_,_]) Console.WriteLine(secound); // => _ mean anything => 2
// if(items is [_,var secound,..]) Console.WriteLine(secound); // => _ mean anything, .. syntax defines a range => 2
// if(items is [_,.. var rest]) Console.WriteLine(string.Join(",",rest)); // => _ mean anything, .. syntax defines a range => 2,3,4
// if(items is [.., var rest]) Console.WriteLine(string.Join(",",rest)); // => _ mean anything, .. syntax defines a range => 4
// if(items is [.., < 4]) Console.WriteLine("Correct"); // => last element < 4 => Empty
// if(items is [.., <= 4]) Console.WriteLine("Correct"); // => last element <= 4 => Correct
if(items is [_,.. { Length: 2}, var last]) Console.WriteLine(last.ToString()); // => 4

Console.ReadLine();