#Правила переносу, що вдалося зберегти:
#програма не відриватиме першу чи дві останні літери від слова
#програма не ділитиме слово, якщо в ньому вже є дефіс
#програма залишатиме хоча б по одному голосному звуку з обох сторін

#Не вдалося:
#розбивати слова з двох коренів лише між цими коренями (потрібен словник із коренями слів)
#розібрати, коли дві літери позначають один звук (також потрібен словник)

def firstPos(word):
    first = len(word)
    for letter in vowels:
        currFirst = word.find(letter.lower())
        if currFirst < first and currFirst != -1:
            first = currFirst
    return first
            
def lastPos(word):
    last = -1
    for letter in vowels:
        currLast = word.rfind(letter.lower())
        if currLast > last:
            last = currLast
    return last
    
def canDivide(word, first, last):
    hyphen = word.find('-')
    length = len(word)
    if hyphen > 1 and hyphen < length - 3:
        return True
    if first > length - 4 or last < 2 or first == last:
        return False
    else:
        return True
    
def divide(word, first, last):
    if word.find('-') == -1:
        ind = first
        while ind <= last:
            if (ind >= 1) and (ind <= len(word) - 4) and ((word[ind] in vowels) or (ind == 2)):
                word = word[:ind+1] + '-' + word[ind+1:]
                last += 1
                ind += 1
            ind += 1
    return word

vowels = ('a', 'e', 'i', 'o', 'u', 'y')
words = input().split(' ')
for i in range(len(words)):
    first = firstPos(words[i])
    last = lastPos(words[i])
    if canDivide(words[i], first, last) == False:
        print('word %d is indivisible' % i)
    elif i % 2 == 0:
        print(divide(words[i], first, last))
