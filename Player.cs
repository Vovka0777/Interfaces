using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_7
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Воспроизведение видео");
        }
        public void Pause()
        {
            Console.WriteLine("Поставлена пауза");
        }
        public void StopPlay()
        {
            Console.WriteLine("Запись остановлена");
        }
        public void StopRecord()
        {
            Console.WriteLine("Воспроизведение остановлено");
        }
        public void Record()
        {
            Console.WriteLine("Производится запись");
        }
    }
}
