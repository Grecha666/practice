int A = 1;
int B = 2;
int C = 6;
int D = 8;
int E = 4;

int MAX = A;

if (A > MAX) MAX = A;
if (B > MAX) MAX = B;
if (C > MAX) MAX = C;
if (D > MAX) MAX = D;
if (E > MAX) MAX = E;

Console.WriteLine(MAX);
