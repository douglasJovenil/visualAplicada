using System;
using System.IO;
using System.Linq;

namespace Aula2{
    class Program{
        static void Main(string[] args){
            Exerc6();
        } // End main

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
