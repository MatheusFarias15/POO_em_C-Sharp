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

### 📥 Desserialização

- A **desserialização** é o processo de converter dados transmitidos (como JSON ou XML) em objetos ou estruturas que podem ser utilizados no programa.
