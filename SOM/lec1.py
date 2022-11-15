# Exercise 1
def prod3(x1,x2,x3):
    return (x1 * x2 * x3)

# Exercise 2
def square(x):
    return x * x
def quadProd3(x1,x2,x3):
    print(prod3(square(x1), square(x2), square(x3)))

# Exercise 3 
def BMI(weight, height):
   print( weight / height **2 )


# Exercise 6

def compareLengths(string1,string2):
    if len(string1) == len(string2):
        print("True")
    else: print ("False")

# Exercise 7 & 8 & 20

def getSum(n):
 
    sum = 0
    while (n != 0):
 
        sum = sum + int(n % 10)
        n = int(n/10)
    
    return sum

def countDigits(x):
    print(getSum(x))

# Exercise 10

def alpha(x):
    if len(x) == 1:
        if x.isnumeric(): print("1")
        else: print("0")
        if x.isalnum() == False: print("-1")
    else: print("Error! Max 1 parameter")

# Exercise 21

def lowerCaseOnly(x):
    for c in x:
     if c.islower():
         print (c)

# Exercise 26        

def isPrime(n):
  for i in range(2, n):
        if n % i == 0:
            return False
        return True

def primos(n):
    for i in range(2, n + 1):
        if isPrime(i):
            print(i, end = " ")

     


    




 
    


        

