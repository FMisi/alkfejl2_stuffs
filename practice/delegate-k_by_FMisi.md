A delegate-eket egyszerűen úgy képzelhetjük el, mint függvénymutatókat, amelyek lehetővé teszik, hogy egy változóval függvényeket tároljunk és hívjunk meg. Lássuk egyszerűbben, példával:
Delegate alapjai

Képzeld el, hogy van egy függvény, ami üzenetet ír ki:

```cs
public static void CustomMethod(string msg) {
    Console.WriteLine(msg);
}
```

Most szeretnél egy változót, ami ezt a függvényt tudja "tárolni" és meghívni. Ehhez hozunk létre egy delegate-t:

```cs
public delegate void Del(string message);
```

Ez a delegate olyan függvényekre tud mutatni, amelyeknek a visszatérési értéke void, és egyetlen string paraméterük van, mint a CustomMethod esetén.

Most hozzárendelhetjük a CustomMethod-ot egy delegate-hez:

```cs
Del delegateHandler = CustomMethod;
```

Most a delegateHandler változóval meg tudod hívni a CustomMethod-ot:

```cs
delegateHandler("Hello, Delegate!");
// Kimenet: Hello, Delegate!
```

Delegate átadása másik függvénynek

A delegate-eket másik függvénynek is átadhatjuk paraméterként. Nézd meg ezt a példát:

```cs
public void DoMagic(int param, Del callback) {
    callback($"Magic number: {param * 3}");
}
```

A DoMagic függvény egy számot és egy delegate-et vár. Amikor meghívjuk, megszorozza a számot 3-mal, majd meghívja a delegate-et (ami egy függvényt mutat).

Például:

```cs
DoMagic(3, delegateHandler);
// Kimenet: Magic number: 9

Delegate több függvénnyel

Egy delegate több függvényre is hivatkozhat. Ha több függvényt szeretnél egy delegate-be "összefűzni", ezt megteheted:

```cs
public class MethodClass {
    public void Method1(string message) {
        Console.WriteLine("Method1: " + message);
    }

    public void Method2(string message) {
        Console.WriteLine("Method2: " + message);
    }
}

var obj = new MethodClass();
Del d1 = obj.Method1;
Del d2 = obj.Method2;

Del allMethods = d1 + d2;
allMethods("Delegate chaining");
// Kimenet:
// Method1: Delegate chaining
// Method2: Delegate chaining
```

Ha egy delegate objektumhoz hozzáadsz egy másik függvényt a += operátorral, mindkét függvény meghívódik a delegate használatakor.
Func és Action

A Func és Action delegate-ek előre definiált delegate típusok, amelyek megkönnyítik a munkát.

    Func: Olyan delegate, amelynek van visszatérési értéke.

Például egy függvény, ami két számot összead:

```cs
static int Sum(int x, int y) {
    return x + y;
}

Func<int, int, int> add = Sum;
int result = add(10, 20);
Console.WriteLine(result); // Kimenet: 30
```

Itt a Func<int, int, int> azt jelenti, hogy a függvény két int paramétert fogad, és egy int-et ad vissza.

    Action: Olyan delegate, amelynek nincs visszatérési értéke.

Például egy függvény, ami csak kiír egy üzenetet:

```cs
public static void Logger(string message) {
    Console.WriteLine("Log: " + message);
}

Action<string> logger = Logger;
logger("This is a log message.");
// Kimenet: Log: This is a log message.

Az Action<string> azt jelenti, hogy a függvény egy string paramétert vár, de nincs visszatérési értéke.
```

Összefoglalás

A delegate-ekkel függvényeket adhatunk át más függvényeknek, több függvényt fűzhetünk össze, és olyan eszközöket, mint a Func és Action, használhatunk egyszerűbb delegate-ként.