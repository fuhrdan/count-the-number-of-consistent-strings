//*****************************************************************************
//** 1684. Count the Number of Consistent Strings   leetcode                 **
//** The original code is below, the optimized code is at the top.    -Dan   **
//** the change improves the constant factors making the code efficient.     **
//*****************************************************************************

int countConsistentStrings(char * allowed, char ** words, int wordsSize) {
    int hashy[200] = {0};
    int allAllowed = 0;

    // Mark allowed characters in the hashy array
    for (int n = 0; n < strlen(allowed); n++) {
        hashy[allowed[n]]++;
    }

    // Check each word
    for (int i = 0; i < wordsSize; i++) {
        int good = 1; // Assume the word is good initially
        int wordLen = strlen(words[i]); // Precompute the word's length
        for (int j = 0; j < wordLen; j++) {
            if (hashy[words[i][j]] == 0) {
                good = 0; // Not good if a character isn't in allowed
                break; // No need to check further
            }
        }
        if (good) {
            allAllowed++;
        }
    }

    return allAllowed;
}

/*
int countConsistentStrings(char * allowed, char ** words, int wordsSize){
    int hashy[200];
    int allAllowed = 0;
    for(int n = 0; n < strlen(allowed); n++)
    {
        int conv = allowed[n];
        hashy[conv]++;
    }
    for(int i = 0; i < wordsSize; i++)
    {
        int good = 0;
        for(int j = 0; j < strlen(words[i]); j++)
        {
            int conv = words[i][j];
            if(hashy[conv] == 0)
            {
                good = -1;
            }
        }
        if(good == 0)
        {
            allAllowed++;
        }
    }
    return allAllowed;
}