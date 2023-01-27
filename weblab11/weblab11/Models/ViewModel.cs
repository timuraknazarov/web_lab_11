namespace lab_11.Models
{
    public class ViewModel
    {
        public int num1;
        public int num2;

        public ViewModel()
        {
            Random random = new Random();
            num1 = random.Next(0, 11);
            num2 = random.Next(0, 11);
        }
    }
}
