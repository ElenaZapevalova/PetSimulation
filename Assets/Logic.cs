using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;


   public class Logic
    {
 
      //string hungry;
        public void Save(string name, string age, string hungry, string happy, string health, string energy, int colorNumber)
        {
            string fileName = "settings.txt";
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Truncate, FileAccess.Write)))
            {              
                sw.WriteLine(name);           
                sw.WriteLine(age);
                sw.WriteLine(hungry);
                sw.WriteLine(happy);
                sw.WriteLine(health);
                sw.WriteLine(energy);
                sw.WriteLine(DateTime.UtcNow);
                sw.WriteLine(colorNumber);

            }
        }

        public string[] Load()
        {
            Pet pet = new Pet();

            string fileName = "settings.txt";

            try
            {                                  //чтение файла
                string[] allText = File.ReadAllLines(fileName);         //чтение всех строк файла в массив строк
                int age = Int32.Parse(allText[1]);
                int hungry = Int32.Parse(allText[2]);
                int happy = Int32.Parse(allText[3]);
                int health = Int32.Parse(allText[4]);
                int energy = Int32.Parse(allText[5]);
                int color = Int32.Parse(allText[7]);



                DateTime start = DateTime.Parse(allText[6]);
                DateTime end = DateTime.UtcNow;

                int minutes = (int)Math.Ceiling((end - start).TotalMinutes);
                int periodsElapsed = minutes / 10;
                

                
                
                int endHungry = Int32.Parse(pet.statsDown(hungry.ToString(), periodsElapsed,6));

                int startHungry = hungry;
            /*      int startValueHungry = (startHungry < 30) ? startHungry : 30;
                  int hungryNumber = (startValueHungry - endHungry) / 6;
                  if (hungryNumber == 0)
                  {
                      hungryNumber = startValueHungry / 6;
                  }

                  int startEnergy = energy;
            /*      int startValueEnergy = (startEnergy < 30) ? startEnergy : 30;
                  int energyNumber = (startValueEnergy - endEnergy) / 3;
                  if (energyNumber == 0)
                  {
                      energyNumber = startValueEnergy / 3;
                  }

                  health = Int32.Parse(pet.statsDown(health.ToString(), Math.Max(hungryNumber, energyNumber),4));
                  */
            health = Int32.Parse(pet.statsDown(health.ToString(), periodsElapsed, 4);
            int endEnergy = Int32.Parse(pet.statsDown(energy.ToString(), periodsElapsed, 3));
            happy = Int32.Parse(pet.statsDown(happy.ToString(), periodsElapsed,5));

            age += calculateDays(start, end);

            return new string[] {endHungry.ToString(), happy.ToString(), health.ToString(), endEnergy.ToString(), allText[0], age.ToString(), color.ToString()};
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            return new string[] { };
            }
        }

    private int calculateDays(DateTime start, DateTime end)
    {
        double days = Math.Abs(Math.Round((end - start).TotalDays, MidpointRounding.ToEven));

        if (days < 0)
        {
            days = 0;
        }

        return (int)days;
    }
		
        public void NewGame(string name, int color)
        {

            string fileName = "settings.txt";                //пишем полный путь к файлу
            if (File.Exists(fileName) != true)
            {  //проверяем есть ли такой файл, если его нет, то создаем
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
                {
                    sw.WriteLine(name);             //пишем строчку, или пишем что хотим
                    sw.WriteLine("0");
                    sw.WriteLine("100");
                    sw.WriteLine("100");
                    sw.WriteLine("100");
                    sw.WriteLine("100");
                    sw.WriteLine(DateTime.UtcNow);
                    sw.WriteLine(color);
                }
            }
            else
            {                              //если файл есть, то откываем его и пишем в него 
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Truncate, FileAccess.Write)))
                {
                    //  (sw.BaseStream).Seek(0, SeekOrigin.End);         //идем в конец файла и пишем строку или пишем то, что хотим
                    sw.WriteLine(name);             //пишем строчку, или пишем что хотим
                    sw.WriteLine("0");
                    sw.WriteLine("100");
                    sw.WriteLine("100");
                    sw.WriteLine("100");
                    sw.WriteLine("100");
                    sw.WriteLine(DateTime.UtcNow);
                    sw.WriteLine(color);

                }
            }
        }
    }

