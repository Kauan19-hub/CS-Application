using System;
using System.Collections.Generic;
using System.Linq;

// Classe principal (POO em C#)
class Program
{

    // Lista, controle e método
    static List<Usuario> usuarios = new List<Usuario>();
    static int proximoId = 1;
    static void Main()

    {
        int opcao;

        // Loop
        do
        {
            Console.Clear();
            Console.WriteLine("1. Cadastrar usuário");
            Console.WriteLine("2. Listar usuários");
            Console.WriteLine("3. Editar usuário");
            Console.WriteLine("4. Remover usuário");
            Console.WriteLine("5. Encerrar");
            Console.WriteLine("Escolha uma das opções");

            // Ler a opção escolhida
            opcao = int.Parse(Console.ReadLine());

            // Direciona à função correspondente, oferece 4 opções de CRUD ao usuário com SWITCH CASE
            switch (opcao)
            {
                case 1:
                    Cadastrar();
                    break;

                case 2:
                    Listar();
                    break;

                case 3:
                    Editar();
                    break;

                case 4:
                    Excluir();
                    break;
            }

        } while (opcao != 0); // Enquanto não escolher a opção de sair
    }

    // Cadastrar usuário
    static void Cadastrar()
    {
        Console.Clear();
        Usuario u = new Usuario();

        u.Id = proximoId++;
        Console.Write("Nome: ");
        u.Nome = Console.ReadLine();

        Console.Write("E-mail: ");
        u.Email = Console.ReadLine();

        usuarios.Add(u);

        Console.WriteLine("\nUsuário cadastrado");
        Console.ReadKey();

    }

    // Listar usuários
    static void Listar()
    {
        Console.Clear();
        Console.WriteLine("=== LISTA DOS USUÁRIOS ===\n");

        if (usuarios.Count == 0)
        {
            Console.WriteLine("Nenhum usuário foi cadastrado");
        }
        else
        {
            foreach (var u in usuarios)
            {
                Console.WriteLine($"ID: {u.Id} | Nome: {u.Nome} | E-mail: {u.Email}");
            }
        }

        Console.ReadKey();
    }

    // Editar usuários
    static void Editar()
    {
        Console.Clear();
        Console.Write("Escreva o ID do usuário: ");
        int id = int.Parse(Console.ReadLine());

        var usuario = usuarios.FirstOrDefault(u => u.Id == id);

        if (usuario == null)
        {
            Console.WriteLine("Usuário não identificado");
        }
        else
        {
            Console.Write("Novo nome: ");
            usuario.Nome = Console.ReadLine();

            Console.Write("Novo e-mail: ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("\nUsuário atualizado");
        }

        Console.ReadKey();
    }

    // Remover usuários
    static void Remover()
    {
        Console.Clear();
        Console.Write("Escreva o ID do usuário: ");
        int id = int.Parse(Console.ReadLine());

        var usuario = usuarios.FirstOrDefault(u => u.Id == id);

        if (usuario == null)
        {
            Console.WriteLine("Usuário não identificado");
        }
        else 
        {
            usuarios.Remove(usuario);
            Console.WriteLine("\nUsuário removido");
        }

        Console.ReadKey();
    }
}

class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
}