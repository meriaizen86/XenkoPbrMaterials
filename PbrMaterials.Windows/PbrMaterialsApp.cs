using Xenko.Engine;

namespace PbrMaterials.Windows
{
    class PbrMaterialsApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
