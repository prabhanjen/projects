import requests
import time
l=[]
print("----- Welcome to DirTest! ----- \n")
time.sleep(3)
target = input("\nEnter target url :")
file = input("Enter the payload file location :")
wordlist = open(file,"r")
for loop in wordlist:
    response = requests.get(url=f"{target}/{loop}")
    code=str(response)[11:14]
    if int(code[0]) == 1 or int(code[0]) == 2 or int(code[0]) == 3:
      print(f"{target}/{loop}{code}")
      l.append(loop[0:-2])
    else:
        print(f"{target}/{loop} encounterd a error {code}")
time.sleep(5)
print("Available directory from the list are :",l)
time.sleep(5)
print("--------- END ---------")
