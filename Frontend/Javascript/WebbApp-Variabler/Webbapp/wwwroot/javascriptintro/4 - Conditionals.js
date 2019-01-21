

//cond1();
//cond2();
//cond3();
//cond4();
//cond5();
//cond6();
//cond7();
//cond8();
//cond9();
function cond1() {

    /*
	    Skapa en variabel shoeMaria och sätt till 36
	    Skapa en variabel shoeAli och sätt till 42
	    Skriv en if-sats som kollar om de har samma skostorlek (skriv ut olika texter)
	    Experimentera med att ändra värden på "shoeMaria" och "shoeAli"
    */

    let shoeMaria = 36;
    let shoeAli = 42;

    if (shoeAli == shoeMaria) {

        console.log("Samma skostorlek")
    }
    else {
        console.log("De har olika skostorlek");
    }
}

function cond2() {

    /*
	    Kolla om Ali har större skostolek än Maria
	    Skriv ut lämpligt meddelande
    */
    let shoeMaria = 36;
    let shoeAli = 42;

    if (shoeMaria < shoeAli) {

        console.log("Ali har större skostorlek än Maria");
    }
    else {
        console.log("Maria har större skostorlek än Ali");
    }
}

function cond3() {

    /*
	    Samma som sist, men kolla även om de har samma skostorlek
    */

    let shoeMaria = 46;
    let shoeAli = 36;

    if (shoeMaria < shoeAli) {

        console.log("Ali har större skor än Maria");
    }
   else if (shoeAli == shoeMaria) {
        console.log("De har lika stora skor");
    }
    else {
        console.log("Maria har större skostorlek än Ali");
    }
}

function cond4() {

    /*
	    Lägg till en till variabel "bigFoot" med skostorlek 52
	    Skriv en if-sats som kolla om bigFoot har större skostorlek än både Ali och Maria
    */

    let shoeMaria = 36;
    let shoeAli = 46;
    let bigFoot = 52;

    if (bigFoot > shoeMaria && bigFoot > shoeAli) {
        console.log("Bigfoot har större än de båda");
    }
    else {
        console.log("Bigfoot har inte störst fötter");
    }
}

function cond5() {

    /*
	    Skriv en ifsats som kollar om någon av de tre har en skostorlek som är större än 50
    */
    let shoeMaria = 36;
    let shoeAli = 46;
    let bigFoot = 52;

    if (50 < bigFoot || 50 < shoeAli || 50 < shoeMaria) {

        console.log("Någon av de har skostorlek större än 50");
    }
}

function cond6() {

    /*
	    Skapa en variabel "favoriteVegetable" och sätt den till "kålrot"
	    Använd en switch-sats för att kolla värdet på "favoriteVegetable" och svara på olika sätt
	    Om t.ex värdet av "favoriteVegetable" är "majrova" skriv "Passar till falafel"
    */

    let favoriteVegetable = "Gurka";
    switch (favoriteVegetable) {
        case "kålrot":
            console.log("Kåligt");
            break;
        case "majrova":
            console.log("Passar bra till falafel");
            break;
        case "Gurka":
            console.log("Kan man lägga på ögonen");
            break;
        default:
            console.log("Hejsanhoppsan");
    }
    
}

function cond7() {

    /*
	    Samma som sist men skapa först en variabel "answer"
	    Istället för att använda "console.log" inuti switch-satsen så sätt variabel "answer"
	    Använd tillslut "console.log" för att skriva ut värdet av "answer"
    */

    let favoriteVegetable = "majrova";
    let answer;
    switch (favoriteVegetable) {
        case "kålrot":
             answer ="Kåligt";
            break;
        case "majrova":
             answer = "Passar bra till falafel";
            break;
        case "Gurka":
             answer = "Kan man lägga på ögonen";
            break;
        default:
            answer = "Hejsanhoppsan";
    }
    console.log(answer);
}

function cond8() {


    /*
	    Jämför == och === i en ifsats
	    Testa med en ifsats om 3=="3" är sant
	    Testa med en ifsats om 3==="3" är sant
    */

    if (3=="3") {
        console.log("Test1");
    }
    if (3 === "3") {
        console.log("Test2");
    }
}

function cond9() {

    /*
	    Övning i "ternary operator"
	    Skapa en variabel a och sätt den till 13*13
	    Skapa en variabel b och sätt den till 169
	    Använd "ternary operator" för att kolla om de är lika. Lägg svaret (strängen "lika" eller "olika") i en variabel "result"
	    Skriv ut result
    */
    let a = 13 * 13;
    let b = 169;
    let result = (a == b) ? 'Lika' : 'Olika';
    console.log(result);
}