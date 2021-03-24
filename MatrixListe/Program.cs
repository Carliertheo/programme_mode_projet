using System;

namespace MatrixListe
{

    class MatrixTab

    {
         int [,] sqmatrix;
         int size;
        /*Classe MatrixTab maitien deux proprieter un tableau 
        a deux dimensions sqmatrix et un entier size*/
       
        
        public MatrixTab (int size, int defaultValue) {
            this.sqmatrix = new int [size, size];
            this.size = size;
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++){
                    this.sqmatrix[i, j] = defaultValue;
                }
            }
            
        }
        /*La fonction MatrixTab retourne un tableau en deux dimensions.
        Elle prend en paramettre un entier size et un entier valeur par default.
        */
          
         
         public string ToString() {
            string ret = "";
            for (int i = 0; i < this.size; i++) {
                ret = ret + " ";
                for (int j = 0; j < this.size; j++) {
                    ret = ret + this.sqmatrix[i,j] + " ";
                }
                ret = ret + "\n";
            }
            return ret;
        }
        /*La méthode ToString permet a la fonction MatrixTab d'avoir un meilleur visuel */
        
        public void HoriSegmentL(int x, int value, int y0, int longueur) {
            int y1 =  y0 + longueur;
            if (x >= 0 && x < this.size &&
                y0 >= 0 && y0 < this.size &&
                y1 >= 0 && y1 < this.size 
               ) 
               {
                   for (int j = y0 ; j <= y1; j ++) {
                       this.sqmatrix[x, j] = value;
                   }
               }
        }/*La méthode HorSegmentL permet d'affecter une valeur a la 
    case de coordoner x,y*/
    }
    

   
    class Program
    {
        static void Main(string[] args)
        {
           
            
            MatrixTab sq5 = new MatrixTab(30, 0);
            Console.WriteLine(sq5.ToString());
            /*Créé une matrix de taille 30x30 de valeur 0*/
            sq5.HoriSegmentL(22, 5, 17, 0);
            Console.WriteLine(sq5.ToString());
            /*Permet d'affecter la valeur 5 a la case de coordoner x=22,y=17*/
            
           
        }
    }
}
