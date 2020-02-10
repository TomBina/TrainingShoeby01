1. Waarom heeft MS de interface IEnumerable<T> toegevoegd aan .NET? Wat is de toegevoegde waarde?

Iteratie is een van de meest voorkomende zaken in code. Dankzij IEnumerable is het mogelijk om alle .NET collections eenvoudig te itereren middels een foreach loop, zonder dat de callsite kennis hoeft te hebben van de achterliggende collectie.

2. Geef van de onderstaande collecties aan, voor welke use case je ze het beste kan gebruiken:
- Array: geschikt voor collecties waarvan de grootte vooraf bekend is en niet veranderd. Relatief snel in iteratie en index look up.
- List<T>: wrapper om de array en geschikt voor collecties die flexibiel capaciteit vereisen.
- Dictionary<T>: key/value collecties. Tevens bijzonder snelle lookups op key.
- Hashset<T>: geschikt voor collecties die uniek moeten zijn. Netals dictionary zijn de lookups razendsnel.
- LinkedList<T>: geschikt voor collecties waarbij doorgaans alleen aan het begin of aan het eind iets moet worden toegevoegd (head/tail). 

3. Wanneer implementeer je equality comparison in een class?
Als de standaard equality comparison die .NET api's gebruiken afwijkt van de equality regels die gelden voor het type van een object.  

4. Wat is GetHashCode()?
Elke object in .NET heeft een hashcode. Op basis van deze unieke code, bepaalt een Dictionary en een HashSet in welke bucket een object wordt geplaatst.