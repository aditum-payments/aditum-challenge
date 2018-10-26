# aditum-challenge

Desafio desenvolvido no processo seletivo da Aditum.

## Instruções

1. **Fazer o _fork_ desse projeto.** O desafio não será corrigido se não for um _fork_ do projeto.
2. **Implementar as funcionalidades obrigatórias.**
3. [Opcional] Implementar as funcionalidades opcionais, caso queira ou seja solicidado.
4. **Use o Git apropriadamente.** Faça _commits_ com frequência e coerência, o uso do Git será avaliado.
5. **Ao terminar, abra um issue com o link do _fork_.**

### Configuração do ambiente

Esse é um projeto de Web API que utiliza o **ASP .NET Core 2**, por isso você vai precisar instalar essa dependência na sua máquina. Outra dependência será o **MongoDB**, que é utilizado pelo projeto. :warning: Se o candidato preferir utilizar outro banco de dados ou outra técnica de armazenamento de dados, é permitido que a tecnologia seja trocada.

## Funcionalidades obrigatórias

Escolhas técnicas podem ser alteradas pelo candidato, porém devem ser justificadas.

### CRUD de `Product`

O método de criação já está implementado. Implemente a leitura (_read_), atualização (_update_) e remoção (_delete_). 

Siga os padrões adotados pelo projeto, ou altere o padrão do projeto inteiro. Sinta-se livre para aplicar quaisquer padrões de projeto.

### Interface

Implemente uma interface para criar, consultar, alterar e deletar produtos. Utilize **AngularJS**. Não é necessário paginação da consulta.

* Tela de visualização de todos os produtos, mostrando o nome do produto e seu valor;
* Tela de visualização dos detalhes de um produto.

## Funcionalidades opcionais

### Implemente o _pattern Unit of Work_

Implemente o padrão de projetos Unit of Work, com os métodos `BeginTransaction`, `Commit` e `Rollback`.

### Testes de unidade

Crie testes de unidade, com as seguintes premissas:

* O teste não pode se conectar ao banco de dados;
* O teste não pode se conectar à internet.

### Consulta paginada

Implemente a consulta paginada dos produtos.

### Pesquisa de produtos

Crie campo de pesquisa dos produtos e implemente filtros.

### Sugira melhorias

Estamos abertos à sugestões de melhoria da implementação desse desafio. :smile:

## Dúvidas

Caso surja alguma duvida, crie _issues_ nesse repositório que nós responderemos assim que pudermos.