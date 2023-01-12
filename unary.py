message = input()
bits = ''

for i in range(len(message)):
    charInBin = str(bin(ord(message[i])))[2:]
    charInBin = charInBin.zfill(7)
    bits += charInBin

last = ' '
resulat = ''
encodedBits = [' 00 0', ' 0 0']

for i in range(len(bits)):
    if bits[i] != last:
        last = bits[i]
        resulat += encodedBits[ord(last) - ord('0')]
    else:
        resulat += '0'

print(resulat[1:])
