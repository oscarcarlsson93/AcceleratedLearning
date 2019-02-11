# Regex 1 - Validering

Anv�nd regex101.com f�r dessa uppgifter.

S�tt flaggorna "gm"

## ABC

Till�t endast tre tecken som kan vara a, b eller c (sm� bokst�ver)

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

    �pple
    P�ron
    traktor
    �

Fail:

    $
    123
    trakt8r
    osc�r

## Multiplikation

Multiplikation av tv� tal

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

Samma som f�rra uppgiften men till�t �ven blanktecken

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

Anv�nd grupper (mha paranteser) f�r att plocka ut faktorerna i multiplikationen (siffrorna runt g�ngertecknet)

Allts� 
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

	F�rsta delen: DE
	Andra delen:  234
	Tredje delen: 456

## Samma siffra tv� g�nger (back referencing)

Till�t bara tre siffror som genast upprepar sig.

F�r att l�sa detta beh�ver du anv�nda "back referencing". Det g�rs med grupper och specialtecknet **\1**

Success:

    123123
    445445
    999999

Fail:

    123
    44544
    9999993

## Samma ord tv� g�nger

Till�t ett ord f�ljt att samma ord igen

Success:

    fisk fisk
    �pple �pple
    br�d br�d

Fail:

    fisk fiskk
    �ppl �pple
    br�dbr�d