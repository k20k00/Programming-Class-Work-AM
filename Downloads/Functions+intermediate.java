
static int SomeMathFunction(int num1, int num2){
	int sum = num1 +num2;
	return sum;
}

static int SomeMathFunction(int num1, int num2, int num3){
	int result = num1 +num2 +num3;
	result = result /3;
	return result;
}

static int SomeMathFunction(int num1){
	int result = SomeOtherMathFunction(num1,num1);
	result =  SomeMathFunction(result,result,12);
	return sum;
}

static int SomeOtherMathFunction(int num1, int num2){
	int sum = num1 +num2;
	return sum;
}


1. 17
2. 7
3. 5
4. 3
5. 6
6. 8
7. 8
8. 13
9. 7
10. 17