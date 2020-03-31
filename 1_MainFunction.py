import sys, os, subprocess, time, glob
import datetime

def Log(string):
    file = open("log.txt","a")
    print(string)
    file.write(string+"\n")
    file.close()
	
generation = 0

start = time.time()
error = 0 
warning = 0

#Erace Previous Log
file = open("log.txt","w")
file.write("")
file.close()

print("getting cards from database")
#gets all the cards from the database
subprocess.run([os.getcwd() + "/11_SqlReader.py"],shell=True)

print("deleting old deck files from ygopro")
files = glob.glob(os.getcwd() +"/KoishiPro_Sakura/deck/*")
for f in files:
    os.remove(f)

startNoSetup = time.time()
print("done set up")
#makes the two random decks
count = 1
while ((count <= 1000) and (error == 0) and (warning < 3)):
    file = open("log.txt","a")
    print("Game:"+str(count))
    file.write("Game:"+str(count)+"\n")
    print("making decks")
    
    subprocess.run([os.getcwd() + "/12_makeDeck.py", "AI_Random.ydk"],shell=True)
    subprocess.run([os.getcwd() + "/12_makeDeck.py", "AI_Random2.ydk"],shell=True)
    
    #Runs the game
    
    print("running game")
    
    subprocess.run([os.getcwd() + "/13_MainGameRunner.py",str(generation),str(count)],shell=True)
                   #stdout=subprocess.PIPE)
    
    #output = p.stdout.read().decode("utf-8") 
    #print(output)
    
    #if output.find("!ERROR!"):
        #error = 1
    #if output.find("WARNING!"):
        #warning += 1
    
    count+=1
    file.close()

file = open("log.txt","a")
end = time.time()

Log("Time Past:" + str(datetime.timedelta(seconds=int(end - start))))
Log("Time Past Excluding Setup:" + str(datetime.timedelta(seconds=int(end - startNoSetup))))

if error == 1:
    print("there were errors")
if warning >= 3:
    print("too many warnings")
file.close()