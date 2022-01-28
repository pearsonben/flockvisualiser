using Caliburn.Micro;
using FlockVisualiser.Boids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
namespace FlockVisualiser.ViewModels
{
    public class GameBoardViewModel : Screen
    {

        public void AddBoid()
        {
            Random rnd = new Random();

            GameEntities.Add(
                new TestBoid { Angle = rnd.Next(0, 360), XPos = rnd.Next(100, 500), YPos = rnd.Next(100, 500) }
                );
        }

        public string TestText { get; set; } = "GameBoarDViewModel";

        public BindableCollection<TestBoid> GameEntities { get; set; } = new BindableCollection<TestBoid>()
            {
                new TestBoid{ Angle = 45, XPos = 100, YPos = 100 },
                new TestBoid{ Angle = 90, XPos = 400, YPos = 300 }
            };

        public DispatcherTimer GameTimer { get; set; } = new DispatcherTimer();

        public GameBoardViewModel()
        {


            //GameEntities

            GameTimer.Tick += GameEngine;
            GameTimer.Interval = TimeSpan.FromMilliseconds(20);
            GameTimer.Start();

        }

        private void GameEngine(object sender, EventArgs e)
        {
            
            foreach(var entity in GameEntities)
            {
                entity.XPos += 1;
                entity.YPos += 1;
                //entity.Angle += 1;
            }


        }
    }
}
