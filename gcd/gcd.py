def gcd(a, b):
    while a != 0 and b != 0:
        if a > b:
            a = a % b
        else:
            b = b % a
    if not (a == 0 and b == 0):
        return max(a, b)
