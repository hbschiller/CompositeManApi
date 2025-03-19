# RTD API
API para acessar serviços de Dados em Tempo Real (RTD) do Profitchart.

## Componentes
### Servidor de API RTD em C#
- Fornece acesso à API REST para dados RTD do Profitchart
- Mantém uma única conexão com o servidor RTD
- Cria tópicos individuais para solicitações de dados
- Limpa recursos automaticamente

### Cliente Terminal Python
- Interface simples de linha de comando para solicitações de dados
- Saída com código de cores para melhor legibilidade
- CTRL+C para sair

## Instalação

### Opção 1: Executável Standalone (Sem Necessidade de Código Fonte)
1. Baixe o arquivo zip da [seção Releases](https://github.com/hbschiller/CompositeManApi/releases)
2. Extraia o arquivo zip em seu computador
3. Execute `RTDApi.exe` diretamente - não requer instalação do .NET

### Opção 2: Compilar a partir do Código Fonte
1. Clone este repositório
2. Execute `dotnet build -c Release`
3. Navegue até a pasta `bin/Release/net7.0`

## Uso
1. Inicie o servidor de API C#:
   ```
   RTDApi.exe
   ```
2. Para acessar Swagger no seu navegador http://localhost:5000/swagger/index.html
3. Execute o cliente Python:
   ```
   python app.py
   ```
4. Digite o símbolo do ticker e o tipo de dados quando solicitado.
   Exemplo: 
   - WINFUT_F_0 
   - MAX

## Tipos de Dados Comuns
- `ABE`: Preço de abertura
- `FEC`: Preço de fechamento do dia anterior
- `ULT`: Último preço (atual)

## Configuração
O arquivo `appsettings.json` contém configurações que podem ser ajustadas conforme necessário.

## Atributos RTD

Para a lista completa de atributos RTD com mais detalhes https://scapp.link/rtd-dde