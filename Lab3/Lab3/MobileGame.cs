using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class MobileGame
    {
        private int level = 1;
        private int score = 0;
        private int remainScore;
        public void Play()
        {
            if (score < 500)
            {
                score += 250;
                remainScore = 500 - score;
                Console.WriteLine($"До перехода на новый уровень осталось {remainScore} очков");
                if (score == 500)
                {
                    Console.WriteLine($"{level} уровень пройден. Текущий уовень {level + 1}");
                    level++;
                }
            }
        }

        public GameMemento SaveState()
        {
            Console.WriteLine($"Сохранение игры. Параметры: {level} уровень, {score} очков");
            return new GameMemento(level, score);
        }

        public void RestoreState(GameMemento memento)
        {
            this.level = memento.Level;
            this.score = memento.Score;
            Console.WriteLine($"Восстановление игры. Параметры: {level} уровень, {score} очков");
        }
    }
}
