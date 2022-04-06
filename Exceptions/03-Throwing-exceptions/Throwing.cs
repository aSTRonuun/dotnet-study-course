using System;

namespace Exceptions {

    class Program03 {

        public static void App() {
            
            var array = new int[3];

            try {
                
                Save("");

            } catch (IndexOutOfRangeException ex) {

                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Not found index");
            } catch (ArgumentNullException ex) {

                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Fail to save");
            } catch(Exception ex) {
                
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            } finally {
                // Recomenado usar o finally para quando ocorer algum erro o finally será executado para que seja verificado e seja feito algo.
                Console.WriteLine($" Chegou ao fim do programa");
                
            }
            
            
        }
    
        static void Save(string text) {
            if(string.IsNullOrEmpty(text)) {
                throw new ArgumentNullException("The text does not is empty or null");
            }
        }
    
    }
}