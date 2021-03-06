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

**7.** Altere o programa do Exercício 3 para criar não apenas um funcionário, mas uma lista (*List*) com vários objetos desse tipo e imprima seus dados no seguinte formato:
```
                               LISTA DE FUNCIONÁRIOS
------------------------------------------------------------------------------------
| Matrícula  | Nome                           | Salário     | Setor                |
------------------------------------------------------------------------------------
| 0000000000 | AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA | R$ 99999,99 | AAAAAAAAAAAAAAAAAAAA |
| 0000000000 | AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA | R$  9999,99 | AAAAAAAAAAAAAAAAAAAA |
| 0000000000 | AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA | R$   999,99 | AAAAAAAAAAAAAAAAAAAA |
------------------------------------------------------------------------------------
```
A classe Funcionario agora deve atender os seguintes requisitos:
- A Matricula não pode conter mais de 10 caracteres;
- O Nome não pode conter mais de 30 caracteres;
- O salário não pode ser superior a 99999.99;
- O setor não pode conter mais de 20 caracteres.

Para as propriedades do tipo texto, caso o valor atribuído a elas exceda o comprimento máximo, a classe deverá cortar o texto informado, mantendo apenas a quantidade permitida (descartando o excesso do final). Já para a propriedade Salário, se o valor informado exceder o máximo permitido, a classe deverá utilizar apenas o valor limite descrito acima.

Atenção aos detalhes da impressão:
- A coluna Matrícula deve estar formatada sempre com 10 caracteres; 
- A coluna Nome deve estar formatada sempre com 30 caracteres;
- A coluna Salário deve conter o símbolo R$ fixo e o valor deve estar formatado sempre com 7 caracteres;
- A coluna Setor deve estar formatada sempre com 20 caracteres.

Dica 1: *Quando o texto for menor que o tamanho da coluna, para manter a formatação, você pode preencher imprimir o valor preenchido com espaços em branco à direita (Matricula, Nome e Setor) ou à esquerda (Salário).*

Dica 2: *A classe String contém métodos para fazer as operações de cortar o texto e preencher à direita ou esquerda. Pesquise quais você deverá utilizar.*

**8.** Altere o programa do Exercício 7 para que agora o setor também seja modelado como uma classe e não mais um string. A classe Setor deve possuir um recurso especial que lhe permitirá abreviar alguns termos comuns utilizados nos nomes dos setores. Por exemplo, se for atribuído o nome "Departamento de Pesquisa" ao setor, este texto deve ser alterado para "Depto. de Pesq.". Utilize a seguinte tabela para fazer as substituições e, caso queira, adicione novos termos.

```
------------------------------
| Termo         | Abreviação |
------------------------------
| Departamento  | Depto.     |
| Secretaria    | Sec.       |
| Coordenação   | Coord.     |
| Gerência      | Ger.       |
| Administração | Adm.       |
| Pesquisa      | Pesq.      |
| Extensão      | Ext.       |
------------------------------
```

Dica: *A classe genérica `Dictionary` pode ser útil nessa questão.*