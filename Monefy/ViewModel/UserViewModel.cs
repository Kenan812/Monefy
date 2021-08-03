using Monefy.Model;
using Monefy.Model.Expences;
using Monefy.Model.Holders;
using Monefy.Services;
using Monefy.Services.CommandDelegates;
using Monefy.Services.FileServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monefy.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IFileService _fileService;

        User user = new User();



        public UserViewModel(IFileService fileService)
        {
            _fileService = fileService;

            if (File.Exists("user.xml"))
            {
                MessageBox.Show("Test");
                user = _fileService.LoadUserInformation("user.xml");
            }
        }




        #region Expences Properties


        private string carExpencePercentage;
        public string CarExpencePercentage 
        { 
            get => carExpencePercentage; 
            set
            {
                carExpencePercentage = value;
                OnPropertyChanged(nameof(CarExpencePercentage));
            }
        }

        private string clothesExpencePercentage;
        public string ClothesExpencePercentage 
        { 
            get => clothesExpencePercentage;
            set
            {
                clothesExpencePercentage = value;
                OnPropertyChanged(nameof(ClothesExpencePercentage));
            } 
        }

        private string communicationExpencePercentage;
        public string CommunicationExpencePercentage
        {
            get => communicationExpencePercentage;
            set
            {
                communicationExpencePercentage = value;
                OnPropertyChanged(nameof(CommunicationExpencePercentage));
            }
        }

        private string eatingOutExpencePercentage;
        public string EatingOutExpencePercentage 
        { 
            get => eatingOutExpencePercentage;
            set
            {
                eatingOutExpencePercentage = value;
                OnPropertyChanged(nameof(EatingOutExpencePercentage));
            } 
        }

        private string entertainmentExpencePercentage;
        public string EntertainmentExpencePercentage
        {
            get => entertainmentExpencePercentage;
            set
            {
                entertainmentExpencePercentage = value;
                OnPropertyChanged(nameof(EntertainmentExpencePercentage));
            }
        }

        private string foodExpencePercentage;
        public string FoodExpencePercentage
        {
            get => foodExpencePercentage;
            set
            {
                foodExpencePercentage = value;
                OnPropertyChanged(nameof(FoodExpencePercentage));
            }
        }

        private string giftsExpencePercentage;
        public string GiftsExpencePercentage
        {
            get => giftsExpencePercentage;
            set
            {
                giftsExpencePercentage = value;
                OnPropertyChanged(nameof(GiftsExpencePercentage));
            }
        }

        private string healthExpencePercentage;
        public string HealthExpencePercentage
        {
            get => healthExpencePercentage;
            set
            {
                healthExpencePercentage = value;
                OnPropertyChanged(nameof(HealthExpencePercentage));
            }
        }

        private string houseExpencePercentage;
        public string HouseExpencePercentage
        {
            get => houseExpencePercentage;
            set
            {
                houseExpencePercentage = value;
                OnPropertyChanged(nameof(HouseExpencePercentage));
            }
        }

        private string petsExpencePercentage;
        public string PetsExpencePercentage
        {
            get => petsExpencePercentage;
            set
            {
                petsExpencePercentage = value;
                OnPropertyChanged(nameof(PetsExpencePercentage));
            }
        }

        private string sportsExpencePercentage;
        public string SportsExpencePercentage
        {
            get => sportsExpencePercentage;
            set
            {
                sportsExpencePercentage = value;
                OnPropertyChanged(nameof(SportsExpencePercentage));
            }
        }

        private string taxiExpencePercentage;
        public string TaxiExpencePercentage
        {
            get => taxiExpencePercentage;
            set
            {
                taxiExpencePercentage = value;
                OnPropertyChanged(nameof(TaxiExpencePercentage));
            }
        }

        private string toietryExpencePercentage;
        public string ToietryExpencePercentage
        {
            get => toietryExpencePercentage;
            set
            {
                toietryExpencePercentage = value;
                OnPropertyChanged(nameof(ToietryExpencePercentage));
            }
        }

        private string transportExpencePercentage;
        public string TransportExpencePercentage
        {
            get => transportExpencePercentage;
            set
            {
                transportExpencePercentage = value;
                OnPropertyChanged(nameof(TransportExpencePercentage));
            }
        }


        #endregion



        private double totalExpence = 0;
        private List<double> totalExpencePerCategory = new List<double>();




        private string totalIncome;
        public string TotalIncome
        {
            get => totalIncome; 
            set 
            { 
                totalIncome = value;
                OnPropertyChanged(nameof(TotalIncome));
            }
        }
        private List<double> totalIncomePerCategory = new List<double>();






        // Used to identify amount of money to add
        private string selectedSum;
        public string SelectedSum
        {
            get => selectedSum;
            set
            {
                selectedSum = value;
                OnPropertyChanged(nameof(SelectedSum));
            }
        }



        public void SaveUser()
        {
            _fileService.SaveUserInformation("user.xml", user);
        }


        #region Adding Expence Commands


        private Command _addCarExpenceCommand;
        public Command AddCarExpenceCommand
        {
            get
            {
                return _addCarExpenceCommand ?? (_addCarExpenceCommand = new DelegateCommand(obj =>
                    {
                        if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddCarExpence(Double.Parse(SelectedSum));
                    }));
            }
        }


        private Command _addClothesExpenceCommand;
        public Command AddClothesExpenceCommand
        {
            get
            {
                return _addClothesExpenceCommand ?? (_addClothesExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddClothesExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addCommunicacionsExpenceCommand;
        public Command AddCommunicacionsExpenceCommand
        {
            get
            {
                return _addCommunicacionsExpenceCommand ?? (_addCommunicacionsExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddCommunicationExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addEatingOutExpenceCommand;
        public Command AddEatingOutExpenceCommand
        {
            get
            {
                return _addEatingOutExpenceCommand ?? (_addEatingOutExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddEatingOutExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addEntertainmentExpenceCommand;
        public Command AddEntertainmentExpenceCommand
        {
            get
            {
                return _addEntertainmentExpenceCommand ?? (_addEntertainmentExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddEntertainmentExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addFoodExpenceCommand;
        public Command AddFoodExpenceCommand
        {
            get
            {
                return _addFoodExpenceCommand ?? (_addFoodExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddFoodExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addGiftsExpenceCommand;
        public Command AddGiftsExpenceCommand
        {
            get
            {
                return _addGiftsExpenceCommand ?? (_addGiftsExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddGiftsExpence(Double.Parse(SelectedSum));
                }));
            }
        }



        private Command _addHealthExpenceCommand;
        public Command AddHealthExpenceCommand
        {
            get
            {
                return _addHealthExpenceCommand ?? (_addHealthExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddHealthExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addHouseExpenceCommand;
        public Command AddHouseExpenceCommand
        {
            get
            {
                return _addHouseExpenceCommand ?? (_addHouseExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddHouseExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addPetsExpenceCommand;
        public Command AddPetsExpenceCommand
        {
            get
            {
                return _addPetsExpenceCommand ?? (_addPetsExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddPetsExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addSportsExpenceCommand;
        public Command AddSportsExpenceCommand
        {
            get
            {
                return _addSportsExpenceCommand ?? (_addSportsExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddSportsExpence(Double.Parse(SelectedSum));
                }));
            }
        }



        private Command _addTaxiExpenceCommand;
        public Command AddTaxiExpenceCommand
        {
            get
            {
                return _addTaxiExpenceCommand ?? (_addTaxiExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddTaxiExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addToiletryExpenceCommand;
        public Command AddToiletryExpenceCommand
        {
            get
            {
                return _addToiletryExpenceCommand ?? (_addToiletryExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddToiletryExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addTransportExpenceCommand;
        public Command AddTransportExpenceCommand
        {
            get
            {
                return _addTransportExpenceCommand ?? (_addTransportExpenceCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.ExpencesHolder.AddTransportExpence(Double.Parse(SelectedSum));
                }));
            }
        }


        #endregion


        #region Adding Income Commands

        private Command _addDepositIncomeCommand;
        public Command AddDepositIncomeCommand
        {
            get
            {
                return _addDepositIncomeCommand ?? (_addDepositIncomeCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.IncomesHolder.AddDepositIncome(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addsalaryIncomeCommand;
        public Command AddSalaryIncomeCommand
        {
            get
            {
                return _addsalaryIncomeCommand ?? (_addsalaryIncomeCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.IncomesHolder.AddSalaryIncome(Double.Parse(SelectedSum));
                }));
            }
        }


        private Command _addSavingsIncomeCommand;
        public Command AddSavingsIncomeCommand
        {
            get
            {
                return _addSavingsIncomeCommand ?? (_addSavingsIncomeCommand = new DelegateCommand(obj =>
                {
                    if (!String.IsNullOrEmpty(SelectedSum)) user.IncomesHolder.AddSavingsIncome(Double.Parse(SelectedSum));
                }));
            }
        }

        #endregion



        #region Choosing Time Interval Commands


        // gets Expences for all working period
        private Command _allIntervalCommand;
        public Command AllIntervalCommand
        {
            get
            {
                return _allIntervalCommand ?? (_allIntervalCommand = new DelegateCommand(obj =>
                {
                    SetListForAllPeriods();
                    SetPercentagesExpences();
                    SetTotalIncome();
                    }));
            }
        }


        // gets Expences for a provided day
        private Command _dayCommand;
        public Command DayCommand
        {
            get
            {
                return _dayCommand ?? (_dayCommand = new DelegateCommand(obj =>
                {
                    SetListForDay();
                    SetPercentagesExpences();
                    SetTotalIncome();
                }));
            }
        }


        // gets Expences for last week
        private Command _weekCommand;
        public Command WeekCommand
        {
            get
            {
                return _weekCommand ?? (_weekCommand = new DelegateCommand(obj =>
                {
                    SetListForLatestWeek();
                    SetPercentagesExpences();
                    SetTotalIncome();
                }));
            }
        }


        // gets Expences for last month
        private Command _monthCommand;
        public Command MonthCommand
        {
            get
            {
                return _monthCommand ?? (_monthCommand = new DelegateCommand(obj =>
                {
                    SetListForLatestMonth();
                    SetPercentagesExpences();
                    SetTotalIncome();
                }));
            }
        }


        // gets Expences for last year
        private Command _yearCommand;
        public Command YearCommand
        {
            get
            {
                return _yearCommand ?? (_yearCommand = new DelegateCommand(obj =>
                {
                    SetListForLatestYear();
                    SetPercentagesExpences();
                    SetTotalIncome();
                }));
            }
        }


        #region Setting totalExpencePerCategory and totalIncomePerCategory For Chosen Time Interval



        private void SetListForDay()
        {
            totalExpencePerCategory = user.ExpencesHolder.GetExpencesPerOneDay(DateTime.Now);
            totalIncomePerCategory = user.IncomesHolder.GetIncomesPerOneDay(DateTime.Now);
        }

        private void SetListForLatestWeek()
        {
            totalExpencePerCategory = user.ExpencesHolder.GetExpencesForLatestWeek();
            totalIncomePerCategory = user.IncomesHolder.GetIncomesForLatestWeek();
        }

        private void SetListForLatestMonth()
        {
            totalExpencePerCategory = user.ExpencesHolder.GetExpenceForLatestMonth();
            totalIncomePerCategory = user.IncomesHolder.GetIncomesForLatestMonth();
        }

        private void SetListForLatestYear()
        {
            totalExpencePerCategory = user.ExpencesHolder.GetExpenceForLatestYear();
            totalIncomePerCategory = user.IncomesHolder.GetIncomesForLatestYear();
        }

        private void SetListForAllPeriods()
        {
            totalExpencePerCategory = user.ExpencesHolder.GetAllExpences();
            totalIncomePerCategory = user.IncomesHolder.GetAllIncome();
        }


        #endregion




        #endregion



        // Sets expence percentage for all expences taken from totalExpencePerCategory
        // Should be manually modified when adding new type of Expence
        private void SetPercentagesExpences()
        {
            try
            {
                totalExpence = 0;

                for (int i = 0; i < totalExpencePerCategory.Count; i++)
                {
                    totalExpence += totalExpencePerCategory[i];
                }

                CarExpencePercentage = ( Math.Round((totalExpencePerCategory[0] / totalExpence), 2) * 100).ToString();
                ClothesExpencePercentage = (Math.Round((totalExpencePerCategory[1] / totalExpence), 2) * 100).ToString();
                CommunicationExpencePercentage = (Math.Round((totalExpencePerCategory[2] / totalExpence), 2) * 100).ToString();
                EatingOutExpencePercentage = (Math.Round((totalExpencePerCategory[3] / totalExpence), 2) * 100).ToString();
                EntertainmentExpencePercentage = (Math.Round((totalExpencePerCategory[4] / totalExpence), 2) * 100).ToString();
                FoodExpencePercentage = (Math.Round((totalExpencePerCategory[5] / totalExpence), 2) * 100).ToString();
                GiftsExpencePercentage = (Math.Round((totalExpencePerCategory[6] / totalExpence), 2) * 100).ToString();
                HealthExpencePercentage = (Math.Round((totalExpencePerCategory[7] / totalExpence), 2) * 100).ToString();
                HouseExpencePercentage = (Math.Round((totalExpencePerCategory[8] / totalExpence), 2) * 100).ToString();
                PetsExpencePercentage = (Math.Round((totalExpencePerCategory[9] / totalExpence), 2) * 100).ToString();
                SportsExpencePercentage = (Math.Round((totalExpencePerCategory[10] / totalExpence), 2) * 100).ToString();
                TaxiExpencePercentage = (Math.Round((totalExpencePerCategory[11] / totalExpence), 2) * 100).ToString();
                ToietryExpencePercentage = (Math.Round((totalExpencePerCategory[12] / totalExpence), 2) * 100).ToString();
                TransportExpencePercentage = (Math.Round((totalExpencePerCategory[13] / totalExpence), 2) * 100).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Sets expence percentage for all expences taken from totalIncomePerCategory
        // Should be manually modified when adding new type of Income
        private void SetTotalIncome()
        {
            try
            {
                double income = 0;

                for (int i = 0; i < totalIncomePerCategory.Count; i++)
                {
                    income += totalIncomePerCategory[i];
                }

                TotalIncome = income.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
