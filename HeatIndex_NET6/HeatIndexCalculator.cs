using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HeatIndex_NET6
{
    public enum ExceptionType
    {
        Warning,
        Error,
        Info
    }
    public class HeatIndexCalculator : IDisposable
    {
        ChromeOptions chromeOptions = new ChromeOptions();
        IWebDriver? driver;
        public event EventHandler<ErrorArgs> ErrorHandler;
        public event EventHandler<HeatIndexArgs> CalculatorHandler;
        private string? temperature_text;
        private string? humidity_text;
        private string? url = null;
        private double HeatIndex;   //攝氏
        private double adjustment;  //攝氏
        private double SimpleTest;  //華氏
        private bool isdriverclosed = true;
        private bool disposedValue;

        public async Task Calculate(int index)
        {
            HeatIndex = -2;
            temperature_text = null;
            humidity_text = null;
            chromeOptions.AddArguments("headless");

            switch(index)
            {
                case 0:
                    url = "https://www.cwb.gov.tw/V8/C/W/OBS_Station.html?ID=C0K46";    //斗南
                    break;
                case 1:
                    url = "https://www.cwb.gov.tw/V8/C/W/OBS_Station.html?ID=A0C41";    //中央大學
                    break;
                case 2:
                    url = "https://www.cwb.gov.tw/V8/C/W/OBS_Station.html?ID=A2C56";    //農工中心
                    break;
                case 3:
                    url = "https://www.cwb.gov.tw/V8/C/W/OBS_Station.html?ID=A0A01";    //臺灣大學
                    break;
                case 4:
                    url = "https://www.cwb.gov.tw/V8/C/W/OBS_Station.html?ID=C0C70";    //中壢
                    break;
                case 5:
                    url = "https://www.cwb.gov.tw/V8/C/W/OBS_Station.html?ID=CAAH6";    //大安森林
                    break;
            }

            try
            {
                await Task.Delay(1);
                driver = new ChromeDriver();
                isdriverclosed = false;
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
                temperature_text = driver.FindElement(By.CssSelector("#obstime > tr:nth-child(1) > td:nth-child(2) > span.tem-C.is-active")).Text;
                humidity_text = driver.FindElement(By.CssSelector("#obstime > tr:nth-child(1) > td:nth-child(8)")).Text;
            }

            catch (NoSuchElementException ex)
            {
                var localErrorHandler = new EventHandler<ErrorArgs>(ErrorHandler);
                var ar = new ErrorArgs(ex.Message, ExceptionType.Warning);
                localErrorHandler(null, ar);
            }

            catch (Exception ex)
            {
                var localErrorHandler = new EventHandler<ErrorArgs>(ErrorHandler);
                var ar = new ErrorArgs(ex.Message, ExceptionType.Error);
                localErrorHandler(null, ar);
            }

            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                }
                isdriverclosed = true;
            }

            if (double.TryParse(temperature_text, out double temperature))
            {
                if (double.TryParse(humidity_text, out double humidity))
                {
                    SimpleTest = 0.5 * ((temperature * 9.0 / 5.0 + 32.0) + 61.0 + (((temperature * 9.0 / 5.0+ 32.0) - 68.0) * 1.2) + humidity * 0.094);
                    if (SimpleTest >= 79.5)
                    {
                        HeatIndex = -8.78469475556 + 1.61139411 * temperature + 2.33854883889 * humidity
                        - 0.14611605 * temperature * humidity - 0.012308094 * temperature * temperature
                        - 0.0164248277778 * humidity * humidity + 0.002211732 * temperature * temperature * humidity
                        + 0.00072546 * temperature * humidity * humidity
                        - 0.000003582 * temperature * temperature * humidity * humidity;
                        if (humidity > 85 && temperature > 26.6 && temperature < 30.6)
                        {
                            adjustment = ((humidity - 85.0) / 10.0) * ((((87.0 - 32.0) / 9.0 * 5.0) - temperature) / 5.0);
                            HeatIndex = HeatIndex + adjustment;
                        }
                        if (humidity < 13 && temperature > 26.6 && temperature < 44.5)
                        {
                            adjustment = ((13.0 - humidity) / 4.0) * Math.Sqrt((17.0 - Math.Abs((temperature * 9.0 / 5.0 + 32.0) - 95.0)) / 17.0);
                            adjustment = (adjustment - 32.0) / 9.0 * 5.0;
                            HeatIndex = HeatIndex - adjustment;
                        }
                    }
                    else
                    {
                        SimpleTest = 0.5 * (SimpleTest + (temperature * 9 / 5 + 32));
                        HeatIndex = (SimpleTest - 32) / 9 * 5;
                    }
                }
            }

            var localCalculatorHandler = new EventHandler<HeatIndexArgs>(CalculatorHandler);
            HeatIndexArgs ar_index;
            if (HeatIndex == -2)
            {
                var localErrorHandler = new EventHandler<ErrorArgs>(ErrorHandler);
                var ar = new ErrorArgs("請稍後重試...", ExceptionType.Info);
                localErrorHandler(null, ar);
                ar_index = new HeatIndexArgs("-2");
            }
            else
            {
                ar_index = new HeatIndexArgs(String.Format("{0}", Math.Round(HeatIndex, 0)));
            }
            localCalculatorHandler(null, ar_index);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 處置受控狀態 (受控物件)
                }

                // TODO: 釋出非受控資源 (非受控物件) 並覆寫完成項
                // TODO: 將大型欄位設為 Null
                try
                {
                    if (isdriverclosed == false)
                    {
                        driver.Quit();
                        driver.Dispose();
                    }
                }

                finally
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                disposedValue = true;
            }
        }

        // // TODO: 僅有當 'Dispose(bool disposing)' 具有會釋出非受控資源的程式碼時，才覆寫完成項
        ~HeatIndexCalculator()
        {
            // 請勿變更此程式碼。請將清除程式碼放入 'Dispose(bool disposing)' 方法
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // 請勿變更此程式碼。請將清除程式碼放入 'Dispose(bool disposing)' 方法
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
    public class ErrorArgs : EventArgs
    {
        public string ErrorMessage { get; }
        public ExceptionType ErrorType { get; }
        public ErrorArgs(string Message, ExceptionType Type) 
        {
            ErrorMessage = Message;
            ErrorType = Type;
        }
    }
    public class HeatIndexArgs : EventArgs
    {
        public string HeatIndex { get; }
        public HeatIndexArgs(string heatIndex)
        {
            HeatIndex = heatIndex;
        }
    }
}
