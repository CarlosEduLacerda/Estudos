import pandas as pd
import numpy as np
import matplotlib.pyplot as plt

arquivo_onda_1 = 'Onda_Endereco_2__o_Retorno.xlsx'
arquivo_onda_2 = 'Onda_Endereco_3__o_Retorno.xlsx'
arquivo_onda_3 = 'Ondas.xlsx'

df_a1 = pd.read_excel(arquivo_onda_1)
df_a2 = pd.read_excel(arquivo_onda_2)

df_a1_a2 = pd.concat([df_a1, df_a2])

# print(df_a1_a2['CNPJ do Cliente'])

total_cidades = df_a1_a2.groupby(['Cidade do Cliente'])

total_cidades = total_cidades.size()

print(total_cidades)

total_cidades.plot(kind='line')
plt.show()