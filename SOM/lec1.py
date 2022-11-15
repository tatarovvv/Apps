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

# Exercise 7

sum() #test