using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CellaVuota = " ";
            string giocatoreX = "X";
            string giocatoreO = "O";
            string giocatoreCorrente = giocatoreX;
            bool Turno = true;
            string Cella1 = CellaVuota;
            string Cella2 = CellaVuota;
            string Cella3 = CellaVuota;
            string Cella4 = CellaVuota;
            string Cella5 = CellaVuota;
            string Cella6 = CellaVuota;
            string Cella7 = CellaVuota;
            string Cella8 = CellaVuota;
            string Cella9 = CellaVuota;
            int PuntiX = 0;
            int PuntiO = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" ┌───────────────────┐");
                    Console.WriteLine($" │Punti giocatore X:{PuntiX}│");
                    Console.WriteLine(" ├───────────────────┤");
                    Console.WriteLine($" │Punti giocatore O:{PuntiO}│");
                    Console.WriteLine(" └───────────────────┘");
                    Console.WriteLine(" ┌──────────────┐");
                    Console.WriteLine(" │ TRIS A PUNTI │");
                    Console.WriteLine(" └──────────────┘");
                    Console.WriteLine("    1   2   3");
                    Console.WriteLine("  ┌───┼───┼───┐");
                    Console.WriteLine($" A│ {Cella1} │ {Cella2} │ {Cella3} │");
                    Console.WriteLine(" ─┼───┼───┼───┤");
                    Console.WriteLine($" B│ {Cella4} │ {Cella5} │ {Cella6} │");
                    Console.WriteLine(" ─┼───┼───┼───┤");
                    Console.WriteLine($" C│ {Cella7} │ {Cella8} │ {Cella9} │");
                    Console.WriteLine("  └───┴───┴───┘");
                    if (Turno == true)
                    {
                        giocatoreCorrente = giocatoreX;
                    }
                    else
                    {
                        giocatoreCorrente = giocatoreO;
                    }
                    Console.WriteLine($"\nTocca al giocatore {giocatoreCorrente}");
                    Console.Write("\nScegli una cella:");
                    string Coordinata = Console.ReadLine();
                    if (Coordinata == "A1"
                        || Coordinata == "A2"
                        || Coordinata == "A3"
                        || Coordinata == "B1"
                        || Coordinata == "B2"
                        || Coordinata == "B3"
                        || Coordinata == "C1"
                        || Coordinata == "C2"
                        || Coordinata == "C3") { }
                    else
                    {
                        do
                        {
                            Console.Write("\nScegli una cella:");
                            Coordinata = Console.ReadLine();
                        } while (Coordinata != "A1"
                        && Coordinata != "A2"
                        && Coordinata != "A3"
                        && Coordinata != "B1"
                        && Coordinata != "B2"
                        && Coordinata != "B3"
                        && Coordinata != "C1"
                        && Coordinata != "C2"
                        && Coordinata != "C3");
                    }

                    switch (Coordinata)
                    {
                        case "A1":
                            if (Cella1 == CellaVuota)
                            {
                                Cella1 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                        case "A2":
                            if (Cella2 == CellaVuota)
                            {
                                Cella2 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                        case "A3":
                            if (Cella3 == CellaVuota)
                            {
                                Cella3 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                        case "B1":
                            if (Cella4 == CellaVuota)
                            {
                                Cella4 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                        case "B2":
                            if (Cella5 == CellaVuota)
                            {
                                Cella5 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                        case "B3":
                            if (Cella6 == CellaVuota)
                            {
                                Cella6 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                        case "C1":
                            if (Cella7 == CellaVuota)
                            {
                                Cella7 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                        case "C2":
                            if (Cella8 == CellaVuota)
                            {
                                Cella8 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                        case "C3":
                            if (Cella9 == CellaVuota)
                            {
                                Cella9 = giocatoreCorrente;
                                break;
                            }
                            else
                            {
                                Turno = !Turno;
                            }
                            break;
                    }
                    Turno = !Turno;
                    if ((Cella1 == giocatoreX) && (Cella2 == giocatoreX) && (Cella3 == giocatoreX) || (Cella1 == giocatoreO) && (Cella2 == giocatoreO) && (Cella3 == giocatoreO))
                    {
                        break;
                    }
                    if ((Cella4 == giocatoreX) && (Cella5 == giocatoreX) && (Cella6 == giocatoreX) || (Cella4 == giocatoreO) && (Cella5 == giocatoreO) && (Cella6 == giocatoreO))
                    {
                        break;
                    }
                    if ((Cella7 == giocatoreX) && (Cella8 == giocatoreX) && (Cella9 == giocatoreX) || (Cella7 == giocatoreO) && (Cella8 == giocatoreO) && (Cella9 == giocatoreO))
                    {
                        break;
                    }
                    if ((Cella1 == giocatoreX) && (Cella4 == giocatoreX) && (Cella7 == giocatoreX) || (Cella1 == giocatoreO) && (Cella4 == giocatoreO) && (Cella7 == giocatoreO))
                    {
                        break;
                    }
                    if ((Cella2 == giocatoreX) && (Cella5 == giocatoreX) && (Cella8 == giocatoreX) || (Cella2 == giocatoreO) && (Cella5 == giocatoreO) && (Cella8 == giocatoreO))
                    {
                        break;
                    }
                    if ((Cella3 == giocatoreX) && (Cella6 == giocatoreX) && (Cella9 == giocatoreX) || (Cella3 == giocatoreO) && (Cella6 == giocatoreO) && (Cella9 == giocatoreO))
                    {
                        break;
                    }
                    if ((Cella1 == giocatoreX) && (Cella5 == giocatoreX) && (Cella9 == giocatoreX) || (Cella1 == giocatoreO) && (Cella5 == giocatoreO) && (Cella9 == giocatoreO))
                    {
                        break;
                    }
                    if ((Cella3 == giocatoreX) && (Cella5 == giocatoreX) && (Cella7 == giocatoreX) || (Cella3 == giocatoreO) && (Cella5 == giocatoreO) && (Cella7 == giocatoreO))
                    {
                        break;
                    }
                } while (Cella1 == CellaVuota
                || Cella2 == CellaVuota
                || Cella3 == CellaVuota
                || Cella4 == CellaVuota
                || Cella5 == CellaVuota
                || Cella6 == CellaVuota
                || Cella7 == CellaVuota
                || Cella8 == CellaVuota
                || Cella9 == CellaVuota);
                Console.Clear();
                Console.WriteLine(" ┌───────────────────┐");
                Console.WriteLine($" │Punti giocatore X:{PuntiX}│");
                Console.WriteLine(" ├───────────────────┤");
                Console.WriteLine($" │Punti giocatore O:{PuntiO}│");
                Console.WriteLine(" └───────────────────┘");
                Console.WriteLine(" ┌──────────────┐");
                Console.WriteLine(" │ TRIS A PUNTI │");
                Console.WriteLine(" └──────────────┘");
                Console.WriteLine("    1   2   3");
                Console.WriteLine("  ┌───┼───┼───┐");
                Console.WriteLine($" A│ {Cella1} │ {Cella2} │ {Cella3} │");
                Console.WriteLine(" ─┼───┼───┼───┤");
                Console.WriteLine($" B│ {Cella4} │ {Cella5} │ {Cella6} │");
                Console.WriteLine(" ─┼───┼───┼───┤");
                Console.WriteLine($" C│ {Cella7} │ {Cella8} │ {Cella9} │");
                Console.WriteLine("  └───┴───┴───┘");
                if (Cella1 != CellaVuota
                && Cella2 != CellaVuota
                && Cella3 != CellaVuota
                && Cella4 != CellaVuota
                && Cella5 != CellaVuota
                && Cella6 != CellaVuota
                && Cella7 != CellaVuota
                && Cella8 != CellaVuota
                && Cella9 != CellaVuota)
                {
                    Console.WriteLine("\nNon ha vinto nessuno");
                }
                else
                {
                    Console.WriteLine($"\nHa vinto il giocatore {giocatoreCorrente}");
                    if (giocatoreCorrente == giocatoreX)
                    {
                        PuntiX++;
                    }
                    else
                    {
                        PuntiO++;
                    }
                }
                Console.WriteLine("\nPremere per procedere alla prossima partita.");
                Console.ReadLine();
                Cella1 = CellaVuota;
                Cella2 = CellaVuota;
                Cella3 = CellaVuota;
                Cella4 = CellaVuota;
                Cella5 = CellaVuota;
                Cella6 = CellaVuota;
                Cella7 = CellaVuota;
                Cella8 = CellaVuota;
                Cella9 = CellaVuota;
            } while (PuntiX < 5 && PuntiO < 5);
            if (PuntiX == 5)
            {
                Console.WriteLine("\nHa vinto la partita il giocatore X");
                Console.WriteLine($"\nPunti X: {PuntiX}");
                Console.WriteLine($"\nPunti O: {PuntiO}");
            }
            else
            {
                Console.WriteLine("\nHa vinto la partita il giocatore O");
                Console.WriteLine($"\nPunti X: {PuntiX}");
                Console.WriteLine($"\nPunti O: {PuntiO}");
            }
        }
    }
}