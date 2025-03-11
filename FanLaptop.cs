using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Jurnal4
{

    class FanLaptop
    {
        enum State { BALANCED, PERFORMANCE, TURBO, QUITE };
        private State currentState;
        State state = State.QUITE;
        public FanLaptop() { 
            currentState = State.QUITE;
            Console.WriteLine("Fan dalam keadaan quite");
        }

        public void modeUp()
        {
            if (currentState == State.QUITE)
            {
                Console.WriteLine("Fan Quite berubah menjadi Balanced");
                currentState = State.BALANCED;
            }
            else if (currentState == State.BALANCED)
            {
                Console.WriteLine("Fan Balanced berubah menjadi Performance");
                currentState = State.PERFORMANCE;
            }
            else if (currentState == State.PERFORMANCE) {
                Console.WriteLine("Fan Performance berubah menjadi Turbo");
                currentState = State.TURBO;
            }
        }

        public void modeDown() {
            if (currentState == State.BALANCED)
            {
                Console.WriteLine("Fan Balanced berubah menjadi Quite");
                currentState = State.QUITE;
            }
            else if (currentState == State.TURBO)
            {
                Console.WriteLine("Fan Turbo berubah menjadi Performance");
                currentState = State.PERFORMANCE;
            }
            else if (currentState == State.PERFORMANCE) {
                Console.WriteLine("Fan Performance berubah menjadi Balanced");
                currentState = State.BALANCED;
            }
        }
        public void turboShortcut()
        {
            if (currentState == State.QUITE)
            {
                Console.WriteLine("Fan Quite berubah menjadi Turbo");
                currentState = State.TURBO;
            }
            else if (currentState == State.TURBO) {
                Console.WriteLine("Fan Turbo berubah menjadi Quite");
                currentState = State.QUITE;
            }
        }

    }
}
