using System;
using System.IO;
using System.Linq;

namespace Aula2{
    class Program{
        static void Main(string[] args){
            Exerc10();
        } // End main

        static void Exerc10(){
            StreamReader file_in;
            StreamWriter file_out;
            string path_in, path_out, max_name;
            int max_population=0;

            Console.Write("Informe o arquivo de entrada: ");
            path_in = Console.ReadLine();

            Console.Write("Informe o arquivo de saida: ");
            path_out = Console.ReadLine();

            if(File.Exists(path_in)){
                try{
                    file_in = new StreamReader(path_in);
                    string[] data = file_in.ReadToEnd().Split('');
                    file_in.Close();

                    for (int i=1; i<data.Length; i+=2){
                        try{ // Gambeta 
                            Console.WriteLine(Int32.Parse(data[i]));
                        } catch (Exception e){
                            Console.WriteLine(e);
                        }
                    }
                    


                } catch (Exception e){
                    Console.WriteLine("Problemas ao ler o arquivo!");
                    Console.WriteLine("Exceção: " + e);
                }
            } else{
                Console.WriteLine("Arquivo " + path_in + " não existe!");
            }
            


        }

        static void Exerc9(){
            StreamReader file_in;
            StreamWriter file_out;
            string[] file_paths = new string[2];
            string[] data = new string[2];

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
                }
            }

            file_out = new StreamWriter("file_out.txt");
            foreach (string content in data){
                Console.WriteLine(content);
                file_out.WriteLine(content);
            }
            file_out.Close();
        }

        static void Exerc6(){
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

        static void Exerc5(){
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

        static void Exerc2(){
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
    } // End class Program
}
