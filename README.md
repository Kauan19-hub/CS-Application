# Programming with C#

###

The first project addresses topics such as:

###

- Object-Oriented (OOP);
- Data structure;
- Organization;
- File handling.

###
```powershell
git clone https://github.com/Kauan19-hub/CS-Application.git
```

---

**<h3>✅ How to Run</h3>**

###

**1️⃣- Run the code in the console**

###

If you already have a `Program.cs` file:

###

**<h2>Using .NET CLI</h2>**

###

- Open the terminal in the project folder;
- Compile and run:

###
```powershell
dotnet run
```

###

> This will compile the project and run the program.

###

**<h2>If you only have one `.cs` file</h2>**

###
```powershell
csc Program.cs
```

###
```powershell
Program.exe
```

###

> `csc` é o compilador `C#` do `.NET` Framework.

###

**2️⃣-Execute a system command within the `C#` program**

###
```csharp
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string comando = "ping google.com";

        Process processo = new Process();
        processo.StartInfo.FileName = "cmd.exe";
        processo.StartInfo.Arguments = "/c " + comando;
        processo.StartInfo.RedirectStandardOutput = true;
        processo.StartInfo.UseShellExecute = false;
        processo.StartInfo.CreateNoWindow = true;

        processo.Start();

        string resultado = processo.StandardOutput.ReadToEnd();
        processo.WaitForExit();

        Console.WriteLine(resultado);
    }
}
```

###

> This will run any `terminal` command within your program.

###

**3️⃣- Run `C#` methods (functions)**

###
```csharp
static void Main()
{
    DizerOla();
}

static void DizerOla()
{
    Console.WriteLine("Olá!");
}
```

---

<div align="left">
  <img src="https://skillicons.dev/icons?i=cs" height="30" alt="csharp logo" title="Csharp" />
  <img width="1" />
  <img src="https://skillicons.dev/icons?i=dotnet" height="30" alt="dot-net logo" title="Dot-Net" />
  <img width="1" />
  <img src="https://skillicons.dev/icons?i=vscode" height="30" alt="vscode logo" title="Visual Studio Code" />
  <img width="1" />
  <img src="https://skillicons.dev/icons?i=git" height="30" alt="git logo" title="Git" />
  <img width="1" />
  <img src="https://skillicons.dev/icons?i=github" height="30" alt="github logo" title="GitHub" />
</div>

###
