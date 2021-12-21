# IT-lab (English version below)
Voor het IT-lab, houden we materialen bij die ontleent kunnen worden, het is aan jou om deze functionaliteiten verder te vervolledigen.

## Domein
Het domein is relatief eenvoudig, er zijn slechts 2 klassen die we bijhouden in de databank, namelijk `Material` en `Event`, je mag tijdens het examen geen visibiliteit van de properties aanpassen. Telkens er een ontlening is, houden we een historiek bij van welke student op welke datum dit materiaal ontleende of terugbracht. De student is op zich geen entiteit maar een gewone string.

## Functionaliteiten
Er zijn twee primaire functionaliteiten, het opzoeken van materialen en het toevoegen van materialen die je dient te implementeren. (daarover straks meer)

## Packages
Alle packages zitten reeds in de projecten, je dient geen extra packages via NuGet toe te voegen, mogelijks wel te gebruiken of te implementeren.

## Vraag 1 - Domein
Als een materiaal wordt geleend moet er een event item worden toegevoegd aan de historiek. Zorg dat de volgende unit tests slagen:
- `Material_Should.Have_history_after_borrowing`
- `Material_Should.Not_be_in_stock_after_borrowing`
- `Material_Should.Cannot_be_borrowed_twice_before_return`
> Verander niets aan setters, getters of parameters, implementeer alleen de methode `Material.Borrow` op basis van de tests.

## Vraag 2 - Unit Test
Wanneer de `student` parameter in de `Material.Borrow` functie niet is ingevuld, zou de methode een `ArgumentException` moeten gooien. Valideer dit door de theoretische `Material_Should.Not_Borrow_To_Invalid_Student` unit test te implementeren **en** de test te laten slagen door een `Guard` clausule uit het Ardalis pakket te gebruiken in de `Material.Borrow` methode.

## Vraag 3 - Configurations
In de database zijn er nog enkele problemen die opgelost moeten worden door de `MaterialConfiguration` correct te implementeren. De `naam` van een `Material` moet altijd uniek zijn in de `Material` (let op de enkelvoud vorm) tabel. De `naam` mag niet null zijn en heeft een maximale lengte van 250. De `omschrijving` is echter optioneel met een maximale lengte van 1000. Als een `Material` wordt verwijderd, moet ook de historie uit de database worden verwijderd. Zorg ervoor dat een historiek niet kan bestaan zonder een gelinkt materiaal.

## Vraag 4 - Auth
De create knop bovenaan de `Materials.Index` pagina zou alleen beschikbaar mogen zijn voor `Administrators`. **Daarnaast** mogen enkel `Administrator`s de `Materials.Create.razor` pagina zien.
> Je hoeft je geen zorgen te maken dat de API call niet afgeschermd is voor deze vraag, omdat we gebruik maken van de `FakeAuthenticationProvider`.

## Vraag 5 - Filter
Momenteel worden de materialen opgehaald zonder enige filterfunctionaliteit in de Index pagina. Implementeer de filterfunctionaliteit zodat wanneer op de zoekknop wordt geklikt, een oproep naar de server wordt uitgevoerd en een lijst van materialen wordt teruggestuurd op basis van de zoekterm in het filter. De aanroep wordt alleen getriggerd bij het klikken op de knop (Search), niet bij het typen of het verliezen van de focus. Gebruik de `MaterialService.GetIndexAsync` methode om het filter gedrag te implementeren. Merk op dat het filteren zelf in de database moet gebeuren en niet in de back-end / front-end. Alleen de materialen met een `naam` die begint met de zoekterm, of de `omschrijving` bevat de `zoekterm` worden geretourneerd in een alfabetische volgorde op basis van de `naam`.

### Eindresultaat -  Zoeken naar materialen
https://user-images.githubusercontent.com/10981553/146948433-8b5e9f5d-8079-42f8-ae38-d84d5b234503.mov

## Vraag 6 - Create
Het aanmaken van materialen is momenteel niet erg functioneel, het is enkel gestyled met behulp van BULMA, hergebruik deze elementen. Implementeer het toevoeg formulier met behulp van de `MaterialDto.Create`, `Materials.Create.razor` en `MaterialService.CreateAsync` (back-/frontend). Gebruik `FluentValidation` om er zeker van te zijn dat er geen ongeldige materialen kunnen worden aangemaakt, controleer de database regels en maak ze consistent (regels in de databank gelden ook voor de validatie). Daarnaast dien je ook de Server / API te beschermen tegen ongeldige materialen, doe ook dit aan de hand van het `FluentValidation.AspNetCore` package.

> Je hoeft geen extra eigenschappen toe te voegen aan de `MaterialDto.Create`.

## Vraag 7 - Notificaties
Wanneer een materiaal is aangemaakt wordt de gebruiker terug genavigeerd naar de `Material.Index.razor` pagina ook moet er een notificatie worden getoond aan de gebruiker. Gebruik [Blazored.Toast](https://github.com/Blazored/Toast) om een succes notifcatie te tonen "Materiaal is toegevoegd!", gebruik de README.md van het project om de functionaliteit te implementeren.

### Eindresultaat -  Toevoegen van materiaal met validatie en notificatie
https://user-images.githubusercontent.com/10981553/146948409-5be6e47c-b60d-4bcb-9db5-4b011d29908e.mov
