using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Alarm
{
    public partial class Form1 : Form
    {
        DateTime alarmTime;

        Thread alarmThread;
        TimeSpan workTimeDefault = new TimeSpan(0, 30, 0);
        TimeSpan workTimeElapsed = new TimeSpan(0, 0, 0);
        TimeSpan availableFreeTime = new TimeSpan(0, 0, 0);
        TimeSpan currentAlarmTimeSpan;
        Enums.alarmType currentAlarmType;
        TimeSpan freeTimeDividend = new TimeSpan(1, 6, 6);
        bool validTimeSpan_free=true;
        bool validTimeSpan_work=true;

        public Form1()
        {
            InitializeComponent();
            WorkTimeBox.Text = workTimeDefault.ToString();
            
            refreshControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tempTime;
            tempTime = alarmTimeInput.Text;
            DateTime outResult;

            if (DateTime.TryParse(tempTime, out outResult))
            {
                setAlarm(outResult);
            }
            else
            {
                if (!alarmThread.IsAlive)
                {
                    AlarmStatusLabel.Text = "Invalid time";
                }
            }
        }

        private void setAlarm(DateTime alarmTime)
        {
            this.alarmTime = alarmTime;
            if (alarmThread != null)
            {
                if (alarmThread.IsAlive)
                {
                    alarmThread.Abort();
                }
            }

            alarmThread = new Thread(new ThreadStart(alarmLoop));
            alarmThread.Start();
            AlarmStatusLabel.Text = "Alarm set for " + this.alarmTime.ToString("HH:mm");
            WindowState = FormWindowState.Minimized;
        }

        private void alarmLoop()
        {
            while (DateTime.Now < alarmTime)
            {
                ;
            }
            this.Invoke((MethodInvoker)delegate
            {
                AlarmStatusLabel.Text = "Time's up!";
                modifyTimeTotals();
                refreshControls();
                WindowState = FormWindowState.Normal;
                this.TopMost = true;
                this.TopMost = false;

            });

        }

        private void refreshControls()
        {
            WorkTimeElapsedLabel.Text = workTimeElapsed.ToString();
            availableFreeTimeLabel.Text = availableFreeTime.ToString();
            FreeTimeBox.Text = availableFreeTime.ToString();
        }

        private void modifyTimeTotals()
        {
            switch (currentAlarmType)
            {
                case Enums.alarmType.free:
                    availableFreeTime = availableFreeTime.Subtract(currentAlarmTimeSpan);
                    break;
                case Enums.alarmType.work:
                    workTimeElapsed = workTimeElapsed.Add(currentAlarmTimeSpan);
                    int hours = currentAlarmTimeSpan.Hours / freeTimeDividend.Hours;
                    int minutes = currentAlarmTimeSpan.Minutes / freeTimeDividend.Minutes;
                    int seconds = currentAlarmTimeSpan.Seconds / freeTimeDividend.Seconds;
                    TimeSpan addFreeTime = new TimeSpan(hours,minutes,seconds);
                    availableFreeTime = availableFreeTime.Add(addFreeTime);
                    break;
            }
        }

        private void setAlarmFromTimeSpan(TimeSpan timeSpan)
        {
            currentAlarmTimeSpan = timeSpan;
            DateTime nowPlusDefault = DateTime.Now.Add(timeSpan);
            setAlarm(nowPlusDefault);
        }

        private TimeSpan getTimeSpanFromString(string input)
        {
            int[] timeSpanArray = input.Split(':').Select(c => int.Parse(c)).ToArray();
            TimeSpan timeSpan = new TimeSpan(timeSpanArray[0], timeSpanArray[1], timeSpanArray[2]);
            return timeSpan;
        }

        private TimeSpan getTimeSpanFromBox(TextBox box)
        {
            return getTimeSpanFromString(box.Text);
        }

        private void WorkTimeButton_Click(object sender, EventArgs e)
        {
            if (boxHasValidTimeSpan(WorkTimeBox))
            {
                currentAlarmType = Enums.alarmType.work;
                setAlarmFromTimeSpan(getTimeSpanFromBox(WorkTimeBox));
            }
        }

        private void FreeTimeButton_Click(object sender, EventArgs e)
        {
            if (sufficientFreeTime()&&boxHasValidTimeSpan(FreeTimeBox))
            {
                currentAlarmType = Enums.alarmType.free;
                setAlarmFromTimeSpan(getTimeSpanFromBox(FreeTimeBox));
            }
        }

        private void FreeTimeBox_TextChanged(object sender, EventArgs e)
        {
            TimeSpan result;
            if(!TimeSpan.TryParse(FreeTimeBox.Text,out result))
            {
                messageLabel.Text = "Time must be in format #+:#+:#+";
            }
            else if (!sufficientFreeTime())
            {
                messageLabel.Text = "Insufficient free time available.";
            }
            else
            {
                messageLabel.Text = "";
            }

        }

        private bool sufficientFreeTime()
        {
            TimeSpan userEnteredTime = getTimeSpanFromBox(FreeTimeBox);
            int comparison = TimeSpan.Compare(userEnteredTime, availableFreeTime);
            return comparison != 1;

        }

        private bool boxHasValidTimeSpan(TextBox textBox)
        {
            TimeSpan result;
            return TimeSpan.TryParse(textBox.Text, out result);
        }


    }
}
