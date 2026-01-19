# Validador de Cartão de Crédito

Um aplicativo simples em C# que valida números de cartão de crédito e identifica o emissor do cartão.

## Funcionalidades

- ✅ Validação de cartões de crédito usando o algoritmo de Luhn
- 🏦 Identificação automática do emissor do cartão
- 🔍 Suporte para múltiplas bandeiras:
  - Visa
  - Mastercard
  - American Express
  - Discover
  - Diners Club
  - JCB

## Requisitos

- .NET 10.0 ou superior

## Como Usar

1. **Clone o repositório ou baixe os arquivos**

2. **Compile o projeto:**
   ```bash
   dotnet build
   ```

3. **Execute o programa:**
   ```bash
   dotnet run
   ```

4. **Digite o número do cartão** quando solicitado

5. **O programa exibirá:**
   - Se o cartão é válido
   - Qual é o emissor do cartão

## Exemplo de Uso

```
Número cartão: 4532015112830366
Válido: True | Emissor: Visa
```

## Estrutura do Projeto

```
validadorCPF/
├── Program.cs              # Arquivo principal da aplicação
├── Models/
│   └── CreditCardValidator.cs  # Classe com lógica de validação
├── validadorCPF.csproj    # Arquivo de configuração do projeto
└── README.md              # Este arquivo
```

## Como Funciona

### Algoritmo de Luhn
O validador utiliza o [algoritmo de Luhn](https://pt.wikipedia.org/wiki/Algoritmo_de_Luhn) para verificar a validade do número do cartão. Este é o padrão da indústria para validação de cartões de crédito.

### Identificação de Emissor
A identificação do emissor é feita através de expressões regulares que verificam o padrão do número do cartão de acordo com as regras de cada bandeira.

## Tecnologias

- **Linguagem:** C# 12.0
- **Framework:** .NET 10.0
- **Bibliotecas:** System.Linq, System.Text.RegularExpressions

## Notas de Segurança

⚠️ **Este é um projeto educacional.** Não armazene ou processe cartões de crédito reais com esta aplicação em produção. Para aplicações reais, use serviços de processamento de pagamento certificados e seguros.

## Licença

Este projeto é fornecido como está para fins educacionais.