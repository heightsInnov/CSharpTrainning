class Calculate{
    int sum = 0;

    public int Add(int firstNumber, int secondNumber){
        sum = firstNumber + secondNumber;
        return sum;
    }

    public int Add(int[] numbers){
        foreach(int i in numbers){
            sum += i;
        }
        return sum;
    }

    public int Add(int number){
          return  sum += number;
    }

    public int Add(int firstNumber, int secondNumber, int thirdNumber){
          return  sum = firstNumber + secondNumber + thirdNumber;
    }
}