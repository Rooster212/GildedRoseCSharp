# Gilded Rose

.NET Core solution, developed in Visual Studio 2019.

Assumptions made:
- Item names are case sensitive.
- Console application for user input is used.
- Console application takes one line entry for the item, and outputs on the next line.

Item assumptions made:
- Aged Brie *doesn't* increase in quality twice as fast after it's sell by date (other items decrease in quality twice as fast after their sell by date)

## Running the application

The application can be run through the Run dialog in Visual Studio.

Alternatively, the command line can be used. .NET Core 3.1 must be installed on the system and configured correctly in the user `PATH`.

Assuming you are using Powershell on Windows:

```bash
# dotnet build will also restore NuGet packages
dotnet build --configuration Debug

# If you aren't in the console project folder, you should enter that
cd GildedRoseConsole\

# Run the application
dotnet run
```

## Tests
Tests can be run through the Visual Studio Test Explorer once Nuget packages have been restored, as the NUnit test runner is installed as a package.

Tests are also run through the GitHub Actions, the results of which can be viewed [here](https://github.com/Rooster212/GildedRoseCSharp/actions).

Alternatively, the command line can be used. .NET Core 3.1 must be installed on the system and configured correctly in the user `PATH`.

```bash
# dotnet build will also restore NuGet packages
dotnet build

# Run the tests
dotnet test GildedRose.sln
```


# Specification

Hi​ ​and​ ​welcome​ ​to​ ​team​ ​Gilded​ ​Rose.​ ​We​ ​are​ ​a​ ​small​ ​inn​ ​with​ ​a​ ​prime​ ​location​ ​in​ ​a
prominent​ ​city​ ​ran​ ​by​ ​a​ ​friendly​ ​innkeeper​ ​named​ ​Allison.​ ​We​ ​also​ ​buy​ ​and​ ​sell​ ​only​ ​the
finest​ ​goods.​ ​Unfortunately,​ ​our​ ​goods​ ​are​ ​constantly​ ​degrading​ ​in​ ​quality​ ​as​ ​they​ ​approach
their​ ​sell​ ​by​ ​date.​ ​We​ ​currently​ ​update​ ​our​ ​inventory​ ​manually.

Your​ ​task​ ​is​ ​to​ ​write​ ​a​ ​program​ ​to​ ​automate​ ​the​ ​inventory​ ​management​ ​based​ ​on​ ​the
following​ ​rules:

### Rules

- All​ ​items​ ​have​ ​a​ ​SellIn​ ​value​ ​which​ ​denotes​ ​the​ ​number​ ​of​ ​days​ ​we​ ​have​ ​to​ ​sell​ ​the item
- All​ ​items​ ​have​ ​a​ ​Quality​ ​value​ ​which​ ​denotes​ ​how​ ​valuable​ ​the​ ​item​ ​is
- At​ ​the​ ​end​ ​of​ ​each​ ​day​ ​our​ ​system​ ​lowers​ ​both​ ​values​ ​for​ ​every​ ​item
- ​Once​ ​the​ ​sell​ ​by​ ​date​ ​has​ ​passed,​ ​Quality​ ​degrades​ ​twice​ ​as​ ​fast
- The​ ​Quality​ ​of​ ​an​ ​item​ ​is​ ​never​ ​negative
- `Aged​ ​Brie` ​actually​ ​increases​ ​in​ ​Quality​ ​the​ ​older​ ​it​ ​gets
- ​`Normal​ ​Item`​ ​decreases​ ​in​ ​Quality​ ​by​ ​1
-​ ​The​ ​Quality​ ​of​ ​an​ ​item​ ​is​ ​never​ ​more​ ​than​ ​50
- `Sulfuras`,​ ​being​ ​a​ ​legendary​ ​item,​ ​never​ ​has​ ​to​ ​be​ ​sold​ ​or​ ​decreases​ ​in​ ​Quality
- `Backstage​ ​passes`,​ ​like​ ​aged​ ​brie,​ ​increases​ ​in​ ​Quality​ ​as​ ​its​ ​SellIn​ ​value approaches;​ ​Its​ ​quality​ ​increases​ ​by​ ​2​ ​when​ ​there​ ​are​ ​10​ ​days​ ​or​ ​less​ ​and​ ​by​ ​3​ ​when there​ ​are​ ​5​ ​days​ ​or​ ​less​ ​but​ ​quality​ ​drops​ ​to​ ​0​ ​after​ ​the​ ​concert
- `Conjured` ​items​ ​degrade​ ​in​ ​Quality​ ​twice​ ​as​ ​fast​ ​as​ ​normal​ ​items

### Input
​​A​ ​list​ ​of​ ​items​ ​in​ ​the​ ​current​ ​inventory.​ ​Each​ ​line​ ​in​ ​the​ ​input​ ​represents​ ​an​ ​inventory item​ ​with​ ​Item​ ​name,​ ​its​ ​sell-in​ ​value​ ​and​ ​quality​ ​e.g.​ ​`Backstage​ ​passes​ ​-1​ ​2` ​=>​ ​Backstage passes​ ​is​ ​past​ ​sellin​ ​value​ ​by​ ​1​ ​day​ ​with​ ​quality​ ​2.

### Output
​Updated​ ​inventory​ ​after​ ​adjusting​ ​the​ ​quality​ ​and​ ​sellin​ ​days​ ​for​ ​each​ ​item​ ​after​ ​a day.

### Test input

```
Aged​ ​Brie​ ​1​ ​1
Backstage​ ​passes​ ​-1​ ​2
Backstage​ ​passes​ ​9​ ​2
Sulfuras​ ​2​ ​2
Normal​ ​Item​ ​-1​ ​55
Normal​ ​Item​ ​2​ ​2
INVALID​ ​ITEM​ ​2​ ​2
Conjured​ ​2​ ​2
Conjured​ ​-1​ ​5
```

### Expected output
```
Aged​ ​Brie​ ​0​ ​2
Backstage​ ​passes​ ​-2​ ​0
Backstage​ ​passes​ ​8​ ​4
Sulfuras​ ​2​ ​2
Normal​ ​Item​ ​-2​ ​50
Normal​ ​Item​ ​1​ ​1
NO​ ​SUCH​ ​ITEM
Conjured​ ​1​ ​0
Conjured​ ​-2​ ​1
```
