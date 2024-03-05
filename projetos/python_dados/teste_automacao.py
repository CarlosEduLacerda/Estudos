from selenium import webdriver
from selenium.webdriver.common.by import By

navegador = webdriver.Chrome()

navegador.get('https://ri.magazineluiza.com.br/ListResultados/Default.aspx')
navegador.maximize_window()
navegador.find_element("xpath", '//*[@id="Form1"]/div[7]/a').click()
navegador.find_element(By.ID, 'ContentInternal_linkCentral').click()

input("Pressione Enter para fechar o navegador...")

navegador.quit()