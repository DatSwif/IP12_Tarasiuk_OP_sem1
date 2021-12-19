#include <iostream>
#include <string>
using namespace std;

int firstPos(string, const char[]);
int lastPos(string, const char[]);
int fWordCount(string);
void splitInWords(string, string[]);
bool canDivide(string, int, int);
void divide(string&, int, int, const char[]);

int main()
{
    const char vowels[] = {'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y'};
    string inputWords;
    getline(cin, inputWords);
    int vWordCount = fWordCount(inputWords);
    string* pWords = new string[vWordCount];
    splitInWords(inputWords, pWords);
    for (int i = 0; i < vWordCount; i++)
    {
        int first = firstPos(pWords[i], vowels);
        int last = lastPos(pWords[i], vowels);
        if (!canDivide(pWords[i], first, last))
        {
            printf("Word %d is indivisible\n", i);
        }
        else if (i % 2 == 0)
        {
            divide(pWords[i], first, last, vowels);
            cout << pWords[i] << endl;
        }
    }
    delete [] pWords;
}

int firstPos(string word, const char vowels[])
{
    int first = word.length();
    int currFirst;
    for (int i = 0; i < 12; i++)
    {
        currFirst = word.find(vowels[i]);
        if ((currFirst < first) && (currFirst != -1))
        {
            first = currFirst;
        }
    }
    return first;
}

int lastPos(string word, const char vowels[])
{
    int last = -1;
    int currLast;
    for (int i = 0; i < 12; i++)
    {
        currLast = word.find(vowels[i]);
        if (currLast > last)
        {
            last = currLast;
        }
    }
    return last;
}

int fWordCount(string inputWords)
{
    int size = inputWords.length();
    int count = 1;
    for (int i = 0; i < size; i++)
    {
        if (inputWords[i] == ' ')
        {
            count += 1;
        }
    }
    return count;
}

void splitInWords(string inputWords, string pWords[])
{
    int size = inputWords.length();
    int wordStart = 0;
    int wordEnd;
    int ind = 0;
    for (int i = 0; i < size; i++)
    {
        if (inputWords[i] == ' ')
        {
            wordEnd = i - 1;
            pWords[ind] = inputWords.substr(wordStart, wordEnd - wordStart + 1);
            ind += 1;
            wordStart = i + 1;
        }
        else if (i == size - 1)
        {
            pWords[ind] = inputWords.substr(wordStart, i - wordStart + 1);
        }
    }
}

bool canDivide(string word, int first, int last)
{
    int hyphen = word.find('-');
    int length = word.length();
    if ((hyphen > 1) && (hyphen < length - 3))
    {
        return true;
    }
    else if (hyphen > -1)
    {
        return false;
    }
    else if ((first > length - 4) || (last < 2) || (first == last))
    {
        return false;
    }
    else
    {
        return true;
    }
}

void divide(string& word, int first, int last, const char vowels[])
{
    bool letterInVowels;
    if (word.find('-') == -1)
    {
        int ind = first;
        while (ind <= last)
        {
            letterInVowels = false;
            for (int i = 0; i < 12; i++)
            {
                if (vowels[i] == word[ind])
                {
                    letterInVowels = true;
                }
                else if (letterInVowels == false)
                {
                    letterInVowels = false;
                }
            }
            if ((ind >= 1) && (ind <= word.length() - 4) && ((letterInVowels) || (ind == 2)))
            {
                word.insert(ind+1, "-");
                last += 1;
                ind += 1;
            }
            ind += 1;
        }
    }
}