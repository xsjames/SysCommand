#SysCommand
Framework for development console application using the MVC pattern. A good option of command line parser.

#Install

* NuGet: 
* NuGet Core CRL: 

#Simple example

######Code

```csharp
namespace Example
{
    using SysCommand.ConsoleApp;

    public class Program
    {
        public static int Main()
        {
            return App.RunApplication();
        }
    }

    // example with method
    public class Command1 : Command
    {
        // overload1
        public string HelloWorld(string myArg0, int? myArg1 = null)
        {
            return string.Format("My HelloWorld1 (Arg0: {0}; Arg1: {1})", myArg0, myArg1);
        }

        // overload2
        public string HelloWorld(string myArg0, DateTime myArg1)
        {
            return string.Format("My HelloWorld2 (Arg0: {0}; Arg1: {1})", myArg0, myArg1);
        }
    }
    
    // example with properties
    public class Command2 : Command
    {
        public string MyArg0 { get; set; }
        public string MyArg1 { get; set; }

        // the method main() without params is used (by convention) when one or more args is parsed
        public string Main()
        {
            return string.Format("My HelloWorld3 (Arg0: {0}; Arg1: {1})", MyArg0, MyArg1);
        }
    }
}
```
######Tests and Results

```
C:\MyApp.exe hello-world --my-arg0 ABC
My HelloWorld1 (Arg0: ABC; Arg1: )

C:\MyApp.exe hello-world ABC
My HelloWorld1 (Arg0: ABC; Arg1: ) // positional

C:\MyApp.exe hello-world --my-arg0 ABC --my-arg1 10000
My HelloWorld1 (Arg0: ABC; Arg1: 10000)

C:\MyApp.exe hello-world ABC 10000
My HelloWorld1 (Arg0: ABC; Arg1: 10000) // positional

C:\MyApp.exe hello-world --my-arg0 ABC --my-arg1 "2017-01-01 10:10:22"
My HelloWorld2 (Arg0: ABC; Arg1: 01/01/2017 10:10:22)

C:\MyApp.exe hello-world ABC "2017-01-01 10:10:22"
My HelloWorld2 (Arg0: ABC; Arg1: 01/01/2017 10:10:22) // positional

C:\MyApp.exe --my-arg0 ABC
My HelloWorld3 (Arg0: ABC; Arg1: )

C:\MyApp.exe --my-arg0 ABC --my-arg1 DEF
My HelloWorld3 (Arg0: ABC; Arg1: DEF)
```

##Comportamento padrão

Ao criar-se uma classe que herda de `Command`, em qualquer lugar do seu projeto console application, todos os seus métodos e propriedades `publicas` serão habilitados para serem chamados via prompt de comando automaticamente.

Os métodos serão convertidos em ações e as propriedades em argumentos de acordo com a seguinte regra: Converte o nome do membro (métodos, parametros e propriedades) em minusculo e adiciona um traço "-" antes de cada letra maiuscula que estiver no meio ou no final do nome. 

**Exemplo:**

```csharp
public string MyProperty { get;set; }
public void MyAction(string MyArgument);
```

```MyApp.exe my-action --my-argument value1 --my-property value2```

Em caso de propriedades ou paramentros de métodos com apenas uma letra, o padrão será deixar a letra minuscula e o input será aceito apenas na forma curta.

**Exemplo:**

```csharp
public string S { get;set; }
public void MyAction(string A);
```

```MyApp.exe -s value1 my-action -a value2```

* Para ter mais controle de quais comandos podem ser utilizados, veja o tópico de `Inicialização`.
* Para desabilitar a disponibilidade automatica de membros `publicos` ou customizar os nomes dos membros, veja o tópico de `Customizações`.

##Help automatico

O `help` é gerado de forma automatica pelo sistema e para exibi-lo basta seguir os exemplos abaixo:

**Exibe o help completo:**

```MyApp.exe help```

**Exibe o help para uma ação especifica:**

```MyApp.exe help my-action```

O texto do `help` é gerado por um comando interno do sistema, mas é possível customizar esse texto, basta criar um novo `Command` que herda da interface `SysCommand.ConsoleApp.Commands.IHelpCommand` e o help padrão será ignorado.

```csharp
using SysCommand.ConsoleApp;
public class Program
{
    public static int Main()
    {
        return App.RunApplication();
    }

    public class CustomHelp : Command, SysCommand.ConsoleApp.Commands.IHelpCommand
    { 
        public CustomHelp()
        {
            HelpText = "My custom help";
        }

        public string MyCustomHelp(string action = null)
        {
            foreach(var map in this.App.Maps)
            { 
                ... 
            }
        }
    }
}
```

```MyApp.exe custom-help```

Uma outra opção é criar um `Descriptor` que herda da interface `SysCommand.ConsoleApp.Descriptor.IDescriptor` e defini-lo na sua propriedade `App.Descriptor`. Isso é possível, pois o `help` padrão utiliza os métodos de help contidos dentro dessa instancia. Essa opção não é recomendada se você deseja apenas customizar o `help`. 

Uma opção mais segura seria criar um `Descriptor` herdando da classe `SysCommand.ConsoleApp.Descriptor.DefaultDescriptor` e sobrescrer apenas os métodos de help.

```csharp
using SysCommand.ConsoleApp;
public class Program
{
    public static int Main()
    {
        return App.RunApplication(
            () => {
                var app = new App();
                app.Descriptor = new CustomDescriptor();
                // OR
                app.Descriptor = new CustomDescriptor2();
                return app;
            }
        );
    }

    public class CustomDescriptor : IDescriptor { ... }
    public class CustomDescriptor2 : DefaultDescriptor
    { 
        public override string GetHelpText(IEnumerable<CommandMap> commandMaps) { ... }
        public override string GetHelpText(IEnumerable<CommandMap> commandMaps, string actionName) { ... }
    }
}
```

* Para customizar os textos de cada ação ou propriedade, veja o tópido de `Customizações`.
* O comando de help é o único que não pode ser ignorado pela inicialização, caso ele não exista na lista de tipos, ele será adicionado internamente.

##Tipos de commands

Atualmente existem tres tipos de comandos:

**Comandos de usuário**

São os comandos comuns e que herdam apenas da class `Command`. 

**Comandos de help**

São os comandos que herdam da classe `Command` e implementam a interface `IHelpCommand`. Contudo, apenas um será utilizado. 

**Comandos de debug**

Os comandos de debug são comandos que são carregados apenas durante o debugging do Visual Studio. Um bom exemplo seria o comando interno "ClearCommand", ele disponibiliza a action "clear" para limpar o prompt de comando que o Visual Studio abre durante o processo de debug. Para criar um comando de debug basta habilitar a flag `Command.OnlyInDebug`.

```csharp
public class ClearCommand : Command
{
    public ClearCommand()
    {
        HelpText = "Clear window. Only in debug";
        OnlyInDebug = true;
    }

    public void Clear()
    {
        Console.Clear();
    }
}
```

##Verbose

O controle de exibição por verbo esta contido em um comando interno chamado `VerboseCommand`. A sua função é alterar o valor da propriedade `App.Console.Verbose` caso o usuário envie um input de verbose. Atualmente, os verbos suportados são:

* All: Exibe todos os verbos
* Info: É o verbo padrão, sempre será exibido, ao menos que o usuário envie o verbo `Quiet`.
* Success: Verbo para mensagens de sucesso.
* Critical: Verbo para mensagens criticas.
* Warning: Verbo para mensagens de warning.
* Error: Verbo para mensagens de erro. O sistema força o envio desse verbo em caso de erros de parse.
* Quiet: Verbo para não exibir nenhuma mensagem, porém se a mensagem estiver sendo forçada, esse verbo é ignorado para essa mensagem.

Para que a funcionalidade funcione corretamente é obrigatorio o uso das funções de output contidas dentro da classe `ConsoleWrapper` e que tem uma instancia disponível na propriedade `App.Console`. 

**Exemplo:**

```csharp
public class TestVerbose : Command
{
    public void Test()
    {
        this.App.Console.Write("output of info"); 
        this.App.Console.Error("output of error");
        this.App.Console.Error("output of error forced", forceWrite: true);
        this.App.Console.Critical("output of critical");
    }
}
```

Forma curta: ```MyApp.exe test -v Critical```

Forma longa: ```MyApp.exe test --verbose Critical```

Outputs:

```
output of info
output of error forced
output of critical
```

* Para desativar o comando `VerboseCommand` veja o tópico de `Inicialização`.

##Controle de output

O mecanismo de output foi extendido para tarefas comuns em uma aplicação console application. Nada impede você de usar o mecanismo padrão do .NET com a classe "Console.Write()" e afins, mas creio que utilizar o wrapper `ConsoleWrapper` pode te dar alguns beneficios como:

* Quebra automatica de linha ao usar os métodos `App.Console.Write(..)` e `App.Console.Read(..)`
* Funcionalidade de verbose nativa
* Possibilidade de customização da cor do texto de cada verbo
  * App.Console.ColorInfo
  * App.Console.ColorCritical
  * App.Console.ColorError
  * App.Console.ColorSuccess
  * App.Console.ColorWarning
  * App.Console.ColorRead

Outro beneficio é a utilização dos `retornos dos métodos` como sendo outra forma de output. É possível afirmar que esse recurso caracteriza o `SysCommand` no padrão "MVC", ficando muito semelhante ao "AspNet MVC".

```csharp
public class TestOutput : Command
{
    public decimal Test()
    {
       var result = this.App.Console.Read("My question: ");

        if (result != "S")
        { 
            // option1: use write method
            this.App.Console.Write(99.99m);
            // option2: or use return, its the same.
            return 99.99m;
        }

        return 0;
    }
}

Input: ```MyApp.exe test```
Outputs:

```
My question: N
99,99
99,99
```

**Comandos de usuário**

* SysCommand.ConsoleApp.Commands.ArgsHistoryCommand


Observação: Caso você opte por escolher os comandos que farão parte da sua aplicação, todos os comandos internos, com exceção do comando de `help`, NÃO serão carregados. O comando de `help` é o único que sempre será carregado.

##Controle de erro automatico

##Trabalhando com propriedades



* Main()

##RestartResult or ActionResult


##Eventos

##Métodos explicitos e implicitos

* Main()

##Tipos de inputs

Os argumentos, sejam eles paramentros de métodos ou propriedades, podem ter duas formas: a `longa` e a `curta`. Na forma `longa` o argumento deve-se iniciar com "--" ou "/" seguido do seu nome. Na forma `curta` ele deve sempre iniciar com apenas um traço "-" e seguido de apenas um caracter. Esse tipo de input (longo ou curto) é chamado de `input nomeado`.

Existe também a possibilidade de aceitar inputs posicionais, ou seja, sem a necessidade de utilizar os nomes dos argumentos. Esse tipo de input é chamado de `input posicional`.

**Exemplo:**

```csharp
public string MyProperty { get;set; }
public void MyAction(string A, string B);
```

**Input nomeado**:

```MyApp.exe my-action -a valueA -b valueB --my-property valueMyProperty```

**Input posicional**:

```MyApp.exe my-action valueA valueB valueMyProperty```

* Para as propriedades, o `input posicional` é desabilitado por padrão, para habilita-lo utilize a propriedade de comando `Command.EnablePositionalArgs`. 
* Para os métodos esse tipo de input é habilitado por padrão, para desabilita-lo veja no tópico de `Customizações`. 

##Customizações

SysCommand.Mapping.ActionAttribute

  * string Name: Define um nome customizado para a action. Ignora o padrão acima.
  * bool Ignore: Permite que um método publico possa continuar sendo publico, mas deixar de ser uma action.
  * bool EnablePositionalArgs: Habilita ou desabilita o parse positional de argumentos. Default é `true`.
  * string Help: Texto usado para compor o help.
  * bool UsePrefix: Define se a action terá ou não o prefixo da classe pai. Default é `false`.
  * bool IsDefault: Define se um método pode ser acesso de forma implicita, ou seja, sem a obrigatoriedade de ter seu nome especificado no input.

[Action(IsDefault=true)]
public void MyAction(string MyArgument);

Explicit input

MyApp.exe my-action my-argument value

Or Implicit input

MyApp.exe my-argument value

SysCommand.Mapping.ArgumentAttribute

  * char ShortName: Indica o caracter para o argumento ser acessado de forma simples, usando apenas um traço. Por exemplo, para habilitar o verbose podemos usar a forma reduzida '-v' ao inves da forma longa '--verbose'.
  * string LongName: Indica a string da forma longa. 
  * bool IsRequired: 
  * string Help: 
  * bool HasDefaultValue: 
  * object DefaultValue: 
  * int Position: 
  * HasPosition: 
  * bool ShowHelpComplement: 


* SysCommand.ConsoleApp.App
* SysCommand.ConsoleApp.Command


É interessante manter todos os seus Command's em uma pasta chamada "Commands", deixando semelhante a estrutura do Asp.NET MVC.

####Support types

string
bool
decimal
double
int
uint
DateTime
byte
short
ushort
long
ulong
float
char
Enum
Enum with Flags
Generic collections (IEnumerable, IList, ICollection)
Arrays

Syntax

[action-name ][-|--|/][name][=|:| ][value]

Boolean syntax

MyApp.exe -a  // true
MyApp.exe -a- // false
MyApp.exe -a+ // true
MyApp.exe -a - // false
MyApp.exe -a + // true
MyApp.exe -a true // true
MyApp.exe -a false // false
MyApp.exe -a 0 // true
MyApp.exe -a 1 // false

Multiple assignments syntax

MyApp.exe -abc  // true for a, b and c
MyApp.exe -abc- // false for a, b and c
MyApp.exe -abc+ // true for a, b and c

Enum syntax

[Flags]
public enum Verbose
{
    None = 0,
    All = 1,
    Info = 2,
    Success = 4,
    Critical = 8,
    Warning = 16,
    Error = 32,
    Quiet = 64
}

MyApp.exe --verbose Error Info Success
MyApp.exe --verbose 32 2 Success

Generic collections or Array sintax

public void MyAction(IEnumerable<decimal> myLst, string[] myArray = null);

MyApp.exe --my-lst 1.0 1.99
MyApp.exe 1.0 1.99 // positional
MyApp.exe --my-lst 1.0 1.99 --my-array str1 str2
MyApp.exe 1.0 1.99 str1 str2 // positional

Importante!

Todos as conversões levam em consideração a cultura configurada na propriedade estática "CultureInfo.CurrentCulture".

####Inicialização

##Features

  * Main context:  `App`
  * Console Application with MVC
    * Parser
    * Supported types
    * Razor templates: Just use the return "Command.View()" in your actions, like MVC Web application. (using System.Web.Razor dependency)
    * T4 templates: Just use the return "Command.ViewT4()" in your actions.
    * Indented text using the class "TableView".
    * Functionality Multi Action to be possible invoke several actions in the same input. By default is enable 'App.EnableMultiAction'.
  * Automatic configuration. Just the class inherit from "Command".
  * Automatic help functionality including usage mode. Just use the input actions 'help'
  * Functionality for saving command histories. Just use the input actions 'history-save [name]', 'history-load [name]', 'history-remove [name]' and 'history-list'
  * Simple mechanism of object persistence in JSON text files (using NewtonSoft dependency)
  * Mechanism to speed development in debug mode. Just use the "App.RunInfiniteIfDebug()" method.
    * Include the command 'clear' to clear the console window when in debug mode.
  * Mechanism to help write and read informations: Just use the console wrapper "App.Console":
    * Write: Print texts using the following verbs: "Info", "Success", "Warning", "Critical", "Error", "None", "All".
    * Read: If you use the 'Writes' methods is recommended use the reads methods.
    * Verbose: Choose which are verbs can be printed in console. Just use the input argument '-v' or '--verbose'
  * Functionality to persists anything in App scope (in memory). Just use 'App.Items".
  * Events controllers "OnComplete", "OnException" e etc...
  * Extras: Simple command line parser using "OptionSet" class.

######Main context

O contexto da execução é baseado na instancia da classe `App`. Os passos são simples, criação, configuração e execução.

App:

* constructor
  *  IEnumerable<Type> commandsTypes (default null): Indica os tipos de comandos que participaração da analise e execução. Caso `null` então será feito uma pesquisa automatica de todos as classes do assembly que herdam de `Command`. A pesquisa é feita usando a classe `AppDomainCommandLoader`.
  *  bool enableMultiAction = true: Determina se a analise irá considerar a execução de mais de uma ação por linha de comando. Ver mais na sequencia.
  *  IExecutor executor = null: Alterar o executor padrão por um customizado.
  *  bool addDefaultAppHandler = true: Desabilita o handler default. O handler default nada mais é que a implementação dos eventos da class `App`.
* bool ReadArgsWhenIsDebug: 
* IEnumerable<CommandMap> Maps: 
* IEnumerable<Command> Commands: 
* ConsoleWrapper Console: 
* IDescriptor Descriptor: 
* ItemCollection Items: 

* App AddApplicationHandler(IApplicationHandler handler): 
* ApplicationResult Run(): 
* ApplicationResult Run(string arg): 
* ApplicationResult Run(string[] args): 
* int RunApplication(Func<App> appFactory = null)
* event OnComplete: 
* event OnException: 
* event OnBeforeMemberInvoke: 
* event OnAfterMemberInvoke: 
* event OnMethodReturn: 

######Parser

Ao criar-se uma classe que herda de `Command`, em qualquer lugar do seu projeto console application, todos os seus métodos e propriedades `publicas` serão habilitados para serem chamados via prompt de comando automaticamente. As customizações podem ser feitas usando atributos ou via construtor da classe de comando.

Customizações do Command:

  * App App: Referencia do contexto da aplicação.
  * string HelpText
  * bool OnlyMethodsWithAttribute
  * bool OnlyPropertiesWithAttribute 
  * bool EnablePositionalArgs
  * bool UsePrefixInAllMethods
  * string PrefixMethods
  * bool OnlyInDebug 
  * ExecutionScope ExecutionScope

```csharp
public class Command1 : Command
{
    public Command1()
    {
        this.HelpText = "My custom help";
        this.EnablePositionalArgs = true;
    }
}
```

ActionAttribute

  * Name: Define um nome customizado para a action. Por padrão, o nome do método 
  * Ignore: 
  * EnablePositionalArgs: 
  * Help: 
  * UsePrefix: 
  * IsDefault: 

ArgumentAttribute

  * char ShortName: 
  * string LongName: 
  * bool IsRequired: 
  * string Help: 
  * bool HasDefaultValue: 
  * object DefaultValue: 
  * int Position: 
  * HasPosition: 
  * bool ShowHelpComplement: 




