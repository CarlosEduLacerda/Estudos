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
from botcity.web.browsers.chrome import default_options
from datetime import datetime
import glob
import os.path
import csv

# Uncomment the line below for integrations with BotMaestro
# Using the Maestro SDK
# from botcity.maestro import *

usuario = input("Digite seu email: ")
senha = input("Digite sua senha: ")

class Bot(WebBot):
    def action(self, execution=None):
        # Uncomment to silence Maestro errors when disconnected
        # if self.maestro:
        #     self.maestro.RAISE_NOT_CONNECTED = False

        # Configure whether or not to run on headless mode
        self.headless = False

        # Uncomment to change the default Browser to Firefox
        self.browser = Browser.CHROME

        # Uncomment to set the WebDriver path
        self.driver_path = r"C:\Users\TI\Desktop\Estudos\botcity\chromedriver-win64\chromedriver-win64\chromedriver.exe"

        planilha = r"C:\Users\TI\Desktop\Estudos\botcity\teste2\planilha"

        self.options = default_options(download_folder_path=planilha)

        # Fetch the Activity ID from the task:
        # task = self.maestro.get_task(execution.task_id)
        # activity_id = task.activity_id

        # Opens the BotCity website.
        self.browse("https://pathfinder.automationanywhere.com/challenges/automationanywherelabs-customeronboarding.html?_ga=2.117836043.302873972.1689080355-771655515.1689080353")
        self.maximize_window()

        self.find_element("//button[@id='onetrust-accept-btn-handler']", By.XPATH).click()

        self.find_element("//button[@id='button_modal-login-btn__iPh6x']", By.XPATH).click()

        self.find_element("//input[@id='42:2;a']", By.XPATH).send_keys(usuario)

        self.find_element("//button[@class='slds-button slds-button_brand button']", By.XPATH).click()

        self.find_element("//input[@id='10:125;a']", By.XPATH).send_keys(senha)

        self.find_element("//button[@class='slds-button slds-button_brand button']", By.XPATH).click()

        self.wait(2000)
        
        self.find_element("//a[@class='btn customer-onboarding__btn-orange']", By.XPATH).click()

        self.wait(2000)

        tipoArquivo = '*.csv'
        
        arquivo = glob.glob(f"{planilha}/{tipoArquivo}")

        arquivoFinal = max(arquivo, key=os.path.getctime)

        with open(arquivoFinal, 'r') as arquivoCSV:

            leitorCSV = csv.reader(arquivoCSV)

            next(leitorCSV)

            for dados in leitorCSV:
                strCustomerName = dados[0]
                strCustomerID = dados[1]
                strPrimaryContact = dados[2]
                strStreetAddress = dados[3]
                strCity = dados[4]
                strState = dados[5]
                strZip = dados[6]
                strEmail = dados[7]
                strDiscount = dados[8]
                strDisclosure = dados[9]

                self.find_element("//input[@id='customerName']", By.XPATH).send_keys(strCustomerName)
                self.find_element("//input[@id='customerID']", By.XPATH).send_keys(strCustomerID)
                self.find_element("//input[@id='primaryContact']", By.XPATH).send_keys(strPrimaryContact)
                self.find_element("//input[@id='street']", By.XPATH).send_keys(strStreetAddress)
                self.find_element("//input[@id='city']", By.XPATH).send_keys(strCity)
                self.find_element("//select[@id='state']", By.XPATH).send_keys(strState)
                self.find_element("//input[@id='zip']", By.XPATH).send_keys(strZip)
                self.find_element("//input[@id='email']", By.XPATH).send_keys(strEmail)

                if strDiscount == 'YES':
                    self.find_element("//input[@id='activeDiscountYes']", By.XPATH).click()
                else:
                    self.find_element("//input[@id='activeDiscountNo']", By.XPATH).click()
                
                if strDisclosure == 'YES':
                    self.find_element("//input[@id='NDA']", By.XPATH).click()
                
                self.find_element("//button[@id='submit_button']", By.XPATH).click()

            self.wait(10000)

            strPrint = f"{arquivoFinal.replace('.csv','')}_{datetime.now().strftime("%d-%m-%Y_%H-%M-%S"".png")}"

            self.screenshot(strPrint)

        # Uncomment to mark this task as finished on BotMaestro
        # self.maestro.finish_task(
        #     task_id=execution.task_id,
        #     status=AutomationTaskFinishStatus.SUCCESS,
        #     message="Task Finished OK."
        # )

        # Wait for 10 seconds before closing
        self.wait(10000)

        # Stop the browser and clean up
        self.stop_browser()

    def not_found(self, label):
        print(f"Element not found: {label}")


if __name__ == '__main__':
    Bot.main()
