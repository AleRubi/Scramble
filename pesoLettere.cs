using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        char[] line = input.ToCharArray();
        int[] val = new int[]{1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10};
        
        int count = 0, tot = 0;
        for(int i = 0; i < line.Length; i++){
            char ver = 'A';
            count = 0;
            bool maiu = true;
            while(maiu == true){
                if(line[i] == ver){
                    maiu = false;
                    tot += val[count];
                }
                if(ver == 'Z'){
                    ver = 'a';
                    count = 0;
                }else{
                    ver++;
                    count++;
                }
            }
        }
        return tot;
    }
}
