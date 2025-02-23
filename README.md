Curso de C# : Aplicando a Orientação a Objetos

- C# é uma linguagem fortemente tipada ou seja sempre precisamos declarar a unidade da variavel seja String, bool, int 
- Utilização do metodo Pascal case: Também conhecido como “upper camel case” ou “capital case”, pascal case combina palavras colocando todas com a primeira letra maiúscula
- Palavras reservadas para leitura e receber valores (get e set)
- get representa leitura e set recebe valores 
- Utilização de construtores 
- Os construtores em C# são importantes porque permitem criar objetos de uma classe, inicializar seus membros e definir valores padrão. Eles também ajudam a manter a integridade dos dados e a promover práticas de programação seguras.
- A visibilidade internal é um conceito importante na programação orientada a objetos, especialmente em C#. Quando você declara uma classe, método ou propriedade como internal, isso significa que ela só pode ser acessada dentro do mesmo projeto ou assembly. Ou seja, outras partes do seu código que estão no mesmo projeto podem usar essa classe, mas se você tentar acessá-la de um projeto diferente, não conseguirá. Isso é útil para encapsular detalhes de implementação que não precisam ser expostos a outros projetos, ajudando a manter o código mais organizado e seguro. Assim, você pode controlar melhor o que é acessível e o que não é.

- A herança é um dos pilares da programação orientada a objetos e permite que uma classe (chamada de classe filha ou subclasse) herde características e comportamentos de outra classe (chamada de classe pai ou superclasse). Isso significa que a classe filha pode usar métodos e propriedades da classe pai, evitando a duplicação de código e promovendo a reutilização.

- Dicas: 
- Visibilidade: Lembre-se de que a visibilidade dos métodos e propriedades na classe pai afeta o acesso na classe filha. Se um método for declarado como private, ele não será acessível na classe filha.
- Construtores: A classe filha não herda os construtores da classe pai, mas pode chamar o construtor da classe pai usando a palavra-chave base.
- Sobrescrita de Métodos: Você pode sobrescrever métodos da classe pai na classe filha usando a palavra-chave override, desde que o método na classe pai seja marcado como virtual.
- Exemplo de utilização: internal class MenuAvaliarBanda : Menu 