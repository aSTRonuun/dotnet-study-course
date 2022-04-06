using System;

namespace Exceptions {

    class Program02 {

        public static void App() {
            
            var array = new int[3];

            try {
                for(int i = 0; i < 5; i++) {

                    // System.IndexOutOfRangeException:
                    Console.WriteLine(array[i]);
                
                }
            } catch (IndexOutOfRangeException ex) {

                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Not found index");
            } catch(Exception ex) {
                
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}