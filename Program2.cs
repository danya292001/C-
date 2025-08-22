string name = "Sophia";
string kurs1 = "Englisch";
string kurs2 = "Mathe";
string kurs3 = "Bio";
string kurs4 = "IT";
string kurs5 = "Psychologie";

int kredit1 = 3;
int kredit2 = 3;
int kredit3 = 4;
int kredit4 = 4;
int kredit5 = 3;

int noteA = 4;
int noteB = 3;

int kurs1n = noteA;
int kurs2n = noteB;
int kurs3n = noteB;
int kurs4n = noteB;
int kurs5n = noteA;


int kreditgesamt = 0;

kreditgesamt += kredit1;
kreditgesamt += kredit2;
kreditgesamt += kredit3;
kreditgesamt += kredit4;
kreditgesamt += kredit5;

int notegesamt = 0;
notegesamt += kredit1 * kurs1n;
notegesamt += kredit2 * kurs2n;
notegesamt += kredit3 * kurs3n;
notegesamt += kredit4 * kurs4n;
notegesamt += kredit5 * kurs5n;

double gpa = (double)notegesamt / kreditgesamt;

Console.WriteLine($"Schüler: {name}\n");
Console.WriteLine("Kurs\t\tNote\t\tKredit Stunden");
Console.WriteLine($"{kurs1} \t{kurs1n} \t\t{kredit1}");
Console.WriteLine($"{kurs2} \t\t{kurs2n} \t\t{kredit2}");
Console.WriteLine($"{kurs3} \t\t{kurs3n} \t\t{kredit3}");
Console.WriteLine($"{kurs4} \t\t{kurs4n} \t\t{kredit4}");
Console.WriteLine($"{kurs5} \t{kurs5n} \t\t{kredit5}");

Console.WriteLine($"GPA:\t\t{gpa:F2}");
