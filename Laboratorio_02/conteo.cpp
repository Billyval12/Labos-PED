#include <iostream>
#include <conio.h>


using namespace std;

void conteo(int,int);

int main(){
    int num=0;
    cout<< "Ingrese el numero: "<<endl;
    cin>> num;

    while (num< 1){
        cout<<"Ingrese un numero POSITIVO"<<endl;
        cin>>num;
    }
    conteo(num, 1);

    getch();
    return 0;
}

void conteo(int num, int acum){
    
    if (acum==num){
        cout<< acum<< endl;
        return;
    }

    else{
        cout<< acum<< endl;
        conteo(num, acum+1);
        cout<<acum<< endl;
        return;
    }
    
}