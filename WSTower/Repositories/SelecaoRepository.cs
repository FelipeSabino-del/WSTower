using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Contexts;
using WSTower.Domains;
using WSTower.Interfaces;

namespace WSTower.Repositories
{
    public class SelecaoRepository : RepositoryBase<Selecao>, ISelecaoRepository
    {
        WSTowerContext ctx = new WSTowerContext();
        int vitorias, empates = 0;

        public IEnumerable<Selecao> OrdemNome()
        {
            IEnumerable<Selecao> selecaos = GetAll();

            return selecaos.OrderBy(s => s.Nome).ToList();
        }

        public int Pontos(int id)
        {
            Selecao selecao = GetById(id);

            int pontos = 0;
            int vitorias = 0;
            int empates = 0;

            foreach (var item in selecao.JogoSelecaoCasaNavigation)
            {
                var vitoria = selecao.JogoSelecaoCasaNavigation.Any(j => j.PlacarCasa > j.PlacarVisitante);
                var empate = selecao.JogoSelecaoCasaNavigation.Any(j => j.PlacarCasa == j.PlacarVisitante);

                if (vitoria)
                {
                    vitorias += 1;
                }

                if (empate)
                {
                    empates += 1;
                }
            }

            foreach (var item in selecao.JogoSelecaoVisitanteNavigation)
            {
                var vitoria = selecao.JogoSelecaoVisitanteNavigation.Any(j => j.PlacarCasa < j.PlacarVisitante);
                var empate = selecao.JogoSelecaoVisitanteNavigation.Any(j => j.PlacarCasa == j.PlacarVisitante);

                if (vitoria)
                {
                    vitorias += 1;
                }

                if (empate)
                {
                    empates += 1;
                }
            }

            return pontos = (vitorias * 3) + empates;

        }

        public Dictionary<Selecao, int> OrdemPontos(int id)
        {
            Dictionary<Selecao, int> dicionario = new Dictionary<Selecao, int>();
            IEnumerable<Selecao> selecaos = GetAll();

            foreach (Selecao item in selecaos)
            {
                var pontos = Pontos(item.Id);
                dicionario.Add(item, pontos);

            }

           

            return dicionario;
        }
    }
}
