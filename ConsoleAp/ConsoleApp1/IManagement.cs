using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // Abtract
    public interface IManagement
    {
        public abstract void controlView();
        public abstract void controlCreate();
        public abstract void ControllUpdate();
        public abstract void controlFind();
        public abstract void controlDelete();


        public abstract void MainMenu();

        public abstract void MenuView();

        public abstract void MenuAdd();

        public abstract void MenuUpdate();


        public abstract void MenuFind();


    }
}
