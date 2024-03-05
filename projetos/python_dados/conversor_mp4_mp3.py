import os
from moviepy.editor import VideoFileClip

# Digite o PATH aqui
arquivo_entrada = r""

try:
    if not arquivo_entrada.lower().endswith('.mp4'):
        print(f"Formato de vídeo não suportado. Por favor, use um vídeo no formato MP4")
    else:
        arquivo_de_video = VideoFileClip(arquivo_entrada)
        audio_extraido = arquivo_de_video.audio

        caminho_sem_extensao, _ = os.path.splitext(arquivo_entrada)[0]

        arquivo_saida_audio = f"{caminho_sem_extensao}.mp3"

        audio_extraido.write_audiofile(arquivo_saida_audio)

        audio_extraido.close()
        arquivo_de_video.close()

        os.system("cls")
        print(f"Arquivo convertido com sucesso. Você pode acessa-lo em {caminho_sem_extensao}")

except Exception as e:
    print(f"Erro ao converter o arquivo: {e}")
