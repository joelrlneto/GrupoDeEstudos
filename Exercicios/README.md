Lista de Exercícios de C#
-------------------------

**1.** Desenvolva um programa que lê 10 nomes no Console e em seguida recebe um texto que deseja buscar. Em seguida, o programa deve exibir quais dos nomes registrados contém o texto informado.

**2.** Altere o programa anterior para que o cliente possa selecionar o tipo de busca. Após ler os nomes e o texto a ser buscado, apresente uma lista com as seguintes opções “Começa com”, “Termina com”, “Contém” e efetue a busca de acordo com a condição escolhida pelo usuário.

**3.** Crie um programa que contenha uma classe para representar um funcionário de uma empresa. Esse funcionário deve ter nome, matrícula, salário e setor onde trabalha. Na classe Program da sua aplicação, instancie um novo funcionário, preencha com dados quaisquer e em seguida imprima as informações desse funcionário no Console.

**4.** Você foi contratado para desenovlver um sistema de gerenciamento para uma universidade. Para a primeira versão, foi solicitado que o sistema seja capaz de gerenciar o cadastro de cursos oferecidos pela universidade, bem como as disciplinas ofertadas na matriz curricular de cada curso. Para cada disciplina, que possui um código e um nome, pode haver várias turmas abertas, que diferem entre si apenas pelo horário das aulas. Também é preciso gerenciar o cadastro de alunos, cujas informações armazenadas são nome, matricula e período de entrada. Os cursos possuem um nome, que deve ser único, e o nível/tipo do curso (bacharelado, tecnólogo e licenciatura).

**5.** Altere o código do programa contido na pasta [4. 23042016/ExercicioPOO/](https://github.com/joelrlneto/GrupoDeEstudos/tree/master/4.%2023042016/ExercicioPOO) e adicione um construtor sobrecarregado em cada classe para simplificar a instanciação dos objetos e reduzir o código da classe Program. Por exemplo, ao invés do seguinte código:

```C#
Aluno a1 = new Aluno();

a1.Matricula = "001";

a1.Nome = "Joel";

a1.Periodo = "2016.1";
```

deve ser possível usar a seguinte estrutura:

```C#
Aluno a1 = new Aluno("001", "Joel", "2016.1");
```

**6.** Altere o código do programa contido na pasta [4. 23042016/ExercicioPOO/](https://github.com/joelrlneto/GrupoDeEstudos/tree/master/4.%2023042016/ExercicioPOO) e crie um *enum* para substituir o string na propriedade Tipo do curso. O enum deve ser chamar `TipoCurso` e deve ser possível utilizá-lo da seguinte forma:

`curso1.Tipo = TipoCurso.Bacharelado`