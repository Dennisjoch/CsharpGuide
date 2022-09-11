# Überblick über C#

**C# ist...**

- Objektorientiert
- komponentenorientierte

**Features:**

- **Garbage Collection:** Gibt automatisch Arbeitsspeicher zurück, der von nicht erreichbaren, nicht verwendeten Objekten belegt wird.
- **Nullable-Typen:** Bietet schutz vor Variablen, die nicht aud zugeordnete Objekte verweisen.
- **Ausnahmebehandlung**: bietet einen strukturierten und erweiterbaren Ansatz zur Fehlererkennung und Wiederherstellung.
- **Lambdaausdrückeunterstützen**
- **Language Integrated Query-Syntax (LINQ):** erstellt ein gängiges Muster für das Arbeiten mit Daten aus einer beliebigen Quelle
- **asynchrone Vorgänge**
- **einheitliches Typsystem**

# .NET-Architektur

C#-Programme werden auf Grundlage von .NET ausgeführt, ein virtuelles Ausführungssystem namens Common Language Runtime (CLR) sowie Klassenbibliotheken. Die CLR ist die Implementierung der Common Language Infrastructure (CLI) von Microsoft, ein internationaler Standard. Die CLI ist die Grundlage für das Erstellen von Ausführungs- und Entwicklungsumgebungen, in denen Sprachen und Bibliotheken nahtlos zusammenarbeiten.

Der in C# geschriebene Quellcode wird in eine** **[Zwischensprache](https://docs.microsoft.com/de-de/dotnet/standard/managed-code) kompiliert, die konform mit der CLI-Spezifikation ist. Der IL-Code wird zusammen mit Ressourcen wie z. B. Bitmaps und Zeichenfolgen in einer Assembly gespeichert, die normalerweise die Erweiterung** ***.dll* aufweist. Eine Assembly enthält ein Manifest, das Informationen über die Typen, die Version und die Kultur der Assembly bereitstellt.

Wenn das C#-Programm ausgeführt wird, wird die Assembly in die CLR geladen. Die CLR konvertiert den IL-Code mithilfe der JIT-Kompilierung (Just-In-Time) in native Computeranweisungen. Die CLR stellt weitere Dienste zur automatischen Garbage Collection, Ausnahmebehandlung und Ressourcenverwaltung bereit. Code, der von der CLR ausgeführt wird, wird manchmal als "verwalteter Code" bezeichnet. "Nicht verwalteter Code" wird in native Computersprache kompiliert, die auf eine bestimmte Plattform zielt.

Eines der wichtigsten Features in .NET ist die Sprachinteroperabilität. Der vom C#-Compiler erzeugte IL-Code entspricht dem allgemeinen Typsystem (CTS, Common Type Specification). Der über C# generierte IL-Code kann mit Code interagieren, der über die .NET-Versionen von F#, Visual Basic oder C++ generiert wurde. Es gibt mehr als 20 weitere CTS-kompatible Sprachen. Eine einzelne Assembly kann mehrere Module enthalten, die in verschiedenen .NET-Sprachen geschrieben wurden. Die Typen können aufeinander verweisen, als wären sie in der gleichen Sprache geschrieben.

Zusätzlich zu den Laufzeitdiensten enthält .NET auch umfangreiche Bibliotheken. Diese Bibliotheken unterstützen viele verschieden Workloads. Sie sind in Namespaces organisiert, die eine große Bandbreite nützlicher Funktionen bereitstellen. Die Bibliotheken beinhalten alles von der Dateiein- und -ausgabe über die Bearbeitung von Zeichenfolgen, XML-Analyse und Webanwendungs-Frameworks bis hin zu Windows Forms-Steuerelementen. Eine typische C#-Anwendung verwendet für die Ausführung von Routinevorgängen ausgiebig die .NET-Klassenbibliothek.


# Erster Schritt

- Hello.cs


[Quelle](https://docs.microsoft.com/de-de/dotnet/csharp/tour-of-csharp//)
