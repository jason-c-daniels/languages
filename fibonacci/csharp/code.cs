int fibonacci(int n) {
   if (n == 0) return 0;
   if (n == 1) return 1;
   return fibonacci(n-1) + fibonacci(n-2);
}

var u = int.Parse(args[0]);
var r = 0;
for (var i = 1; i < u; i++) {
   r += fibonacci(i);
}
Console.WriteLine(r); // Print out the result