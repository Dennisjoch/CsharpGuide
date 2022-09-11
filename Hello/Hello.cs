//Der System-Namespace enthält eine Reihe von Typen, wie etwa die Console-Klasse,
//auf die im Programm verwiesen wird, und eine Reihe anderer Namespaces, wie etwa IO und Collections.
using System; 

//Namespaces bieten eine hierarchische Möglichkeit zum Organisieren von C#-Programmen und -Bibliotheken.
namespace CsharpGuide;

class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, World");
    }
}

//Die Hello-Klasse, die vom Programm „Hello, World“ deklariert wird, verfügt über einen einzelnen Member:
//die Main-Methode. Die Main-Methode wird mit dem Modifizierer static deklariert.
//Auch wenn Instanzmethoden mit dem Schlüsselwort this auf eine bestimmte einschließende Objektinstanz verweisen können,
//agieren statische Methoden ohne Verweis auf ein bestimmtes Objekt.
//Gemäß Konvention fungiert eine statische Methode mit der Bezeichnung Main als Einstiegspunkt eines C#-Programms.
//Die Ausgabe des Programms wird anhand der WriteLine-Methode der Console-Klasse im System-Namespace generiert.
//Diese Klasse wird anhand der Standardklassenbibliotheken bereitgestellt, auf die standardmäßig automatisch vom Compiler verwiesen wird.