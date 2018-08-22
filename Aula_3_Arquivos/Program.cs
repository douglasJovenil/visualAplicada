using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace Aula_3_Arquivos {
    class Program {
        static void Main(string[] args){
            Exerc19();
        }

        static void Exerc19(){
            string file_name, line, max_student;
            StreamReader file;
            int max_note;
            string[] values;

            Console.Write("Informe o arquivo de entrada: ");
            file_name = Console.ReadLine();

            if (File.Exists(file_name)) {
                try {
                    file = new StreamReader(file_name);
                    max_note = 0;
                    max_student = "";

                    while ((line = file.ReadLine()) != null) {
                        values = line.Replace(":", "").Split(' ');
                        if (Int32.Parse(values[3]) > max_note){
                            max_note = Int32.Parse(values[3]);
                            max_student = values[1];
                        }
                    }
                    file.Close();
                    Console.WriteLine($"Estudante: {max_student} \t Maior nota: {max_note}");

                } catch (Exception e) {
                    Console.WriteLine($"Problemas ao ler o arquivo {file_name}");
                    Console.WriteLine($"Exceção: {e}");
                }
            } else {
                Console.WriteLine($"Arquivo {file_name} não encontrado");
            }
        }

        static void Exerc18(){
            StreamReader file;
            string file_name_in, line;
            float total_price = (float)0.00;

            Console.Write("Informe o arquivo de entrada: ");
            file_name_in = Console.ReadLine();

            if (File.Exists(file_name_in)) {
                try {
                    file = new StreamReader(file_name_in);
                    while((line = file.ReadLine()) != null){
                        total_price += float.Parse(line.Replace(" ", "").Split(";")[1]);
                    }
                    file.Close();

                    Console.WriteLine($"Preço total da compra: R${total_price}");
                } catch (Exception e) {
                    Console.WriteLine($"Problema as ler o arquivo {file_name_in}");
                    Console.WriteLine($"Exceção: {e}");
                }
            } else {
                Console.WriteLine($"Arquivo {file_name_in} não encontrado!");
            }
        }
  
        static void Exerc10() {
            string current_population = "", current_city = "", max_city= "";
            string path_in, path_out, line;
            StreamWriter file_out;
            StreamReader file_in;
            int max_population=0;

            Console.Write("Informe o arquivo de entrada: "); 
            path_in = Console.ReadLine();

            Console.Write("Informe o arquivo de saida: ");
            path_out = Console.ReadLine();

            if (File.Exists(path_in)) {
                try{
                    file_in = new StreamReader(path_in);
                    
                    while ((line = file_in.ReadLine()) != null) {
                        current_city = current_population = "";
                        for (int i = 0; i < line.IndexOf(';'); i++) current_city += line[i];
                        for (int i = line.IndexOf(' ') + 1; i < line.Length; i++) current_population += line[i];
                        if (Int32.Parse(current_population) > max_population){
                            max_population = Int32.Parse(current_population);
                            max_city = current_city;    
                        }
                    }
                    file_in.Close();

                    file_out = new StreamWriter(path_out);
                    file_out.WriteLine($"Cidade com a maior populacao: {max_city}");
                    file_out.WriteLine($"Populacao total: {max_population}");
                    file_out.Close();
                    Console.WriteLine($"Arquivo {path_out} criado com sucesso! ");


                } catch (Exception e) {
                    Console.WriteLine("Problemas ao ler o arquivo!");
                    Console.WriteLine($"Exceção: {e}");
                }
            } else {
                Console.WriteLine($"Arquivo {path_in} não encontrado!");
            }
        }

        static void Exerc9() {
            string[] file_paths = new string[2];
            string[] data = new string[2];
            string file_out_name = "file_out.txt";
            bool flag_file_error = false;
            StreamWriter file_out;
            StreamReader file_in;
            
            for (int i=0; i<file_paths.Length; i++){
                Console.Write("Informe o caminho do arquivo número " + (i+1) + ": ");
                file_paths[i] = Console.ReadLine();
            }

            for(int i=0; i<file_paths.Length; i++){
                if (File.Exists(file_paths[i])){
                    try{
                        file_in = new StreamReader(file_paths[i]);
                        data[i] = file_in.ReadToEnd();
                        file_in.Close();
                    } catch (Exception e){
                        Console.WriteLine("Problemas ao ler o arquivo!");
                        Console.WriteLine("Exceção: " + e);
                    }
                } else{
                    Console.WriteLine("O Arquivo " + file_paths[i] + " não existe!");
                    flag_file_error = true;
                }
            }

            if (!flag_file_error){
                file_out = new StreamWriter(file_out_name);
                foreach (string content in data){
                    Console.WriteLine(content);
                    file_out.WriteLine(content);
                }
                file_out.Close();
                Console.WriteLine($"Arquivo {file_out_name} criado com sucesso!");
            } else {
                Console.WriteLine("Falha ao criar o arquivo de saida!");
            }
        }

        static void Exerc6() {
            StreamReader my_file;
            string file_path;
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            int current_character, accumulator = 0;

            Console.Write("Informe o caminho do arquivo: ");
            file_path = Console.ReadLine();

            if(File.Exists(file_path)){
                try{
                    my_file = new StreamReader(file_path);

                    while((current_character = my_file.Read()) != -1){
                        foreach (char current_vowel in vowels){
                            accumulator += ((char)current_character == current_vowel) ? 1 : 0;
                        }
                    }
                    my_file.Close();
                    Console.WriteLine("Total de vogais: " + accumulator);

                } catch (Exception e){
                    Console.WriteLine("Problemas ao ler o arquivo!");
                    Console.WriteLine("Exceção: " + e);
                }
            } else{
                Console.WriteLine("Arquivo não encontrado!");
            }
            
        }

        static void Exerc5() {
            StreamReader my_file;
            string file_path, line;
            char character;
            int accumulator = 0;

            Console.Write("Informe o caminho do arquivo: ");
            file_path = Console.ReadLine();
            Console.Write("Informe o caractere: ");
            character = Console.ReadKey().KeyChar;
            Console.ReadLine();

            if (File.Exists(file_path)){
                try{
                    my_file = new StreamReader(file_path);
                    
                    while((line = my_file.ReadLine()) != null){
                        foreach (char current_character in line){
                            accumulator += (current_character == character) ? 1 : 0;
                        }
                    }
                    my_file.Close();
                    Console.WriteLine("Ocorrências de " + character + " no arquivo " + file_path + ": " + accumulator);

                }catch (Exception e){
                    Console.WriteLine("Problemas ao ler o arquivo!");
                    Console.WriteLine("Exceção: " + e);   
                }
            } else{
                Console.WriteLine("Arquivo não existe!");
            }
        }

        static void Exerc2() {
            StreamReader my_file;
            string file_path, line;
            int accumulator = 1;

            Console.Write("Informe o caminho do arquivo: ");
            file_path = Console.ReadLine();
            
            if(File.Exists(file_path)){
                try{
                    my_file = new StreamReader(file_path);
                    while ((line = my_file.ReadLine()) != null){
                        accumulator++;
                    }
                    my_file.Close();
                    Console.WriteLine("Total de linhas do arquivo " + file_path + ": " + accumulator);
                } catch (Exception e){
                    Console.WriteLine("Problemas ao ler o arquivo!");
                    Console.WriteLine("Exceção: " + e);
                }
            } else{
                Console.WriteLine("Arquivo não existe!");
            }
        }      
        
        static void Exerc15(){
            int current_year = Int32.Parse(DateTime.Today.ToString("yyyy"));
            string file_name_in, file_name_out, line, condition;
            StreamReader file_in;
            StreamWriter file_out;
            string[] values;
            int age;

            Console.Write("Informe o arquivo de entrada: ");
            file_name_in = Console.ReadLine();
            file_name_in = @"src\Exerc15_in.txt";

            Console.Write("Informe o arquivo de saida: ");
            file_name_out = Console.ReadLine();

            if (File.Exists(file_name_in)){
                try {
                    file_in = new StreamReader(file_name_in);
                    file_out = new StreamWriter(file_name_out);

                    while((line = file_in.ReadLine())!= null){
                        values = line.Replace(" ", "").Split(';');
                        age = current_year - Int32.Parse(values[1]);

                        if (age < 18){
                            condition = "Menor de idade";
                        } else if (age > 18){
                            condition = "Maior de idade";
                        } else {
                            condition = "Entrando na maior idade";
                        }

                        file_out.WriteLine($"Nome: {values[0]} \t Idade: {age} \t Condicao: {condition}");
                    }
                    file_in.Close();
                    file_out.Close();
                    Console.WriteLine($"Arquivo {file_name_out} criado com sucesso!");

                } catch (Exception e) {
                    Console.WriteLine($"Problemas ao ler o arquivo {file_name_in}");
                    Console.WriteLine($"Exceção: {e}");
                }

            } else {
                Console.WriteLine($"Arquivo {file_name_in} não encontrado!");
            }

        }

        static void Exerc13() {
            List<string> names, phones;
            string file_name;
            StreamWriter file;
            int i;

            Console.Write("Informe o arquivo de saida: ");
            file_name = Console.ReadLine();

            try{
                file = new StreamWriter(file_name);
                names = new List<string>();
                phones = new List<string>();
                i = -1;

                do {
                    Console.Write("Informe o nome: ");
                    names.Add(Console.ReadLine());
                    Console.Write("Informe o telefone: ");
                    phones.Add(Console.ReadLine());
                    i++;
                } while (phones[i] != "0");

                for (int j = 0; j < names.Count - 1; j++) file.WriteLine($"Nome: {names[j]} \t Telefone: {phones[j]}");
                file.Close();

            } catch (Exception e) {
                Console.WriteLine($"Problemas ao gravar o arquivo {file_name}");
                Console.WriteLine($"Exceção: {e}");
            }
        }

    }
}
