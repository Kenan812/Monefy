using Monefy.Model.Expences;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Monefy.Model.Holders
{
    public class ExpencesHolder
    {
        private List<List<IExpence>> allExpences = new List<List<IExpence>>();


        public ExpencesHolder()
        {
            List<IExpence> carExpences = new List<IExpence>();
            List<IExpence> clothesExpences = new List<IExpence>();
            List<IExpence> communicationsExpences = new List<IExpence>();
            List<IExpence> eatingOutExpences = new List<IExpence>();
            List<IExpence> entertainmentExpences = new List<IExpence>();
            List<IExpence> foodExpences = new List<IExpence>();
            List<IExpence> giftsExpences = new List<IExpence>();
            List<IExpence> healthExpences = new List<IExpence>();
            List<IExpence> houseExpences = new List<IExpence>();
            List<IExpence> petsExpences = new List<IExpence>();
            List<IExpence> sportsExpences = new List<IExpence>();
            List<IExpence> taxiExpences = new List<IExpence>();
            List<IExpence> toiletryExpences = new List<IExpence>();
            List<IExpence> transportExpences = new List<IExpence>();

            allExpences.Add(carExpences);
            allExpences.Add(clothesExpences);
            allExpences.Add(communicationsExpences);
            allExpences.Add(eatingOutExpences);
            allExpences.Add(entertainmentExpences);
            allExpences.Add(foodExpences);
            allExpences.Add(giftsExpences);
            allExpences.Add(healthExpences);
            allExpences.Add(houseExpences);
            allExpences.Add(petsExpences);
            allExpences.Add(sportsExpences);
            allExpences.Add(taxiExpences);
            allExpences.Add(toiletryExpences);
            allExpences.Add(transportExpences);
        }



        #region Add Expence

        /* Add new mehtod for each new expence */


        public void AddCarExpence(double sum)
        {
            allExpences[0].Add(new CarExpence(sum));
        }


        public void AddClothesExpence(double sum)
        {
            allExpences[1].Add(new ClothesExpence(sum));
        }


        public void AddCommunicationExpence(double sum)
        {
            allExpences[2].Add(new CommunicationsExpence(sum));
        }


        public void AddEatingOutExpence(double sum)
        {
            allExpences[3].Add(new EatingOutExpence(sum));
        }


        public void AddEntertainmentExpence(double sum)
        {
            allExpences[4].Add(new EntertainmentExpence(sum));
        }


        public void AddFoodExpence(double sum)
        {
            allExpences[5].Add(new FoodExpence(sum));
        }


        public void AddGiftsExpence(double sum)
        {
            allExpences[6].Add(new GiftsExpence(sum));
        }


        public void AddHealthExpence(double sum)
        {
            allExpences[7].Add(new HealthExpence(sum));
        }


        public void AddHouseExpence(double sum)
        {
            allExpences[8].Add(new HouseExpence(sum));
        }


        public void AddPetsExpence(double sum)
        {
            allExpences[9].Add(new PetsExpence(sum));
        }


        public void AddSportsExpence(double sum)
        {
            allExpences[10].Add(new SportsExpence(sum));
        }


        public void AddTaxiExpence(double sum)
        {
            allExpences[11].Add(new TaxiExpence(sum));
        }


        public void AddToiletryExpence(double sum)
        {
            allExpences[12].Add(new ToiletryExpence(sum));
        }


        public void AddTransportExpence(double sum)
        {
            allExpences[13].Add(new TransportExpence(sum));
        }


        #endregion


        #region Get Expences for Provided Time Span


        /*
         
         Return order:
            -car
            -clothes
            -communication
            -eatingOut
            -entertainment
            -food
            -gifts
            -health
            -house
            -pets
            -sports
            -taxi
            -toiletry
            -transport
         */


        public List<double> GetAllExpences()
        {
            List<double> sums = new List<double>();
            double totalCount = 0;

            for (int i = 0; i < allExpences.Count; i++)
            {
                totalCount = 0;
                
                for (int j = 0; j < allExpences[i].Count; j++)
                {
                    totalCount += allExpences[i][j].TotalSum;
                }

                sums.Add(totalCount);
            }


            return sums;
        }


        public List<double> GetExpencesPerOneDay(DateTime day)
        {
            List<double> sums = new List<double>();

            // Default values
            for (int i = 0; i < allExpences.Count; i++)
            {
                sums.Add(0);
            }


            for (int i = 0; i < allExpences.Count; i++)
            {
                for (int j = 0; j < allExpences[i].Count; j++)
                {
                    if (allExpences[i][j].ExecutionDate.Day == day.Day && allExpences[i][j].ExecutionDate.Month == day.Month && allExpences[i][j].ExecutionDate.Year == day.Year)
                    {
                        sums[i] += allExpences[i][j].TotalSum;
                    }

                    else if ((allExpences[i][j].ExecutionDate.Year > day.Year) || (allExpences[i][j].ExecutionDate.Year == day.Year && allExpences[i][j].ExecutionDate.Month > day.Month) ||
                        (allExpences[i][j].ExecutionDate.Day > day.Day && allExpences[i][j].ExecutionDate.Month == day.Month && allExpences[i][j].ExecutionDate.Year == day.Year))
                    {
                        break;
                    }
                }
            } 

            return sums;
        }


        public List<double> GetExpencesForLatestWeek()
        {

            List<double> sums = new List<double>();

            // Default values
            for (int i = 0; i < allExpences.Count; i++)
            {
                sums.Add(0);
            }

            for (int i = 0; i < allExpences.Count; i++)
            {
                for (int j = 0; j < allExpences[i].Count; j++)
                {
                    if (allExpences[i][j].ExecutionDate.DayOfWeek == DateTime.Now.DayOfWeek && (DateTime.Now.DayOfYear - allExpences[i][j].ExecutionDate.DayOfYear <= 7))
                    {
                        sums[i] += allExpences[i][j].TotalSum;
                    }
                    else if (DateTime.Now.DayOfYear - allExpences[i][j].ExecutionDate.DayOfYear > 7)
                    {
                        break;
                    }
                }
            }

            return sums;
        }


        public List<double> GetExpenceForLatestMonth()
        {
            List<double> sums = new List<double>();
            
            // Default values
            for (int i = 0; i < allExpences.Count; i++)
            {
                sums.Add(0);
            }

            for (int i = 0; i < allExpences.Count; i++)
            {
                for (int j = 0; j < allExpences[i].Count; j++)
                {
                    if (DateTime.Now.Month == allExpences[i][j].ExecutionDate.Month && DateTime.Now.Year == allExpences[i][j].ExecutionDate.Year)
                    {
                        sums[i] += allExpences[i][j].TotalSum;
                    }
                }
            }

            return sums;
        }



        public List<double> GetExpenceForLatestYear()
        {
            List<double> sums = new List<double>();

            // Default values
            for (int i = 0; i < allExpences.Count; i++)
            {
                sums.Add(0);
            }

            for (int i = 0; i < allExpences.Count; i++)
            {
                for (int j = 0; j < allExpences[i].Count; j++)
                {
                    if (DateTime.Now.Year == allExpences[i][j].ExecutionDate.Year)
                    {
                        sums[i] += allExpences[i][j].TotalSum;
                    }
                }
            }

            return sums;
        }

        #endregion


    }


    public enum Expence
    {
        carExpence = 0,
        clothesExpence,
        communicationExpence,
        eatingOutExpence,
        entertainmentExpence,
        foodExpence,
        giftsExpence,
        healthExpence,
        houseExpence,
        petsExpence,
        sportsExpence,
        taxiExpence,
        toiletryExpence,
        transportExpence
    }

}
