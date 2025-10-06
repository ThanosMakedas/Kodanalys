Kodanalys – Refaktoreringsrapport

Jag har genomfört fyra separata commits för att förbättra den ursprungliga koden i uppgiften "Kodanalys och förbättring". Nedan följer en sammanfattning av varje förändring, varför den gjordes, och hur den bidrar till bättre kodkvalitet enligt principer som läsbarhet, DRY och underhållbarhet.


1. Ändrade klassnamn från "program" till "Program"
Varför: Enligt C#-konventioner ska klassnamn skrivas med PascalCase. Detta förbättrar läsbarheten och gör koden mer professionell.
Kodkvalitet: Förbättrad läsbarhet och underhållbarhet genom att följa etablerade kodstandarder.


2. Förbättrade variabelnamn för tydlighet
Vad ändrades: Variabler som unicornSparkle, magicConstant, celestialWhispers, nanoBanan, f00l m.fl. ersattes med tydliga namn som choice, userCount, users, indexToRemove, found.
Varför: Tydliga och beskrivande namn gör koden lättare att förstå och följa.


3. Förenklade borttagning av användare
Vad ändrades: Den tidigare manuella loopen för att ta bort en användare från en array ersattes med den inbyggda metoden List.Remove().
Varför: Den nya metoden är enklare, mer läsbar och minskar mängden kod.


4. Förenklade sökning av användare
Vad ändrades: Den tidigare loopen för att söka efter en användare ersattes med List.Contains().
Varför: Den nya metoden är mer effektiv och lättare att förstå.

Reflektion

Genom att arbeta med denna uppgift har jag lärt mig hur viktigt det är att skriva kod som är tydlig, enkel och lätt att underhålla. Jag har sett hur små förändringar, som att byta namn på variabler eller använda rätt metoder, kan göra stor skillnad.
Jag har också förstått värdet av att följa kodstandarder, som PascalCase för klassnamn, och att använda inbyggda metoder som `List.Remove()` och `List.Contains()` istället för att skriva egna loopar. Det gör koden både kortare och mer pålitlig.
Dessutom har jag lärt mig att använda Git för att dokumentera varje steg i arbetet. Genom att göra flera commits med tydliga beskrivningar har jag kunnat visa hur koden utvecklats och förbättrats. Det är något jag kommer att ta med mig i framtida projekt.
