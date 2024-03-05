import os
from moviepy.editor import VideoFileClip

# Digite o PATH aqui
video_mp4 = r""

videoClip = VideoFileClip(video_mp4)

caminho_sem_extensao = os.path.splitext(video_mp4)[0]

videoClip.write_gif("video_mp4_convertido.gif")

os.system("cls")
print("Arquivo convertido com sucesso. Acesse C:/Users/TI para ver o arquivo.")