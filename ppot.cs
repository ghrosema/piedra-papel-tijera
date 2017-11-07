/*
 * 
 * Piedra, papel o tijera
 * programación funcional
*/

using System;

public class PiedraPapelOTijera
{
    static public void Main(string[] args)
    {
		//Declaración de variables para contar rondas y resultados de las mismas
		
        int rondas = 0;
        int empates =0 , humano = 0, computadora = 0;
        string jugadas;

        //Ejecuta la función/rutina de bienvenida que devuelve la letra de opción.
        //Se almacena la entrada del usuario en la variable "menu"
        string menu=imprimirBienvenidaYMenuPrincipal();


        //Mientras en el menú no se ingrese "s" para salir se juega de a 3 rondas
        while(menu != "s"){
            if (rondas == 3)
            {
                //Si se cumplieron las tres rondas
                Console.Clear();
                arbitro(empates,humano,computadora);
                Console.ReadLine();
                Console.Clear();
                rondas = 0;
                menu=imprimirBienvenidaYMenuPrincipal();

            }
            else
            {
                //Bloque de ejecución de ronda
                //Se incrementan los contadores de resultados
                jugadas = jugada();
                if (jugadas=="e"){
                    empates++;
                }else{
                    if(jugadas=="c"){
                        computadora++;
                    }else{
                        humano++;
                    }
                }
                rondas++;
            }

        }

      }



//Funciones/rutinas

    //Función de número aleatorio

    public static int jugadaAleatoria()
    {
        Random aleatorio = new Random();
        //Generación de número aleatorio entre 1 y 3
        int numero = aleatorio.Next(1, 4);
        return numero;
        }
    
    //Función para imprimir mensaje de bienvendida y menú principal
    public static string imprimirBienvenidaYMenuPrincipal(){
		string prueba = @"
Bienvenidx a:
       _          _                                      _         
 _ __ (_) ___  __| |_ __ __ _     _ __   __ _ _ __   ___| |   ___  
| '_ \| |/ _ \/ _` | '__/ _` |   | '_ \ / _` | '_ \ / _ \ |  / _ \ 
| |_) | |  __/ (_| | | | (_| |_  | |_) | (_| | |_) |  __/ | | (_) |
| .__/|_|\___|\__,_|_|  \__,_( ) | .__/ \__,_| .__/ \___|_|  \___/ 
|_|                          |/  |_|         |_|                   
 _   _  _                
| |_(_)(_) ___ _ __ __ _ 
| __| || |/ _ \ '__/ _` |
| |_| || |  __/ | | (_| |
 \__|_|/ |\___|_|  \__,_|
     |__/                

J-Jugar
S-Salir de juego
";
		Console.WriteLine(prueba);
        string ingreso = Console.ReadLine();
        return ingreso;
    }


    //Función de jugada
    public static string jugada()
    {
        //ACSII art de las señas del juego
        string piedraH, piedraC, papelH, papelC, tijeraH, tijeraC;
        piedraH = @" 
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";
        piedraC = @"
  _______
 (____   '---
(_____)      
(_____)      
 (____)      
  (___)__.---
";
        papelH = @"
    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)
";
        papelC = @"
       _______    
  ____(____   '---
 (______          
(_______          
 (_______         
  (__________.---
";
        tijeraH = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)

";
        tijeraC = @"
       _______    
  ____(____   '---
 (______          
(__________       
      (____)      
       (___)__.---
";
		
        //Limpia el menú principal e invita al usuario a realizar una jugada
        Console.Clear();
        Console.WriteLine("elija una opción\n\n1-piedra\n" + piedraH + "\n2-papel\n" + papelH + "\n3-tijera\n" + tijeraH + "\n");

        int jugada = int.Parse(Console.ReadLine());
        int jugadaComputadora = jugadaAleatoria();

        //Si hay empate de devuelve "e". si gana la computadora se devuelve "c" y si gana el jugador se devuelve "h"

        //Jugador humano elige piedra
        if (jugada == 1)
        {
            if (jugadaComputadora == 1)
            {
                Console.Clear();
                Console.Write(piedraH + piedraC + "\nEmpate!!!");
                Console.ReadLine();
                return "e";
            }
            else
            {
                if (jugadaComputadora == 2)
                {
                    Console.Clear();
                    Console.Write(piedraH + papelC + "\nPerdiste!!!");
                    Console.ReadLine();
                    return "c";
                }
                else
                {
                    Console.Clear();
                    Console.Write(piedraH + tijeraC + "\nGanaste!!!");
                    Console.ReadLine();
                    return "h";
                }
            }

        }
        else
        {

            //Jugador humano elije papel
            if (jugada == 2)
            {
                if (jugadaComputadora == 2)
                {
                    Console.Clear();
                    Console.Write(papelH + papelC + "\nEmpate!!!");
                    Console.ReadLine();
                    return "e";
                }
                else
                {

                    if (jugadaComputadora == 3)
                    {
                        Console.Clear();
                        Console.Write(papelH + tijeraC + "\nPerdiste!!!");
                        Console.ReadLine();
                        return "c";
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write(papelH + piedraC + "\nGanaste!!!");
                        Console.ReadLine();
                        return "h";
                    }
                }
            }
            else
            {

                //Jugador humano elije tijera
                if (jugada == 3)
                {
                    if (jugadaComputadora == 3)
                    {
                        Console.Clear();
                        Console.Write(tijeraH + tijeraC + "\nEmpate!!!");
                        Console.ReadLine();
                        return "e";
                    }
                    else
                    {
                        if (jugadaComputadora == 1)
                        {
                            Console.Clear();
                            Console.Write(tijeraH + piedraC + "\nPerdiste!!!");
                            Console.ReadLine();
                            return "c";
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write(tijeraH + papelC + "\nGanaste!!!");
                            Console.ReadLine();
                            return "h";
                        }
                    }
                }
            }
        }
        return "z";

    }

    //Función que imprime ganador, perdedor y empates
    public static void arbitro(int empates, int puntajeHumano, int puntajeComputadora){
        Console.WriteLine("Jugador: "+puntajeHumano);
        Console.WriteLine("Máquina: "+puntajeComputadora);
        Console.WriteLine("Empates: "+empates);
    }
}
/*
__     ___              ____              _        
\ \   / (_)_   ____ _  |  _ \ ___ _ __ __// _ __  
 \ \ / /| \ \ / / _` | | |_) / _ \ '__/ _ \| '_ \ 
  \ V / | |\ V / (_| | |  __/  __/ | | (_) | | | |
   \_/  |_| \_/ \__,_| |_|   \___|_|  \___/|_| |_|
                                                  
*/