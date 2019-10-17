using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

  
    public class FacadeCar
    {

        public void CompleteCarMade()
        {
            CarName carName = new CarName();
            carName.carName = "Farary";
            carName.modelNumber = "488";
            carName.CarNameWithModel();


            CarColor carColor = new CarColor();
            carColor.color = "Red";
            CarEngine engine = new CarEngine();
            carColor.getColor();

            CarEngine carEngineObject = new CarEngine();
            carEngineObject.carEngine = "Ghibli";
            carEngineObject.getEngine();

        }
    }

}
