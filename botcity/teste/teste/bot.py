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

from botcity.core import DesktopBot
# Uncomment the line below for integrations with BotMaestro
# Using the Maestro SDK
# from botcity.maestro import *


class Bot(DesktopBot):
    def action(self, execution=None):
        # Uncomment to silence Maestro errors when disconnected
        # if self.maestro:
        #     self.maestro.RAISE_NOT_CONNECTED = False

        # Fetch the Activity ID from the task:
        # task = self.maestro.get_task(execution.task_id)
        # activity_id = task.activity_id

        # Opens the BotCity website.
        #self.browse("http://www.botcity.dev")
        # self.execute(r"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Cisco Packet Tracer\Cisco Packet Tracer.lnk")
        # self.wait(10000)
        
        # if not self.find( "pesquisar", matching=0.97, waiting_time=10000):
        #     self.not_found("pesquisar")
        # self.click()
        
        self.browse("https://www.hashtagtreinamentos.com/")
        
        if not self.find( "curso_de_python", matching=0.97, waiting_time=10000):
            self.not_found("curso_de_python")
        
        
        if not self.find( "click_curso", matching=0.97, waiting_time=10000):
            self.not_found("click_curso")
        self.click()
        
        if not self.find( "curso_python2", matching=0.97, waiting_time=10000):
            self.not_found("curso_python2")

        if not self.find( "tela_carregada", matching=0.97, waiting_time=10000):
            self.not_found("tela_carregada")

        self.scroll_down(500)
        
        if not self.find( "primeiro_nome", matching=0.97, waiting_time=10000):
            self.not_found("primeiro_nome")
        self.click()
        
        self.paste("Teste")
        
        if not self.find( "email", matching=0.97, waiting_time=10000):
            self.not_found("email")
        self.click()
        
        self.paste("nada@teste.com")
        
        if not self.find( "numero", matching=0.97, waiting_time=10000):
            self.not_found("numero")
        self.click()
        
        self.paste("15999999999")
        
        if not self.find( "enviar", matching=0.97, waiting_time=10000):
            self.not_found("enviar")
        self.click()        

        # Uncomment to mark this task as finished on BotMaestro
        # self.maestro.finish_task(
        #     task_id=execution.task_id,
        #     status=AutomationTaskFinishStatus.SUCCESS,
        #     message="Task Finished OK."
        # )

    def not_found(self, label):
        print(f"Element not found: {label}")


if __name__ == '__main__':
    Bot.main()



