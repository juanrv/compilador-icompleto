﻿using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Transversal;
using lectorArchivo.Tablas;
using lectorArchivo.GestorErrores;

namespace lectorArchivo.Analizador
{
    class AnalizadorLexico
    {
        private int Puntero;
        private int NumeroDeLineaActual;
        private Linea LineaActual;
        private String CaracterActual;
        private String Lexema;
        private int EstadoActual;
        private bool ContinuarAnalisis = true;
        private ComponenteLexico Componente;
        private TipoComponente TipoComponente;


        public AnalizadorLexico()
        {
            this.NumeroDeLineaActual = 0;
            CargarNuevaLinea();
        }


        public ComponenteLexico Analizador(bool Metodo)
        {

            if (Metodo)
            {
                resetearMorse();
                while (ContinuarAnalisis)
                {
                    if (EstadoActual == 1)
                    {
                        Estado1();
                    }
                    else if (EstadoActual == 2)
                    {
                        Estado2();
                    }
                    else if (EstadoActual == 3)
                    {
                        Estado3();
                    }
                    else if (EstadoActual == 4)
                    {
                        Estado4();
                    }
                    else if (EstadoActual == 5)
                    {
                        Estado5();
                    }
                    else if (EstadoActual == 6)
                    {
                        Estado6();
                    }
                    else if (EstadoActual == 7)
                    {
                        Estado7();
                    }
                    else if (EstadoActual == 8)
                    {
                        Estado8();
                    }
                    else if (EstadoActual == 9)
                    {
                        Estado9();
                    }
                    else if (EstadoActual == 10)
                    {
                        Estado10();
                    }
                    else if (EstadoActual == 11)
                    {
                        Estado11();
                    }
                    else if (EstadoActual == 12)
                    {
                        Estado12();
                    }
                    else if (EstadoActual == 13)
                    {
                        Estado13();
                    }
                    else if (EstadoActual == 14)
                    {
                        Estado14();
                    }
                    else if (EstadoActual == 15)
                    {
                        Estado15();
                    }
                    else if (EstadoActual == 16)
                    {
                        Estado16();
                    }
                    else if (EstadoActual == 17)
                    {
                        Estado17();
                    }
                    else if (EstadoActual == 18)
                    {
                        Estado18();
                    }
                    else if (EstadoActual == 19)
                    {
                        Estado19();
                    }
                    else if (EstadoActual == 20)
                    {
                        Estado20();
                    }
                    else if (EstadoActual == 21)
                    {
                        Estado21();
                    }
                    else if (EstadoActual == 22)
                    {
                        Estado22();
                    }
                    else if (EstadoActual == 23)
                    {
                        Estado23();
                    }
                    else if (EstadoActual == 24)
                    {
                        Estado24();
                    }
                    else if (EstadoActual == 25)
                    {
                        Estado25();
                    }
                    else if (EstadoActual == 26)
                    {
                        Estado26();
                    }
                    else if (EstadoActual == 27)
                    {
                        Estado27();
                    }
                    else if (EstadoActual == 28)
                    {
                        Estado28();
                    }
                    else if (EstadoActual == 29)
                    {
                        Estado29();
                    }
                    else if (EstadoActual == 30)
                    {
                        Estado30();
                    }
                    else if (EstadoActual == 31)
                    {
                        Estado31();
                    }
                    else if (EstadoActual == 32)
                    {
                        Estado32();
                    }
                    else if (EstadoActual == 33)
                    {
                        Estado33();
                    }
                    else if (EstadoActual == 34)
                    {
                        Estado34();
                    }
                    else if (EstadoActual == 35)
                    {
                        Estado35();
                    }
                    else if (EstadoActual == 36)
                    {
                        Estado36();
                    }
                    else if (EstadoActual == 37)
                    {
                        Estado37();
                    }
                    else if (EstadoActual == 38)
                    {
                        Estado38();
                    }
                    else if (EstadoActual == 39)
                    {
                        Estado39();
                    }
                    else if (EstadoActual == 40)
                    {
                        Estado40();
                    }
                    else if (EstadoActual == 41)
                    {
                        Estado41();
                    }
                    else if (EstadoActual == 42)
                    {
                        Estado42();
                    }
                    else if (EstadoActual == 43)
                    {
                        Estado43();
                    }
                    else if (EstadoActual == 44)
                    {
                        Estado44();
                    }
                    else if (EstadoActual == 45)
                    {
                        Estado45();
                    }
                    else if (EstadoActual == 46)
                    {
                        Estado46();
                    }
                    else if (EstadoActual == 47)
                    {
                        Estado47();
                    }
                    else if (EstadoActual == 48)
                    {
                        Estado48();
                    }
                    else if (EstadoActual == 49)
                    {
                        Estado49();
                    }
                    else if (EstadoActual == 50)
                    {
                        Estado50();
                    }
                    else if (EstadoActual == 51)
                    {
                        Estado51();
                    }
                    else if (EstadoActual == 52)
                    {
                        Estado52();
                    }
                    else if (EstadoActual == 54)
                    {
                        Estado54();
                    }
                    else if (EstadoActual == 55)
                    {
                        Estado55();
                    }
                    else if (EstadoActual == 56)
                    {
                        Estado56();
                    }
                    else if (EstadoActual == 57)
                    {
                        Estado57();
                    }
                    else if (EstadoActual == 58)
                    {
                        Estado58();
                    }
                    else if (EstadoActual == 59)
                    {
                        Estado59();
                    }
                    else if (EstadoActual == 60)
                    {
                        Estado60();
                    }
                    else if (EstadoActual == 61)
                    {
                        Estado61();
                    }
                    else if (EstadoActual == 62)
                    {
                        Estado62();
                    }
                    else if (EstadoActual == 63)
                    {
                        Estado64();
                    }
                    else if (EstadoActual == 64)
                    {
                        Estado64();
                    }
                    else if (EstadoActual == 65)
                    {
                        Estado65();
                    }
                    else if (EstadoActual == 66)
                    {
                        Estado66();
                    }
                    else if (EstadoActual == 67)
                    {
                        Estado67();
                    }
                    else if (EstadoActual == 68)
                    {
                        Estado68();
                    }
                    else if (EstadoActual == 69)
                    {
                        Estado69();
                    }
                    else if (EstadoActual == 70)
                    {
                        Estado70();
                    }
                    else if (EstadoActual == 71)
                    {
                        Estado71();
                    }
                    else if (EstadoActual == 72)
                    {
                        Estado72();
                    }
                    else if (EstadoActual == 73)
                    {
                        Estado73();
                    }
                    else if (EstadoActual == 74)
                    {
                        Estado74();
                    }
                    else if (EstadoActual == 75)
                    {
                        Estado75();
                    }
                    else if (EstadoActual == 76)
                    {
                        Estado76();
                    }
                    else if (EstadoActual == 77)
                    {
                        Estado77();
                    }
                    else if (EstadoActual == 78)
                    {
                        Estado78();
                    }
                    else if (EstadoActual == 79)
                    {
                        Estado79();
                    }
                    else if (EstadoActual == 80)
                    {
                        Estado80();
                    }
                    else if (EstadoActual == 81)
                    {
                        Estado81();
                    }
                    else if (EstadoActual == 82)
                    {
                        Estado82();
                    }
                    else if (EstadoActual == 83)
                    {
                        Estado84();
                    }
                    else if (EstadoActual == 85)
                    {
                        Estado85();
                    }
                    else if (EstadoActual == 86)
                    {
                        Estado86();
                    }
                    else if (EstadoActual == 87)
                    {
                        Estado87();
                    }
                    else if (EstadoActual == 88)
                    {
                        Estado88();
                    }
                    else if (EstadoActual == 89)
                    {
                        Estado89();
                    }
                    else if (EstadoActual == 90)
                    {
                        Estado90();
                    }
                    else if (EstadoActual == 91)
                    {
                        Estado91();
                    }
                    else if (EstadoActual == 92)
                    {
                        Estado92();
                    }
                    else if (EstadoActual == 93)
                    {
                        Estado93();
                    }
                    else if (EstadoActual == 94)
                    {
                        Estado94();
                    }
                    else if (EstadoActual == 95)
                    {
                        Estado95();
                    }
                    else if (EstadoActual == 96)
                    {
                        Estado96();
                    }
                    else if (EstadoActual == 97)
                    {
                        Estado97();
                    }
                    else if (EstadoActual == 98)
                    {
                        Estado98();
                    }
                    else if (EstadoActual == 99)
                    {
                        Estado99();
                    }
                    else if (EstadoActual == 100)
                    {
                        Estado100();
                    }
                    else if (EstadoActual == 101)
                    {
                        Estado101();
                    }
                    else if (EstadoActual == 102)
                    {
                        Estado102();
                    }
                    else if (EstadoActual == 103)
                    {
                        Estado103();
                    }
                    else if (EstadoActual == 104)
                    {
                        Estado105();
                    }
                    else if (EstadoActual == 105)
                    {
                        Estado105();
                    }
                    else if (EstadoActual == 106)
                    {
                        Estado106();
                    }
                    else if (EstadoActual == 107)
                    {
                        Estado107();
                    }
                    else if (EstadoActual == 108)
                    {
                        Estado108();
                    }
                    else if (EstadoActual == 109)
                    {
                        Estado109();
                    }
                    else if (EstadoActual == 110)
                    {
                        Estado110();
                    }
                    else if (EstadoActual == 111)
                    {
                        Estado111();
                    }
                    else if (EstadoActual == 112)
                    {
                        Estado112();
                    }
                    else if (EstadoActual == 113)
                    {
                        Estado113();
                    }
                    else if (EstadoActual == 114)
                    {
                        Estado114();
                    }
                    else if (EstadoActual == 115)
                    {
                        Estado115();
                    }
                    else if (EstadoActual == 116)
                    {
                        Estado116();
                    }
                    else if (EstadoActual == 117)
                    {
                        Estado117();
                    }
                    else if (EstadoActual == 118)
                    {
                        Estado118();
                    }
                    else if (EstadoActual == 119)
                    {
                        Estado119();
                    }
                    else if (EstadoActual == 120)
                    {
                        Estado120();
                    }
                    else if (EstadoActual == 121)
                    {
                        Estado121();
                    }
                    else if (EstadoActual == 122)
                    {
                        Estado122();
                    }
                    else if (EstadoActual == 123)
                    {
                        Estado123();
                    }
                    else if (EstadoActual == 124)
                    {
                        Estado124();
                    }
                    else if (EstadoActual == 125)
                    {
                        Estado125();
                    }
                    else if (EstadoActual == 126)
                    {
                        Estado126();
                    }
                    else if (EstadoActual == 127)
                    {
                        Estado127();
                    }
                    else if (EstadoActual == 128)
                    {
                        Estado128();
                    }
                    else if (EstadoActual == 129)
                    {
                        Estado129();
                    }
                    else if (EstadoActual == 130)
                    {
                        Estado130();
                    }
                    else if (EstadoActual == 131)
                    {
                        Estado131();
                    }
                    else if (EstadoActual == 132)
                    {
                        Estado132();
                    }
                    else if (EstadoActual == 133)
                    {
                        Estado133();
                    }
                    else if (EstadoActual == 134)
                    {
                        Estado134();
                    }

                }
                return TablaMaestra.SincronizarTabla(Componente);


            }
            else
            {
                resetearLatin();
                while (ContinuarAnalisis)
                {
                    if (EstadoActual == 135)
                    {
                        Estado135();
                    }
                    else if (EstadoActual == 136)
                    {
                        Estado136();
                    }
                    else if (EstadoActual == 137)
                    {
                        Estado137();
                    }
                    else if (EstadoActual == 138)
                    {
                        Estado138();
                    }
                    else if (EstadoActual == 139)
                    {
                        Estado139();
                    }
                    else if (EstadoActual == 140)
                    {
                        Estado140();
                    }
                    else if (EstadoActual == 141)
                    {
                        Estado141();
                    }
                    else if (EstadoActual == 142)
                    {
                        Estado142();
                    }
                    else if (EstadoActual == 143)
                    {
                        Estado143();
                    }
                    else if (EstadoActual == 144)
                    {
                        Estado144();
                    }
                    else if (EstadoActual == 145)
                    {
                        Estado145();
                    }
                    else if (EstadoActual == 146)
                    {
                        Estado146();
                    }
                    else if (EstadoActual == 147)
                    {
                        Estado147();
                    }
                    else if (EstadoActual == 148)
                    {
                        Estado148();
                    }
                    else if (EstadoActual == 149)
                    {
                        Estado149();
                    }
                    else if (EstadoActual == 150)
                    {
                        Estado150();
                    }
                    else if (EstadoActual == 151)
                    {
                        Estado151();
                    }
                    else if (EstadoActual == 152)
                    {
                        Estado152();
                    }
                    else if (EstadoActual == 153)
                    {
                        Estado153();
                    }
                    else if (EstadoActual == 154)
                    {
                        Estado154();
                    }
                    else if (EstadoActual == 155)
                    {
                        Estado155();
                    }
                    else if (EstadoActual == 156)
                    {
                        Estado156();
                    }
                    else if (EstadoActual == 157)
                    {
                        Estado157();
                    }
                    else if (EstadoActual == 158)
                    {
                        Estado158();
                    }
                    else if (EstadoActual == 159)
                    {
                        Estado159();
                    }
                    else if (EstadoActual == 160)
                    {
                        Estado160();
                    }
                    else if (EstadoActual == 161)
                    {
                        Estado161();
                    }
                    else if (EstadoActual == 162)
                    {
                        Estado162();
                    }
                    else if (EstadoActual == 163)
                    {
                        Estado163();
                    }
                    else if (EstadoActual == 164)
                    {
                        Estado164();
                    }
                    else if (EstadoActual == 165)
                    {
                        Estado165();
                    }
                    else if (EstadoActual == 166)
                    {
                        Estado166();
                    }
                    else if (EstadoActual == 167)
                    {
                        Estado167();
                    }
                    else if (EstadoActual == 168)
                    {
                        Estado168();
                    }
                    else if (EstadoActual == 169)
                    {
                        Estado169();
                    }
                    else if (EstadoActual == 170)
                    {
                        Estado170();
                    }
                    else if (EstadoActual == 171)
                    {
                        Estado171();
                    }
                    else if (EstadoActual == 172)
                    {
                        Estado172();
                    }
                    else if (EstadoActual == 173)
                    {
                        Estado173();
                    }
                    else if (EstadoActual == 174)
                    {
                        Estado174();
                    }
                    else if (EstadoActual == 175)
                    {
                        Estado175();
                    }
                    else if (EstadoActual == 176)
                    {
                        Estado176();
                    }
                    else if (EstadoActual == 177)
                    {
                        Estado177();
                    }
                    else if (EstadoActual == 178)
                    {
                        Estado178();
                    }
                    else if (EstadoActual == 179)
                    {
                        Estado179();
                    }
                    else if (EstadoActual == 180)
                    {
                        Estado180();
                    }
                    else if (EstadoActual == 181)
                    {
                        Estado184();
                    }
                    else if (EstadoActual == 182)
                    {
                        Estado182();
                    }
                    else if (EstadoActual == 183)
                    {
                        Estado183();
                    }
                    else if (EstadoActual == 184)
                    {
                        Estado184();
                    }
                    else if (EstadoActual == 185)
                    {
                        Estado185();
                    }
                    else if (EstadoActual == 186)
                    {
                        Estado186();
                    }
                    else if (EstadoActual == 187)
                    {
                        Estado187();
                    }
                    else if (EstadoActual == 188)
                    {
                        Estado188();
                    }
                    else if (EstadoActual == 189)
                    {
                        Estado189();
                    }
                    else if (EstadoActual == 190)
                    {
                        Estado190();
                    }
                    else if (EstadoActual == 191)
                    {
                        Estado191();
                    }
                    else if (EstadoActual == 192)
                    {
                        Estado192();
                    }
                    else if (EstadoActual == 193)
                    {
                        Estado193();
                    }
                    else if (EstadoActual == 194)
                    {
                        Estado194();
                    }
                    else if (EstadoActual == 195)
                    {
                        Estado195();
                    }
                    else if (EstadoActual == 196)
                    {
                        Estado196();
                    }
                    else if (EstadoActual == 197)
                    {
                        Estado197();
                    }
                    else if (EstadoActual == 198)
                    {
                        Estado198();
                    }
                    else if (EstadoActual == 199)
                    {
                        Estado199();
                    }
                }
                return TablaMaestra.SincronizarTabla(Componente);


            }



        }

        private void CargarNuevaLinea()
        {
            NumeroDeLineaActual++;
            LineaActual = Cache.obtenerCache().ObtenerLinea(NumeroDeLineaActual);
            NumeroDeLineaActual = LineaActual.ObtenerNumeroLinea();
            InicializarPuntero();
        }

        private void InicializarPuntero()
        {
            Puntero = 1;
        }

        private void DevolverPuntero()
        {
            if (Puntero > 1)
            {
                Puntero--;
            }
        }

        private void AdelantarPuntero()
        {
            Puntero++;
        }

        private void LeerSiguienteCaracter()
        {
            if (LineaActual.EsFinArchivo())
            {
                CaracterActual = LineaActual.ObtenerContenido();
            }
            else if (Puntero > LineaActual.ObtenerContenido().Length)
            {
                CaracterActual = "@FL@";
            }
            else
            {
                CaracterActual = LineaActual.ObtenerContenido().Substring(Puntero, 1);
                AdelantarPuntero();
            }
        }

        private void FormarComponenteMorse()
        {
            Lexema = Lexema + CaracterActual;
            EstadoActual = 1;
        }

        private void FormarComponenteLatin()
        {
            Lexema = Lexema + CaracterActual;
            EstadoActual = 135;

        }

        private void ResetearLexema()
        {
            Lexema = "";
        }
        private void DevorarEspaciosBlanco()
        {
            String Blanco = " ";
            while (CaracterActual.Equals(Blanco))
            {
                LeerSiguienteCaracter();
            }

        }
        private void resetearMorse()
        {
            EstadoActual = 1;
            CaracterActual = "";
            ContinuarAnalisis = true;
            ResetearLexema();
        }

        private void resetearLatin()
        {
            EstadoActual = 135;
            CaracterActual = "";
            ContinuarAnalisis = true;
            ResetearLexema();
        }


        private void CargarNuevaLineaMorse()
        {
            CargarNuevaLinea();
            resetearMorse();
        }
        private void CargarNuevaLineaLatin()
        {
            CargarNuevaLinea();
            resetearLatin();
        }

        private bool EsPunto()
        {
            return ".".Equals(CaracterActual);
        }

        private bool EsGuion()
        {
            return "-".Equals(CaracterActual);
        }

        private bool EsBarraInclinada()
        {
            return "/".Equals(CaracterActual);
        }

        private bool EsFinDeLinea()
        {
            return "@FL@".Equals(CaracterActual);
        }
        private bool EsFinDeArchivo()
        {
            return "@EOF@".Equals(CaracterActual);
        }
        private bool EsEspacio()
        {
            return " ".Equals(CaracterActual);
        }


        private void Estado1()
        {
            DevorarEspaciosBlanco();
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 4;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 71;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada())
            {
                EstadoActual = 6;
                FormarComponenteMorse();
            }
            else if (EsFinDeLinea())
            {
                EstadoActual = 2;
            }
            else if (EsFinDeArchivo())
            {
                EstadoActual = 3;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado2()
        {
            CargarNuevaLineaMorse();
            ContinuarAnalisis = false;
        }
        private void Estado3()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.FIN_DE_ARCHIVO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

        }

        private void Estado4 ()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 37;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 7;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 5;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado5()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_E, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }

        private void Estado6()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.ESPACIO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado7()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 23;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 9;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 8;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado8()
        {


            CrearComponenteSimbolo(Lexema, Categoria.LETRA_A, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
          
            ContinuarAnalisis = false;
        }
        private void Estado9()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 11;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 17;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 10;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado10()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_W, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado11()
        {
            LeerSiguienteCaracter();
            
            if (EsGuion())
            {
                EstadoActual = 13;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 12;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado12()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_P, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado13()
        {
            LeerSiguienteCaracter();

            if (EsPunto())
            {
                EstadoActual = 15;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 14;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado14()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_TILDE_A, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado15()
        {
            LeerSiguienteCaracter();

            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 16;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado16()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.ARROBA, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }

        private void Estado17()
        {
            LeerSiguienteCaracter();

            if (EsGuion())
            {
                EstadoActual = 19;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 18;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado18()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_J, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado19()
        {
            LeerSiguienteCaracter();

            if (EsPunto())
            {
                EstadoActual = 21;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 20;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado20()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_UNO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado21()
        {
            LeerSiguienteCaracter();

            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 22;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado22()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.COMILLA_SIMPLE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado23()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 25;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 29;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 24;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado24()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_R, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado25()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 27;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 32;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 26;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado26()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_L, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado27()
        {
            LeerSiguienteCaracter();
         
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 28;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado28()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_E, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado29()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 30;
                FormarComponenteMorse();
            }

            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado30()
        {
            LeerSiguienteCaracter();
            if (EsGuion())
            {
                EstadoActual = 35;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 31;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado31()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.MAS, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado32()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 33;
                FormarComponenteMorse();
            }


            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado33()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 34;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado34()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.BARRA_INCLINADA, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado35()
        {
            LeerSiguienteCaracter();
           
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 36;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado36()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.PUNTO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado37()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 55;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 39;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 38;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado38()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_I, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado39()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual =49;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 41;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 40;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado40()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_U, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado41()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 44;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 42;
                FormarComponenteMorse();
            }
            
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado42()
        {
            LeerSiguienteCaracter();
            
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 43;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado43()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_DOS, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado44()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 45;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 46;
                FormarComponenteMorse();
            }

            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado45()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 48;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado46()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 47;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado47()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.GUION_BAJO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        
        private void Estado48()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.INTERROGACION_CIERRA, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado49()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 41;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 53;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 50;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado50()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_F, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado51()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 52;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado52()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_TILDE_E, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado53()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 54;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado54()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.INTERROGACION_ABRE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado55()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 65;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 57;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 56;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado56()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_S, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado57()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 60;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 59;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 58;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado58()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_V, NumeroDeLineaActual, Puntero -Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado59()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 63;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado60()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 61;
                FormarComponenteMorse();
            }
           
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado61()
        {
            LeerSiguienteCaracter();
             if (EsGuion())
            {
                EstadoActual = 62;
                FormarComponenteMorse();
            }
            
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado62()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 64;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado63()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_TRES, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        
        private void Estado64()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.SIGNO_PESOS, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
           
        }
        private void Estado65()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 69;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 67;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 66;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado66()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_H, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado67()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 68;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado68()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_CUATRO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado69()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 70;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado70()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_CINCO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado71()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 73;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 104;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 72;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado72()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_T, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado73()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 75;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 89;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 74;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado74()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_N, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado75()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 77;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 85;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 76;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado76()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_D, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado77()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 79;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 83;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 78;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado78()
        {

            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_B, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado79()
        {
            LeerSiguienteCaracter();
             if (EsGuion())
            {
                EstadoActual = 81;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 80;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado80()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_C, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado81()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 82;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado82()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.GUION, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado83()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 84;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado84()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.IGUAL, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado85()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 87;
                FormarComponenteMorse();
            }
            
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 86;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado86()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_X, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
          
        }
        private void Estado87()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 88;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado88()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.BARRA_INCLINADA, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado89()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 91;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 98;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 90;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado90()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_K, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado91()
        {
            LeerSiguienteCaracter();
           if (EsGuion())
            {
                EstadoActual = 92;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 93;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado92()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 96;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 94;
                FormarComponenteMorse();
            }
            
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado93()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_C, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado94()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 95;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado95()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.ADMIRACION_CIERRA, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado96()
        {
            LeerSiguienteCaracter();
             if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 97;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado97()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.PUNTO_Y_COMA, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado98()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 100;
                FormarComponenteMorse();
            }
            
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 99;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado99()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_Y, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado100()
        {
            LeerSiguienteCaracter();
             if (EsGuion())
            {
                EstadoActual = 101;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 102;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado101()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 103;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado102()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.PARENTESIS_ABRE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        
        private void Estado103()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.PARENTESIS_CIERRA, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado104()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 106;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 121;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 105;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado105()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_M, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado106()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 108;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 117;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 107;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado107()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_G, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado108()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 110;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 114;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 109;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado109()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_Z, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado110()
        {
            LeerSiguienteCaracter();
             if (EsGuion())
            {
                EstadoActual = 111;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 112;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado111()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 113;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado112()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_SIETE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        
        private void Estado113()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.ADMIRACION_ABRE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado114()
        {
            LeerSiguienteCaracter();
            if (EsGuion())
            {
                EstadoActual = 115;
                FormarComponenteMorse();
            }
            
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado115()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 116;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado116()
        {
            ContinuarAnalisis = false;

            CrearComponenteLiteral(Lexema, Categoria.COMA, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado117()
        {
            LeerSiguienteCaracter();
            if (EsGuion())
            {
                EstadoActual = 119;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 118;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado118()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_Q, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado119()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 120;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado120()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_ENYE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado121()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 128;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 123;
                FormarComponenteMorse();
            }
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 122;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado122()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_O, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado123()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 124;
                FormarComponenteMorse();
            }
            else if (EsGuion())
            {
                EstadoActual = 125;
                FormarComponenteMorse();
            }
            
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado124()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 126;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado125()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 127;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado126()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_NUEVE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        
        private void Estado127()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.NUMERO_CERO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado128()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 130;
                FormarComponenteMorse();
            }
            
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 129;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado129()
        {
            ContinuarAnalisis = false;
            CrearComponenteSimbolo(Lexema, Categoria.LETRA_TILDE_O, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado130()
        {
            LeerSiguienteCaracter();
            if (EsPunto())
            {
                EstadoActual = 132;
                FormarComponenteMorse();
            }
            
            else if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 131;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado131()
        {
            ContinuarAnalisis = false;

            CrearComponenteLiteral(Lexema, Categoria.NUMERO_OCHO, NumeroDeLineaActual, Puntero -Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado132()
        {
            LeerSiguienteCaracter();
            if (EsBarraInclinada() || EsEspacio() || EsFinDeLinea())
            {
                EstadoActual = 133;
            }
            else
            {
                EstadoActual = 134;
            }
        }
        private void Estado133()
        {
            ContinuarAnalisis = false;

            int posicionInicial = Puntero - Lexema.Length;
            int posicionFinal = Puntero - 1;
            CrearComponenteLiteral(Lexema, Categoria.DOS_PUNTOS, NumeroDeLineaActual, posicionInicial, posicionFinal);
            DevolverPuntero();
        }

        private void Estado134()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            String Causa = "Hubo un error en la cadena";
            String Falla = "Morse no valido";
            String Solucion = "#";
            Error Error = Error.CrearErrorLexico(Lexema, Categoria.ERROR, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1, Falla, Causa, Solucion);
            ManejadorErrores.Reportar(Error);
            CrearComponenteDummy("1", Error.ObtenerCategoria(), Error.ObtenerNumeroLinea(), Error.ObetenerPosicionInicial(), Error.ObetenerPosicionInicial());
        }



        private void Estado135()
        {
            LeerSiguienteCaracter();
            if (EsFinDeArchivo())
            {
                EstadoActual = 136;
            }
            else if (EsFinDeLinea())
            {
                EstadoActual = 137;
                
            }
            else if ("A".Equals(CaracterActual) || "a".Equals(CaracterActual))
            {
                EstadoActual = 139;
            }
            else if ("B".Equals(CaracterActual) || "b".Equals(CaracterActual))
            {
                EstadoActual = 140;
            }
            else if ("C".Equals(CaracterActual) || "c".Equals(CaracterActual))
            {
                EstadoActual = 141;
            }
            else if ("D".Equals(CaracterActual) || "d".Equals(CaracterActual))
            {
                EstadoActual = 142;
            }
            else if ("E".Equals(CaracterActual) || "e".Equals(CaracterActual))
            {
                EstadoActual = 143;
            }
            else if ("F".Equals(CaracterActual) || "f".Equals(CaracterActual))
            {
                EstadoActual = 144;
            }
            else if ("G".Equals(CaracterActual) || "g".Equals(CaracterActual))
            {
                EstadoActual = 145;
            }
            else if ("H".Equals(CaracterActual) || "h".Equals(CaracterActual))
            {
                EstadoActual = 146;
            }
            else if ("I".Equals(CaracterActual) || "i".Equals(CaracterActual))
            {
                EstadoActual = 147;
            }
            else if ("J".Equals(CaracterActual) || "j".Equals(CaracterActual))
            {
                EstadoActual = 148;
            }
            else if ("K".Equals(CaracterActual) || "k".Equals(CaracterActual))
            {
                EstadoActual = 149;
            }
            else if ("L".Equals(CaracterActual) || "l".Equals(CaracterActual))
            {
                EstadoActual = 150;
            }
            else if ("M".Equals(CaracterActual) || "m".Equals(CaracterActual))
            {
                EstadoActual = 151;
            }
            else if ("N".Equals(CaracterActual) || "n".Equals(CaracterActual))
            {
                EstadoActual = 152;
            }
            else if ("O".Equals(CaracterActual) || "o".Equals(CaracterActual))
            {
                EstadoActual = 153;
            }
            else if ("P".Equals(CaracterActual) || "p".Equals(CaracterActual))
            {
                EstadoActual = 154;
            }
            else if ("Q".Equals(CaracterActual) || "q".Equals(CaracterActual))
            {
                EstadoActual = 155;
            }
            else if ("R".Equals(CaracterActual) || "r".Equals(CaracterActual))
            {
                EstadoActual = 156;
            }
            else if ("S".Equals(CaracterActual) || "s".Equals(CaracterActual))
            {
                EstadoActual = 157;
            }
            else if ("T".Equals(CaracterActual) || "t".Equals(CaracterActual))
            {
                EstadoActual = 158;
            }
            else if ("U".Equals(CaracterActual) || "u".Equals(CaracterActual))
            {
                EstadoActual = 159;
            }
            else if ("V".Equals(CaracterActual) || "v".Equals(CaracterActual))
            {
                EstadoActual = 160;
            }
            else if ("W".Equals(CaracterActual) || "w".Equals(CaracterActual))
            {
                EstadoActual = 161;
            }
            else if ("X".Equals(CaracterActual) || "x".Equals(CaracterActual))
            {
                EstadoActual = 162;
            }
            else if ("Y".Equals(CaracterActual) || "y".Equals(CaracterActual))
            {
                EstadoActual = 163;
            }
            else if ("Z".Equals(CaracterActual) || "z".Equals(CaracterActual))
            {
                EstadoActual = 164;
            }
            else if (EsEspacio())
            {
                EstadoActual = 165;
            }
            else if ("Á".Equals(CaracterActual) || "á".Equals(CaracterActual))
            {
                EstadoActual = 166;
            }
            else if ("É".Equals(CaracterActual) || "é".Equals(CaracterActual))
            {
                EstadoActual = 167;
            }
            else if ("Ó".Equals(CaracterActual) || "ó".Equals(CaracterActual))
            {
                EstadoActual = 168;
            }
            else if ("Ñ".Equals(CaracterActual) || "ñ".Equals(CaracterActual))
            {
                EstadoActual = 169;
            }
            else if ("0".Equals(CaracterActual))
            {
                EstadoActual = 170;
            }
            else if ("1".Equals(CaracterActual))
            {
                EstadoActual = 171;
            }
            else if ("2".Equals(CaracterActual))
            {
                EstadoActual = 172;
            }
            else if ("3".Equals(CaracterActual))
            {
                EstadoActual = 173;
            }
            else if ("4".Equals(CaracterActual))
            {
                EstadoActual = 174;
            }
            else if ("5".Equals(CaracterActual))
            {
                EstadoActual = 175;
            }
            else if ("6".Equals(CaracterActual))
            {
                EstadoActual = 176;
            }
            else if ("7".Equals(CaracterActual))
            {
                EstadoActual = 177;
            }
            else if ("8".Equals(CaracterActual))
            {
                EstadoActual = 178;
            }
            else if ("9".Equals(CaracterActual))
            {
                EstadoActual = 179;
            }
            else if (".".Equals(CaracterActual))
            {
                EstadoActual = 180;
            }
            else if (",".Equals(CaracterActual))
            {
                EstadoActual = 181;
            }
            else if ("¿".Equals(CaracterActual))
            {
                EstadoActual = 182;
            }
            else if ("?".Equals(CaracterActual))
            {
                EstadoActual = 183;
            }
            else if ("'".Equals(CaracterActual))
            {
                EstadoActual = 184;
            }
            else if ("¡".Equals(CaracterActual))
            {
                EstadoActual = 185;
            }
            else if ("!".Equals(CaracterActual))
            {
                EstadoActual = 186;
            }
            else if ("/".Equals(CaracterActual))
            {
                EstadoActual = 187;
            }
            else if ("(".Equals(CaracterActual))
            {
                EstadoActual = 188;
            }
            else if (")".Equals(CaracterActual))
            {
                EstadoActual = 189;
            }
            else if ("&".Equals(CaracterActual))
            {
                EstadoActual = 190;
            }
            else if ("$".Equals(CaracterActual))
            {
                EstadoActual = 191;
            }
            else if ("+".Equals(CaracterActual))
            {
                EstadoActual = 192;
            }
            else if ("-".Equals(CaracterActual))
            {
                EstadoActual = 193;
            }
            else if (":".Equals(CaracterActual))
            {
                EstadoActual = 194;
            }
            else if (";".Equals(CaracterActual))
            {
                EstadoActual = 195;
            }
            else if ("=".Equals(CaracterActual))
            {
                EstadoActual = 196;
            }
            else if ("_".Equals(CaracterActual))
            {
                EstadoActual = 197;
            }
            else if ("\"".Equals(CaracterActual))
            {
                EstadoActual = 198;
            }
            else if ("@".Equals(CaracterActual))
            {
                EstadoActual = 199;
            }
            else
            {
                EstadoActual = 138;
            }
        }

        private void Estado136()
        {
            ContinuarAnalisis = false;
            CrearComponenteLiteral(Lexema, Categoria.FIN_DE_ARCHIVO, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

        }
        private void Estado137()
        {
            CargarNuevaLineaLatin();
            ContinuarAnalisis = false;
        }

        private void Estado138()
        {
            DevolverPuntero();
            ContinuarAnalisis = false;
            String Causa = "Hubo un error en la cadena";
            String falla = "Latin no valido";
            String Solucion = "#";
            Error Error = Error.CrearErrorLexico(Lexema, Categoria.ERROR, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1, falla, Causa, Solucion);
            ManejadorErrores.Reportar(Error);
            CrearComponenteDummy("1", Error.ObtenerCategoria(), Error.ObtenerNumeroLinea(), Error.ObetenerPosicionInicial(), Error.ObetenerPosicionInicial());

        }
        private void Estado139()
        {
            ContinuarAnalisis = false;

            int posicionInicial = Puntero - Lexema.Length;
            int posicionFinal = Puntero - 1;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, posicionInicial, posicionFinal);
            DevolverPuntero();
        }
        private void Estado140()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado141()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado142()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado143()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado144()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado145()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado146()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado147()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado148()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado149()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado150()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado151()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado152()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado153()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado154()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado155()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado156()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado157()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado158()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado159()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado160()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado161()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado162()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado163()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado164()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado165()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado166()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.TILDE_A_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado167()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.TILDE_E_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado168()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.TILDE_O_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado169()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.LETRA_ENYE_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado170()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorse(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado171()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado172()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado173()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado174()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado175()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado176()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado177()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado178()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado179()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.NUMERO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado180()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.PUNTO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado181()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.COMA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado182()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.PREGUNTA_ABRE_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado183()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.PREGUNTA_CIERRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado184()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.COMILLA_SIMPLE_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado185()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.ADMIRACION_ABRE_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado186()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.ADMIRACION_CIERRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado187()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.BARRA_INCLINADA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado188()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.PARENTESIS_ABRE_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado189()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.PARENTESIS_CIERRA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado190()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.ET_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado191()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.SIGNO_PESOS_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado192()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.MAS_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado193()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.GUION_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado194()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.DOS_PUNTOS_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado195()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.PUNTO_Y_COMA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);

            DevolverPuntero();
        }
        private void Estado196()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.IGUAL_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);
            DevolverPuntero();
        }
        private void Estado197()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.GUION_BAJO_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);
            DevolverPuntero();
        }
        private void Estado198()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.BARRA_INCLINADA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);
            DevolverPuntero();
        }
        private void Estado199()
        {
            ContinuarAnalisis = false;
            CrearComponenteMorseLiteral(Lexema, Categoria.ARROBA_MORSE, NumeroDeLineaActual, Puntero - Lexema.Length, Puntero - 1);
            DevolverPuntero();

        }

        private void CrearComponenteSimbolo(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Componente = ComponenteLexico.CrearComponenteSimbolo(Lexema, categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }
        private void CrearComponenteLiteral(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Componente = ComponenteLexico.CrearComponenteLiteral(Lexema, categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }
        private void CrearComponenteDummy(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Componente = ComponenteLexico.CrearComponenteDummy(Lexema, categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }
        private void CrearComponenteMorse(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Componente = ComponenteLexico.CrearComponenteSimbolo(Lexema, categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }
        private void CrearComponenteMorseLiteral(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            Componente = ComponenteLexico.CrearComponenteLiteral(Lexema, categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }


    }
}
