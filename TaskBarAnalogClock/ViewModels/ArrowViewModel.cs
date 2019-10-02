using System;
using System.Windows.Media;
using System.Windows.Threading;
using Cafemoca.TaskBarAnalogClock.Models;

namespace Cafemoca.TaskBarAnalogClock.ViewModels
{
    internal class ArrowViewModel : ViewModelBase
    {
        private readonly DispatcherTimer _timer = new DispatcherTimer();

        private ArrowType _arrowType;
        public ArrowType ArrowType
        {
            get => this._arrowType;
            set
            {
                this._arrowType = value;
                this.OnPropertyChanged();
            }
        }

        private double _angle;
        public double Angle
        {
            get => this._angle;
            set
            {
                this._angle = value;
                this.OnPropertyChanged();
            }
        }

        private int _length;
        public int Length
        {
            get => this._length;
            set
            {
                this._length = value;
                this.OnPropertyChanged();
            }
        }

        private double _thickness;
        public double Thickness
        {
            get => this._thickness;
            set
            {
                this._thickness = value;
                this.OnPropertyChanged();
            }
        }

        private Brush _color;
        public Brush Color
        {
            get => this._color;
            set
            {
                this._color = value;
                this.OnPropertyChanged();
            }
        }

        public ArrowViewModel()
        {
            this._timer.Interval = TimeSpan.FromSeconds(1);
            this._timer.Tick += this.Timer_Tick;
            this._timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            switch (this._arrowType)
            {
                case ArrowType.Hour:
                    this.Angle = time.Hour * (360 / 12)+ time.Minute * (360 / 12) / 60;
                    return;
                case ArrowType.Minute:
                    this.Angle = time.Minute * (360 / 60);
                    return;
                case ArrowType.Second:
                    this.Angle = time.Second * (360 / 60);
                    return;
            }
        }
    }
}
