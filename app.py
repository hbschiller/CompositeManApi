import requests

import requests
import os
import platform

# ANSI color codes
class Colors:
    RESET = '\033[0m'
    BLACK = '\033[30m'
    RED = '\033[31m'
    GREEN = '\033[32m'
    YELLOW = '\033[33m'
    BLUE = '\033[34m'
    MAGENTA = '\033[35m'
    CYAN = '\033[36m'
    WHITE = '\033[37m'
    
    # Background colors
    BG_BLACK = '\033[40m'
    BG_RED = '\033[41m'
    BG_GREEN = '\033[42m'
    BG_YELLOW = '\033[43m'
    BG_BLUE = '\033[44m'
    BG_MAGENTA = '\033[45m'
    BG_CYAN = '\033[46m'
    BG_WHITE = '\033[47m'
    
    # Style
    BOLD = '\033[1m'
    UNDERLINE = '\033[4m'

def clear_screen():
    if platform.system() == 'Windows':
        os.system('cls')
    else:
        os.system('clear')

def main():
    base_url = "http://localhost:5000"
    
    clear_screen()
    print(f"{Colors.BG_BLUE}{Colors.WHITE}{Colors.BOLD}     RTD Market Data Terminal     {Colors.RESET}")
    print(f"{Colors.BG_GREEN}{Colors.WHITE}{Colors.BOLD} by SchillerApp   www.ScApp.link  {Colors.RESET}")
    print(f"{Colors.YELLOW}        CTRL + C para sair       {Colors.RESET}")
    
    try:
        while True:
            try:
                ticker = input(f"\n{Colors.CYAN}Ticker: {Colors.RESET}")
                data_type = input(f"{Colors.CYAN}Tipo de Dado: {Colors.RESET}")
                
                url = f"{base_url}/api/MarketData/{ticker}/{data_type}"
                response = requests.get(url)
                
                if response.status_code == 200:
                    data = response.json()
                    print(f"{Colors.GREEN}Valor: {Colors.BOLD}{data['value']}{Colors.RESET}")
                else:
                    print(f"{Colors.RED}Erro: Status {response.status_code}{Colors.RESET}")
            except requests.RequestException as e:
                print(f"{Colors.RED}Erro de Requisição: {e}{Colors.RESET}")
    except KeyboardInterrupt:
        print(f"\n{Colors.YELLOW}Fechando Terminal!{Colors.RESET}")

if __name__ == "__main__":
    main()