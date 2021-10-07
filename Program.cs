using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{	
					case "0":
						DicasSeries();
						break;
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "6":
						proLancamento();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}

        private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
			genero: (Genero)entradaGenero,
			titulo: entradaTitulo,
			ano: entradaAno,
			descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}

		private static void proLancamento(){

			Console.WriteLine(" __Chucky__ / Gênero: Terror / Lançamento: 12 de outubro de 2021");
			Console.WriteLine(" Sinopse: Chucky é uma próxima série de televisão americana de terror criada por Don Mancini com base na franquia \r\n Child's Play. Sua estreia será na Syfy e na USA Network em 12 de outubro de 2021. A série serve como uma \r\n continuação de Cult of Chucky, o sétimo filme da franquia. ");
			Console.WriteLine();
			Console.WriteLine(" __Hawkeye - Gavião Arqueiro__ / Gênero: Ação / Lançamento:  24 de novembro de 2021");
			Console.WriteLine(" Sinopse: Clint Barton e Kate Bishop atiram flechas e tentam evitar se transformarem em alvos. ");	
			Console.WriteLine();
			Console.WriteLine(" __She-Hulk__ / Gênero: Superaventura / Lançamento: 2022");
			Console.WriteLine(" Sinopse: She-Hulk é uma futura série de televisão estadunidense de super-herói criada por Jessica Gao para o Disney+, \r\n baseada na personagem Jennifer Walters / Mulher-Hulk da Marvel Comics. É ambientado no Universo \r\n Cinematográfico Marvel, compartilhando continuidade com os filmes da franquia. ");	
			Console.WriteLine();
			Console.WriteLine(" __Moon Knight__ / Gênero: Superaventura / Lançamento: 2022");
			Console.WriteLine(" Sinopse: Moon Knight é uma futura minissérie norte-americana de super-herói criada por Jeremy Slater para o Disney+, \r\n baseada no personagem Marc Spector / Cavaleiro da Lua da Marvel Comics. É ambientada no Universo \r\n Cinematográfico Marvel, compartilhando continuidade com os filmes da franquia.  ");
			 

		}

		private static void DicasSeries()
		{	
			Console.WriteLine("Escolha um Gênero:");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			
			string entradaDica = (Console.ReadLine());

			switch (entradaDica)
				{	
					case "1":
						Console.WriteLine("\r\n Dica de Ação: \r\n ___The Boys___ \r\n Um dos principais seriados de ação da rival Amazon Prime Video, The Boys traz uma visão mais pessimista \r\n sobre a existência de super-heróis em nossa sociedade. Inspirada em uma história em quadrinhos, a paródia \r\n acompanha um grupo de indivíduos cujo objetivo é acabar com os super indivíduos.");
						break;
					case "2":
						Console.WriteLine("\r\n Dica de Aventura: \r\n ___O Falcão e o Soldado do Inverno___ \r\n Falcão e o Soldado Invernal são obrigados a formar uma dupla incompatível e embarcarem em uma aventura global \r\n que deve testar tanto suas habilidades de sobrevivência quanto sua paciência.");
						break;
					case "3":
						Console.WriteLine("\r\n Dica de Comédia: \r\n ___Friends___ \r\n Friends tinha que ser a primeira série a ocupar essa lista não é mesmo!? Isso porque ela é prestigiada por \r\n muitos, e contém nada mais nada menos do que 236 episódios. A história gira em torno de um grupo de amigos \r\n que vive em Manhattan, em Nova York. O elenco principal conta com Jennifer Aniston (Rachel), \r\n Courteney Cox (Monica), Lisa Kudrow (Phoebe), Matt LeBlanc (Joey), Matthew Perry (Chandler) e \r\n David Schwimmer (Ross) que trazem situações do dia a dia com muito humor.");
						break;
					case "4":
						Console.WriteLine("\r\n Dica de Documentario: \r\n ___Nosso Planeta___ \r\n Podemos concordar que o planeta Terra vive uma de suas maiores crises ambientais de todos os tempos. \r\n Nosso Planeta é uma série documental que apresenta imagens de tirar o fôlego revelando a diversidade das belezas \r\n naturais que ainda estão entre nós. Dos mesmos criadores de Planeta Terra e Planeta Azul, esta série original \r\n emociona com sua fotografia exuberante e curiosidades fascinantes sobre o nosso planeta.");
						break;
					case "5":
						Console.WriteLine("\r\n Dica de Drama: \r\n ___Dark___ \r\n Os mistérios sombrios de uma pequena cidade alemã são expostos quando duas crianças desaparecem. Enquanto as famílias \r\n procuram os dois desaparecidos, eles descobrem uma trama de indivíduos conectados com a história conturbada da cidade.");
						break;
					case "6":
						Console.WriteLine("\r\n Dica de Espionagem: \r\n ___AGENT CARTER___ \r\n Agent Carter conta a história Peggy Carter (Hayley Atwell). O ano é 1946, e Peggy se vê marginalizada quando \r\n  os soldados da Segunda Guerra retornam ao lar. Trabalhando para a SSR (Reserva Científica Estratégica), \r\n Peggy precisa conciliar os afazeres administrativos com as missões secretas para Howard Stark \r\n (Dominic Cooper), ao mesmo tempo que leva uma vida de solteira após perder o seu amor, Steve Rogers");
						break;
					case "7":
						Console.WriteLine("\r\n Dica de Faroeste: \r\n ___WESTWORLD___ \r\n Uma mescla de faroeste e ficção científica, Westworld é uma adaptação para a telinha do filme homônimo de 1973 \r\n estrelado por Yul Brynner e James Brolin. Situada em um futuro não tão distante, em que humanos frequentam parques \r\n temáticos e interagem com robôs que sequer desconfiam de sua própria natureza, a trama explora o que \r\n  aconteceria se as máquinas questionassem sua submissão ao homem. Uma das melhores surpresas de 2016, a série \r\n irá ganhar a segunda temporada ainda este ano.");
						break;
					case "8":
						Console.WriteLine("\r\n Dica de Fantasia: \r\n ___Sweet Tooth___ \r\n Em uma perigosa aventura em um mundo pós-apocalíptico, um adorável menino-cervo sai em busca de um novo começo na \r\n companhia de um protetor rabugento.");
						break;
					case "9":
						Console.WriteLine("\r\n Dica de Ficcao_Cientifica: \r\n ___3%___ \r\n Em um futuro não muito distante, o planeta é um lugar devastado. Aos 20 anos, todo cidadão recebe a chance de \r\n passar por uma rigorosa seleção para ascender ao Maralto, uma região farta de oportunidades. \r\n Porém, apenas 3% consegue chegar lá.");
						break;
					case "10":
						Console.WriteLine("\r\n Dica de Musical: \r\n ___Glee___ \r\n Glee é a mais famosa série do gênero, que conta com seis temporadas e se foca nos membros do clube de canto da \r\n Escola William McKinley. Mostra todos os problemas enfrentados por eles, como suas sexualidades e bullying por causa \r\n delas, etnia, relacionamentos e conflitos internos. A maior parte das músicas são covers muito bem executados. ");
						break;
					case "11":
						Console.WriteLine("\r\n Dica de Romance: \r\n ___Anatomia de Grey___ \r\n A série médica de enorme sucesso foca em um grupo de jovens médicos do Hospital Grace Mercy West, \r\n de Seattle, que começaram a carreira na própria instituição como residentes. Um dos jovens médicos que dá nome ao show, Meredith Grey, \r\n é filha de um famoso cirurgião. Meredith luta para manter as relações com seus colegas, especialmente o \r\n chefe do centro cirúrgico, Richard Webber, devido ao relacionamento que já existia entre os dois -- Webber teve um caso com a mãe de \r\n Meredith na época em que ela era jovem.");
						break;
					case "12":
						Console.WriteLine("\r\n Dica de Suspense: \r\n ___Slasher___ \r\n Slasher é uma série de televisão canadense antológica de terror. Produzida em associação com a rede canadense \r\n Super Channel, é a primeira série original da Chiller, que a estreou em 4 de março de 2016. A Super Channel a estreou no Canadá \r\n em 1 de abril de 2016.");
						break;
					case "13":
						Console.WriteLine("\r\n Dica de Terror: \r\n ___The Walking Dead___ \r\n Baseado na história em quadrinhos escrita por Robert Kirkman, este drama potente e visceral retrata a vida nos \r\n Estados Unidos pós-apocalíptico. Um grupo de sobreviventes, liderado pelo policial Rick Grimes, segue viajando em \r\n busca de uma nova moradia segura e distante dos mortos-vivos. A pressão para permanecerem vivos e lutarem \r\n pela sobrevivência faz com  que muitos do grupo sejam submetidos às mais profundas formas de crueldade humana. Rick acaba \r\n descobrindo que o tão assustador desespero pela subsistência pode ser ainda mais fatal do que os próprios mortos-vivos que os rodeiam.");
						break;
					case "14":
						Console.WriteLine("\r\n Dica de Biográfico: \r\n ___AnneFrank. Parallel Stories___ \r\n O primeiro título da lista é o documentário AnneFrank - Parallel Stories, lançado em 2019, que pelo \r\n nome você pode até desconfiar do que se trata. Anne Frank foi uma jovem judia e vítima do Holocausto provocado pelo \r\n nazismo, que foi assassinada no campo de concentração de Bergen-Belsen, na Alemanha, quando tinha apenas 16 anos. \r\n Enquanto passou dois anos se escondendo dos nazistas, ela escrevia em um diário para contar um pouco da sua história e relatando os \r\n momentos que estava vivendo, e suas anotações se tornaram inspiração para diversas obras.");
						break;
					case "15":
						Console.WriteLine("\r\n Dica de Comédia_dramática: \r\n ___Todas as Mulheres do Mundo___ \r\n Diferentes histórias de amor se cruzam com a jornada de Paulo (Emilio Dantas), um jovem que já namorou diversas \r\n mulheres. No entanto, sua vida amorosa muda quando ele conhece a encantadora Maria Alice (Sophie Charlotte) \r\n acreditando que encontrou a mulher da sua vida.");
						break;
					case "16":
						Console.WriteLine("\r\n Dica de Comédia_romântica: \r\n ___The Ranch___ \r\n Após uma breve e fracassada carreira no futebol americano, Colt retorna para administrar o \r\n rancho da família ao lado de seu irmão Jameson e seu pai Beau, que ele não via há 15 anos.");
						break;
					case "17":
						Console.WriteLine("\r\n Dica de História: \r\n ___A Bíblia___ \r\n Acompanhe os episódios mais significativos do texto sagrado do Antigo e Novo Testamento, como a jornada \r\n de Noé na arca, o Êxodo e a vida de Jesus.");
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

			

		}

        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());			

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
			genero: (Genero)entradaGenero,
			titulo: entradaTitulo,
			ano: entradaAno,
			descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Lucas Decola Tech a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("0- Dicas de Séries");
			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("6- Próximos Lançamentos");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
