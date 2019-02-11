## Intro

L�s uppgifterna med **en** search and replace i Visual Studio. 

Tips: anv�nd grupper ( ) och backreferensing $1 f�r att l�sa uppgifterna.

## CSS formattering

Omvandla:

    a {font:Arial; color:red}
    h1 {padding:10px}
    h3 {margin:20px; padding-right:20px}

till

    a 
    {
    font:Arial; color:red
    }

    h1 
    {
    padding:10px
    }

    h3 
    {
    margin:20px; padding-right:20px
    }


## ContentType.cs - Ta bort Name

Kolla i ContentType.cs.  Ta bort Name="�." �verallt mha regulj�ruttryck.

T.ex 

    [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)] 

till

    [Display(Order = 2)] 


## ContentType.cs - Ta bort Required

Kolla i ContentType.cs.  Ta bort [Required(...)] �verallt.

T.ex 

        [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)]
        [Required(AllowEmptyStrings = false)]
        [Enum(typeof(Enums.AssignedActivityRole))]

till

        [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)]
        [Enum(typeof(Enums.AssignedActivityRole))]


F�rv�ntat resultat efter de tv� senaste �vningarna: **ContentTypes - ExpectedResult.cs**

## Konstskola.html - Ta bort metataggar 

Kolla i konstskola.html. Ta bort alla metataggar <meta>, t.ex denna:

    <meta property="og:description" content="M�leri | Grafik | Skulptur | Id�gestaltning" />

F�rv�ntat resultat: **konstskola - ExpectedResult1.html**


## Konstskola.html - Ta bort id inom link 

Kolla i konstskola.html. Ta bort id inom alla <link>-tagger.

T.ex:

    <link rel='stylesheet' id='child-style-css'  href='http://gbgkonstskola.se/wp-content/themes/wp-gk/style.css?ver=3.0' type='text/css' media='all' />

==>

    <link rel='stylesheet' href='http://gbgkonstskola.se/wp-content/themes/wp-gk/style.css?ver=3.0' type='text/css' media='all' />

F�rv�ntat resultat: **konstskola - ExpectedResult2.html**



## Konstskola.html - Ta bort kommentarer

Kolla i konstskola.html. Ta bort alla html-kommentarer.

T.ex

    <!-- Jetpack Open Graph Tags -->

F�rv�ntat resultat: **konstskola - ExpectedResult3.html**


## Konstskola.html - Mellanslag och tabbar

Kolla i konstskola.html. Ta bort alla "luft" i b�rjan av varje rad

     <body class="home singular page�>   
       
            <div class="off-canvas-wrapper">
    <div class="off-canvas-wrapper-inner" data-off-canvas-wrapper>

==>

    <body class="home singular page�>   
    <div class="off-canvas-wrapper">
    <div class="off-canvas-wrapper-inner" data-off-canvas-wrapper>

Ta ej bort tomma rader, det ska vara lika m�nga rader i den manipulerade filen som den gamla.

F�rv�ntat resultat: **konstskola - ExpectedResult4.html**
