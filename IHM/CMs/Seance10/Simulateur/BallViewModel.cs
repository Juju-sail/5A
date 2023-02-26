using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
    public class BallViewModel : ViewModelBase
    {
        private const double GRAVITY = -20.0; // pixels / s²

        private double _px; // pixels
        private double _py; // pixels
        private double _vy; // pixels / s

        public BallViewModel(double px, double py)
        {
            _px = px;
            _py = py;
            _vy = 0.0;
        }

        public void Update(TimeSpan delta)
        {
            if (_py > 0.0)
            {
                _vy += GRAVITY * delta.TotalSeconds;
                _py += _vy * delta.TotalSeconds;
            }
            else
            {
                _py = 0.0;
            }

            OnPropertyChanged(nameof(PositionY));
        }

        public double PositionX
        {
            get { return _px; }
        }

        public double PositionY
        {
            get { return _py; }
        }
    }
}
