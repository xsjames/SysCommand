[
![Inglês](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/img/en-us.png)
](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/en.md)
[
![Português](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/img/pt-br.png)
](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md)

# <a name="documentation" />Documentação

* [Iniciando](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#class-app)
  * [Inicializando com o simulador de console](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#initializing-by-static-method)
  * [Especificando os tipos de comandos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#specifying-commands)
  * [Tipos de comandos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#kind-of-commands)
  * [Orquestrador de comandos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#orchestrating-commands)
  * [Controle de eventos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#events)
* [Input](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input)
  * [`Arguments`](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-arguments)
    * [Argumento nomeado](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-named)
    * [Argumento posicional](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-positional)
  * [`Actions`](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-actions)
    * [Multi-action](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#using-the-multi-action-feature)
  * [Tipos suportados](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#support-types)
  * [Parser](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser)
    * [Mapeamento](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-mapping)
      * [Retorno](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-mapping-return)
    * [Parser simples](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-simple)
      * [Retorno](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-simple-return)
    * [Parser complexo](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-complex)
      * [Escolhendo os melhores métodos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-complex-methods)
      * [Escolhendo as melhores propriedades](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-complex-properties)
      * [Retorno](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-complex-return)
    * [Execução](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-execution)
      * [Retorno](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#input-parser-execution-return)
* [Output](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#output)
  * [Usando template Razor](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#output-razor)
  * [Usando template T4](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#output-t4)
  * [Dados tabelado](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#output-tabulated)
* [Trabalhando com propriedades](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties)
  * [Modo de uso 1](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-use-mode1)
  * [Modo de uso 2](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-use-mode2)
  * [Customizando os nomes dos argumentos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-customizing-name)
  * [Customizando as informações de help](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-customizing-help)
  * [Propriedades obrigatórias](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-required)
  * [Habilitando o input posicional](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-positional)
  * [Escolha manual de propriedades via atributo](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-ignore-public)
* [Trabalhando com métodos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods)
  * [Métodos sem parâmetros](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-without-params)
  * [parâmetros optionais](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-optional-params)
  * [Sobrecargas](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-overloads)
  * [Usando inputs posicionais](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-positional-inputs)
  * [Ignorar métodos publicos por uma escolha manual usando atributo](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-ignore-public)
  * [Customizando nomes de ações e argumentos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-customizing-names)
  * [Customizando as informações de help nas ações e em seus parâmetros](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-customizing-help)
  * [Trocando a posição de parâmetros posicionais](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-changing-position)
  * [Propriedades do atributos ArgumentAttribute que não são utilizados](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-not-used-attrs)
  * [Métodos padrão](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-default)
* [Help](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#help)
  * [Customizando](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#help-default)
* [Verbose](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#verbose)
* [Tratamento de erros](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#error)
* [Variáveis de contexto](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#variable)
* [Gerenciador de objetos em forma de arquivos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#file-manager)
* [Redirecionamento de comandos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#redirectiong-commands)
* [Cancelamento da continuidade da execução](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#stop-propagation)
* [Gerenciamento de históricos de argumentos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#argument-history-manager)
* [Extras - OptionSet](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#extras)

# <a name="class-app" />Iniciando

A inicialização do contexto da aplicação pode ser feita de duas formas, por uma instância da class `App` com suas possíveis customizações ou através do método estático `App.RunApplication` que disponibiliza um recurso chamado **simulador de console** que ajuda você a testar seus inputs dentro do próprio Visual Studio, sem a necessidade de executar seu ".exe" em um console externo.

A classe `App` esta no topo da hierarquia de classes, cada instância equivale a um contexto isolado que vai conter uma arvore de outros objetos que são exclusivos desse contexto. Nenhum recurso estático é usado aqui e isso é importante para ter a liberdade de criar quantas instâncias quiser em qualquer escopo.

Em seu construtor estão as primeiras configurações:

```csharp
public App(
           IEnumerable<Type> commandsTypes = null,
           bool enableMultiAction = true,
           bool addDefaultAppHandler = true,
           TextWriter output = null
       )
```

* `commandsTypes`: Especifica os tipos dos `Command` que serão utilizados em todo o processo. Caso seja `null` então o sistema buscará automáticamente qualquer classe que extenda de `Command`. Entenda melhor em [Especificando os tipos de comandos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#specifying-commands).
* `enableMultiAction`: Liga ou desliga o comportamento de `MultiAction`. Por padrão, esse comportamento estará habilitado. Entenda melhor em [Multi-action](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#using-the-multi-action-feature).
* `addDefaultAppHandler`: Caso seja `false` então NÃO cria o handler de eventos que é responsável pelo mecanismo padrão de `outputs` e controles de `erros` e dentre outros. O padrão é `true`. Entenda melhor em [Controle de eventos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#events).
* `output`: Redireciona a saída para o `TextWriter` especificado. Do contrário será usado por padrão o `Console.Out`.

## <a name="initializing-by-static-method" />Inicializando com o simulador de console

Este recurso ajuda você a testar seus inputs dentro do próprio Visual Studio sem a necessidade de executar seu ".exe" em um console externo. É importante ressaltar que esse simulador só será exibido dentro do Visual Studio.

A chamada é bastante simples, basta adicionar uma linha para que tudo funcione usando as regras padrão. Caso você queira customizar a sua instância de `App` então utilize o construtor `App.RunApplication(Func<App> appFactory)`.

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Default
        App.RunApplication();

        // Or use custom App

        /*
        App.RunApplication(() =>
        {
            var app = new App(enableMultiAction: false);
            return app;
        });
        */
    }

    public class MyCommand : Command
    {
        public string MyProperty
        {
            set
            {
                App.Console.Write(value);
            }
        }
    }
}
```

Quando você executar esse código no Visual Studio, um prompt com o label `cmd>` será exibido. Isso indica que você pode iniciar seus testes quantas vezes for necessário. Para sair, você pode usar o atalho padrão "CTRL+C" ou apertar o botão "stop" do Visual Studio.

```
cmd> --my-property value
value
cmd> --my-property otherValue
otherValue
```

## <a name="specifying-commands" />Especificando os tipos de comandos

Ao especificar cada `Command` que será utilizado, você perde o recurso de busca automática, mas ganha a flexibidade de controlar quais `Commands` devem ou não fazer parte do seu sistema. Para isso você pode trabalhar de duas formas, a **inclusiva** ou a **exclusiva**. A forma inclusiva é basicamente a especificação de cada `Command` e a forma exclusiva é o oposto, primeiro se carrega tudo e depois elimina-se o que não deseja.

A classe `SysCommand.ConsoleApp.Loader.AppDomainCommandLoader` é a responsável por buscar os `Commands` de forma automática e você pode usa-la caso queira usar a forma exclusiva. Internamente o sistema faz uso dela caso o parâmetro `commandsTypes` esteja `null`.

**Exemplo de forma inclusiva:**

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var commandsTypes = new[]
        {
            typeof(FirstCommand)
        };

        // Specify what you want.
        new App(commandsTypes).Run(args);

        // Search for any class that extends from Command.
        /*
        new App().Run(args);
        */
    }

    public class FirstCommand : Command
    {
        public string FirstProperty
        {
            set
            {
                App.Console.Write("FirstProperty");
            }
        }
    }

    public class SecondCommand : Command
    {
        public string SecondProperty
        {
            set
            {
                App.Console.Write("SecondProperty");
            }
        }
    }
}
```

```
MyApp.exe help
usage:    [--first-property=<phrase>] <actions[args]>

FirstCommand

   --first-property    Is optional.

Displays help information

   help
      --action         Is optional.

Use 'help --action=<name>' to view the details of
any action. Every action with the symbol "*" can
have his name omitted.
```

Perceba que ao digitar `help` a classe `SecondCommand` não é exibida.

Perceba também que existe um help para o próprio mecanismo de help, esse `Command` sempre deverá existir, caso não seja especificado na sua lista de tipos o proprio sistema se encarregará de cria-lo utilizando o help padrão `SysCommand.ConsoleApp.Commands.HelpCommand`. Para mais informações sobre customização de help consulte [Help](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#help).

**Exemplo de forma exclusiva:**

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Create loader instance
        var loader = new AppDomainCommandLoader();

        // Remove unwanted command
        loader.IgnoreCommand<FirstCommand>();
        loader.IgnoreCommand<VerboseCommand>();
        loader.IgnoreCommand<ArgsHistoryCommand>();

        // Get all commands with 'ignored' filter
        var commandsTypes = loader.GetFromAppDomain();

        new App(commandsTypes).Run(args);
    }

    public class FirstCommand : Command
    {
        public string FirstProperty
        {
            set
            {
                App.Console.Write("FirstProperty");
            }
        }
    }

    public class SecondCommand : Command
    {
        public string SecondProperty
        {
            set
            {
                App.Console.Write("SecondProperty");
            }
        }
    }
}
```

```
MyApp.exe help
usage:    [--second-property=<phrase>] <actions[args]>

SecondCommand

   --second-property    Is optional.

Displays help information

   help
      --action          Is optional.

Use 'help --action=<name>' to view the details of
any action. Every action with the symbol "*" can
have his name omitted.
```

Perceba que ao digitar `help` a classe `FirstCommand` não é exibida.

Por enquanto, não se atente agora para as classes `VerboseCommand` e `ArgsHistoryCommand` elas são commands internos e serão explicados mais adiante na documentação.

## <a name="kind-of-commands" />Tipos de comandos

Atualmente existem tres tipos de comandos:

**Comandos de usuário**

São os comandos comuns e que herdam apenas da class `Command`.

**Comandos de help**

São os comandos que herdam da classe `Command` e implementam a interface `IHelpCommand`. Contudo, apenas um será utilizado.

**Comandos de debug**

Os comandos de debug são comandos que são carregados apenas durante o debugging do Visual Studio. Um exemplo desse tipo é o comando interno "ClearCommand", ele disponibiliza a ação chamada `clear` para limpar o prompt aberto pelo Visual Studio durante o debug. Para criar um comando do tipo "debug", é necessário habilitar a flag `Command.OnlyInDebug`.

```csharp
public class ClearCommand : Command
{
    public ClearCommand()
    {
        this.HelpText = "Clear window. Only in debug";
        this.OnlyInDebug = true;
    }

    public void Clear()
    {
        Console.Clear();
    }
}
```

## <a name="orchestrating-commands" />Orquestrador de comandos

Uma forma interessante de usar o SysCommand é fazendo o uso de diversos comandos em uma ação que orquestre as execuções. É importante lembrar que os comandos devem ser criados para funcionarem de forma independente, se isso não for possível, não torne-o um comando, crie uma classe que não herde de `Command` e utilize em sua ação.

O exemplo abaixo mostra um cenário onde seria interessante o uso de diversos comandos em uma ação. A ideia é criar uma aplicação que possa fazer a montagem de um `csproj` e também o ZIP de uma pasta qualquer. Porém, teremos uma ação `Publish` que fará a publicação da aplicação usando os dois comandos.

```csharp
using SysCommand.ConsoleApp;
using SysCommand.Mapping;
using System;
using System.Diagnostics;
using System.IO;

namespace Publisher
{
    public class OrchestratorCommand : Command
    {
        public void Publish(string csproj, string dirOutput)
        {
            var build = App.Commands.Get<MSBuildCommand>();
            var zip = App.Commands.Get<ZipCommand>();

            build.Build(csproj, dirOutput);
            pack.Zip(dirOutput);
        }
    }

    public class ZipCommand : Command
    {
        private void Zip(string dirToZip)
        {
            System.IO.Compression.ZipFile.CreateFromDirectory(dirToZip, $"{dirToZip}/package.zip"});
        }
    }

    public class MSBuildCommand : Command
    {
        public BuildCommand()
        {
            this.UsePrefixInAllMethods = true;
        }

        public void Clear()
        {
            // Clear
        }

        [Action(UsePrefix = false)]
        public void Build(string csproj, string dirOutput)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    FileName = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe",
                    WindowStyle = ProcessWindowStyle.Normal,
                    Arguments = string.Format("{0} /t:Build /m /property:Configuration={1} /p:OutDir={2}", csproj, "Debug", dirOutput)
                };

                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                App.Console.Error(ex.Message);
            }
        }
    }
}
```

## <a name="events" />Controle de eventos

Os eventos são importantes para interceptar cada passo da execução e modificar ou extender o comportamento padrão. Os eventos existentes são os seguintes:

* `App.OnBeforeMemberInvoke(ApplicationResult, IMemberResult)`: É acionado antes de invocar cada membro (propriedade ou método) que foi analisado.
* `App.OnAfterMemberInvoke(ApplicationResult, IMemberResult)`: É acionado depois de invocar cada membro (propriedade ou método) que foi analisado.
* `App.OnMethodReturn(ApplicationResult, IMemberResult)`: : É acionado sempre que um método retorna valor
* `App.OnComplete(ApplicationResult)`: É acionado ao fim da execução
* `App.OnException(ApplicationResult, Exception)`: É acionado em caso de exceção.

**Exemplo:**

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var app = new App();

        app.OnBeforeMemberInvoke += (appResult, memberResult) =>
        {
            app.Console.Write("Before: " + memberResult.Name);
        };

        app.OnAfterMemberInvoke += (appResult, memberResult) =>
        {
            app.Console.Write("After: " + memberResult.Name);
        };

        app.OnMethodReturn += (appResult, memberResult) =>
        {
            app.Console.Write("After MethodReturn: " + memberResult.Name);
        };

        app.OnComplete += (appResult) =>
        {
            app.Console.Write("Count: " + appResult.ExecutionResult.Results.Count());
            throw new Exception("Some error!!!");
        };

        app.OnException += (appResult, exception) =>
        {
            app.Console.Write(exception.Message);
        };

        app.Run(args);
    }

    public class FirstCommand : Command
    {
        public string MyProperty { get; set; }

        public string MyAction()
        {
            return "Return MyAction";
        }
    }
}
```

```
MyApp.exe --my-property value my-action
Before: MyProperty
After: MyProperty
Before: MyAction
After: MyAction
Return MyAction
After MethodReturn: MyAction
Count: 2
Some error!!!
```

No exemplo acima, note que o controle passou para quem implementou os eventos.

Por padrão, nos temos o handler `SysCommand.ConsoleApp.Handlers.DefaultApplicationHandler` que é adicionado automaticamente. Esse handler é responsável pelo mecanismo padrão de `outputs` e controles de `erros`. Esse foi o responsável imprimir a linha "Return MyAction" do output acima. Para desliga-lo e ter o controle total dos eventos, basta desabilitar a flag `addDefaultAppHandler = false` no construtor.

```csharp
new App(addDefaultAppHandler: false).Run(args);
```

Outro modo de adicionar eventos é usando a interface `SysCommand.ConsoleApp.Handlers.IApplicationHandler`. Dessa maneira sua regra fica isolada, mas tendo o contraponto de ser obrigado a implementar todos os métodos da interface. Para adicionar um novo handler siga o exemplo abaixo:

```csharp
new App(addDefaultAppHandler: false)
        .AddApplicationHandler(new CustomApplicationHandler())
        .Run(args);
```

# <a name="input" />Input

Dividimos o input de usuário em duas entidades: `arguments` e `actions`.

## <a name="input-arguments" />`Arguments`

Os argumentos representam o meio mais básico de uma aplicação console, são normalmente representados da seguinte forma:

```
C:\MyApp.exe --argument-name value     // Long
C:\MyApp.exe -v value                  // Short
C:\MyApp.exe value                     // Positional
```

Programaticamente, os `arguments` podem ser derivados de propriedades ou dos parâmetros dos métodos.

### <a name="input-named" />Argumento nomeado

Argumentos nomeados são caracterizado por duas formas: a **longa** e a **curta**. Na forma **longa** o argumento deve-se iniciar com `--` seguido do seu nome. Na forma **curta** ele deve iniciar com apenas um traço `-` ou uma barra `/` seguido de apenas um caracter que representa o argumento.

Os valores dos argumentos devem estar na frente do nome do argumento separados por um espaço ` ` ou pelos caracteres `:` ou `=`.

**Exemplo:**

```csharp
public string MyProperty { get;set; }
public string v { get;set; }
```

_Input longo:_

```
MyApp.exe --my-property value
MyApp.exe -v value
```

_Input curto:_

```
MyApp.exe -v value
```

_OU usando o delimitador `/` e os separadores `=` e `:`_

```
MyApp.exe --my-property=value
MyApp.exe /v:value
```

### <a name="input-positional" />Argumento posicional

Argumentos posicionais funcionam sem a necessidade de utilizar os nomes dos argumentos. Basta inserir seus valores diretamente. Só é preciso tomar cuidado com esse recurso, pois pode confundir o usuário em caso de muitos argumentos posicionais.

**Exemplo:**

```csharp
public string PropA { get;set; }
public string PropB { get;set; }
public string PropC { get;set; }
```

_Input nomeado:_

```
MyApp.exe --prop-a ValueA --prop-b ValueB --prop-c ValueC
```

_Input posicional:_

```
MyApp.exe ValueA ValueB ValueC
```

_Observações:_

* Para as propriedades, o **input posicional** é desabilitado por padrão, para habilitar esse recurso, utilize a configuração `Command.EnablePositionalArgs`.
* Para os métodos, esse tipo de input é habilitado por padrão, para desabilita-lo veja no tópico de [Usando inputs posicionais](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-positional-inputs).

## <a name="input-actions" />`Actions`

São palavras reservadas para executar uma determinada ação em seu aplicativo. Elas não precisam de nenhum sufixo como ocorre com os `arguments`,basta usa-las diretamente em seu input. Seu uso é similar ao modo como usamos os recursos do git, veja:

```
git add -A;
git commit -m "comments"
```

Onde `add` e`commit` seria o nome das ações e `-A` e`-m` seus respectivos argumentos.

Programaticamente, as ações são derivadas dos métodos.

### <a name="using-the-multi-action-feature" />Multi-action

O recurso de multi-action permite que você consiga disparar mais de uma `action` em um mesmo input. Por padrão, ele vem habilitado e caso você ache desnecessário então é só desliga-lo. É importante ressaltar que o recurso [Gerenciamento de históricos de argumentos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#argument-history-manager) deixará de funcionar caso isso ocorra.

Outro ponto importante é a necessidade de "escapar" seu input caso o valor que você deseje inserir conflite com um nome de uma `action`. Essa regra vale para valores de argumentos de qualquer natureza (propriedades ou parâmetros).

**Exemplo:**

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        new App().Run(args);

        // EnableMultiAction = false
        /*
        new App(null, false).Run(args);
        */
    }

    public class MyCommand : Command
    {
        public string Action1(string value = "default")
        {
            return $"Action1 (value = {value})";
        }

        public string Action2(string value = "default")
        {
            return $"Action2 (value = {value})";
        }
    }
}
```

```
MyApp.exe action1
Action1 (value = default)

MyApp.exe action2
Action2 (value = default)

MyApp.exe action1 action2
Action1 (value = default)
Action2 (value = default)

MyApp.exe action1 action2 action1 action1 action2
Action1 (value = default)
Action2 (value = default)
Action1 (value = default)
Action1 (value = default)
Action2 (value = default)

MyApp.exe action1 --value \\action2
Action1 (value = action2)
```

O último exemplo demostra como usar o scape em seus valores que conflitam com nomes de ações. Um fato importante é que no exemplo foi usado duas barras invertidas para fazer o scape, mas isso pode variar de console para console, no `bash` o uso de apenas uma barra invertida não tem nenhum efeito, provavelmente ele deve usar para outros scapes antes de chegar na aplicação.

## <a name="support-types" />Tipos suportados

Todos os tipos primitivos do .NET são suportados, incluindo suas versões anuláveis: `Nullable<?>`.

* `string`
* `bool` ou `bool?`
* `decimal` ou `decimal?`
* `double` ou `double?`
* `int` ou `int?`
* `uint` ou `uint?`
* `DateTime` ou `DateTime?`
* `byte` ou `byte?`
* `short` ou `short?`
* `ushort` ou `ushort?`
* `long` ou `long?`
* `ulong` ou `ulong?`
* `float` ou `float?`
* `char` ou `char?`
* `Enum`/`Enum Flags` ou `Enum?`
* `Generic collections` (`IEnumerable`, `IList`, `ICollection`)
* `Arrays`

**Sintaxe genérica:**

```
[action-name ][-|/|--][argument-name][=|:| ][value]
```

**Sintaxe para `string`:**

As `strings` podem ser utilizadas de duas formas:

* Texto com espaços: Utilize aspas `" "` para textos com espaços. Do contrário você terá um erro de parse.
* Texto sem espaços: Não é obrigatório o uso de aspas, basta inserir seu valor diretamente.

```
MyApp.exe --my-string oneWord
MyApp.exe --my-string "oneWord"
MyApp.exe --my-string "two words"
```

**Sintaxe para `char`:**

Assim como em .NET os chars podem ter valores com apenas um caracter ou com um número que represente seu valor na escala de caracteres.

```
MyApp.exe --my-char 1
MyApp.exe --my-char A
```

**Sintaxe para `int`, `long`, `short` e suas variações "u" :**

São entradas númericas onde a única regra é o valor inserido não ultrapassar o limite de cada tipo.

```
MyApp.exe --my-number 1
MyApp.exe --my-number 2
MyApp.exe --my-number 999999
```

**Sintaxe para `decimal`, `double` e `float`:**

Para esses tipos é possível utilizar números inteiros ou números decimais. Só fique atento para a configuração de cultura da sua aplicação. Se for `pt-br` utilize o separador `,` / Para o formato americano utilize `.`

_EN-US:_

```
MyApp.exe --my-number 10
MyApp.exe --my-number 0.99
```

_PT-BR:_

```
MyApp.exe --my-number 10
MyApp.exe --my-number 0,99
```

**Sintaxe para `Boolean`:**

* Para o valor `TRUE`: Use `true`, `1`, `+` (separado por espaço ou unido com o nome do argumento) ou omita o valor.
* Para o valor `FALSE`: Use `false`, `0`, `-` (separado por espaço ou unido com o nome do argumento).

```
MyApp.exe -a  // true
MyApp.exe -a- // false
MyApp.exe -a+ // true
MyApp.exe -a - // false
MyApp.exe -a + // true
MyApp.exe -a true // true
MyApp.exe -a false // false
MyApp.exe -a 0 // true
MyApp.exe -a 1 // false
```

_Atribuições multiplas:_

Para argumentos que estão configurados com a **forma curta**, é possível definir o mesmo valor em diversos argumentos com apenas um traço `-`, veja:

```csharp
public void Main(char a, char b, char c) {};
```

```
MyApp.exe -abc  // true for a, b and c
MyApp.exe -abc- // false for a, b and c
MyApp.exe -abc+ // true for a, b and c
```

**Sintaxe para `DateTime`:**

O formato de entrada para os tipos `DateTime` depende da cultura que estiver configurado em sua aplicação.

_EN-US:_

```
MyApp.exe --my-date "12/13/2000 00:00:00"
```

_PT-BR:_

```
MyApp.exe --my-date "13/12/2000 00:00:00"
```

_UNIVERSAL:_

```
MyApp.exe --my-date "2000-12-13 00:00:00"
```

**Sintaxe para `Enums`:**

Os valores de entrada podem variar entre o nome do `Enum`, no formato case-sensitive, ou o seu número interno. Para `Enum Flags`, utilize espaços para adicionar ao valor do argumento.

```csharp
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

public void Main(Verbose verbose, string otherParameter = null);
```

```
MyApp.exe --verbose Error Info Success
MyApp.exe --verbose 32 2 Success
MyApp.exe Success EnumNotContainsThisString     // positional
```

No último exemplo, o valor "EnumNotContainsThisString" não pertence ao enum `Verbose`, sendo assim o próximo argumento receberá esse valor caso seu tipo seja compativél.

**Sintaxe para coleções genéricas e arrays**

As listas/arrays tem o mesmo padrão de input, separe com um espaço para adicionar um novo item da lista. Caso seu texto tenha espaço em seu conteúdo, então o adicione entre aspas.

```csharp
public void Main(IEnumerable<decimal> myLst, string[] myArray = null);
```

```
MyApp.exe --my-lst 1.0 1.99
MyApp.exe 1.0 1.99 // positional
MyApp.exe --my-lst 1.0 1.99 --my-array str1 str2
MyApp.exe --my-lst 1.0 1.99 --my-array "string with spaces" "other string" uniqueWord
MyApp.exe 1.0 1.99 str1 str2 // positional
```

No último exemplo, o valor "str1" quebra a sequência de números `1.0 1.99`, sendo assim o próximo argumento receberá esse valor caso seu tipo seja compativél.

**Importante!**

Todos as conversões levam em consideração a cultura configurada na propriedade estática "CultureInfo.CurrentCulture".

## <a name="input-parser" />Parser

O parser é dividido em 4 etapas fundamentais e o namespace `SysCommand.DefaultExecutor` é o responsável por conter as lógicas de cada etapa. A interface `SysCommand.DefaultExecutor.IExecutor` contém 4 métodos que representam cada uma dessas etapas e a classe `SysCommand.DefaultExecutor.Executor` implementa essa interface com as regras padrão do `SysCommand`.

As etapas são:

1. Mapeamento: Representado pelo método `GetMaps`.
2. Parser simples: Representado pelo método `ParseRaw`
3. Parser complexo: Representado pelo método `Parse`
4. Execução: Representado pelo método `Execute`

```csharp
public interface IExecutor
{
    IEnumerable<CommandMap> GetMaps(IEnumerable<CommandBase> commands);
    IEnumerable<ArgumentRaw> ParseRaw(string[] args, IEnumerable<CommandMap> commandsMap);
    ParseResult Parse(string[] args, IEnumerable<ArgumentRaw> argumentsRaw, IEnumerable<CommandMap> commandsMap, bool enableMultiAction);
    ExecutionResult Execute(ParseResult parseResult, Action<IMemberResult, ExecutionScope> onInvoke);
}
```

### <a name="input-parser-mapping" />Mapeamento

No mapeamento o foco é popular uma lista do modelo `SysCommand.Mapping.CommandMap` onde cada item de `CommandMap` representa um `Command`, ou seja, o mapa do comando com todas as suas `Properties` e `Methods`.

Para cada `Property` temos a classe `SysCommand.Mapping.ArgumentMap` que contém todas as informações de uma propriedade para que ela se torne um `argument` na linha de comando. Basicamente, essas informações refletem o atributo `ArgumentAttribute` somado de outras informações internas.

Para cada `Action` temos a classe `SysCommand.Mapping.ActionMap` que contém todas as informações de uma ação para que ela se torne um `action` na linha de comando. Basicamente, essas informações refletem o atributo `ActionAttribute` somado de outras informações internas. Essa classe contém uma lista com a assinatura `IEnumerable<ArgumentMap> ArgumentsMaps` que representa os seus parâmetros.

#### <a name="input-parser-mapping-return" />Retorno

Por fim, uma lista do tipo `IEnumerable<CommandMap>` é retornada contendo o mapa de cada `Command`.

### <a name="input-parser-simple" />Parser simples

É o momento onde ocorre a transformação de um `input` em objeto da forma mais simples possível, a única informação adicional que essa etapa precisa é de uma lista de `ActionMap`, assim é possível saber quando uma `action` foi inputada. Cada item é representado pela classe `SysCommand.Parsing.ArgumentRaw` que contém todas as informações do argumento como por exemplo `Name`, `Value` e `ArgumentFormat` que determina o formato do input, veja suas possibilidades:

* `Unnamed`: Argumento posicional
* `ShortNameAndNoValue`: Argumento na forma curta e sem valor (booleanos)
* `ShortNameAndHasValue`: Argumento na forma curta com valor
* `ShortNameAndHasValueInName`: Argumento na forma curta e com valor unificado com o nome do argumento usando `=` ou `:`.
* `LongNameAndNoValue`: Argumento na forma longa sem valor (booleanos)
* `LongNameAndHasValue`: Argumento na forma longa com valor
* `LongNameAndHasValueInName`: Argumento na forma longa e com valor unificado com o nome do argumento usando `=` ou `:`.

Essa etapa precisa conhecer as `actions`, pelo único motivo de escapar valores que conflitem com nomes de `actions`.

Considere que `action1` é uma ação com 1 argumento opcional chamado `--value` e que aceita valores posicionais:

```csharp
public void Action1(string value = null);
```

_Dispara a `action1` duas vezes:_

```
MyApp.exe action1 action1
```

_Executa apenas uma vez a ação "action1" com o valor "action1" no argumento `--value`. Sem essa escape a "action1" seria chamada duas vezes:_

```
MyApp.exe action1 \action1
```

Assim o parser sabe que o input `\action1` significa `action1`, ou seja, sem a barra de escape `\`.

#### <a name="input-parser-simple-return" />Retorno

Por fim, uma lista do tipo `IEnumerable<ArgumentRaw>`.

### <a name="input-parser-complex" />Parser complexo

É a etapa mais longa, onde combina o resultado do mapeamento com o resultado do parser simples. O objetivo é obter as melhores rotas para um mesmo input.

1. A primeira etapa consiste em encontrar os métodos de acordo com o input. Para isso será usado, como referencia, todos os `ArgumentRaw` no formato `Unnamed`, ou seja, argumentos sem nomes. A busca será dentro do mapa retornado pelo método `GetMaps`. Quando um método é encontrado, uma instância do tipo `SysCommand.Parsing.ActionParsed` é criada e cada parâmetro do método será representado pela classe `SysCommand.Parsing.ArgumentParsed`.
2. A primeira `action` pode ter seu nome omitido, mas para isso ela precisa ser do tipo **padrão**. Veja [Métodos padrão](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-default). Caso existam, elas só serão utilizadas quando o primeiro `ArgumentRaw` do input não é uma `action`. Nesse cenário todos os **métodos padrão** serão escolhidos para a próxima etapa. Daí para frente o processo será o mesmo.
3. Após encontrar todos os métodos de cada `action` do input, será feito a divisão em níveis. Cada nível será criado da seguinte forma:
  * Se o input iniciar com argumentos e não existir **método padrão**, então o primeiro nível será criado com estes argumentos.
  * Caso exista mais de uma `action` no input, incluindo os **métodos padrão**, cada uma representará um novo nível.
  * Os argumentos que não fazem parte do mapa da ação (sobras) formaram outro nível. Esse nível será criado após essa ação.
  * Caso não encontre nenhuma ação no input enviado, então haverá apenas um nível com os argumentos que podem ou não existir.
  * Caso não exista nenhum input, mas exista **métodos padrão** sem parâmetros, então eles serão escolhidos para a execução.
4. Todos os níveis que não são de `action` (apenas de argumentos) serão usados para encontrar as `properties`. Quando isso acontece, cada propriedade será representada pela classe `SysCommand.Parsing.ArgumentParsed` assim como os parâmetros dos métodos.

Nota importante: Quando a flag `bool enableMultiAction` estiver desligada o parser aceitará apenas uma `action`.

**Exemplo:**

```csharp
namespace Example.Input.Parser
{
    using SysCommand.ConsoleApp;
    using System;

    public class Program
    {
        public static int Main(string[] args)
        {
            return App.RunApplication();
        }
    }

    public class Command1 : Command
    {
        public string Property1 { get; set; }

        public void Main(string a, string b, string c)
        {

        }

        public void Action1(string value = null)
        {

        }

        public void Action2(string value = null)
        {

        }
    }

    public class Command2 : Command
    {
        public string Property2 { get; set; }

        public void Action1(string value = null)
        {

        }

        public void Action2(string value = null)
        {

        }
    }
}
```

_A. 2 níveis com o primeiro pertencendo ao método padrão 'Main(...)':_

```
MyApp.exe --a 1 --b 2 --c 3 action2
          |      L1        |  L2   |
```

_B. 2 níveis com duas ações:_

```
MyApp.exe action1 action2
          |  L1  |   L2 |
```

_C. 3 níveis, iniciando com 1 argumentos:_

```
MyApp.exe --property1 value action1 action2
          |        L1      |   L2  |  L3  |
```

_D. 3 níveis, iniciando com 2 argumentos:_

```
MyApp.exe --property1 value --property2 value2 action1 action2
          |                L1                 |   L2  |   L3 |
```

_E. 4 níveis, com sobras de argumentos na 'action2':_

```
MyApp.exe --property1 value action1 action2 --property2 value2
          |       L1       |   L2  |  L3   |        L4       |

```

No exemplo `E` o argumento `--property2` foi derivado dos argumentos extras da ação `action2`. Observe que essa ação não teve seu argumento `--value` especificado no input e o argumento `--property2` não faz parte de seu mapa, sendo assim esse argumento entra como extra e insumo para o próximo nível de argumentos. Esses extras podem estar em qualquer lugar depois do nome da `action`, após seu nome, no meio ou no final.

#### <a name="input-parser-complex-methods" />Escolhendo os melhores métodos

Com a divisão de níveis por "ações" concluída, é escolhido os melhores métodos dentro de cada nível.

1. Essa escolha trabalha da seguinte forma:
  * Seleciona os métodos que tem todos os parâmetros válidos
  * Entre os métodos válidos, seleciona o primeiro método que tenha, respectivamente:
    * A maior quantidade de parâmetros combinados com o input que foi enviado
    * A menor quantidade de parâmetros em seu mapa
    * A menor quantidade de argumentos extras
2. Com o melhor método em mãos para cada nível, a próxima etapa é remover todos os métodos do mesmo nível que não combinam com o melhor método. Isso não significa que tenham que ter a mesma assinatura, ou seja, não é preciso ter o mesmo nome, nem a mesma quantidade de parâmetros e nem os mesmos tipos, nada disso importa, o que vale é a relação do input com o método.

A combinação desejada é que todos os outros métodos tenham as mesmas quantidades de parâmetros analisados (`ArgumentParsed`) e que os inputs de seus parâmetros (`IEnumerable<ArgumentRaw> AllRaw`) combinem com os inputs do melhor método, inclusive, com a mesma sequência. Isso significa que a estratégia de parse do input foi a mesma para os métodos que combinaram, assim garante que não haverá o uso do mesmo input para finalidades diferentes.

**Exemplos:**

```csharp
namespace Example.Input.Parser
{
    using SysCommand.ConsoleApp;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static int Main(string[] args)
        {
            return App.RunApplication();
        }
    }

    public class Command1 : Command
    {
        public void Action3(string value = null)
        {
            App.Console.Write("Action3(string value = null)");
        }
    }

    public class Command2 : Command
    {
        public void Action3(int? value = null, string value2 = null)
        {
            App.Console.Write("Action3(int? value = null, string value2 = null)");
        }
    }

    public class Command3 : Command
    {
        public void Action3(List<string> value = null)
        {
            App.Console.Write("Action3(List<string> value)");
        }
    }
}
```

**Nota**: Os valores dos argumentos de todos os cenários estão no formato posicional

```
MyApp.exe action3 123 456 action3 123 456 678 action3 999
Output Level1:
    Action3(int? value = null, string value2 = null)
Output Level2:
    Action3(List<string> value)
Output Level3:
    Action3(string value = null)
    Action3(int? value = null, string value2 = null)
    Action3(List<string> value)
```

_Explicação:_

* Inputs (`ArgumentRaw`) "action3", "123", "456", "action3", "123", "456", "678", "action3", "999"
* Esse input tem 3 nível:
  * Nível 1: `action3 123 456`
    * `Action3(int? value = null, string value2 = null)`: Melhor método, todos devem ter esse modelo
      * `ArgumentParsed` 1: `AllRaw { "123" }`
      * `ArgumentParsed` 2: `AllRaw { "456" }`
    * `Action3(string value = null)`: Não foi escolhido
      * `ArgumentParsed` 1: `AllRaw { "123" }`
    * `Action3(List<string> value)`: Não foi escolhido
      * `ArgumentParsed` 1: `AllRaw { "123", "456" }`
  * Nível 2: `action3 123 456 678`
    * `Action3(List<string> value)`: Melhor método, todos devem ter esse modelo
      * `ArgumentParsed` 1: `AllRaw { "123", "456", "678" }`
    * `Action3(string value = null)`: : Não foi escolhido
      * `ArgumentParsed` 1: `AllRaw { "123" }`
    * `Action3(int? value = null, string value2 = null)`: Não foi escolhido
      * `ArgumentParsed` 1: `AllRaw { "123" }`
      * `ArgumentParsed` 2: `AllRaw { "456" }`
  * Nível 3: `action3 999`
    * `Action3(string value = null)`: Melhor método
      * `ArgumentParsed` 1: `AllRaw { "999" }`
    * `Action3(int? value = null, string value2 = null)`: A sequência esperada foi combinada
      * `ArgumentParsed` 1: `AllRaw { "999" }`
    * `Action3(List<string> value)`: A sequência esperada foi combinada
      * `ArgumentParsed` 1: `AllRaw { "999" }`

Todos os métodos "não escolhidos" foram descartados do processo. Essa regra é primordial para que mais de uma `action`, com a mesma assinatura, seja chamada no mesmo nível.

#### <a name="input-parser-complex-properties" />Escolhendo as melhores propriedades

Essa escolha trabalha da seguinte forma:

1. Localiza a "propriedade" de referência para cada input (`ArgumentRaw`) do mesmo nível. Para isso, seleciona a primeira propriedade válida que tem o primeiro input, depois a segunda propriedade válida que tem o segundo input e assim sucessivamente até que todos os inputs sejam completamente combinados. É possível que apenas uma propriedade de referência tenha mais de um input, é o caso de listas ou `Enums Flags`. Esses tipos de classes terão preferência para serem referências, pois combinam mais de um input. Essa regra não existe para os métodos porque os parâmetros dos melhores métodos já são referências para os demais.
2. Depois de localizar as referências, a segunda etapa é excluir as outras propriedades válidas que não combinam com as referências. Aqui é a mesma regra dos parâmetros dos métodos, ou seja, para combinar as propriedades devem ter os mesmos inputs (`ArgumentRaw`) e com as mesmas sequências. Assim garante que não haverá o uso do mesmo input para finalidades diferentes.
3. Se algum `ArgumentRaw` não for combinado, então todos os argumentos válidos serão eliminados.

**Exemplos:**

```csharp
namespace Example.Input.Parser
{
    using SysCommand.ConsoleApp;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static int Main(string[] args)
        {
            return App.RunApplication();
        }
    }

    public class Command4 : Command
    {
        public string Prop1 { set { App.Console.Write("Command4.Prop1"); } }
        public string Prop2 { set { App.Console.Write("Command4.Prop2"); } }
        public string Prop3 { set { App.Console.Write("Command4.Prop3"); } }
        public string Prop4 { set { App.Console.Write("Command4.Prop4"); } }

        public Command4()
        {
            this.EnablePositionalArgs = true;
        }
    }

    public class Command5 : Command
    {
        [Flags]
        public enum MyEnum
        {
            A = 1, B = 2, C = 4 , D = 8
        }

        public MyEnum Prop1
        {
            set
            {
                App.Console.Write("Command5.Prop1");
            }
        }

        public Command5()
        {
            this.EnablePositionalArgs = true;
        }
    }

    public class Command6 : Command
    {
        [Flags]
        public enum MyEnum
        {
            A = 1, B = 2, C = 4
        }

        public MyEnum Prop1
        {
            set
            {
                App.Console.Write("Command6.Prop1");
            }
        }

        public Command6()
        {
            this.EnablePositionalArgs = true;
        }
    }
}
```

**Nota**: Os valores dos argumentos de todos os cenários estão no formato posicional

_Cenário 1: Existe "propriedades" com prioridade, mas que são descartadas por estarem inválidas._

```
MyApp.exe W Z Y T
Output Level1:
    Command4.Prop1
    Command4.Prop2
    Command4.Prop3
    Command4.Prop4
```

_Explicação:_

* Inputs (`ArgumentRaw`): "W", "Z", "Y", "T"
* Esse input tem 1 nível:
  * `Command4.Prop1`: Propriedade de referência para o input "W"
    * `AllRaw { "W" }`
  * `Command4.Prop2`: Propriedade de referência para o input "Z"
    * `AllRaw { "Z" }`
  * `Command4.Prop3`: Propriedade de referência para o input "Y"
    * `AllRaw { "Y" }`
  * `Command4.Prop4`: Propriedade de referência para o input "T"
    * `AllRaw { "T" }`
  * `Command5.Prop1`: Propriedade que tem prioridade, mas está inválida, o input "W" não faz parte do `Enum`.
    * `AllRaw { "W" }`
  * `Command6.Prop1`: Mesma situação de `Command5.Prop1`
    * `AllRaw { "W" }`

_Cenário 2: Propriedade com mais combinações será a referência_

```
MyApp.exe A B C D
Output Level1:
    Command5.Prop1
```

_Explicação:_

* Inputs (`ArgumentRaw`): "A", "B", "C", "D"
* Esse input tem 1 nível:
  * `Command5.Prop1`: Propriedade de referência de todos os inputs
    * `AllRaw { "A", "B", "C", "D" }`
  * `Command6.Prop1`: Propriedade tem os 3 primeiros inputs, mas ela precisa ser 100% compátivel com a referência.
    * `AllRaw { "A", "B", "C" }`
  * `Command4.Prop1`: Propriedade está válida, mas o input `A` já tem a referência `Command5.Prop1` que tem prioridade por maioria.
    * `AllRaw { "A" }`
  * `Command4.Prop2`: Mesma situação de `Command4.Prop1`
    * `AllRaw { "B" }`
  * `Command4.Prop3`: Mesma situação de `Command4.Prop1`
    * `AllRaw { "C" }`
  * `Command4.Prop4`: Mesma situação de `Command4.Prop1`
    * `AllRaw { "D" }`

_Cenário 3: Propriedade com mais combinações será a referência_

```
MyApp.exe A B C W
Output Level1:
    Command4.Prop4
    Command5.Prop1
    Command6.Prop1
```

_Explicação:_

* Inputs (`ArgumentRaw`): "A", "B", "C", "W"
* Esse input tem 1 nível:
  * `Command5.Prop1`: Propriedade de referência dos 3 primeiros inputs
    * `AllRaw { "A", "B", "C" }`
  * `Command6.Prop1`: Compatível com a referência
    * `AllRaw { "A", "B", "C" }`
  * `Command4.Prop1`: Propriedade está válida, mas o input `A` já tem a referência `Command5.Prop1` que tem prioridade por maioria.
    * `AllRaw { "A" }`
  * `Command4.Prop2`: Mesma situação de `Command4.Prop1`
    * `AllRaw { "B" }`
  * `Command4.Prop3`: Mesma situação de `Command4.Prop1`
    * `AllRaw { "C" }`
  * `Command4.Prop4`: Propriedade de referência do input "W" que é a 4 posição, posição que essa propriedade aceita.
    * `AllRaw { "W" }`

Todos as propriedades "não escolhidas" foram descartados do processo. Essa regra é primordial para que mais de uma propriedade seja chamada no mesmo nível.

#### <a name="input-parser-complex-return" />Retorno

Por fim, uma instância do tipo `SysCommand.Parsing.ParseResult` é retornada contendo:

* `Levels`: Contém todos os níveis, onde cada nível tem uma lista de `CommandParse`. Os `CommandParse` contém a lista dos membros (métodos ou propriedades) que estão válidos ou inválidos.
* `Args`: A lista de inputs que deram inicio ao parse.
* `Maps`: A lista de mapas que deram inicio ao parse.
* `EnableMultiAction`: O mesmo parâmetro de entrada que deu inicio ao parse.

### <a name="input-parser-execution" />Execução

A execução só ocorre se todos os níveis tiverem ao menos um `Command` válido.

Um `Command` é considerado válido quando ele tem ao menos um membro válido (método ou propriedade) e não exista membros inválidos.

Se essa regra falhar, o retorno do método `Execute()` vai indicar na propriedade `ExecutionResult.State` qual o tipo do erro e todos os erros serão indicados na propriedade `ExecutionResult.Errors`:

* `ExecutionState.NotFound`: Quando não encontra nenhum membro válido ou inválido em nenhum nível. Ou quando só existem propriedades e todas estão com no estado `NotMapped`.
* `ExecutionState.HasError`: Indica que existe um ou mais membros inválidos em algum dos níveis.

Se tudo estiver certo, a ordem da execução será a seguinte:

* Define o `ExecutionScope` em todos os `Command` que estão válidos. Isso é importante para o comando ter acesso ao escopo da execução corrente.
* Executa todas as propriedades, indiferentemente de qual nível ela esteja.
* Para cada `Command` válido: Caso o comando tenha propriedades, então executa o método `Main()` se estiver implementado.
* Executa todos os métodos de cada nível na ordem do menor para o maior (ou da esquerda para a direita do input).

#### <a name="input-parser-execution-return" />Retorno

Por fim, uma instância do tipo `SysCommand.Execution` é retornada contendo:

* `Results`: Os resultados de cada membro (métodos ou propriedades)
* `Errors`: Lista com os erros, caso existam.
* `State`: Success, HasError, NotFound

# <a name="output" />Output

O mecanismo de output foi extendido para aumentar a produtividade.

Primeiro, foi criado um pequeno wrapper da classe `System.Console` chamado `SysCommand.ConsoleApp.ConsoleWrapper` que esta disponivel dentro do contexto da aplicação na propriedade `App.Console`. Esse wrapper pode ser herdado e ter seus recursos modificados ou potencializados, mas por padrão temos as seguintes funcionalidades:

* Métodos de write para cada tipo de verbo
* Possibilidade de customização da cor do texto de cada verbo
  * `App.Console.ColorInfo`
  * `App.Console.ColorCritical`
  * `App.Console.ColorError`
  * `App.Console.ColorSuccess`
  * `App.Console.ColorWarning`
  * `App.Console.ColorRead`
* Variavel de controle de tipo de saída `App.Console.ExitCode` onde você pode usa-la como retorno do seu método `int Main(string[] args)`:
  * "0" : Sucesso
  * "1" : Erro
* Quebra de linha inteligente durante o uso dós métodos de write e read. A variável `App.Console.BreakLineInNextWrite` controla as quebras e te ajuda a não deixar linhas vazias sem necessidade.

Outro recurso seria a utilização da sintaxe `returns` dentro das ações e que serão, caso existam, utilizados como output. Esse recurso se assemelha muito ao "AspNet MVC".

**Exemplo:**

```csharp
public class TestOutput : Command
{
    public decimal Test()
    {
       var result = this.App.Console.Read("My question: ");

        if (result != "S")
        { 
            // option1: use write method in wrapper class
            this.App.Console.Write(1.1m);

            // option2: use .NET class directly
            Console.WriteLine(2.2m);
        }

        // option3: or use return, its the same the option1
        return 3.3m;
    }
}
```

Input:

```
MyApp.exe test
```

Outputs:

```
My question: N
1.1
2.2
3.3
```

Por último, vale lembrar que nada disso impede você de usar os mecanismos comuns do .NET, como a classe "System.Console".

## <a name="output-razor" />Usando template Razor

Outra opção para exibir outputs é a utilização de templates `Razor`. Esse mecanismo foi projetado para coisas simples, é muito importante dizer que ele não dispõe de diversos recursos como: debug e analise de erros.

Para utilizar `Razor` deve-se seguir alguns simples passos:

* Por organização, criar uma pasta chamada "Views".
* Caso ainda queira mais organização, crie uma sub-pasta dentro da pasta "Views" com o nome do `Command`.
* Criar um arquivo de template com a extensão ".cshtml" dentro da pasta "Views". Esse arquivo deve ter o mesmo nome da action (método)
* Implementar o seu template podendo ou não usar a variável "@Model"
* Exibir as propriedades do arquivo ".cshtml" e configura-lo com a **Build Action = Embedded Resource** ou com a propriedade **Copy to Output = Copy aways**. Isso é necessário para o gerenciador de template encontre o arquivo na basta "bin/" em caso do uso do **Copy to Output** ou dentro do Assembly do domínio de aplicativo padrão com o uso do **Build Action**.

**Exemplo:**

###### Commands/ExampleRazorCommand.cs

```csharp
public class ExampleRazorCommand : Command
{
    public string MyAction()
    {
        return View<MyModel>();
    }

    public string MyAction2()
    {
        var model = new MyModel
        {
            Name = "MyName"
        };

        return View(model, "MyAction.cshtml");
    }

    public string MyAction3()
    {
        return ViewContent("My name: @Model.Name", new { Name = "John" });
    }

    public class MyModel
    {
        public string Name { get; set; }
    }
}
```

###### Views/ExampleRazor/MyAction.cshtml

```
@model ExampleRazorCommand.MyModel
@if (Model == null)
{
    <text>#### HelloWorld {NONE} ####</text>
}
else {
    <text>#### HelloWorld (@Model.Name) ####</text>
}
```

###### Tests

Input1:

```
MyApp.exe my-action
MyApp.exe my-action2
MyApp.exe my-action3
```

Outputs:

```
#### HelloWorld {NONE} ####
#### HelloWorld {MyName} ####
My name: John
```

###### Observação

* A pesquisa do template via `Arquivo físico` ou via `Embedded Resource` segue a mesma lógica. Ele busca pelo caminho mais especifico usando o nome do "command.action.extensão" e caso ele não encontre ele tentará encontrar pelo nome mais generico, sem o nome do command.
  * Busca primeiro por: `ExampleRazorCommand.MyAction.cshtml`
  * Caso não encontre na primeira tentativa, então busca por: `MyAction.cshtml`
* É possível passar o nome da view diretamente, sem a necessidade de usar a pesquisa automática. como no exemplo da action `MyAction2()`.

## <a name="output-t4" />Usando template T4

Outra opção para exibir outputs é a utilização de templates `T4`. Esse mecanismo, ao contrário dos templates `Razor` é mais completo, ele não perdeu nenhum dos beneficios que o Visual Studio nos fornece. Basta seguir apenas alguns passos para usa-lo:

* Por organização, criar uma pasta "Views"
* Criar um arquivo T4 no formato "Runtime Text Template"
* Se for utilizar o modelo é preciso configurar um parâmetro, que por obrigatoriedade, deve ter o nome `Model` e ter o seu respetivo tipo configurado na tag`type`. Caso não utilize nenhum modelo então ignore esse passo.
* Implementar o seu template

**Exemplo:**

###### Commands/ExampleT4Command.cs

```csharp
public class ExampleT4Command : Command
{
    public string T4MyAction()
    {
        return ViewT4<MyActionView>();
    }

    public string T4MyAction2()
    {
        var model = new MyModel
        {
            Name = "MyName"
        };

        return ViewT4<MyActionView, MyModel>(model);
    }

    public class MyModel
    {
        public string Name { get; set; }
    }
}
```

###### Views/ExampleT4/MyActionView.tt

```csharp
<#@ parameter type="Example.T4Command.MyModel" name="Model" #>
<# if(Model == null) { #>
#### HelloWorld {NONE} ####
<# } #>
<# else { #>
#### HelloWorld (<#= Model.Name #>) ####
<# } #>
```

###### Tests

Input1:

```
MyApp.exe t4-my-action
```

Input2:

```
MyApp.exe t4-my-action2
```

Outputs:

```
    #### HelloWorld {NONE} ####
    #### HelloWorld {MyName} ####
```

## <a name="output-tabulated" />Dados tabelado

A classe `SysCommand.ConsoleApp.View.TableView` traz o recurso de `output tabelado` que pode ser muito útil para apresentar informações de forma rápida e visualmente mais organizada. É claro que tudo depende da quantidade de informação que você quer exibir, quanto maior, pior a visualização.

**Exemplo:**

###### Commands/TableCommand.cs

```csharp
public class TableCommand : Command
{

    public string MyTable()
    {
        var list = new List<MyModel>
        {
            new MyModel() {Id = "1", Column2 = "Line 1 Line 1"},
            new MyModel() {Id = "2 " , Column2 = "Line 2 Line 2"},
            new MyModel() {Id = "3", Column2 = "Line 3 Line 3"}
        };

        return ViewTable(list);
    }

    public string MyTableCustomized()
    {
        var list = new List<MyModel>
        {
            new MyModel() {Id = "1", Column2 = "Line 1 Line 1"},
            new MyModel() {Id = "2 " , Column2 = "Line 2 Line 2"},
            new MyModel() {Id = "3", Column2 = "Line 3 Line 3"}
        };

        return TableView.ToTableView(list)
                        .Build()
                        .ToString();
    }

    public class MyModel
    {
        public string Id { get; set; }
        public string Column2 { get; set; }
    }
}
```

###### Tests

Input1:

```
MyApp.exe my-table
```

Outputs:

```
Id   | Column2
--------------------
1    | Line 1 Line 1
--------------------
2    | Line 2 Line 2
--------------------
3    | Line 3 Line 3
--------------------
```

# <a name="properties" />Trabalhando com propriedades

O trabalho com propriedades é muito simples e objetivo, basta criar suas propriedades como publicas e escolher um dos dois meios abaixo para saber se uma propriedade foi inputada pelo usuário, você que escolhe qual utilizar:

## <a name="properties-use-mode1" />Modo de uso 1

Primeiro, você pode utilizar o método `Main()` sem parâmetro e que, por convensão de nome, será o responsável por ser invocado caso alguma de suas propriedade tenha sido utilizadas no input do usuário. O nome "Main" foi escolhido para manter o padrão de nomenclatura que o .NET utiliza em aplicações de console.

Por segurança, utilize todos os tipos primitivos como `Nullable` para garantir que o usuário fez o input. Ou utilize o método `GetArgument(string name)` para verificar se uma propriedade foi analisada. Vale ressaltar que uma propriedade com **valor padrão** sempre terá um resultado após o parse e caso necessário, utilize mais uma verificação para saber se o resultado partiu de um input do usuário.

**Exemplo:**

```csharp
public string Main()
{
    if (this.MyProperty != null)
        App.Console.Write("Has MyProperty");

    if (this.MyPropertyInt != null)
        App.Console.Write("Safe mode: MyPropertyInt");

    if (this.MyPropertyUnsafeMode == 0)
        App.Console.Write("Unsafe mode: Preferably, use nullable in MyPropertyUnsafeMode");

    if (this.GetArgument("MyPropertyUnsafeMode") != null)
        App.Console.Write("Safe mode, but use string: MyPropertyUnsafeMode");

    if (this.GetArgument(nameof(MyPropertyUnsafeMode)) != null)
        App.Console.Write("Safe mode, but only in c# 6: MyPropertyUnsafeMode");

    if (this.GetArgument(nameof(MyPropertyDefaultValue)) != null)
        App.Console.Write("MyPropertyDefaultValue aways has value");

    // if necessary, add this verification to know if property had input.
    if (this.GetArgument(nameof(MyPropertyDefaultValue)).IsMapped)
        App.Console.Write("MyPropertyDefaultValue has input");

    return "Main() methods can also return values ;)";
}
```

```
C:\MyApp.exe --my-property value
Has MyProperty
Unsafe mode: Preferably, use nullable in MyPropertyUnsafeMode
MyPropertyDefaultValue aways has value
Main() methods can also return values ;)

C:\MyApp.exe --my-property-int 0
Safe mode: MyPropertyInt
Unsafe mode: Preferably, use nullable in MyPropertyUnsafeMode
MyPropertyDefaultValue aways has value
Main() methods can also return values ;)

C:\MyApp.exe --my-property-unsafe-mode 0
Unsafe mode: Preferably, use nullable in MyPropertyUnsafeMode
Safe mode, but use string: MyPropertyUnsafeMode
Safe mode, but only in c# 6: MyPropertyUnsafeMode
MyPropertyDefaultValue aways has value
Main() methods can also return values ;)

C:\MyApp.exe --my-property-default-value 0
Unsafe mode: Preferably, use nullable in MyPropertyUnsafeMode
MyPropertyDefaultValue aways has value
MyPropertyDefaultValue has input
Main() methods can also return values ;)
```

Tenha muito cuidado com propriedades que tenham **valores padrão**, o fato dela ter valor por padrão faz com que o método `Main()` sempre seja chamado mesmo quando não exista nenhum input.

```
C:\MyApp.exe
Unsafe mode: Preferably, use nullable in MyPropertyUnsafeMode
MyPropertyDefaultValue aways has value
Main() methods can also return values ;)
```

## <a name="properties-use-mode2" />Modo de uso 2

Por fim, você ainda pode utilizar o `set { .. }` da sua propriedade para tomar alguma ação. Esse recurso não é recomendado, pois o método `GetArgument(string name)` ainda não esta pronto para ser usado nesse momento, mas caso queira algo pontual e rápido, nada te impede de usar esse meio.

```csharp
public class TestProperty2Command : Command
{
    public bool MyCustomVerbose
    {
        set
        {
            if (value)
                Console.WriteLine("MyCustomVerbose=true");
            else
                App.Console.Write("MyCustomVerbose=false");
        }
    }
}
```

```
C:\MyApp.exe --my-custom-verbose
MyCustomVerbose=true

C:\MyApp.exe --my-custom-verbose false
MyCustomVerbose=false
```

## <a name="properties-customizing-name" />Customizando os nomes dos argumentos

A regra a seguir descreve como é o comportamento padrão de nomenclatura para que uma propriedade vire um `argument`:

Primeiro se converte o nome da propriedade em minusculo, depois adiciona um traço "-" antes de cada letra maiuscula que estiver no meio ou no final do nome. No caso de propriedades com apenas uma letra, o padrão será deixar a letra minuscula e o input será aceito apenas na forma curta.

Essa é a regra padrão de nomenclarutura e você pode escolher usa-la ou customizada-la, para isso utilize o atributo `ArgumentAttribute`. O uso do atributo `ArgumentAttribute` é exclusivo, ao utiliza-lo você esta eliminando o padrão de nomenclatura por completo, ou seja, se você customizar a **forma curta** você será obrigado a customizar a **forma longa** também, e vice-versa. Do contrário só o formato customizado será habilitado.

**Exemplo:**

```csharp
public class CustomPropertiesNamesCommand : Command
{
    // customized with long and short option
    [Argument(LongName = "prop", ShortName = 'A')]
    public int? MyCustomPropertyName { get; set; }

    // only with long option
    public string NormalLong { get; set; }

    // customized only with short option
    [Argument(ShortName = 'B')]
    public string ForcedShort { get; set; }

    // only with short option
    public int? C { get; set; }

    public CustomPropertiesNamesCommand()
    {
    }

    public void Main()
    {
        if (MyCustomPropertyName != null)
            App.Console.Write("MyCustomPropertyName=" + MyCustomPropertyName);

        if (NormalLong != null)
            App.Console.Write("NormalLong=" + NormalLong);

        if (ForcedShort != null)
            App.Console.Write("ForcedShort=" + ForcedShort);

        if (C != null)
            App.Console.Write("C=" + C);
    }
}
```

```
C:\MyApp.exe --prop 111 --normal-long strvalue -B strvalue2 -c 9999
MyCustomPropertyName=111
NormalLong=strvalue
ForcedShort=strvalue2
C=9999

C:\MyApp.exe -A 111 --normal-long strvalue -B strvalue2 -c 9999
MyCustomPropertyName=111
NormalLong=strvalue
ForcedShort=strvalue2
C=9999
```

## <a name="properties-customizing-help" />Customizando as informações de help

Para configurar o texto de help utilize o atributo `ArgumentAttribute(Help="my help")`. Caso você não informe esse atributo, seu argumento ainda será exibido no help, mas sem informações de ajuda.

Contudo, ainda será exibido um texto de complemento para cada argumento, esse texto informa se o argumento é obrigatório ou opcional (com ou sem **valor padrão**). Esse texto é exibido por padrão, mas você pode desativa-lo com o atributo `ArgumentAttribute(ShowHelpComplement=false)`.

```csharp
public class CustomPropertiesHelpCommand : Command
{
    // customized with long and short option
    [Argument(Help = "This is my property")]
    public int? MyPropertyHelp { get; set; }

    [Argument(Help = "This is my property 2", ShowHelpComplement = false)]
    public int? MyPropertyHelp2 { get; set; }

    public CustomPropertiesHelpCommand()
    {
        this.HelpText = "Custom help for CustomPropertiesHelpCommand";
    }
}
```

```
C:\MyApp.exe help
Custom help for CustomPropertiesHelpCommand

   --my-property-help              This is my property. Is optional.
   --my-property-help2             This is my property 2
```

Para mais informações sobre o help veja no tópico [Help](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#help).

## <a name="properties-required" />Propriedades obrigatórias

Para argumentos que são obrigatórios, é necessário que você use o `ArgumentAtrribute` ligando a flag `IsRequired`.

**Exemplo:**

```csharp
public class TestProperty5Command : Command
{
    [Argument(IsRequired = true)]
    public string MyPropertyRequired { get; set; }

    public void Main()
    {
        if (MyPropertyRequired != null)
            App.Console.Write("MyPropertyRequired=" + MyPropertyRequired);
    }
}
```

```
C:\MyApp.exe
There are errors in command: TestProperty5Command
The argument '--my-property-required' is required

C:\MyApp.exe --my-property-required 123
MyPropertyRequired=123
```

## <a name="properties-positional" />Habilitando o input posicional

Para habilitar o input posicional basta ligar a flag `EnablePositionalArgs` em seu `Command`, contudo é importante validar o quanto isso necessário, pois muitos inputs posicionais podem complicar muito o uso da sua aplicação. Apesar do `SysCommand` estar bem preparado para esse tipo de input, não queremos que você polua o seu input.

```csharp
public class TestProperty3Command : Command
{
    public int? MyPosicionalProperty1 { get; set; }
    public int? MyPosicionalProperty2 { get; set; }

    public TestProperty3Command()
    {
        this.EnablePositionalArgs = true;
    }

    public void Main()
    {
        if (MyPosicionalProperty1 != null)
            App.Console.Write("MyPosicionalProperty1=" + MyPosicionalProperty1);
        if (MyPosicionalProperty2 != null)
            App.Console.Write("MyPosicionalProperty2=" + MyPosicionalProperty2);
    }
}
```

```
C:\MyApp.exe --my-posicional-property1 1 --my-posicional-property2 2
MyPosicionalProperty1=1
MyPosicionalProperty2=2

C:\MyApp.exe 1 2
MyPosicionalProperty1=1
MyPosicionalProperty2=2

C:\MyApp.exe 1 --my-posicional-property2 2
MyPosicionalProperty1=1
MyPosicionalProperty2=2
```

Você pode também controlar a posição de cada propriedade dentro do input usando a configuração `Position`.

**Exemplo:**

```csharp
public class TestProperty3Command : Command
{
    [Argument(Position = 2)]
    public int? MyPosicionalProperty1 { get; set; }

    [Argument(Position = 1)]
    public int? MyPosicionalProperty2 { get; set; }

    public TestProperty3Command()
    {
        this.EnablePositionalArgs = true;
    }

    public void Main()
    {
        if (MyPosicionalProperty1 != null)
            App.Console.Write("MyPosicionalProperty1=" + MyPosicionalProperty1);
        if (MyPosicionalProperty2 != null)
            App.Console.Write("MyPosicionalProperty2=" + MyPosicionalProperty2);
    }
}
```

```
C:\MyApp.exe --my-posicional-property1 1 --my-posicional-property2 2
MyPosicionalProperty1=1
MyPosicionalProperty2=2

C:\MyApp.exe 1 2
MyPosicionalProperty1=2
MyPosicionalProperty2=1
```

## <a name="properties-ignore-public" />Escolha manual de propriedades via atributo

Para mudar o comportamente padrão de propriedades publicas, você precisa apenas desligar a flag `OnlyPropertiesWithAttribute` do `Command`. Com ela desligada o analisador deixará de olhar para as propriedades publicas e usará apenas as propriedades publicas e que tiverem o atributo `ArgumentAtrribute`.

**Exemplo:**

```csharp
public class TestProperty4Command : Command
{
    public int? MyPropertyWithoutAttribute { get; set; }

    [Argument]
    public int? MyPropertyWithAttribute { get; set; }

    public TestProperty4Command()
    {
        this.OnlyPropertiesWithAttribute = true;
    }

    public void Main()
    {
        if (MyPropertyWithAttribute != null)
            App.Console.Write("MyPropertyWithAttribute=" + MyPropertyWithAttribute);
    }
}
```

```
C:\MyApp.exe --my-property-with-attribute 1
MyPropertyWithAttribute=1

C:\MyApp.exe --my-property-without-attribute 1
There are errors in command: DoSomethingCommand
The argument '--my-property-without-attribute' does not exist
```

# <a name="methods" />Trabalhando com métodos

O trabalho com métodos também é muito bem simples, todos os métodos definidos como `public`, por padrão, serão habilitados para virarem `actions` e estarem disponíveis para uso. O fato interessante é que você pode utilizar os recursos nativos do .NET deixando seu código mais limpo, como:

* Métodos sem parâmetros
* Métodos com parâmetros opcionais com **valor padrão**
* Métodos com sobrecargas
* Métodos com a sintaxe `return`, por padrão, será utilizado como output no console usando

## <a name="methods-without-params" />Métodos sem parâmetros

**Exemplo:**

```csharp
public class Method1Command : Command
{
    public string MyAction()
    {
        return "MyAction";
    }
}
```

```
C:\MyApp.exe my-action
MyAction
```

## <a name="methods-optional-params" />parâmetros optionais

Os parâmetros opcionais são uteis para evitar a criação de sobrecargas e no caso de uma aplicação console ajuda a criar `actions` com diversas opções, mas não obrigando o usuário a preencher todas.

Por segurança, ao usar parâmetros opcionais, obte por utilizar todos os tipos primitivos como `Nullable` para _garantir que o usuário fez o input_. Ou utilize o método `GetAction()` para verificar se o parâmetro foi mapeado, ou seja, se teve algum tipo de input.

**Exemplo:**

```csharp
public class Method1Command : Command
{
    public string MyAction2(int? arg0 = null, int arg1 = 0)
    {
        // unsafe, because the user can enter with value "--arg1 0" and you never know.
        if (arg1 != 0)
            App.Console.Write("arg1 wrong way to do it!");

        // safe, but bureaucratic
        if (this.GetAction().Arguments.Any(f => f.Name == "arg1" && f.IsMapped))
            App.Console.Write("arg1 has input");

        // recommended. the best way! 
        if (arg0 != null)
            App.Console.Write("arg0 has input");

        return "MyAction2";
    }
}
```

```
C:\MyApp.exe my-action2
MyAction2

C:\MyApp.exe my-action2 --arg0 99
arg0 has input
MyAction2

C:\MyApp.exe my-action2 --arg1 0
arg1 has input
MyAction2
```

Observação: Não utilize o método `GetAction()` em métodos que não são `actions`, você terá uma exception.

## <a name="methods-overloads" />Sobrecargas

O recurso de sobrecarga de métodos é suportado da mesma forma que você faria para qualquer outra finalidade. Muitas vezes esse recurso pode ser mais interessante que usar parâmetros opcionais, o código fica mais limpo. Outras vezes isso não será possível, pois com parâmetros opcionais o usuário tem a opção de escolher qualquer parâmetro independentemente de sua posição no método, coisa que a sobrecarga não pode.

**Exemplo:**

```csharp
public class Method1Command : Command
{
    public string MyAction3()
    {
        return "MyAction3";
    }

    public string MyAction3(int arg0)
    {
        return "arg0 has input";
    }

    public void MyAction3(int arg0, int arg1)
    {
        App.Console.Write("arg0 has input");
        App.Console.Write("arg1 has input");
    }
}
```

```
C:\MyApp.exe my-action3
MyAction3

C:\MyApp.exe my-action3 --arg0 9
arg0 has input

C:\MyApp.exe my-action3 --arg0 9 --arg1 99
arg0 has input
arg1 has input

C:\MyApp.exe my-action3 --arg1 99
There are errors in command: Method1Command
The argument '--arg1' does not exist
```

O último comando mostrou a limitação da sobrecarga com relação aos parâmetros opcionais. O analisador entendeu que os dois métodos com parâmetros `MyAction3` estão inválidos, veja:

* `MyAction3(int arg0)`: Não tem o input `--arg1` que foi solicitado, portanto esta inválido.
* `MyAction3(int arg0, int arg1)`: Tem o input `--arg1`, mas não tem o input `--arg0`, portanto esta inválido.

Nesse caso o analisador escolhera o unico método valido, ou seja, o método `MyAction3` _sem parâmetros_ e usará o argumento extra `--arg1` para tentar encontra-lo como propriedade em algum `Command`, porém essa propriedade não existe em nenhum lugar, gerando o erro.

## <a name="methods-positional-inputs" />Usando inputs posicionais

Outro modo de chamar sua action no console é usando **input posicional**. Por padrão, todas as `action` aceitam argumentos posicionais, mais isso pode ser desabilitado usando o atributo `ActionAttribute(EnablePositionalArgs = false)`.

**Exemplo:**

```csharp
public string MyActionWithPosicional(int arg0, int arg1)
{
    return "MyActionWithPosicional";
}

[Action(EnablePositionalArgs = false)]
public string MyActionWithoutPosicional(int arg0, int arg1)
{
    return "MyActionWithoutPosicional";
}
```

```
C:\MyApp.exe my-action-with-posicional --arg0 1 --arg1 2
MyActionWithPosicional

C:\MyApp.exe my-action-with-posicional 1 2
MyActionWithPosicional

C:\MyApp.exe my-action-without-posicional --arg0 1 --arg1 2
MyActionWithoutPosicional

C:\MyApp.exe my-action-without-posicional 1 2
There are errors in command: Method1Command
Error in method: my-action-without-posicional(Int32, Int32)
The argument '--arg0' is required
The argument '--arg1' is required
```

## <a name="methods-ignore-public" />Ignorar métodos publicos por uma escolha manual usando atributo

Para mudar o comportamente padrão de métodos publicos, você precisa apenas desligar a flag `OnlyMethodsWithAttribute` do `Command`. Com ela desligada o analisador deixará de olhar para as métodos publicos e usará apenas os métodos publicos e que tiverem o atributo `ActionAtrribute`.

**Exemplo:**

```csharp
public class Method2Command : Command
{
    public Method2Command()
    {
        this.OnlyMethodsWithAttribute = true;
    }

    [Action]
    public string MyActionWithAttribute()
    {
        return "MyActionWithAttribute";
    }

    public string MyActionWithoutAttribute()
    {
        return "MyActionWithAttribute";
    }
}
```

```
C:\MyApp.exe my-action-with-attribute
MyActionWithAttribute

C:\MyApp.exe my-action-without-attribute
Could not find any action.
```

Outra forma de ignorar métodos publicos e sem alterar o comportamento padrão da propriedade `OnlyMethodsWithAttribute` do `Command` é utilizando o atributo `ActionAttribute(Ignore = true)`.

**Exemplo:**

```csharp
public class Method3Command : Command
{
    public string MyActionNotIgnored()
    {
        return "MyActionNotIgnored";
    }

    [Action(Ignore = true)]
    public string MyActionIgnored()
    {
        return "MyActionIgnored";
    }
}
```

```
C:\MyApp.exe my-action-not-ignored
MyActionNotIgnored

C:\MyApp.exe my-action-ignored
Could not find any action.
```

## <a name="methods-customizing-names" />Customizando nomes de ações e argumentos

A regra a seguir descreve como é o processo padrão de transformação de um nome de um método em ação e também dos nomes de seus parâmetros em argumentos.

Primeiro se converte o nome do membro (métodos ou parâmetros) em minusculo, depois adiciona um traço "-" antes de cada letra maiuscula que estiver no meio ou no final do nome. No caso de paramentros com apenas uma letra, o padrão será deixar a letra minuscula e o input será aceito apenas na forma curta.

Essa é a regra padrão de nomenclarutura e você pode escolher usa-la ou customizada-la de modo total ou parcial. Para isso utilize os atributos `ActionAttribute` para métodos e `ArgumentAttribute` os parâmetros. O uso do atributo `ArgumentAttribute` é exclusivo, ao utiliza-lo você esta eliminando o padrão de nomenclatura por completo, ou seja, se você customizar a **forma curta** você será obrigado a customizar a **forma longa** também, e vice-versa. Do contrário só o formato customizado será habilitado.

**Exemplo:**

```csharp
public class Method3Command : Command
{
    [Action(Name = "ActionNewName")]
    public string MyAction(
        [Argument(LongName = "longName1", ShortName = 'a')]
        string arg0, // customized with long and short option

        string arg1, // only with long option

        [Argument(ShortName = 'z')]
        string arg2, // only with short option

        string z     // only with short option
    )
    {
        return "ActionNewName";
    }
}
```

```
C:\MyApp.exe ActionNewName --longName1 1 --arg1 2 -z 3 -w 4
ActionNewName

C:\MyApp.exe ActionNewName -a 1 --arg1 2 -z 3 -w 4
ActionNewName
```

Outra opção de customização é a inclusão de prefixo antes do nome de cada `action`. Isso pode ser feito de duas formas, a primeira você só precisa ligar a flag de comando `Command.UsePrefixInAllMethods`. Com essa flag ligada, todas as `actions` passarão a ter o seguinte padrão de nome "CommandName-ActionName", ou seja, elas vão conter o nome do `Command` adicionado de um "-" seguido do nome da action. Caso o nome do comando tenha o sufixo "Command" então esse sufixo será removido.

Você ainda pode querer que essa flag não afete todas as suas `actions`, para isso utilize a flag `ActionAttribute(UsePrefix=false)` para que uma determinada action não tenha seu nome alterado com o prefixo.

```csharp
public class PrefixedCommand : Command
{
    public PrefixedCommand()
    {
        this.UsePrefixInAllMethods = true;
    }

    public string MyAction()
    {
        return "prefixed-my-action";
    }

    [Action(Name = "my-action2-custom")]
    public string MyAction2()
    {
        return "prefixed-my-action2-custom";
    }

    [Action(UsePrefix = false)]
    public string MyActionWithoutPrefix()
    {
        return "my-action-without-prefix";
    }
}
```

```
C:\MyApp.exe prefixed-my-action
prefixed-my-action

C:\MyApp.exe prefixed-my-action2-custom
prefixed-my-action2-custom

C:\MyApp.exe my-action-without-prefix
my-action-without-prefix
```

A segunda forma é você especificar qual será o prefixo de cada `action` usando a propriedade de comando `Command.PrefixMethods`. Assim o prefixo não será processado usando o nome do comando e sim especificado por você. Vale ressaltar que a flag `Command.UsePrefixInAllMethods` ainda precisa estar ligada.

**Exemplo:**

```csharp
public class Prefixed2Command : Command
{
    public Prefixed2Command()
    {
        this.PrefixMethods = "custom-prefix";
        this.UsePrefixInAllMethods = true;
    }

    public string MyAction()
    {
        return "custom-prefix-my-action";
    }
}
```

```
C:\MyApp.exe custom-prefix-my-action
custom-prefix-my-action
```

## <a name="methods-customizing-help" />Customizando as informações de help nas ações e em seus parâmetros

Para configurar o texto de help utilize o atributo `ActionAttribute(Help="my help")`. Caso você não informe esse atributo, sua ação ainda será exibido no help, mas sem informações de ajuda.

Para cada parâmetro utilizasse o mesmo atributo das propriedades `ArgumentAttribute(Help="")`. O comportamento é exatamente o mesmo. Veja [Customizando as informações de help](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-customizing-help).

**Exemplo:**

```csharp
public class MethodHelpCommand : Command
{
    public MethodHelpCommand() 
    {
        this.HelpText = "Help for this command";
    }

    [Action(Help = "Action help")]
    public string MyActionHelp(
        [Argument(Help = "Argument help")]
        string arg0, // With complement

        [Argument(Help = "Argument help", ShowHelpComplement = false)]
        string arg1  // Without complement
    )
    {
        return "Action help";
    }
}
```

```
C:\MyApp.exe help
Help for this command

   my-action-help                  Action help
      --arg0                       Argument help. Is required.
      --arg1                       Argument help
```

Para mais informações sobre o help veja no tópico [Help](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#help).

## <a name="methods-changing-position" />Trocando a posição de parâmetros posicionais

A propriedade `ArgumentAttribute(Position=X)` também funciona para parâmetros da mesma forma que funciona para propriedades. Não é um recurso que faça muito sentido, mas é importante documenta-lo.

**Exemplo:**

```csharp
public class Method5Command : Command
{
    public string MyActionWithArgsInverted(
        [Argument(Position = 2)]
        string arg0,
        [Argument(Position = 1)]
        string arg1
    )
    {
        return "MyActionWithArgsInverted";
    }
}
```

```
C:\MyApp.exe my-action-with-args-inverted 1 2
arg0 = '2'; arg1 = '1'
```

## <a name="methods-not-used-attrs" />Propriedades do atributos ArgumentAttribute que não são utilizados

As seguintes propriedades não fazem sentido no cenário de parâmetros de métodos e só existem por que o atributo `ArgumentAtrribute` é compartilhado no uso de propriedades.

* IsRequired: Em C#, todo parâmetro que não tem **valor padrão** é obrigatório, essa configuração é ignorada se for utilizada.
* DefaultValue: Como o proprio C# já nos dá a opção de **valor padrão** em parâmetros, essa configuração é redundante, sendo assim ela é ignorada por que o padrão do .NET já é suficiente e mais limpo.

## <a name="methods-default" />Métodos padrão

O uso de métodos padrão (ou métodos implicitos) fazem com que o recurso seja muito similar ao uso de propriedades, ou seja, você não é obrigado a especificar o nome da `action` e os seus parâmetros podem ser inseridos diretamente no input como se fossem argumentos provenientes de propriedades.

Por convensão, se você chamar sua `action` de "Main" e ela tiver parâmetros, ela será considerada como padrão. Para mudar esse comportamento você deve desligar a flag `Action(IsDefault = false)`, assim o comportamento padrão será alterado e sua action "Main" (com parâmetros) não será mais acessada de forma implicita e obrigará a especificação de seu nome no input. O contrário também é verdadeiro, se sua action tem outro nome e você gostaria de torna-la um método padrão então basta ligar a flag `Action(IsDefault = true)`.

**Exemplo:**

```csharp
public class MethodDefaultCommand : Command
{
    public string Main(string arg0)
    {
        return "Main(string arg0)";
    }

    public string Main(string arg0, string arg1)
    {
        return "Main(string arg0, string arg1)";
    }

    [Action(IsDefault = false)]
    public string Main(int argument)
    {
        return "Main(int argument)";
    }

    [Action(IsDefault = true)]
    public string AnyName(string argument)
    {
        return "AnyName(string argument)";
    }

    [Action(IsDefault = true)]
    public string ActionWhenNotExistsInput()
    {
        return "ActionWhenNotExistsInput()";
    }
}
```

```
C:\MyApp.exe --arg0 value
Main(string arg0)

C:\MyApp.exe --arg0 value --arg1 value1
Main(string arg0, string arg1)

C:\MyApp.exe main --argument 9999
Main(int argument)

C:\MyApp.exe --argument value
AnyName(string argument)

C:\MyApp.exe
ActionWhenNotExistsInput()
```

**Observações:**

* É importante ressaltar que o todos os métodos padrão ainda podem ser chamados de maneira explicita, ou seja, com o seu nome sendo especifico.
* O uso de método padrão sem argumentos só funciona se não existir nenhum argumento required, do contrário esse método nunca será chamado, pois haverá um erro obrigando o uso do argumento.'

# <a name="help" />Help

O formato do help leva em consideração todos os elementos que compõem o sistema, ou seja, `Commands`, `Arguments` e `Actions`. Ele é gerado de forma automática utilizando os textos de help de cada um desses elementos, por isso é importante manter essas informações preenchidas e atualizadas, isso ajudará você e quem for utilizar sua aplicação.

No formato padrão, existem duas formas de exibir o help: o **help completo** e o **help por action**:

**Exibe o help para uma ação especifica:**

```
MyApp.exe help my-action-name
```

**Exibe o help completo:**

```
MyApp.exe help
```

Para o help completo, o formato de saída que será exibido será o seguinte:

```
usage:    [--argument=<phrase>] [--argument-number=<number>]
          [-v, --verbose=<None|All|Info|Success|Critical|Warning|Error|Quiet>]
          --required-argument=<phase>
          <actions[args]> (A)

Command help (B)
    LongName (C1), ShortName (C2)      Help text for arguments of command (properties) (C3). Complement (C4)
    Action (D)
      LongName (E1), ShortName (E2)    Help text for arguments of actions (parameters) (E3). Complement (E4)

Use 'help --action=<name>' to view the details of
any action. Every action with the symbol "*" can
have his name omitted. (F)
```

A fonte de cada texto esta em cada elemento `Commands`, `Arguments` e `Actions` e os textos complementares estão na classe estática `SysCommand.ConsoleApp.Strings`. Segue o mapeamento de cada texto conforme o formato exibido acima:

* **A.** O texto `usage` é gerado internamente pela classe `DefaultDescriptor` e sempre será exibido.
* **B.** O texto do `Command` sempre será exibido e a sua fonte vem da propriedade `Command.HelpText` que deve ser definida no construtor do seu comando. Caso você não atribua nenhum valor para essa propriedade, o padrão será exibir o nome do comando.
* **C.** Será exibido todas os argumentos (propriedades) do comando, um em baixo do outro.
  * **C1.** A fonte desse texto vem do atributo `ArgumentAtrribute(LongName="")`.
  * **C2.** A fonte desse texto vem do atributo `ArgumentAtrribute(ShortName="")`.
  * **C3.** A fonte desse texto vem do atributo `ArgumentAtrribute(Help="")`.
  * **C4.** Esse texto só vai aparecer se a flag `ArgumentAtrribute(ShowHelpComplement=true)` estiver ligada. O texto que será exibido vai depender da configuração do membro:
    * `Strings.HelpArgDescRequired`: Quando o membro é obrigatório
    * `Strings.HelpArgDescOptionalWithDefaultValue`: Quando o membro é opcional e tem **valor padrão**.
    * `Strings.HelpArgDescOptionalWithoutDefaultValue`: Quando o membro é opcional e não tem **valor padrão**.
* **D.** A fonte desse texto vem do atributo `ActionAtrribute(Name="")`.
* **E.** São as mesmas fontes dos argumentos de comando (propriedades), pois ambos os membros utilizam o mesmo atributo.
* **F.** Texto complementar para explicar como o help funciona. A fonte desse texto vem da classe `Strings.HelpFooterDesc`.

**Exemplo:**

```csharp
public class HelpCommand : Command
{
    // With complement
    [Argument(Help = "My property1 help")]
    public string MyProperty1 { get; set; }

    // Without complement
    [Argument(Help = "My property2 help", ShowHelpComplement = false, IsRequired = true)]
    public int MyProperty2 { get; set; }

    public HelpCommand()
    {
        this.HelpText = "Help for this command";
    }

    [Action(Help = "Action help")]
    public void MyActionHelp
    (
        [Argument(Help = "Argument help")]
        string arg0, // With complement

        [Argument(Help = "Argument help", ShowHelpComplement = false)]
        string arg1  // Without complement
    )
    {

    }
}
```

```
usage:    --my-property2=<number> [--my-property1=<phrase>] [-v,
          --verbose=<None|All|Info|Success|Critical|Warning|Error|Quiet>]
          <actions[args]>

Help for this command

   --my-property1    My property1 help. Is optional.
   --my-property2    My property2 help

   my-action-help    Action help
      --arg0         Argument help. Is required.
      --arg1         Argument help
```

## <a name="help-default" />Customizando

A funcionalidade de `help` nada mais é que um comando interno `SysCommand.ConsoleApp.Commands.HelpCommand.cs` que define as duas `actions` de help que foram apresentadas no tópico anterior. Por definição, todo comando de help precisa herdar da interface `SysCommand.ConsoleApp.Commands.IHelpCommand`, assim o sistema entende que esse comando fará esse papel. Obrigatóriamente, sempre haverá um comando de help, caso o usuário não customize, o comando padrão `HelpCommand` será utilizado.

Abaixo, segue um exemplo de um help completamente customizado:

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
        public string MyCustomHelp(string action = null)
        {
            foreach(var map in this.App.Maps)
            {

            }
            return "Custom help";
        }
    }
}
```

```
MyApp.exe my-custom-help
Custom help

MyApp.exe help
Could not find any action.
```

Uma outra opção é criar um `Descriptor` que herda da interface `SysCommand.ConsoleApp.Descriptor.IDescriptor` e defini-lo na sua propriedade `App.Descriptor`. Isso é possível, pois o help padrão utiliza os métodos de help contidos dentro dessa instância. Essa opção não é recomendada se você deseja apenas customizar o `help`.

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

**Observações:**

* O comando de help é o único que não pode ser ignorado pela inicialização, caso ele não exista na lista de tipos, o comando `SysCommand.ConsoleApp.Commands.HelpCommand.cs` será adicionado internamente.
* Para mais informações sobre customizações do help em propriedades veja o tópido de [Customizando as informações de help](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#properties-customizing-help).
* Para mais informações sobre customizações do help em ações veja o tópido de [Customizando as informações de help nas ações e em seus parâmetros](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#methods-customizing-help).

# <a name="verbose" />Verbose

O controle de exibição por verbo esta contido em um comando interno chamado `SysCommand.ConsoleApp.Commands.VerboseCommand`. A sua função é alterar o valor da propriedade `App.Console.Verbose` caso o usuário envie um input de verbose. Atualmente, os verbos suportados são:

* `All`: Exibe todos os verbos
* `Info`: É o verbo padrão, sempre será exibido, ao menos que o usuário envie o verbo `Quiet`.
* `Success`: Verbo para mensagens de sucesso. Só será exibido se o usuário solicitar.
* `Critical`: Verbo para mensagens criticas. Só será exibido se o usuário solicitar.
* `Warning`: Verbo para mensagens de warning. Só será exibido se o usuário solicitar.
* `Error`: Verbo para mensagens de erro. O sistema força o envio desse verbo em caso de erros de parse. Só será exibido se o usuário solicitar.
* `Quiet`: Verbo para não exibir nenhuma mensagem, porém se a mensagem estiver sendo forçada, esse verbo é ignorado para essa mensagem.

Para que a funcionalidade funcione corretamente é obrigatorio o uso das funções de output contidas dentro da classe `SysCommand.ConsoleApp.ConsoleWrapper` e que tem uma instância disponível na propriedade `App.Console`.

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

_Forma curta:_

```
MyApp.exe test -v Critical
```

_Forma longa:_

```
MyApp.exe test --verbose Critical
```

Outputs:

```
output of info
output of error forced
output of critical
```

É importante dizer que você pode desligar esse recurso e implementar seu próprio mecanismo de verbose. Para isso você precisa desativar o comando `VerboseCommand` e criar seu próprio conjunto de funções para cada verbo.

* Para desativar o comando `VerboseCommand` utilize a forma exclusiva de especificação de comandos. Veja o tópico [Especificando os tipos de comandos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#specifying-commands).

# <a name="error" />Tratamento de erros

O tratamento de erro é gerado de forma automática pelo sistema e são categorizados da seguinte forma:

* Erros no processo de parse: São erros que ocorrem no processo de parse e são sub categorizados da seguinte forma:
  * `ArgumentParsedState.ArgumentAlreadyBeenSet`: Indica que um argumento esta duplicado no mesmo input.
  * `ArgumentParsedState.ArgumentNotExistsByName`: Indica que um argumento nomeado não existe.
  * `ArgumentParsedState.ArgumentNotExistsByValue`: Indica que um argumento posicional não existe
  * `ArgumentParsedState.ArgumentIsRequired`: Indica que um argumento é obrigatório
  * `ArgumentParsedState.ArgumentHasInvalidInput`: Indica que um argumento esta inválido
  * `ArgumentParsedState.ArgumentHasUnsupportedType`: Indica que o esta tudo certo com o input, porém o tipo do argumento não tem suporte. Veja a lista de tipos suportados em [Tipos suportados](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#support-types).
* Not Found: Nenhuma rota encontrada para o input solicitado.
* Exception génerica: Não existe nenhum tipo de tratamento padrão, mas é possível interceptar qualquer exception dentro do evento `App.OnException`.

O responsável por formatar e imprimir os erros é o handler padrão `SysCommand.ConsoleApp.Handlers.DefaultApplicationHandler`. Ele intercepta o resultado final da execução e caso tenha erros chama um dos método `ShowErrors(ApplicationResult appResult)`, `ShowNotFound(ApplicationResult appResult)` e que estão na classe `SysCommand.ConsoleApp.Descriptor.DefaultDescriptor`.

Caso queira customizar as mensagens de erro, você pode trocar o handler `DefaultApplicationHandler` por completo (não recomendado) ou criar uma classe que herde de `DefaultDescriptor` subrescrevendo apenas os métodos de erros.

**Exemplo:**

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
                app.OnException += (appResult, exception) =>
                {
                    app.Console.ExitCode = ExitCodeConstants.Error;
                    app.Console.Write(exception.Message);
                };
                return app;
            }
        );
    }

    public class CustomDescriptor : DefaultDescriptor
    {
        public override void ShowErrors(ApplicationResult appResult)
        {
            foreach (ExecutionError error in appResult.ExecutionResult.Errors)
            {
                foreach (ArgumentParsed prop in error.PropertiesInvalid)
                {
                    if (prop.ParsingStates.HasFlag(ArgumentParsedState.ArgumentAlreadyBeenSet))
                        appResult.App.Console.Error(string.Format("The argument '{0}' has already been set", prop.GetArgumentNameInputted()));
                    if (prop.ParsingStates.HasFlag(ArgumentParsedState.ArgumentNotExistsByName))
                        appResult.App.Console.Error(string.Format("The argument '{0}' does not exist", prop.GetArgumentNameInputted()));
                    if (prop.ParsingStates.HasFlag(ArgumentParsedState.ArgumentNotExistsByValue))
                        appResult.App.Console.Error(string.Format("Could not find an argument to the specified value: {0}", prop.Raw));
                    if (prop.ParsingStates.HasFlag(ArgumentParsedState.ArgumentIsRequired))
                        appResult.App.Console.Error(string.Format("The argument '{0}' is required", prop.GetArgumentNameInputted()));
                    if (prop.ParsingStates.HasFlag(ArgumentParsedState.ArgumentHasInvalidInput))
                        appResult.App.Console.Error(string.Format("The argument '{0}' is invalid", prop.GetArgumentNameInputted()));
                    if (prop.ParsingStates.HasFlag(ArgumentParsedState.ArgumentHasUnsupportedType))
                        appResult.App.Console.Error(string.Format("The argument '{0}' is unsupported", prop.GetArgumentNameInputted()));
                }

                foreach (ActionParsed method in error.MethodsInvalid)
                {
                    foreach (ArgumentParsed parameter in method.Arguments)
                    {
                        ...
                    }
                }
            }
        }

        public override void ShowNotFound(ApplicationResult appResult)
        {
            appResult.App.Console.Error("Could not find any action.", forceWrite: true);
        }
    }
}
```

# <a name="variable" />Variáveis de contexto

A propriedade `App.Items` é a responsável por manter um escopo isolado de variáveis por cada instância da classe `App`. Na prática ela é uma coleção de objetos (chave/valor) que pode auxiliar na passagem de valores entre os comandos.

Essa coleção herda de `Dictionary<object, object>` e foi estendida com a adição de alguns métodos de ajuda:

* `T Get<T>()`: Retorna o primeiro elemento do tipo `T`, se não encontrar então retorna `null` para tipos complexos e `Exception` para `struct`.
* `T Get<T>(object key)`: Retorna o primeiro elemento da chave informada, o comportamento de retorno é o mesmo do método acima.
* `T GetOrCreate<T>()`: Se existir, retorna o primeiro elemento do tipo `T` ou cria uma nova instância via reflexão onde o tipo `T` será a chave.
* `T GetOrCreate<T>(object key)`: Se existir, retorna o primeiro elemento da chave informada ou cria uma nova instância via reflexão.

_Nota: Para a criação de novas instâncias via reflexão é necessário que a classe tenha um construtor sem parâmetros._

**Exemplo:**

```csharp
namespace Example.ContextVariable
{
    using SysCommand.ConsoleApp;

    public class Program
    {
        public static int Main(string[] args)
        {
            return App.RunApplication(delegate()
            {
                var app = new App();
                app.Items["variable1"] = 1;
                return app;
            });
        }
    }

    public class Command1 : Command
    {
        public void Action()
        {
            this.App.Console.Write(App.Items["variable1"]);
            App.Items["variable1"] = (int)App.Items["variable1"] + 1;
        }

        public void Action2()
        {
            this.App.Console.Write(App.Items["variable1"]);
        }
    }
}
```

```
MyApp.exe action action2
1
2
```

Note que a variável `variable1` foi atribuída na criação do contexto `App` e foi incrementada quando passou na action `action2`.

# <a name="file-manager" />Gerenciador de objetos em forma de arquivos

Esse recurso é muito útil para persistir informações em arquivo no formato `Json`. Ele utiliza a dependência do framework `NewtonSoft.Json` para fazer todo o trabalho de serialização e deserialização.

A classe `SysCommand.ConsoleApp.Files.JsonFileManager` é a responsável pelo controle padrão de gerência de objetos em forma de arquivos. Nela contém alguns recursos que vão te ajudar a ganhar tempo caso precise persistir objetos. O formato será sempre `Json`.

_Propriedades:_

* `DefaultFolder`: Nome da pasta padrão. O padrão é `.app`.
* `bool SaveInRootFolderWhenIsDebug`: Determina se a pasta padrão será criada na raiz do projeto quando esta em modo de debug dentro do Visual Studio. Isso ajuda a visualizar os arquivos gerados usando a opção `Show all files` do `Solution Explorer`.
* `string DefaultFilePrefix`: Adiciona um prefixo em todos os arquivos. O padrão é `null`.
* `string DefaultFileExtension`: Especifica a extensão dos arquivos. O padrão é `.json`.
* `bool UseTypeFullName`: Determina se a formatação dos tipos `T` contemplará o nome completo do tipo. O padrão é `false`.

_Métodos:_

* `Save<T>(T obj)`: Salva um objeto na pasta padrão onde o nome do arquivo será o nome tipo `T` formatado, com exceção de classes que tem o atributo `ObjectFile`.
* `Save(object obj, string fileName)`: Salva um objeto na pasta padrão com um nome especifico.
* `Remove<T>()`: Remove um objeto na pasta padrão onde o nome do arquivo será o nome tipo `T` formatado, com exceção de classes que tem o atributo `ObjectFile`.
* `Remove(string fileName)`: Remove um objeto na pasta padrão com um nome especifico.
* `T Get<T>(string fileName = null, bool refresh = false)`: Retorna um objeto da pasta padrão.
  * `fileName`: Indica o nome do arquivo, caso seja `null` o nome do tipo `T` será usado na busca, com exceção de classes que tem o atributo `ObjectFile`.
  * `refresh`: Se `false`, buscará no cache interno caso já tenha sido carregado anteriormente. Do contrário será forçado o carregamento do arquivo.
* `T GetOrCreate<T>(string fileName = null, bool refresh = false)`: Mesmo comportamento do método acima, porém cria uma nova instância quando não encontrar o arquivo na pasta padrão. É importância dizer que o arquivo não será criado, apenas a instância do tipo `T`. Para salvar fisicamente é necessário utilizar o método `Save`.
* `string GetObjectFileName(Type type)`: Retorna o nome do tipo formatado ou se estiver usando o atributo `ObjectFile`, retorna o valor da propriedade `FileName`.
* `string GetFilePath(string fileName)`: Retorna o caminho do arquivo dentro da pasta padrão.

_Atributo `ObjectFile`:_

Esse atributo é útil para fixar um nome de arquivo em uma determinada classe. Assim, ao usar os métodos `Save<T>(T obj)`, `Get<T>()`, `Remove<T>()` ou `GetOrCreate<T>()` o nome do tipo do objeto não será mais utilizado. O nome fixado na propriedade `ObjectFile(FileName="file.json")` será sempre usado para esse tipo.

**Exemplo:**

```csharp
namespace Example.FileManager
{
    using SysCommand.ConsoleApp;
    using SysCommand.ConsoleApp.Files;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static int Main(string[] args)
        {
            return App.RunApplication();
        }
    }

    public class Command1 : Command
    {
        private JsonFileManager fileManager;

        public Command1()
        {
            fileManager = App.Items.GetOrCreate<JsonFileManager>();
        }

        public void Save(string title, string description = null)
        {
            var tasks = fileManager.GetOrCreate<Tasks>();
            tasks.LastUpdate = DateTime.Now;

            var task = tasks.AllTasks.FirstOrDefault(t => t.Title == title);
            if (task == null)
            {
                task = new Task
                {
                    Id = tasks.AllTasks.Count + 1,
                    Title = title,
                    Description = description,
                    DateAndTime = DateTime.Now
                };
                tasks.AllTasks.Add(task);
            }

            fileManager.Save(tasks);
        }

        public void Get(string title)
        {
            var tasks = fileManager.GetOrCreate<Tasks>();
            this.ShowTask(tasks.AllTasks.Where(t => t.Title.Contains(title)));
        }

        private void ShowTask(IEnumerable<Task> tasks)
        {
            foreach (var task in tasks)
                this.ShowTask(task);
        }

        private void ShowTask(Task task)
        {
            if (task == null)
            {
                App.Console.Error("Task not found");
                return;
            }

            App.Console.Write("Id: " + task.Id);
            App.Console.Write("Title: " + task.Title ?? "-");
            App.Console.Write("Description: " + task.Description ?? "-");
            App.Console.Write("Date: " + task.DateAndTime);
        }

        [ObjectFile(FileName = "tasks")]
        public class Tasks
        {
            public DateTime LastUpdate { get; set; }
            public List<Task> AllTasks { get; set; } = new List<Task>();
        }

        public class Task
        {
            public int Id { get; set; }
            public DateTime DateAndTime { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }
    }
}
```

```
MyApp.exe save "title1" "description1"
MyApp.exe save "title2" "description2"
MyApp.exe get "title"
Id: 1
Title: title1
Description: description1
Date: 20/02/2017 21:22:19
Id: 2
Title: title2
Description:
Date: 20/02/2017 21:24:20
```

Note que para criar uma instância de `JsonFileManager` foi utilizado o escopo do contexto `App.Items`, isso é útil para manter apenas uma instância desse gerenciador, economizando memória e mantendo as mesmas configurações em qualquer lugar que for utiliza-lo. É claro que se as configurações forem especificas, então será necessário criar uma nova instância com outras configurações no escopo que achar melhor.

# <a name="redirectiong-commands" />Redirecionamento de comandos

Para redirecionar a sua aplicação com uma nova sequência de comandos é muito simples, basta a sua action retornar uma instância da classe `RedirectResult` passando em seu construtor uma string contendo a nova sequência de comandos. Vale ressaltar que as instâncias dos comandos serão as mesmas, ou seja, o estado de cada comando não voltará ao inicio, apenas o fluxo de execução. Outro ponto importante é que qualquer ação depois da ação que retornou o `RedirectResult` não será mais chamado.

**Exemplo:**

```csharp
public class RedirectCommand : Command
{
    private int _count;

    public RedirectResult RedirectNow(string arg)
    {
        _count++;
        App.Console.Write($"Redirecting now!!. Count: {_count}");
        return new RedirectResult("redirected", "--arg", arg);
    }

    public string Something()
    {
        return "Something";
    }

    public string Redirected(string arg)
    {
        _count++;
        return $"Redirected: {arg}. Count: {_count}";
    }
}
```

No exemplo abaixo a ação `Something` será executada porque ela esta definida antes do redirect.

```
C:\MyApp.exe something redirect-now my-value
Something
Redirecting now!!. Count: 1
Redirected: my-value. Count: 2
```

No exemplo abaixo a action `Something` não será executada porque ela esta definida depois do redirect.

```
C:\MyApp.exe redirect-now my-value something
Redirecting now!!. Count: 1
Redirected: my-value. Count: 2
```

# <a name="stop-propagation" />Cancelamento da continuidade da execução

Quando existem muitas ações com o mesmo nome e assinatura, todas elas serão executadas juntas quando solicitada pelo usuário. Porém, você pode impedir isso usando o comando `ExecutionScope.StopPropagation()` dentro da sua action que você deseje que seja a última na pilha de execução.

**Exemplo:**

```csharp
public class StopPropagationCommand1 : Command
{
    public string StopPropagationAction1(bool cancel = false)
    {
        return "StopPropagationCommand1.StopPropagationAction1";
    }

    public string StopPropagationAction2()
    {
        return "StopPropagationCommand1.StopPropagationAction2";
    }
}

public class StopPropagationCommand2 : Command
{
    public string StopPropagationAction1(bool cancel = false)
    {
        if (cancel)
        {
            ExecutionScope.StopPropagation();
        }

        return "StopPropagationCommand2.StopPropagationAction1";
    }

    public string StopPropagationAction2()
    {
        return "StopPropagationCommand2.StopPropagationAction2";
    }
}

public class StopPropagationCommand3 : Command
{
    public string StopPropagationAction1(bool cancel = false)
    {
        return "StopPropagationCommand3.StopPropagationAction1";
    }

    public string StopPropagationAction2()
    {
        return "StopPropagationCommand3.StopPropagationAction2";
    }
}
```

```
C:\MyApp.exe stop-propagation-action1
StopPropagationCommand1.StopPropagationAction1
StopPropagationCommand2.StopPropagationAction1
StopPropagationCommand3.StopPropagationAction1

C:\MyApp.exe stop-propagation-action1 --cancel
StopPropagationCommand1.StopPropagationAction1
StopPropagationCommand2.StopPropagationAction1
```

Perceba que ao utilizar o argumento `--cancel` a action "StopPropagationCommand3.StopPropagationAction1" não foi executada. Isso por que ela estava na última posição da pilha de execução e como a action "StopPropagationCommand2.StopPropagationAction1" cancelou a continuidade da execução, qualquer outra action da sequência sera ignorada.

Outra possibilidade de uso do `StopPropagation` é quando existem multiplas ações no mesmo input. A lógica é a mesma, será cancelado todas as ações da pilha que estão depois da action que disparou o stop.

```
C:\MyApp.exe stop-propagation-action1 stop-propagation-action2
StopPropagationCommand1.StopPropagationAction1
StopPropagationCommand2.StopPropagationAction1
StopPropagationCommand3.StopPropagationAction1
StopPropagationCommand1.StopPropagationAction2
StopPropagationCommand2.StopPropagationAction2
StopPropagationCommand3.StopPropagationAction2

C:\MyApp.exe stop-propagation-action1 --cancel stop-propagation-action2
StopPropagationCommand1.StopPropagationAction1
StopPropagationCommand2.StopPropagationAction1
```

Perceba que a execução parou no mesmo ponto.

# <a name="argument-history-manager" />Gerenciamento de históricos de argumentos

Esse recurso permite que você salve aqueles inputs que são utilizados com muita frequencia e podem ser persistidos indeterminadamente. O seu funcionamento é bem simples, um `Command` interno chamado `SysCommand.ConsoleApp.Commands.ArgsHistoryCommand` é responsável por salvar os comandos e carrega-los quando solicitado. O arquivo `.app/history.json` é onde ficam salvos os comandos no formato `Json`. As `actions` de gerenciamento são as seguintes:

* `history-save [name]`: Utilize para salvar um comando. É obrigatório especificar um nome.
* `history-load [name]`: Utilize para carregar um comando usando um nome salvo anteriormente.
* `history-delete [name]`: Utilize para deletar um comando.
* `history-list`: Utilize para listar todos os comandos salvos.

**Exemplo:**

```csharp
public class TestArgsHistories : Command
{
    public void TestHistoryAction()
    {
        this.App.Console.Write("Testing"); 
    }
}
```

```
C:\MyApp.exe test-history-action history-save "CommonCommand1"
Testing

C:\MyApp.exe history-load "CommonCommand1"
Testing

C:\MyApp.exe history-list
[CommonCommand1] test-history-action

C:\MyApp.exe history-remove "CommonCommand1"
C:\MyApp.exe history-list
```

Os dois últimos comandos não retornam outputs.

* Para desativar o comando `ArgsHistoryCommand` veja o tópico [Especificando os tipos de comandos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#specifying-commands).
* A action `history-load` retorna um objeto do tipo `RedirectResult` que força o redirecionamento para um novo comando. Qualquer input depois dessa action será desprezado. Veja o tópico [Redirecionamento de comandos](https://github.com/juniorgasparotto/SysCommand/blob/master/documentation/pt-br.md#redirectiong-commands).
* Esse recurso só vai funcionar se a flag `App.EnableMultiAction` estiver ligada.

# <a name="extras" />Extras - OptionSet

Esse extra foi criado para uma ocasião especifica de parse onde o foco é ser simples. Com a classe `SysCommand.Extras.OptionSet` é possível fazer o parse de argumentos da forma tradicional.

_Métodos:_

* `void Add<T>(string longName, string helpText, Action<T> action)`: Adiciona uma configuração no formato **longo**
* `void Add<T>(char shortName, string helpText, Action<T> action)`: Adiciona uma configuração no formato **curto**
* `Add<T>(string longName, char? shortName, string helpText, Action<T> action)`: Adiciona uma configuração no formato **longo** e **curto**.
* `Add<T>(Argument<T> argument)`: Adiciona uma configuração completa
* `void Parse(string[] args, bool enablePositionalArgs = false)`: Executa o parse

_Propriedades:_

* `ArgumentsValid`: Depois do parse essa informação contém todos os argumentos válidos
* `ArgumentsInvalid`: Depois do parse essa informação contém todos os argumentos inválidos
* `HasError`: Verifica se existe erros no parse

**Exemplo:**

```csharp
using SysCommand.ConsoleApp;
using SysCommand.ConsoleApp.Helpers;
using SysCommand.Extras;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.Extras
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(Strings.CmdIndicator);
                args = ConsoleAppHelper.StringToArgs(Console.ReadLine());

                bool verbosity = false;
                var shouldShowHelp = false;
                var names = new List<string>();

                var options = new OptionSet();

                options.Add(new OptionSet.Argument<List<string>>("name", "the name of someone to greet.")
                {
                    Action = (n) =>
                    {
                        if (n != null)
                            names.AddRange(n);
                    }
                });

                options.Add(new OptionSet.Argument<bool>('v', "show verbose")
                {
                    Action = (v) =>
                    {
                        verbosity = v;
                    }
                });

                options.Add(new OptionSet.Argument<bool>("help", "show help")
                {
                    Action = (h) =>
                    {
                        shouldShowHelp = h;
                    }
                });

                options.Parse(args);

                if (!options.ArgumentsInvalid.Any())
                {
                    Console.WriteLine("verbosity: " + verbosity);
                    Console.WriteLine("shouldShowHelp: " + shouldShowHelp);
                    Console.WriteLine("names.Count: " + names.Count);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
```

```
cmd> --name a b c -v --help
verbosity: True
shouldShowHelp: True
names.Count: 3
```