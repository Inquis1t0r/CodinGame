#include <stdlib.h>
#include <stdio.h>
#include <string.h>

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
int main()
{

    // game loop
    while (1) {
         int maxH = 0;
         int indexM = 0;
            
        for (int i = 0; i < 8; i++) {
            int mountainH; // represents the height of one mountain.
            scanf("%d", &mountainH);
            
              if(mountainH > maxH){
                maxH = mountainH;
                indexM = i;                
                }

        // Write an action using printf(). DON'T FORGET THE TRAILING \n
        // To debug: fprintf(stderr, "Debug messages...\n");
        
        }
        printf("%d\n", indexM); // The index of the mountain to fire on.
        fprintf(stderr, "Debug messages...\n");
   
    }
     return 0;
}The Descent
