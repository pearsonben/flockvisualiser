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

        public string TestText { get; set; } = "GameBoarDViewModel";

        public BindableCollection<TestBoid> GameEntities { get; set; } = new BindableCollection<TestBoid>()
            {
                new TestBoid{ Angle = 45, XPos = 100, YPos = 100 },
                new TestBoid{ Angle = 90, XPos = 400, YPos = 300 }
            };

        //public DispatcherTimer GameTimer { get; set; } = new DispatcherTimer();

        public GameBoardViewModel()
        {


            //GameEntities

            //GameTimer.Tick += GameEngine;


        }

        private void GameEngine(object sender, EventArgs e)
        {
            
        }
    }
}
