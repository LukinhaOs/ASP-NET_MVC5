using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MVC5_Parte_2.Models
{
    public class Noticia
    {
        public int NoticiasID { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsMaterias()
        {
            var dados = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiasID = 1,
                    Categoria = "Esportes",
                    Titulo = "Airton Senna",
                    Conteudo = "Airton Senna ganhou mais uma copa mundial. Dessa vez foi dificil " +
                    " para o nosso herói de corrida! Mas a vitória é plena cercada de torcedores que acompanharam o momento",
                    Data = new DateTime (2015, 5, 22)
                },

                new Noticia
                {
                    NoticiasID = 2,
                    Categoria = "Comidas",
                    Titulo = "Barra de chocolate Trento",
                    Conteudo = "Uma deliciosa barra feita com 50% Chocolate está ficando cada vez mais famosa " +
                    " a empresa Trento está lucrando a cada dia, são 35 milhões de barras vendidades em uma única semana! Um sucesso para a StartUp Trento...",
                    Data = new DateTime (2022, 11, 05)
                },

                new Noticia
                {
                    NoticiasID = 3,
                    Categoria = "Entretenimento",
                    Titulo = "O novo console da gigante Microsoft, Xbox Series X",
                    Conteudo = "Em quanto menos se espera podemos ser pegos de surpresa, algo totalmente imprevisível... Imaginando. " +
                    " Esta noite no The Game Awards, nada mais e nada menos Phil Spencer sobe ao palco para anunciar o novo console da Microsoft. Seguido de mais um novo lançamento no final" +
                    " O jogo 'HellBlade 2: Senua's Saga'",
                    Data = new DateTime (2019, 11, 27)
                },

                new Noticia
                {
                    NoticiasID = 4,
                    Categoria = "Tecnologia",
                    Titulo = "Star Link: Wi-fi via satélite agora é uma realidade?",
                    Conteudo = "O Multi Bilionario Elon Musk está criando um novo projeto chamado de Star Link" +
                    "Um nome curioso... Pensar que hoje já é possível de utilizar o Wi-fi fora da esferá Terrestre já não é mais uma visão para um futuro tão distante." +
                    "O projeto tem como objeto de simplesmente implantar dispositivos em satélites capazes de enviarem sinais Ghz para a terra em uma velocidade muito mais alta que as conexões atuais.",
                    Data = new DateTime (2022, 02, 25)
                },

                new Noticia
                {
                    NoticiasID = 5,
                    Categoria = "Economia",
                    Titulo = "A falta de educação financeira no Brasil",
                    Conteudo = "Investimento é um conhecimento que não pode ser tirado de você. Hoje menos de 10% da população Brasileira não tem interesse em criar um patrimônio a base de investimentos." +
                    "Ao se perguntar o que é uma corretora, por exemplo, muitos tem a visão de se assemelhar há um banco, ou ainda, simplesmente não tem ideia do que seja." + 
                    "A massiva parte da população Brasileira tem somente uma visão há curto prazo e desacreditam que é possível de enriquecer ao longo do tempo com um portifólio de investimentos, " +
                    "Seja na Bolsa de Valores, Criptomoedas, Imóveis e tantos outros tipos...",
                    Data = new DateTime (2022, 04, 15)
                }
            };

            return dados;
        }
    }
}