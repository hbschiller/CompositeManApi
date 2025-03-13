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

## Uso

1. Inicie o servidor de API C#:
   ```
   RTDApi.exe
   ```

2. Para acessar Swagger no seu navegador http://localhost:5000/swagger/index.html

2. Execute o cliente Python:
   ```
   python app.py
   ```

3. Digite o símbolo do ticker e o tipo de dados quando solicitado.

Exemplo: 

- WINFUT_F_0 
- MAX

## Tipos de Dados Comuns

- `ABE`: Preço de abertura
- `FEC`: Preço de fechamento do dia anterior
- `ULT`: Último preço (atual)