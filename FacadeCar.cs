using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

  
    public class FacadeCar
    {

        public void CompleteCarMade()
        {
            CarName name = new CarName();
            name.CarNameWithModel();
            CarColor color = new CarColor();
            CarEngine engine = new CarEngine();
           
            color.getColor();
            engine.getEngine();
        }
    }

}
