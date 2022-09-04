# Exercício Proposto: Cálculo de Imposto

## Objetivo :dart:

Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um, bem como o total de imposto arrecadado.

Os dados da pessoa física são:

- Nome;
- Renda Anual; e
- Gastos com Saúde.

Os dados da pessoa jurídica são:

- Nome;
- Renda Anual; e
- Número de funcionários;

As regras para cálculo de imposto são as seguintes:

- Pessoa Física:

    - Pessoas cuja renda anual for abaixo de $ 20000.00 pagam 15% de imposto;
    
    - Pessoas cuja renda anual é maior ou igual a $ 20000.00 pagam 25% de imposto;

    - Pessoas com gastos em saúde tem 50% do valor gasto abatido no imposto;

- Pessoa Jurídica:

    - Pessoas Jurídicas pagam 16% de imposto;

    - Empresas com mais de 10 funcionários pagam apenas 14% de imposto.


## Exemplo :computer:

```
Enter the number of tax payers: 3

Tax payer #1 data:
Individual or company (i/c)? i
Name: Alex
Anual income: 50000.00
Health expenditures: 2000.00

Tax payer #2 data:
Individual or company (i/c)? c
Name: SoftTech
Anual income: 400000.00
Number of employees: 25

Tax payer #3 data:
Individual or company (i/c)? i
Name: Bob
Anual income: 120000.00
Health expenditures: 1000.00

TAXES PAID:
Alex: $ 11500.00
SofTech: $ 56000.00
Bob: $ 29500.00

TOTAL TAXES: $ 97000.00

```