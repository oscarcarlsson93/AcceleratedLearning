# Regex 1 - Validering

Använd regex101.com för dessa uppgifter.

Sätt flaggorna "gm"

## ABC

Tillåt endast tre tecken som kan vara a, b eller c (små bokstäver)

Success:

    abc
    cab
    bca
    aaa
    ccc

Fail:

    abcc
    caB
    bc
    a aa
    cccc


## Svenskt ord

Validera ett svenskt ord.

Success:

    äpple
    Päron
    traktor
    ö

Fail:

    $
    123
    trakt8r
    oscèr

## Multiplikation

Multiplikation av två tal

Success:

    3*4
    7*8
    12*8
    3*5
    111*2222

Fail:

    3a*4
    3 *4    
    7#8
    12*8a
    *5
    1112222



## Multiplikation II 

Samma som förra uppgiften men tillåt även blanktecken

Success:

    3*4
    7*   8
    12 *8
       3*5
       111  *  2222   

Fail:

    3a*4
    7#8
    12*8a
    *5
    1112222


## Multiplikation III

Använd grupper (mha paranteser) för att plocka ut faktorerna i multiplikationen (siffrorna runt gångertecknet)

Alltså 
    3 * 4 => Group1: 3 och Group2: 4
    7 * 8 => Group1: 7 och Group2: 8


## Telefonnummer

Validera telefonnummer.  

Success:

    030211223
    031-112233
    073-6401023
    0736401023
    112

Fail:

    78
    031-112233a
    08-22-3344
    1111111111222222222222233333333333


## Produktnummer

Validera produktnummer.

Success:

    AB-100-100
    DE-234-456
    FF-421-334

Fail:

    AB
    AB-100
    AB-10-0-100
    DEE-234-456
    FF-421-334-


## Produktnummer II

Skriv ett C# program som plockar ut delarna ur ett produktnummer. T.ex

    Ange produktnummer: DE-234-456 

	Första delen: DE
	Andra delen:  234
	Tredje delen: 456

## Samma siffra två gånger (back referencing)

Tillåt bara tre siffror som genast upprepar sig.

För att lösa detta behöver du använda "back referencing". Det görs med grupper och specialtecknet **\1**

Success:

    123123
    445445
    999999

Fail:

    123
    44544
    9999993

## Samma ord två gånger

Tillåt ett ord följt att samma ord igen

Success:

    fisk fisk
    äpple äpple
    bröd bröd

Fail:

    fisk fiskk
    äppl äpple
    brödbröd