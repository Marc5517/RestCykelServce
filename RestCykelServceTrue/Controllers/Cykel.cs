﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCykelServceTrue.Controllers
{
    public class Cykel
    {
        private int _id;
        private string _farve;
        private int _pris;
        private int _gear;

        public int Id
        {

            get => _id;
            set
            {
                _id = value;
            }
        }

        public string Farve
        {
            get => _farve;
            set
            {
                if (value.Length < 1) throw new ArgumentException();
                _farve = value;
            }
        }

        public int Pris
        {
            get => _pris;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _pris = value;
            }
        }

        public int Gear
        {
            get => _gear;
            set
            {
                if (value < 3 || value > 32) throw new ArgumentOutOfRangeException();
                _gear = value;
            }
        }

        public Cykel(int id, string farve, int pris, int gear)
        {
            Id = id;
            Farve = farve;
            Pris = pris;
            Gear = gear;
        }

        public Cykel()
        {

        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Farve)}: {Farve}, {nameof(Pris)}: {Pris}, {nameof(Gear)}: {Gear}";
        }
    }
}
