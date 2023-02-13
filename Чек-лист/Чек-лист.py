import math

AB = float(input('Write the first cathet: '))
AC = float(input('Write the second cathet: '))

BC = math.sqrt(AB ** 2 + AC ** 2) 
S = (AB * AC) / 2
P = AB + AC + BC

print('The area of a right triangle: %2.f' % S)
print('The perimeter of a right triangle: %2.f' % P)
