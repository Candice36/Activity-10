//1.  1 error located regarding object creation which should be mentioned like namespace as well 

//CST117_IC08_console.Set A = new CST117_IC08_console.Set();

//Others are not errors but logically wrong things like

//2. contains a method with the 1st number which is not equal to any given value then it can  return false  this is an issue

//3. the union method that you stated put all elements to the 1st Set we do not change in set

// created new set and added 2 set values to the set


//Corrected by candice bell
//cst 150 activity 10 

//use for IC08
//Lydia's code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console { 

    class Set { 
    
        private List<int> elements;

        public Set(){
            elements = new List<int>();
        }

        public bool addElement(int val){
            if (containsElement(val)) return false;
            else{
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val){
            for (int i = 0; i < elements.Count; i++) {
                if (val == elements[i]) return true;
                // else return false;
            }
            return false;
        }

        public override string ToString() {
            string str = "";
            foreach (int i in elements){
                str += i + " ";
            }
            return str;
        }

        public void clearSet(){
            elements.Clear();
        }

        public Set union(Set rhs){
            Set C = new Set();
            for (int i = 0; i < rhs.elements.Count; i++){
                C.addElement(rhs.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            for (int i = 0; i < this.elements.Count; i++){
                C.addElement(this.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            return C;
        }


    }


}
        class HelloWorld{
       static void Main(){
    CST117_IC08_console.Set A = new CST117_IC08_console.Set();
    CST117_IC08_console.Set B = new CST117_IC08_console.Set();

    //put some stuff in the sets

    Random r = new Random();

    for (int i = 0; i < 10; i++)

    {

        A.addElement(r.Next(4));

        B.addElement(r.Next(12));

    }

    //display each set and the union

    Console.WriteLine("A: " + A);

    Console.WriteLine("B: " + B);

    Console.WriteLine("A union B: " + A.union(B));

    //display original sets (should be unchanged)

    Console.WriteLine("After union operation");

    Console.WriteLine("A: " + A);

    Console.WriteLine("B: " + B);

        Console.ReadLine();
}
}



