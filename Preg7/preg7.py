def suma(num1,num2):
   return num1+num2

def resta(num1,num2):
   return num1-num2

def multi(num1,num2):
   return num1*num2

def divi(num1,num2):
   if(num2!=0): 
       return num1/num2
   else:
       return -1

num1=input("Ingrese el primer numero ")
num2=input("Ingrese el segundo numero ")
num1=int(num1)
num2=int(num2)
print( "Suma de los dos numeros ")
print( suma (num1,num2))
print( "Resta de los dos numeros ")
print( resta (num1,num2))
print( "Multipicacion de los dos numeros ")
print( multi (num1,num2))
print( "Division de los dos numeros ")
print( divi (num1,num2))
    
