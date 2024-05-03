"""
WARNING:

Please make sure you install the bot with `pip install -e .` in order to get all the dependencies
on your Python environment.

Also, if you are using PyCharm or another IDE, make sure that you use the SAME Python interpreter
as your IDE.

If you get an error like:
```
ModuleNotFoundError: No module named 'botcity'
```

This means that you are likely using a different Python interpreter than the one used to install the bot.
To fix this, you can either:
- Use the same interpreter as your IDE and install your bot with `pip install -e .`
- Use the same interpreter as the one used to install the bot (`pip install -e .`)

Please refer to the documentation for more information at https://documentation.botcity.dev/
"""

from botcity.web import WebBot, Browser, By
from botcity.web.util import element_as_select
from botcity.web.parsers import table_to_dict
from botcity.plugins.excel import BotExcelPlugin
from botcity.maestro import *
# Uncomment the line below for integrations with BotMaestro
# Using the Maestro SDK

excel = BotExcelPlugin()
excel.add_row(["CIDADE", "POPULAÇÃO"])

class Bot(WebBot):
    def action(self, execution=None):
        # Uncomment to silence Maestro errors when disconnected
        if self.maestro:
            self.maestro.RAISE_NOT_CONNECTED = False

        # Configure whether or not to run on headless mode
        self.headless = False

        maestro = BotMaestroSDK.from_sys_args()

        # maestro.login(server="https://developers.botcity.dev", login="login", key="key")

        # Uncomment to change the default Browser to Firefox
        self.browser = Browser.CHROME

        # Uncomment to set the WebDriver path
        self.driver_path = r"C:\Users\TI\Desktop\Estudos\botcity\chromedriver-win64\chromedriver-win64\chromedriver.exe"

        # Fetch the Activity ID from the task:
        # task = self.maestro.get_task(execution.task_id)
        # activity_id = task.activity_id

        # Opens the BotCity website.
        self.browse("https://buscacepinter.correios.com.br/app/faixa_cep_uf_localidade/index.php")
        self.driver.maximize_window()

        encontra_uf = element_as_select(self.find_element("//select[@id='uf']", By.XPATH))
        encontra_uf.select_by_value("SP")

        btn_pesquisar = self.find_element("//button[@id='btn_pesquisar']", By.XPATH)
        btn_pesquisar.click()

        self.wait(3000)

        tabela = self.find_element("//table[@id='resultado-DNEC']", By.XPATH)
        tabela = table_to_dict(table=tabela)

        self.navigate_to("https://cidades.ibge.gov.br/brasil/panorama")

        contador = 1
        str_CidadeAnterior = ""
        
        for cidade in tabela:

            str_Cidade = cidade["localidade"]

            if str_CidadeAnterior == str_Cidade:
                continue

            if contador <= 5:

                procura = self.find_element("//input[@placeholder='O que você procura?']", By.XPATH)
                procura.send_keys(str_Cidade)

                opcao_cidade = self.find_element(f"//a[span[contains(text(), '{str_Cidade}')] and span[contains(text(), 'SP')]]", By.XPATH)
                self.wait(1000)
                opcao_cidade.click()

                self.wait(2000)

                populacao = self.find_element("//div[@class='indicador__valor']", By.XPATH)
                str_populacao = populacao.text

                print(str_Cidade, str_populacao)
                excel.add_row([str_Cidade, str_populacao])
                maestro.new_log_entry(activity_label="CIDADES", values={"CIDADE": f"{str_Cidade}", "POPULACAO": f"{str_populacao}"})

                contador += 1
                str_CidadeAnterior = str_Cidade

            else:
                print("Número máximo de cidades alcançado")
                break

        excel.write(r"C:\Users\TI\Desktop\Estudos\botcity\busca_cep\Infos_Cidades.xlsx")

        self.wait(5000)

        # Uncomment to mark this task as finished on BotMaestro
        self.maestro.finish_task(
            task_id=execution.task_id,
            status=AutomationTaskFinishStatus.SUCCESS,
            message="Task Finished OK."
        )

        # Wait for 10 seconds before closing
        # self.wait(3000)

        # Stop the browser and clean up
        self.stop_browser()

    def not_found(self, label):
        print(f"Element not found: {label}")


if __name__ == '__main__':
    Bot.main()
