
namespace TechnicalInterview {
    public class Calculator{


        public int Sum(){
            return 0;
        }


        public int Sum( string number ) {           
            return number.Split('\n', ',').Select(int.Parse).Sum();
        }
    }
}