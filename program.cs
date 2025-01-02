Musica musica1 = new Musica();
musica1.nome = "Radio GaGa";
musica1.artista = "Queen";
musica1.duracao = 300;
musica1.EscreveDisponivel(true); 
Musica musica2 = new Musica();
musica2.nome = "Bohemian Rapsody";
musica2.artista = "Queen";
musica2.duracao = 200;
musica2.EscreveDisponivel(false);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();