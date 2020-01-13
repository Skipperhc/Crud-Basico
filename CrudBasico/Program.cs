using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBasico {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa = new Pessoa();

            pessoa.AdicionarPessoa();
            pessoa.AdicionarPessoa();
            pessoa.AdicionarPessoa();
            pessoa.AdicionarPessoa();

            pessoa.ListarPessoa();

            Console.WriteLine(pessoa.refinarPessoa(Console.ReadLine())[0].Nome);

            pessoa.ListarPessoa();

            pessoa.remover(Console.ReadLine());

            pessoa.ListarPessoa();

            pessoa.refinar(Console.ReadLine());

            pessoa.ListarPessoa();

            pessoa.Editar(Console.ReadLine());

            pessoa.ListarPessoa();

        }
    }

    class Pessoa {
        public List<Pessoa> Lista = new List<Pessoa>();
        public string Nome { get; set; }

        public void AdicionarPessoa() {
            Lista.Add(new Pessoa() {
                Nome = Console.ReadLine()
            });
        }

        public void ListarPessoa() {
            foreach (var person in Lista) {
                Console.WriteLine(person.Nome);
            }
        }

        public void refinar(string nome) {
            Lista = Lista.FindAll(x => x.Nome == nome);
        }

        public List<Pessoa> refinarPessoa(string nome) {
            return Lista.FindAll(x => x.Nome == nome);
        }

        public void remover(string nome) {
            int Local = Lista.FindIndex(x => x.Nome == nome);
            Lista.RemoveAt(Local);
        }

        public void Editar(string nome) {
            int Local = Lista.FindIndex(x => x.Nome == nome);
            string novonome = Console.ReadLine();
            Lista[Local] = new Pessoa() { Nome = novonome };
        }
    }
}
