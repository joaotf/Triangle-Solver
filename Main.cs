using System;
using TriangleSolverSpace;

namespace MyNamespace {
public class MyMainClass {
    public static void Main() {
        int menu = 0;
        int x=0,y=0,z=0;
        while(menu != 2){
            Console.Write("1.Enter triangle dimensions\n2.Exit\nOption =>");
            var d = Console.ReadLine();
            if(int.TryParse(d,out menu))
                Console.WriteLine("\n\n");
            else
                Console.WriteLine("Digite uma opção válida!");
            switch(menu){
                case 1:{
                    Console.WriteLine("Digite o valor de X");
                    var a = Console.ReadLine();
                    if(int.TryParse(a,out x))
                        Console.WriteLine("");
                    else
                        break;

                    Console.WriteLine("Digite o valor de Y");
                    var b = Console.ReadLine();
                    if(int.TryParse(b,out y))
                        Console.WriteLine("");
                    else
                        break;

                    Console.WriteLine("Digite o valor de Z");
                    var c = Console.ReadLine();
                    if(int.TryParse(c,out z))
                        Console.WriteLine("");
                    else
                        break;
                    string resposta = TriangleSolver.Analyze(x,y,z);
                    if(resposta != "Não formam um triângulo!"){
                        Console.WriteLine("Os números fornecidos formam um triângulo!\nTipo : {0}",resposta);
                    }else
                        Console.WriteLine(resposta);
                        break;
                    }
                case 2:{
                    break;
                }
                }
            }
        }
  }
  }