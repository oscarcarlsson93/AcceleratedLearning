
//obj1();
//obj2();
//obj3();
//obj4();

function obj1() {
    
    /*
        Skapa ett objekt "person" med uppgifter om Johan Rheborg: förnamn, efternamn, födelseår
        Skriv ut förnamnet
        Skriv ut hans fullständiga namn
    */

    let person = {
        Förnamn: "Johan ",
        Efternamn: "Rheborg",
        Födelseår: 1963,

    };

    console.log(person.Förnamn + person.Efternamn);
}

function obj2() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till ett par rollkaraktärer (Percy Nilegård, Farbror Barbro...)
       Lägg till adressuppgifter (street, city, country)
       Skriv ut info om Johan utifrån objektet "person":
            Johan är född år 1963
            Johan bor på gatan Kammakargatan 38 lgh 1401
            Johan har spelat 3 roller, bland annat Percy Nilegård
    */

    let person = {
        Förnamn: "Johan ",
        Efternamn: "Rheborg",
        Födelseår: 1963,
        Rollkaraktärer: ["Percy Nilegård", "Fabror Barbro", "Fredde Schiller"],
        Street: "Kammakargatan 33 lgh 1401",
        City: "Stockholm",
        Country: "Sweden",

    };
    console.log(`Johan är född år ${person.Födelseår}`);
    console.log(`Johan bor på gatan ${person.Street}`);
    console.log(`Johan har spelar ${person.Rollkaraktärer.length} roller, bland annat ${person.Rollkaraktärer[0]}`);
  
}


function obj3() {

    /*
       Skapa en array "paintings" med tre målningar (tre element)
       För varje målning finns info: namn, konstnär och året den blev målad
       Skriv ut antalet målningar: "Det finns XXXst målningar"
       Skriv ut den tredje målningen t.ex: "Pablo Picasso målade Guernica år 1937"
       Loopa igenom alla målningar med "for of" och skriv ut all info i tabellform
       Tips: använd "padEnd" för att skriva ut tabellen snyggt
    */
    let paintings = [
        { Name: "Guernica", Artist: "Pablo Picasso", Year: 1938 },
        { Name: "Mona Lisa", Artist: "Leonardo da Vinci", Year: 1503 },
        { Name: "Oscars tavla", Artist: "Oscar Carlsson", Year: 2019 }]

        console.log(`Det finns ${paintings.length}st målningar`);
    console.log(`${paintings[2].Artist} målade ${paintings[2].Name} år ${paintings[2].Year}`);

    for (const x of paintings) {

        console.log(x.Name + " " + x.Artist + " " + x.Year);
    }
    

}

function obj4() {

    /*
       Skapa ett objekt "skriet" (av Edvard Munch 1893). Lägg till den i paintingsarrayen mha "push".
       Skriv ut dess år mha variablen "paintings" 
       Använd "pop" för att plocka bort de tre sista målningarna
       Skriv ut antalet målningar i arrayen 
    */
    let paintings = [
        { Name: "Guernica", Artist: "Pablo Picasso", Year: 1938 },
        { Name: "Mona Lisa", Artist: "Leonardo da Vinci", Year: 1503 },
        { Name: "Oscars tavla", Artist: "Oscar Carlsson", Year: 2019 }]

    let skriet = { Name: "Skriet", Artist: "Edvard Munch", Year: 1893 };
    paintings.push(skriet);

    console.log(paintings[3].Year);
    paintings.pop();
    paintings.pop();
    paintings.pop();

    console.log(paintings.length);
  
}

// -------- EXTRA UPPGIFTER -----------------------------------------

function objExtra1() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till en metod "fullName" till person
       Lägg till en metod "numberOfRoles" till person

       Används sedan dessa för att skriva ut:
            Johan Rheborg
            Johan Rheborg har spelat i 3 roller
    */
}