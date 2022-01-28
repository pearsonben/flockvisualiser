using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlockVisualiser.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {

        public ControlsViewModel ControlsVM { get; set; } = new ControlsViewModel();
        public GameBoardViewModel GameBoardVM { get; set; } = new GameBoardViewModel();





    }
}
