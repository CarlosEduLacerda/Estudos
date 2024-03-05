import os
from PIL import Image

nome_imagem = input("Digite o nome da imagem: ")
formato = input("Para qual formato deseja converter a imagem: ")

extensoes_suportadas = ('bmp', 'eps', 'gif', 'icns', 'ico', 'im', 'jpg', 'jpeg', 'msp', 'pcx', 'png', 'ppm', 'psd', 'tiff', 'tif', 'webp', 'xv')

if nome_imagem.split('.')[-1].lower() not in extensoes_suportadas:
    print(f"Formato de imagem não suportado. Por favor, use uma imagem nos formatos: {extensoes_suportadas}")
else:
    try:
        imagem = Image.open(nome_imagem)
        imagem_convertida = imagem.convert('RGB')

        caminho_sem_extensao = os.path.splitext(nome_imagem)[0]

        imagem_convertida.save(f'{caminho_sem_extensao}.{formato}')
        print(f'Imagem convertida com sucesso para {caminho_sem_extensao}.{formato}')
    except Exception as e:
        print(f"Erro ao converter a imagem: {e}")
