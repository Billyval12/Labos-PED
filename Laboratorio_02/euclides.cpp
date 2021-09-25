#include <iostream>
#include <thread>
#include <chrono>

using namespace std;

int euclides (int,int);

int main(){

int numA, numB;
    
    cout<<"INGRESE EL PRIMER NUMERO (positivo): "<<endl;
    cin>> numA;

    cout<<"INGRESE EL SEGUNDO NUMERO (positivo): "<<endl;
    cin>> numB;

    if (numA>numB)
    {
       cout<<"El mcd es: " << euclides(numA, numB);
    }else if (numB>numA)
    {
        cout<<"El mcd es: " << euclides(numB,numA);
    }
    
    
    return 0;
}


int euclides (int a, int b){

    if(b==0){
        return a;
    }

    else{
        euclides(b,a%b);
    }

}