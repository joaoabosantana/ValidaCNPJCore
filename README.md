# Validador de CNPJ

> Biblioteca para validação de número de inscrição no Cadastro Nacional da Pessoa Jurídica

![Nuget](https://img.shields.io/nuget/v/ValidaCNPJCore) ![Nuget](https://img.shields.io/nuget/dt/ValidaCNPJCore)

## Introdução

A validação de um CNPJ é feito por meio de um algoritmo que multiplica a primeira parte do CNPJ (o número de inscrição propriamente dito) por duas sequências de constantes e compara seus resoltados com o dígito verificador (a parte final).

Esta biblioteca fornece um método para realizar as multiplicações e verificar se um dado CNPJ é válido. Para um aplicativo de exemplo, veja o projeto [ValidaCNPJApp](https://github.com/jotaantoniosantana/ValidaCNPJApp).

### Inspiração

O código original não é meu, estando presente em diversos sites sobre o assunto. Esta é uma implementação melhorada e atualizada do código encontrado em http://macoratti.net/11/09/c_val1.htm.

## Tecnologias

- .NET Core 3.1
- C# 8.0
- nUnit 3

## Consumo

A biblioteca pode ser adicionada a qualquer projeto .NET como um pacote NuGet. Veja [a página do pacote em nuget.org](https://www.nuget.org/packages/ValidaCNPJCore/) sobre como fazê-lo.

Depois de adicionada ao projeto, referencie a biblioteca acrescentando `using ValidaCNPJCore` no seu código. Ao fazê-lo, a biblioteca expõe a classe `Validar`, que possui o método `CNPJ()`.

Passe para `CNPJ()` o número de inscrição a ser validado como uma `string`. A validação é uma operação booleana que retorna `true` para um CNPJ válido e `false` para um inválido.

## Exemplo de Código

Este exemplo é retirado do projeto [ValidaCNPJApp](https://github.com/jotaantoniosantana/ValidaCNPJApp).

Interface:

```xaml
<StackPanel Grid.Row="1" Margin="8">
    <TextBlock Margin="8" FontSize="14" Text="Digite o CNPJ:" />
    <TextBox x:Name="txtCNPJ" Margin="8" FontSize="14" />
    <Button Margin="8" Click="Button_Click" Content="Validar" FontSize="14" />
</StackPanel>
```

Consumo e chamada da biblioteca:

```csharp
using ValidaCNPJCore;

private void Button_Click(object sender, RoutedEventArgs e)
    {
        string cnpj = txtCNPJ.Text;

        txtResultado.Text = Validar.CNPJ(cnpj) == true ? "O CNPJ é válido." : "O CNPJ não é válido.";
    }
```

## Funcionalidades

[Veja o mais recente lançamento](https://github.com/jotaantoniosantana/ValidaCNPJCore/releases) para uma lista de funcionalidades implementadas.

### Para Fazer

- Implementar validação da string passada para o método.

## Status

O desenvolvimento da versão 1.0.0 da bilbioteca está _feito_. 


## Mantenedor

ValidaCNPJCore é um projeto criado e mantido por [@jotaantoniosantana](https://github.com/jotaantoniosantana).

## Licença

MIT.
