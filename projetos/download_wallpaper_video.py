import pytube
import os

os.system("cls")

link = input("Digite o link do vídeo que deseja baixar: ")

yt = pytube.YouTube(link)

yt.streams.filter(progressive=True, file_extension='mp4').order_by('resolution').desc().first().download('Downloads')

print("Download concluído")