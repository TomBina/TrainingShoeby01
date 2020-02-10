1) Waarom werkt de CLR met IL?

Dit heeft als voordeel dat meerdere high level languages kunnen worden ondersteund. C#, VB.NET en F# hebben allemaal een verschillende syntax, maar draaien allemaal op dezelfde CLR.

2) Wat is het verschil tussen Roslyn en de JIT compiler?

Roslyn compileert de broncode naar IL. De JIT compileert IL naar native.

3. Waarom functioneert de CLR als een virtuele machine? Wat zijn de voordelen hiervan?

Dit creëert een abstractie tussen de code die we schrijven en de low level details van de runtime environment. 
Als C# developer hoef je je bijvoorbeeld niet druk te maken hoe memory allocatie plaatsvind. Dit werkt out-of-the-box. 
Daarnaast is het tegenwoordig mogelijk om met de CLR van .NET core op meerdere platformen te draaien (Windows, Linux etc). De code die je schrijft hoeft 
hiervoor niet aangepast te worden.

4.	Wat is de Framework Class Library?

Dit is een verzameling van API’s die toegang bieden tot veelvoorkomende zaken als data typen en file access.

5.	Wat is het voordeel van een garbage collector?

Dankzij de GC hoeven wij gealloceerd geheugen niet zelf op te ruimen. Dit maakt de broncode eenvoudiger. 
Daarnaast komt de GC out-of-the-box met slimme algoritmes om “slim” op te ruimen. Zo worden objecten die 
gereed zijn voor GC doorgaans niet meteen opgeruimd, maar pas als het geheugen een bepaald threshold bereikt.

6.	Wat is verschil tussen managed en unmanaged code?
Managed code wordt beheerd door de runtime. Hierdoor hoef je essentiële zaken als memory safety, GC etc niet zelf te regelen.

7.	Wat is type safety en wat zijn hier de voordelen van?
Type safety betekent dat toegewezen variables daadwerkelijk zijn wat ze beogen te zijn. Vb: var data = new [] { 1,2,3,4 }. 
De CLR zorgt er nu voor dat er een blok geheugen wordt gereserveerd die 4 ints kan opslaan.

8.	Omschrijf zonder formele begrippen in eigen woorden wat .NET is.
.NET is een framework voor software ontwikkeling. Met .NET is het mogelijk om verschillende soorten applicaties te ontwikkelen, 
 dat alle benodigde kennis van de low level details hiervoor aanwezig hoeft te zijn.
