using System;
using day9_dll;
using IrrKlang;

namespace day9_methods_aand_dlls
{
    class Program
    {

        class ManaKlase
        {



            //no jebkuras citas klases varēs varēs piekļūt šai metodei
            //public void Metode1()

            //tikai šīs klases metodes var piekļūt šai metodei
            //private void Metode2()

            //child klases var piekļūt
            //protected void Metode3() 

            public int Factorial(int sk)
            {
               int result;

                if (sk == 1)
                {
                    return 1;
                } else
                {
                    result = Factorial(sk - 1) * sk;
                    return result;
                }

                //return something anyway :)
            }


            //references visbiežāk ir masīvi tādēļ, ka mēs šos masīvus apstrādājam !
            //
            public void Parasta_reference(int sk, ref string str)
            {

                sk++;

                int rr = sk;

                str += rr.ToString();


                //..
                //kalkulēt 
                //...


            }



            public void Parasta_kopija(int sk, string str)
            {

                //jābūt nodrošinātām parametru kopijām !!!

                sk++;

                int rr = sk;

                str += rr.ToString();


                //..
                //kalkulēt 
                //...


            }


            static void Main(string[] args)
            {
                ManaKlase kl = new ManaKlase();


                Console.WriteLine(kl.Factorial(10));

                int skaitlis = 5;

                string str = "Skaitlis :";



                //taisam kopijas `skaitlis`  un `str`
                kl.Parasta_kopija(skaitlis, str);

                kl.Parasta_reference(skaitlis, ref str);


                //while (sk > 0)

                //kas notiek, ja šis ir ciklā un `str` izmērs ir megabaitos ?
                //kl.Parasta_kopija(skaitlis, str);

                //kl.Parasta_reference(ref sk, ref str);

                //


                Aritmetika ar = new Aritmetika();

                Console.WriteLine(ar.Add(1, 2));


                //nav viens un tas pats
                //kl.Metode4(5, 6);
                //kl.Metode4(6, 5);   


                ISoundEngine skanja = new ISoundEngine();


                //skanja.Play2D("sadfasd");




                Console.WriteLine("Hello World!");
            }
        }
    }
}
