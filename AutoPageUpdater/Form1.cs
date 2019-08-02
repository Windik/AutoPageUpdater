using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AutoPageUpdater
{
    public partial class Form1 : Form
    {
        public string addressText = @"http://google.ru";
        public string infoLabelDefaultText = "Количество прошедших обновлений: ";
        public string timeToUpdateDefaultText = "Текущее время до обновления: ";
        public int countOfUpdatesInt = 1;
        public int currentCountOfUpdates = 0;
        public int minTimeInt = 30;
        public int maxTimeInt = 180;
        public Random rnd = new Random();
        public int curTimeRandom;
        public Thread seleniumThread;
        public Thread timerThread;
        public delegate void inUpdater();
        public delegate void inTimer();
        public int counter;
        public Boolean isExit = false;
        public Boolean isDriverClosed = true;

        public IWebDriver driver;

        public Form1()
        {
            

            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (addressBox.Text.ToString() != "") { 
                // Получаем введенный адрес
                addressText = addressBox.Text.ToString();
            }
            if (countOfUpdates.Text.ToString() != "" && Convert.ToInt32(countOfUpdates.Text.ToString()) > 0)
            {
                // Получаем количество обновлений страницы и конвертируем в число
                countOfUpdatesInt = Convert.ToInt32(countOfUpdates.Text.ToString());
            }
            if (minTimeUpdate.Text.ToString() != "" && Convert.ToInt32(minTimeUpdate.Text.ToString()) > 0)
            {
                // Получаем минимальное время
                minTimeInt = Convert.ToInt32(minTimeUpdate.Text.ToString());
            }
            if (maxTimeUpdate.Text.ToString() != "" && Convert.ToInt32(maxTimeUpdate.Text.ToString()) > 0)
            {
                maxTimeInt = Convert.ToInt32(maxTimeUpdate.Text.ToString());
            }
            isExit = false;
            
            seleniumThread = new Thread(pageUpdater);
            seleniumThread.Start();

            
        }

        public void pageUpdater()
        {
            // открываем браузер Хром
            driver = new ChromeDriver();
            timerThread = new Thread(backTimer);
            timerThread.Start();
            
            // Цикл обновлений страницы
            while (currentCountOfUpdates < countOfUpdatesInt)
            {
                if (isExit == false)
                {
                    // открываем браузер Хром
                    // driver = new ChromeDriver();
                    // Увеличиваем счетчик
                    currentCountOfUpdates += 1;
                    countUpdates();
                    driver.Navigate().GoToUrl(addressText);
                    curTimeRandom = rnd.Next(minTimeInt, maxTimeInt);
                    counter = curTimeRandom;
                    Thread.Sleep(curTimeRandom * 1000);
                } else
                {
                    driver.Close();
                    driver.Quit();
                    stopThreads();
                    break;
                }
            }
            if (isExit == false)
            {
                driver.Close();
                driver.Quit();
                
            }
            
        }

        public void backTimer()
        {
            timeUpdates();
        }

        public void updateCounter()
        {
            infoLabel.Text = infoLabelDefaultText + currentCountOfUpdates.ToString();

        }

        public void countUpdates()
        {
;
            infoLabel.BeginInvoke(new inUpdater(updateCounter));

        }

        public void timerCounter()
        {

                timeToUpdate.Text = timeToUpdateDefaultText + counter.ToString();
      
        }

        public void timeUpdates()
        {
            
            while (true)
            {
                if (counter > 0)
                {
                    timeToUpdate.BeginInvoke(new inTimer(timerCounter));
                    counter -= 1;
                    Thread.Sleep(1000);
                } else
                {

                }
            }
            

        }

        // https://www.twitch.tv/thewindik

        private void stopButton_Click(object sender, EventArgs e)
        {
            isExit = true;


            //driver.Quit();
            stopThreads();
            
        }

        public void stopThreads()
        {
            if (seleniumThread != null)
            {
                seleniumThread.Abort();
            }
            if (timerThread != null)
            {
                timerThread.Abort();
            }
        }

        public void upChacker(TextBox tbx)
        {
            if (tbx.Text != "")
            {
                //MessageBox.Show(countOfUpdates.Text);
                if (Convert.ToDouble(tbx.Text.ToString()) > 99999)
                {
                    tbx.Text = "99999";
                }
                if (Convert.ToDouble(tbx.Text.ToString()) < 1)
                {
                    tbx.Text = "1";
                }
            }
        }

        private void countOfUpdates_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
               
            }
            
        }

        private void countOfUpdates_KeyUp(object sender, KeyEventArgs e)
        {
            upChacker(countOfUpdates);
        }

        private void minTimeUpdate_KeyUp(object sender, KeyEventArgs e)
        {
            upChacker(minTimeUpdate);
        }

        private void maxTimeUpdate_KeyUp(object sender, KeyEventArgs e)
        {
            upChacker(maxTimeUpdate);
        }

        private void minTimeUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void maxTimeUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }


    }
}
