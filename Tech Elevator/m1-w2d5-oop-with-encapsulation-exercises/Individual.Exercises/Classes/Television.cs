using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        private bool isOn;
        private int currentChannel;
        private int currentVolume;

        public bool IsOn
        {
            get { return isOn; }
        }
        public int CurrentChannel
        {
            get { return currentChannel; }
        }
        public int CurrentVolume
        {
            get { return currentVolume; }
        }

        public Television()
        {
            isOn = false;
            currentChannel = 3;
            currentVolume = 2;
        }

        public void TurnOff()
        {
            isOn = false;
        }
        public void TurnOn()
        {
            isOn = true;
        }
        public void ChangeChannel(int newChannel)
        {
            if (newChannel >= 3 && newChannel <= 18 && isOn == true)
            {
                currentChannel = newChannel;
            }
        }
        public void ChannelUp()
        {
            if (isOn == true && currentChannel == 18)
            {
                currentChannel = 3;
            }
            else if (isOn == true && currentChannel < 18)
            {
                currentChannel += 1;
            }
        }
        public void ChannelDown()
        {
            if (isOn == true && currentChannel == 3)
            {
                currentChannel = 18;
            }
            else if (isOn == true && currentChannel > 3)
            {
                currentChannel -= 1;
            }
        }
        public void RaiseVolume()
        {
            if (currentVolume < 10 && isOn == true)
            {
                currentVolume += 1;
            }
        }
        public void LowerVolume()
        {
            if (currentVolume > 0 && isOn == true)
            {
                currentVolume -= 1;
            }
        }
    } 
}
