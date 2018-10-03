using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class Pricing
    {
        //Gadget Components
        private double _switchCostPerUnit    = 10.99;
        private double _buttonCostPerUnit    = 20.87;
        private double _lightCostPerUnit     = 30.76;

        //Widget Components
        private double _gearCostPerUnit      = 12.65;
        private double _springCostPerUnit    = 14.54;
        private double _leverCostPerUnit     = 16.43;

        //Power Supplies
        private double _batteryCostPerUnit   = 500.32;
        private double _solarCostPerUnit     = 900.21;
        private double _generatorCostPerUnit = 1100.10;


        public virtual double SwitchCostPerUnit
        {
            set
            {
                this._switchCostPerUnit = value;
            }
            get
            {
                return _switchCostPerUnit;
            }
        }

        public virtual double ButtonCostPerUnit
        {
            set
            {
                this._buttonCostPerUnit = value;
            }
            get
            {
                return _buttonCostPerUnit;
            }
        }

        public virtual double LightCostPerUnit
        {
            set
            {
                this._lightCostPerUnit = value;
            }
            get
            {
                return _lightCostPerUnit;
            }
        }

        public virtual double GearCostPerUnit
        {
            set
            {
                this._gearCostPerUnit = value;
            }
            get
            {
                return _gearCostPerUnit;
            }
        }

        public virtual double SpringCostPerUnit
        {
            set
            {
                this._springCostPerUnit = value;
            }
            get
            {
                return _springCostPerUnit;
            }
        }

        public virtual double LeverCostPerUnit
        {
            set
            {
                this._leverCostPerUnit = value;
            }
            get
            {
                return _leverCostPerUnit;
            }
        }

        public virtual double BatteryCostPerUnit
        {
            set
            {
                this._batteryCostPerUnit = value;
            }
            get
            {
                return _batteryCostPerUnit;
            }
        }

        public virtual double SolarCostPerUnit
        {
            set
            {
                this._solarCostPerUnit = value;
            }
            get
            {
                return _solarCostPerUnit;
            }
        }

        public virtual double GeneratorCostPerUnit
        {
            set
            {
                this._generatorCostPerUnit = value;
            }
            get
            {
                return _generatorCostPerUnit;
            }
        }
    }
}
