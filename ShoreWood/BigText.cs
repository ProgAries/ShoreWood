using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class BigText
    {
        public static void Titre()
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"                                                                                                  
                                                 H     H  EEEEEE  RRRRRR      OOOO                            
                                                 H     H  EE      RR   RR   OO    OO                          
                                                 HHHHHHH  EEEEEE  RR RRRR  OO      OO                         
                                                 H     H  EE      RR  R     OO    OO                          
                                                 H     H  EEEEEE  RR    R     OOOO                            
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                        VV        VV    SSSSS                                 
                                                         VV      VV   SSS                                     
                                                          VV    VV      SSSS                                  
                                                           VV  VV          SSS                                
                                                             VV        SSSSS                                  
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                      MM        MM      OOOO     NN      NN     SSSSS  TTTTTTTTTT  EEEEEE  RRRRRR     SSSSS   
                      MM MM  MM MM    OO    OO   NN NN   NN   SSS          TT      EE      RR   RR  SSS       
                      MM   MM   MM   OO      OO  NN  NN  NN     SSSS       TT      EEEEEE  RR RRRR    SSSS    
                      MM        MM    OO    OO   NN   NN NN        SSS     TT      EE      RR  R         SSS  
                      MM        MM      OOOO     NN     NNN    SSSSS       TT      EEEEEE  RR    R   SSSSS
                                                                                                              
                                                                                                            ");  
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void Winner()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
            ==============================================================================================
            ==============================================================================================
            ==============================================================================================
            ===========                                                                     ==============
            ===========  WW               WW  III  NN      NN  NN      NN  EEEEEE  RRRRRR   ==============
            ============  WW     WWW     WW   III  NN NN   NN  NN NN   NN  EE      RR   RR  ==============
            =============  WW   WW WW   WW    III  NN  NN  NN  NN  NN  NN  EEEEEE  RR RRRR  ==============
            ==============  WW WW   WW WW     III  NN   NN NN  NN   NN NN  EE      RR  R    ==============
            ===============  WWW     WWW      III  NN     NNN  NN     NNN  EEEEEE  RR    R  ==============
            ================                                                                ==============
            ==============================================================================================
            ==============================================================================================
            ==============================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
            ================================================================================
            ================================================================================
            ================================================================================
            ==============                                                   ===============
            ==============    GGGGGGGGG      AAAA      MM        MM  EEEEEE  ===============
            ==============   GG             AA  AA     MM MM  MM MM  EE      ===============
            ==============  GG    GGGGG    AAAAAAAA    MM   MM   MM  EEEEEE  ===============
            ==============   GG      GG   AA      AA   MM        MM  EE      ===============
            ==============    GGGGGGGGG  AA        AA  MM        MM  EEEEEE  ===============
            ==============                                                   ===============
            ==============                                                   ===============
            ==============        OOOO     VV        VV  EEEEEE  RRRRRR      ===============
            ==============      OO    OO    VV      VV   EE      RR   RR     ===============
            ==============     OO      OO    VV    VV    EEEEEE  RR RRRR     ===============
            ==============      OO    OO      VV  VV     EE      RR  R       ===============
            ==============        OOOO          VV       EEEEEE  RR    R     ===============
            ==============                                                   ===============
            ================================================================================
            ================================================================================
            ================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
