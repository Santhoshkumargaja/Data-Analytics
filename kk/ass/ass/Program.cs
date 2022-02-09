// See https://aka.ms/new-console-template for more informati
import os
path=os.chdir("C:\Users\gajas\Downloads\files")

i = 0
for file in os.listdir(path):
    newfilename = "file{}.pdf".format(i)
    os.rename(file, newfilename)
    i = i + 1
