using System;
namespace FeeCalculator {
	public class Program {

		public static void Main(string[] args) {
			double[] fees = new double[5];
			double[] discountedFees = new double[5];
			discountedFees = calculateDiscount(fees);
			Console.WriteLine("--------------------------------");
			Console.WriteLine("The fees with discount are as : ");
			for(int i = 0; i < 5; i++) {
				Console.WriteLine("Student " + (i + 1) + ": " + discountedFees[i]);
			}
		}

		public static double[] calculateDiscount(double[] fees) {
			for(int i = 0; i < 5; i++) {
				fees[i] = takeInput(i);
			}
			for(int i = 0; i < 5; i++) {
				if(fees[i] > 7000) {
					fees[i] = fees[i] - (fees[i] * 0.05);
				}
			}
			return fees;
		}
		
		public static double takeInput(int i) {
			Console.Write("Enter fees of " + (i + 1) + " student : ");
			double temp = double.Parse(Console.ReadLine());
			if(temp < 5000 || temp > 10000) {
				Console.WriteLine("Error! fees must be in the range of 5000 to 10000");
				temp = takeInput(i);
			}
			return temp;
		}
	}
}
