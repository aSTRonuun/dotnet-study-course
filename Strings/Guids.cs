using  System;

namespace Guids {

    class Program {

        static void App(string[] args) {
            
            // .NewGuid - Gera um ID aleatorio
            var id = Guid.NewGuid();
            Console.WriteLine(id);
            

            // Passar exatamente no mesmo formato de um Gui
            id = new Guid("5cc8c52f-ed6f-4112-975e-99120bd54c38");
            Console.WriteLine(id);

            // Version Guid menor
            Console.WriteLine(id.ToString().Substring(0, 8));
            
            // Sem nenhum parametro gera o Guid totalmente zerado
            id = new Guid();
            Console.WriteLine(id);

            
            
        }
    }
}