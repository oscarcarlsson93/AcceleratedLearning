## Intro

Lös uppgifterna med **en** search and replace i Visual Studio. 

Tips: använd grupper ( ) och backreferensing $1 för att lösa uppgifterna.

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

Kolla i ContentType.cs.  Ta bort Name="…." överallt mha reguljäruttryck.

T.ex 

    [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)] 

till

    [Display(Order = 2)] 


## ContentType.cs - Ta bort Required

Kolla i ContentType.cs.  Ta bort [Required(...)] överallt.

T.ex 

        [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)]
        [Required(AllowEmptyStrings = false)]
        [Enum(typeof(Enums.AssignedActivityRole))]

till

        [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)]
        [Enum(typeof(Enums.AssignedActivityRole))]


Förväntat resultat efter de två senaste övningarna: **ContentTypes - ExpectedResult.cs**

## Konstskola.html - Ta bort metataggar 

Kolla i konstskola.html. Ta bort alla metataggar <meta>, t.ex denna:

    <meta property="og:description" content="Måleri | Grafik | Skulptur | Idégestaltning" />

Förväntat resultat: **konstskola - ExpectedResult1.html**


## Konstskola.html - Ta bort id inom link 

Kolla i konstskola.html. Ta bort id inom alla <link>-tagger.

T.ex:

    <link rel='stylesheet' id='child-style-css'  href='http://gbgkonstskola.se/wp-content/themes/wp-gk/style.css?ver=3.0' type='text/css' media='all' />

==>

    <link rel='stylesheet' href='http://gbgkonstskola.se/wp-content/themes/wp-gk/style.css?ver=3.0' type='text/css' media='all' />

Förväntat resultat: **konstskola - ExpectedResult2.html**



## Konstskola.html - Ta bort kommentarer

Kolla i konstskola.html. Ta bort alla html-kommentarer.

T.ex

    <!-- Jetpack Open Graph Tags -->

Förväntat resultat: **konstskola - ExpectedResult3.html**


## Konstskola.html - Mellanslag och tabbar

Kolla i konstskola.html. Ta bort alla "luft" i början av varje rad

     <body class="home singular page”>   
       
            <div class="off-canvas-wrapper">
    <div class="off-canvas-wrapper-inner" data-off-canvas-wrapper>

==>

    <body class="home singular page”>   
    <div class="off-canvas-wrapper">
    <div class="off-canvas-wrapper-inner" data-off-canvas-wrapper>

Ta ej bort tomma rader, det ska vara lika många rader i den manipulerade filen som den gamla.

Förväntat resultat: **konstskola - ExpectedResult4.html**
