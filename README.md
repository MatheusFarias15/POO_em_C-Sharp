# 📘 Curso de C# : Aplicando a Orientação a Objetos

---

### 🧠 Fundamentos da Linguagem

- **C#** é uma linguagem fortemente tipada, ou seja, sempre precisamos declarar a unidade da variável, como: `string`, `bool`, `int`.
- Utilização do **método Pascal Case**: Também conhecido como *upper camel case* ou *capital case*, Pascal Case combina palavras colocando todas com a primeira letra maiúscula.

---

### 🛠️ Getters e Setters

- Palavras reservadas para leitura e recebimento de valores: `get` e `set`.
  - `get` representa **leitura**.
  - `set` representa **atribuição de valores**.

---

### 🏗️ Construtores

- Os construtores em C# são importantes porque permitem:
  - Criar objetos de uma classe.
  - Inicializar membros e definir valores padrão.
  - Manter a integridade dos dados.
  - Promover práticas de programação seguras.

---

### 🔐 Visibilidade `internal`

- A visibilidade `internal` indica que uma classe, método ou propriedade só pode ser acessada **dentro do mesmo projeto ou assembly**.
- Isso ajuda a encapsular detalhes de implementação, tornando o código mais **organizado e seguro**.
- **Controle total** sobre o que é acessível fora do projeto.

---

### 👨‍👩‍👧‍👦 Herança

- A herança é um dos pilares da POO e permite que uma classe (filha) herde características e comportamentos de outra (pai).
- Isso evita duplicação de código e promove **reutilização**.

#### 📌 Dicas importantes:

- **Visibilidade**: Métodos `private` não são acessíveis na classe filha.
- **Construtores**: A classe filha **não herda** os construtores da classe pai, mas pode chamar usando `base`.
- **Sobrescrita de métodos**: Use `override` na classe filha para sobrescrever métodos `virtual` da classe pai.

> 💡 *Exemplo de utilização:*  
> `internal class MenuAvaliarBanda : Menu`

---

# 🌐 Curso de C# : Consumindo API, Gravando Arquivos e Utilizando o LINQ

---

### 🌍 Trabalhando com APIs

- A classe `HttpClient` é usada para enviar requisições HTTP (GET, POST, PUT, DELETE...) e receber respostas do servidor web.  
  Ela faz parte do namespace: `System.Net.Http`.

#### Etapas do uso:

1. **Instanciação**: Criar uma instância de `HttpClient`.
2. **Envio da requisição**: Usar métodos como `GetStringAsync`, `GetAsync`, `PostAsync`, etc.
3. **Recebimento da resposta**: Objeto `HttpResponseMessage`, contendo:
   - Código de status (ex: 200 OK, 404 Not Found)
   - Headers
   - Conteúdo da resposta
4. **Tratamento da resposta**:
   - Ler o conteúdo (geralmente JSON ou XML)
   - Desserializar para objetos C#

---

# 📦 Serialização e Desserialização em C# com JSON

Este documento explica como funciona a **serialização** e **desserialização** de objetos em C# utilizando `System.Text.Json`.

---

## 🔄 Serialização (Objeto C# para JSON)

A **serialização** transforma um objeto C# em uma string JSON, ideal para armazenar ou transferir dados entre sistemas.

### ✅ Etapas do processo:

1. **Reflexão**  
   O `JsonSerializer` examina a estrutura do objeto com base em reflexão.

2. **Mapeamento com atributos**  
   Ele identifica as propriedades do objeto e utiliza `[JsonPropertyName]` para definir os nomes no JSON.

3. **Conversão de tipos**  
   Os tipos de dados do C# são convertidos para equivalentes em JSON.

4. **Geração do JSON**  
   Uma string JSON é gerada contendo os nomes e valores das propriedades do objeto.

---

## 📥 Desserialização (JSON para Objeto C#)

Na **desserialização**, o processo é o inverso: transforma-se uma string JSON em um objeto C#.

### 💡 Exemplo prático

**JSON de entrada:**

```json
{
  "song": "Bohemian Rhapsody",
  "artist": "Queen",
  "duration_ms": 355000
} 
``` 

# 🔁 C#: Trabalhando com Arrays e Coleções – Loops

## O que são loops?

Loops (laços de repetição) permitem executar um bloco de código várias vezes até que uma condição seja atendida. Em C#, os principais tipos de loops são:

---

## 🔢 1. `for`

Usado quando **sabemos o número de vezes** que o código deve ser executado:

```csharp
for (int i = 0; i < 5; i++) 
{
    Console.WriteLine($"Iteração {i}");
} 
```

### 🧠 Entendendo o Loop `for`

No código acima, temos:

- **Inicialização (`int i = 0`)**: Define o contador que dará início ao loop.
- **Condição (`i < 5`)**: Enquanto essa condição for verdadeira, a execução continuará se repetindo.
- **Incremento (`i++`)**: Atualiza o contador ao final de cada ciclo (ou “iteração”).

🔁 Em outras palavras:  
Enquanto `i` for menor que 5, incrementamos o contador em +1 a cada passo.  
Quando `i` chega ao valor 5, o loop é encerrado automaticamente.

### 🔄 Estrutura de Repetição: `while`

A estrutura `while` executa um bloco de código **enquanto uma condição for verdadeira**. A verificação é feita **antes** de cada execução.

#### 🧠 Como funciona?

No exemplo abaixo, temos:

```csharp
int tentativas = 0;
while (tentativas < 3)
{
    Console.WriteLine($"Tentativa {tentativas + 1}");
    tentativas++;
}```

### 🔁 Estrutura de Repetição: `do-while`

A estrutura `do-while` é **similar ao `while`**, com uma diferença importante:  
> Ela executa o bloco **pelo menos uma vez**, pois a verificação da condição acontece **após** a execução.

#### 🧪 Exemplo em C#:

```csharp
int tentativas = 0;
do 
{
    Console.WriteLine($"Tentativa {tentativas + 1}");
    tentativas++;
} while (tentativas < 3);
```

## 4. `foreach`

Percorre todos os itens de uma coleção (arrays, listas, etc.). Por exemplo:

```csharp
string[] frutas = { "Maçã", "Banana", "Laranja" };
foreach (string fruta in frutas) 
{
    Console.WriteLine(fruta);
}
```

### 🕑 Quando usar cada estrutura de repetição?

| Estrutura  | Quando Usar?                                      | Exemplo Típico                       |
|------------|---------------------------------------------------|--------------------------------------|
| `for`      | Quando você sabe o número exato de iterações       | Contagens, processamento de intervalos|
| `while`    | Para loops com condições complexas ou indefinidas  | Validação de entrada, jogos em loop  |
| `do-while` | Quando o bloco deve executar pelo menos 1 vez      | Menus interativos, tentativas de login|
| `foreach`  | Para percorrer todos os itens de uma coleção       | Listas, arrays, dicionários          |