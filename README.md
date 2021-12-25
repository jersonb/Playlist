# Playlist

> Primeira parte dos meus estudos sobre estrutura de dados.
> Resolvi começar justo por uma estrutura que já me salvou no passado.

## Projeto Playlist

> Implementado na mão, sem uso das abstrações de Lista do C#, apenas array.
> Confeço que sofri pra implementar a parte onde o array aumenta conforme o necessário, por exemplo o código abaixo.

```csharp
        public void AddAfter(Music after, Music music)
        {
            var musics = new Music[1];
            var refMusic = Music;
            var i = 0;

            while (refMusic != null)
            {
                Array.Resize(ref musics, i + 1);
                musics.SetValue(refMusic, i++);

                if (refMusic.Equals(after))
                {
                    Array.Resize(ref musics, i + 1);
                    musics.SetValue(music, i++);
                }
                refMusic = refMusic.Next;
            }

            SetPlayList(musics);
        }
```

## Projeto Playlist2

> Implementado com a abstração LinkedList do C#.
> Foi bem fácil pra desenvolver. 
