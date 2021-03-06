﻿using QSF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSF.Examples.DateTimePickerControl.DatePickerExample
{
    public class DatePickerViewModel : ExampleViewModel
    {
        private int guests;
        private DateTime checkInDate;
        private DateTime checkOutDate;

        public DatePickerViewModel()
        {
            this.guests = 1;
            this.checkInDate = DateTime.Today;
            this.checkOutDate = DateTime.Today;
        }

        public DateTime CheckInDate
        {
            get
            {
                return this.checkInDate;
            }
            set
            {
                if (this.checkInDate != value)
                {
                    this.checkInDate = value;
                    this.OnPropertyChanged();
                    this.OnCheckInDateChanged();
                }
            }
        }

        public DateTime CheckOutDate
        {
            get
            {
                return this.checkOutDate;
            }
            set
            {
                if (this.checkOutDate != value)
                {
                    this.checkOutDate = value;
                    this.OnPropertyChanged();
                    this.OnCheckOutDateChanged();
                }
            }
        }

        public int Guests
        {
            get
            {
                return this.guests;
            }
            set
            {
                if (this.guests != value)
                {
                    this.guests = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private void OnCheckInDateChanged()
        {
            if (this.CheckOutDate < this.CheckInDate)
            {
                this.CheckOutDate = this.CheckInDate;
            }
        }

        private void OnCheckOutDateChanged()
        {
            if (this.CheckInDate > this.CheckOutDate)
            {
                this.CheckInDate = this.CheckOutDate;
            }
        }
    }
}
