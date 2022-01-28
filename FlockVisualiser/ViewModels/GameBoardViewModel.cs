using Caliburn.Micro;
using FlockVisualiser.Boids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Drawing;
namespace FlockVisualiser.ViewModels
{
    public class GameBoardViewModel : Screen
    {

        public void AddBoid()
        {
            Random rnd = new Random();

            GameEntities.Add(new DynamicBoid
            {
                CurrentPosition = new Point(rnd.Next(100, 1300), rnd.Next(100, 600)),
                CurrentAngle = rnd.Next(0, 360)
            });

            // GameEntities.Add(
            //   new TestBoid { Angle = rnd.Next(0, 360), XPos = rnd.Next(100, 1300), YPos = rnd.Next(100, 600) }
            //);
        }
        public BindableCollection<IBoidBase> GameEntities { get; set; } = new BindableCollection<IBoidBase>();

        public string TestText { get; set; } = "GameBoarDViewModel";


        public DispatcherTimer GameTimer { get; set; } = new DispatcherTimer();

        public GameBoardViewModel()
        {

            GameEntities.Add(new DynamicBoid
            {
                CurrentPosition = new Point(300,500),
                
                CurrentAngle = 0
            });
            

            GameTimer.Tick += GameEngine;
            GameTimer.Interval = TimeSpan.FromMilliseconds(20);
            GameTimer.Start();


        }

        private void GameEngine(object sender, EventArgs e)
        {
            
            foreach(var entity in GameEntities)
            {
                
                entity.Rotate(1);

            }
            GameEntities.Refresh();


        }
    }
}
