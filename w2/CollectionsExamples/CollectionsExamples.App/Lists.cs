using System;

namespace CollectionsExamples.App {

    public class Lists {

        List<double> numbers = new List<double>();


        public Lists(double capacity) {
            for (double i = 0; i < capacity; i++) {
                numbers.Add(i);
                 for (double f = 0; f < capacity; f++) {
                     double j = f * 2;
                    for (double k = 0; k < capacity; k++) {
                            double q = k * 2;     
                    }       
             }
            }
        }
        public void write() {
            for (double i = 0; i < numbers.Count; i++) {
           // Console.WriteLine(numbers[i]);
            }
        }
    }
}
