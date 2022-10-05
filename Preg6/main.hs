import System.IO

suma :: Integer -> Integer -> Integer
suma x y =  x + y

resta :: Integer -> Integer -> Integer
resta x y =  x - y

multi :: Integer -> Integer -> Integer
multi x y =  x * y

divi :: Double -> Double -> Double
divi x y =  if y/=0 then x / y else -1

main :: IO ()
main = do
  putStrLn "Ingrese el primer numero"
  e1 <- getLine
  putStrLn "Ingrese el segundo numero"
  e2 <- getLine
  let num1 = (read e1 :: Integer)
  let num2 = (read e2 :: Integer)
  putStrLn "Suma de los dos numeros "
  print (suma num1 num2)
  putStrLn "Resta de los dos numeros "
  print (resta num1 num2)
  putStrLn "Multipicacion de los dos numeros "
  print (multi num1 num2)
  putStrLn "Division de los dos numeros "
  let num1 = (read e1 :: Double)
  let num2 = (read e2 :: Double)
  print (divi num1 num2)