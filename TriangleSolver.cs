using System;
namespace TriangleSolverSpace {
public static class TriangleSolver{
    public static string Analyze(int x,int y,int z){
        if(x + y >= z && z + y >= x && z + x >= y){
            if(x == y && x == z){
                return "Equilátero";
            }
            if((x == y && (x != z && y != z)) || (x == z && (x != y && z != y)) || (y == z && (y != x && z != x))){
                return "Isósceles";
            }
            if(x != y && x != z){
                return "Escaleno";
            }
        }
        return "Não formam um triângulo!";
            }
        }
  }