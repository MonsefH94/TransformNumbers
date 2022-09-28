Salut Monsef.

Ci-après, tu trouveras des remarques sur le code produit lors de la dernière séance de Kata TDD.
Dans tous les cas, je te remercie déjà d'avoir continué et de jouer le jeu.

# 1. Refactoring des tests.

Je vois des Arrange/Act/Assert.
Je pense qu'après toutes ces séances à écrire des tests unitaires, tu commences à prendre le pli.
Alors du coup, je vais introduire de nouvelles notions.

## 1.1 Parameterized tests

Quand un test unitaire simple se répète de façon strictement identique on va essayer de le rendre paramétrique.

Tout d'abord, la documentation officielle:
 - [NUnit](https://docs.nunit.org/articles/nunit/technical-notes/usage/Parameterized-Tests.html)
 - [MsTests](https://learn.microsoft.com/en-us/visualstudio/test/how-to-create-a-data-driven-unit-test?view=vs-2022)
 - [MsTestsV2](https://github.com/Microsoft/testfx-docs)
   - [coup de main](https://www.meziantou.net/mstest-v2-data-tests.htm)

 Allons-y pour un exemple sur la base de ce que tu as codé:

```csharp
public void Should_return_I_when_1_is_entered()
{
    //Arrange
    int enterNumbre = 1;
    TransformNumbersFullTDD transform = new TransformNumbersFullTDD();

    //Act
    string result = transform.DigitstoRomains(enterNumbre);

    //Assert
    Assert.AreEqual("I", result);
}

[TestMethod]
public void Should_return_II_when_2_is_entered()
{
    //Arrange
    int enterNumbre = 2;
    TransformNumbers transform = new TransformNumbers();

    //Act
    string result = transform.DigitstoRomains(enterNumbre);

    //Assert
    Assert.AreEqual("II", result);
}

[TestMethod]
public void Should_return_III_when_3_is_entered()
{
    //Arrange
    int enterNumbre = 3;
    TransformNumbers transform = new TransformNumbers();

    //Act
    string result = transform.DigitstoRomains(enterNumbre);

    //Assert
    Assert.AreEqual("III", result);
}
```

 deviendrait :
```csharp
[DataTestMethod]
[DynamicData(nameof(MyArabicRomanTestcases))]
public void Should_return_correct_roman_number_when_given_arabic_integer(int arabic, string expectedRoman)
{
    //Arrange
    TransformNumbersFullTDD transform = new TransformNumbersFullTDD();

    //Act
    string actualRoman = transform.DigitstoRomains(arabic);

    //Assert
    Assert.AreEqual(expectedRoman, actualRoman);
}

public static IEnumerable<object[]> MyArabicRomanTestcases
{
    get
    {
        yield return new object[] { 1, "I" };
        yield return new object[] { 2, "II" };
        yield return new object[] { 3, "III" };
    }
}
```

Si tu grattes, tu verras qu'on peut aussi utiliser une méthode.
Les détails précis de ce que tu peux utiliser, sont derrière l'api System.Reflection (apprendre à invoquer dynamiquement des objets/méthodes etc...)

## 1.2 BeforeEach 
Tous tes tests démarrent par créer un objet :
```TransformNumbersFullTDD transform = new TransformNumbersFullTDD();``` dans l'étape arrange.
Sauf que cet "arrangement" ne nous renseigne peu ou pas de choses en soi, puisque la classe TransformNumbersFullTDD est celle qu'on teste (souvent appelée SUT : System under test)

Dans ce cas précis, on va de nouveau se pencher sur le framework de tests et chercher un truc qui se lance "avant chaque test" (souvent "BeforeEach")
- [MsTestsV2](https://www.meziantou.net/mstest-v2-test-lifecycle-attributes.htm)

Ca nous donnerait, sur la base de ce que tu as écrit : (j'ignore le point précédent pour le moment)
```csharp
[TestClass]
public class TransformNumbersFullTDDTests
{
    private TransformNumbersFullTDD transform;
    
    [TestInitialize]
    public void TestInitialize()
    {
        transform = new TransformNumbersFullTDD();
    }
    public void Should_return_I_when_1_is_entered()
    {
        //Arrange
        int enterNumbre = 1;
        // transform a déjà été initialisé, avant chaque cas de test
    
        //Act
        string result = transform.DigitstoRomains(enterNumbre);
    
        //Assert
        Assert.AreEqual("I", result);
    }
}
```

Alors, ensuite j'ai dit que j'ignorais 1.1
En effet, dans la technique montrée en 1.1, il reste une seule méthode de test. Donc aucun bénéfice à "sortir" quelque chose "avant chaque test"
Du coup, il faut faire chauffer ses neurones pour choisir ;-)

## 1.3 Region

J'ai vu dans ton fichier de tests, 2 régions pour séparer logiquement, intentionnelement 2 "séries de tests"
Du coup, pour faire suite à ce que je dis sur les intentions.
Peut être qu'en C#, 2 fichiers différents avec les noms que tu as donnés à tes régions serait plus "judicieux" ?


# 2. Code de production

## 2.1 Merci

Comme pour Myriam, Merci d'avoir joué le jeu. Et encore merci, puisqu'il s'agit de ta V2.

## 2.2 Langage C# 

J''ai vu ceci:

```csharp
StringBuilder result_in_romains = new StringBuilder();
for (int i = 0; i < digits_Entered_By_User; i++)
{
    result_in_romains.Append("I");
}
return result_in_romains.ToString();
```

Je te propose ceci:
```csharp
return new string('I', digits_Entered_By_User)
```
Oui je suis un fainéant. 
L'idée ici, c'est de se dire "Hmm.. si personne a fait ça avant moi, je donne mon salaire  la croix rouge"
Gogogo.. gooogle ! :-D

Stringbuilder était un bon réflexe performance,
MAIS on doit discuter de performance seulement à la toute fin 
(et encore, ""premature optimization is the root of all evil"")

## 2.3 -1

J'aime assez la soustraction à 5 et la comparaison à -1
J'essaie de garder cette idéeen tête lors de ma prochaine tentative.
Ca oblige à jongler avec devant/derrière pour l'insertion des aux caractères, mais c'est très intéressant
Merci.

## 2.4 séparer append/prepend du return

Dans tes méthodes. il y a des If/else if/ else,  dans lesquels tu fais:
```csharp
return MonStringBuilder.apprend/prepend.ToString()
```
Pourquoi ne pas séparer append/prepend de return ...ToString()

2-3 bénéfices:
- les if/else if influencent ce qu'on append ou comment on append (prepend)
- le return peut être finalà tous ces cas de figure.
- (Bonus) le cas == 0... devrait disparaitre. 
  - accessoirement, ta méthode Transform_Numbers_From_1_To_3 semble déjà gérer le cas 0 ^^


