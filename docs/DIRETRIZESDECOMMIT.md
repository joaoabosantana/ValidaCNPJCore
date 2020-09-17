# Diretrizes de Commit

Este projeto segue as linhas gerais do [Conventional Commits](https://www.conventionalcommits.org/pt-br/v1.0.0-beta.4/).

## Estrutura Geral

O commit deve ter a seguinte estrutura:

```
<tipo>[escopo opcional]: <descrição>

[corpo opcional]

[rodapé opcional]
```

### Tipos Permitidos

-   build: Mudanças que afetam o sistema de compilação ou suas dependências externas
-   chore: Mudanças em ferramentas, arquivos de configuração e outras mudanças que não afetam o código em produção
-   ci: Mudanças nos arquivos de configuração e scripts de integração contínua
-   docs: Mudanças apenas na documentação
-   feat: Uma nova funcionalidade
-   fix: Uma correção de erro
-   perf: Uma mudança de código que melhora o desempenho
-   refactor: Uma mudança de código que nem corrige um erro nem adiciona uma funcionalidade
-   style: Mudanças que não afetam o sentido do código
-   test: Adição de testes faltantes ou correção de testes existentes

O tipo `fix:` equivale ao `PATCH` no versionamento semântico.

O tipo `feat:` equivale ao `MINOR` no versionamento semântico.


### Escopos

Os escopos são de uso opcional e quando usados devem explicitar a área afetada pelo tipo.

Alguns escopos:

-   appveyor
-   changelog
-   dependabot
-   nuget
-   repo

Uma exceção à regra acima é o escopo `changelog`, que deve sempre ser usado em conjunto com o tipo `docs:` para indicar mudanças no changelog.

### Descrição

A descrição é um breve resumo das alterações promovidas pelo commit.

Use sempre o verbo no modo imperativo afirmativo verbal.

-   Use _altera_ ao invés de _alterou_ ou _alterar_.
-   Use _muda_ ao invés de _mudou_ ou _fez mudança_.

### Corpo

O corpo explica, se necessário, a motivação para as mudanças introduzidas pelo commit. Deve também estar no imperativo afirmativo verbal.

### Rodapé

O rodapé pode ter duas funções, concomitantes ou não.

Quando o commit introduz uma mudança que promove a quebra de compatibilidade da API, no rodapé deve estar a expressão `BREAKING CHANGE:`seguida da explicação dessa quebra de compatibilidade.

Um commit com um `BREAKING CHANGE:` equivale ao `MAJOR` no versionamento semântico.

Caso o commit resolve um problema presente no sistema de controle de problemas, o rodapé deve possuir uma das [palavras mágicas](https://docs.github.com/pt/github/managing-your-work-on-github/linking-a-pull-request-to-an-issue#linking-a-pull-request-to-an-issue-using-a-keyword) seguidas do número do problema.

Como regra geral, use a palavra-chave `Resolve`, que é um cognato do verbo resolver no imperativo afirmativo.
