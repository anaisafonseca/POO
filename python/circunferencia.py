from math import pi

class Circunferencia():
    def area(self,r=1):
        area = pi * r**2
        print(area)

circ = Circunferencia()
circ.area()
circ.area(5)