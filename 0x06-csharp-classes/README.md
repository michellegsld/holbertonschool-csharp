## README for 0x06-csharp-classes ##
### A directory within the holbertonschool-csharp repo ###

| File Name | Description |
| --------- | ----------- |
| 0-enemy/ <br> 0-enemy/0-enemy.csproj <br> 0-enemy/0-enemy.cs | **Task: 0. Braaainsss** <br> A namespace called `Enemies` with an empty public class called `Zombie` that defines a zombie. |
| 1-enemy/ <br> 1-enemy/1-enemy.csproj <br> 1-enemy/1-enemy.cs | **Task: 1. Healthy competition** <br> Based on `0-enemy`, added a public field called `health`, an int with no value, to the public class `Zombie`. The public constructor is `public Zombie()`, and sets the value of `health` to `0`. |
| 2-enemy/ <br> 2-enemy/2-enemy.csproj <br> 2-enemy/2-enemy.cs | **Task: 2. Health validation** <br> Based on `1-enemy`, defines a zombie by adding the public constructor `public Zombie(int value)` where `value` must be greater than or equal to 0. If `value` was less than 0 then an `ArgumentException` was thrown with the message `Health must be greater than or equal to 0`. |
| 3-enemy/ <br> 3-enemy/3-enemy.csproj <br> 3-enemy/3-enemy.cs | **Task: 3. Zombie health** <br> Based on `2-enemy`, makes `health` a private field instead. Adds the public method `public int GetHealth()` that returns the value of health of the Zombie object. |
| 4-enemy/ <br> 4-enemy/4-enemy.csproj <br> 4-enemy/4-enemy.cs | **Task: 4. Hello, my name is** <br> Based on `3-enemy`, with a private field called `name`, where `name` has to be a string with a default value of `(No name)`. The public property `Name` has a `get` to retrieve `name` and `set` to set `name`. |
| 5-enemy/ <br> 5-enemy/5-enemy.csproj <br> 5-enemy/5-enemy.cs | **Task: 5. Printing a zombie** <br> Based on `4-enemy`, adding a public `.toString()` that prints the Zombie object's attributes to stdout, with the format: `Zombie name: <name> / Total Health: <health>`. |
