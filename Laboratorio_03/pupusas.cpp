#include <iostream>
#include <strings.h>
using namespace std;

struct ordPupusas
{
    int cantidad;
    string tipo,ingredientes,soda;

    ordPupusas *next;
};

class listasimple{
    private:
    ordPupusas *pInicio;

    public:
    listasimple();
    ~listasimple();
    void insorden(int,string,string,string);
    void showlist();
};

listasimple::listasimple()
    {
        pInicio = NULL;
    }
listasimple::~listasimple()
{
      ordPupusas *sig;
      cout<<"Destructor ejecutandose"<<endl;
      while (sig -> next)
      {
        sig = pInicio;
        pInicio = pInicio -> next;
        delete sig;
      }
      
}

void listasimple::insorden(int cant1, string tipo1, string ingredientes1, string soda1)
    {
        ordPupusas *neworder = new ordPupusas;

        neworder->cantidad = cant1;
        neworder->tipo = tipo1;
        neworder->ingredientes= ingredientes1;
        neworder->soda = soda1;

        neworder->next = NULL;

        if(pInicio == NULL){
            pInicio = neworder;
        }else{
            ordPupusas *aux =neworder;
            aux = pInicio;
            while(aux -> next)
            {
                aux = aux->next;
            }
            aux ->next = neworder;
        }
}



void listasimple :: showlist(){

        ordPupusas *show = new ordPupusas;
        show = pInicio;
        while (show !=NULL)
        {
            cout<< "Cantidad de pupusas: " << show->cantidad <<endl;
            cout<< "Tipo: " << show->tipo <<endl;
            cout<< "Ingrediente: " << show->ingredientes <<endl;
            cout<< "Coca-Cola: " << show->soda <<endl;
            cout<< "--------------------"<<endl;
            
            show = show -> next;
        }

        
}


int main(){
    listasimple objlist;

    int option = 0;
    bool continuemenu = true;
    int cantidad=0;
    string tipo, ingredientes, soda;

    do 
    {
    cout<<"  --PUPUSERIA UCA--  \n"<<endl;
    cout<<"1. introducir una orden  \n"<<endl;
    cout<<"2. Mostrar datos de la orden \n"<<endl;
    cout<<"3. Salir    \n"<<endl;
    cout<<"Digite una opcion: "<<endl;
    cin>>option;
    switch (option)
    {
    case 1:
        cout<<" ---INSERCION DE DATOS---"<<endl;
        cout<<"Cuantas pupusas desea ordenar: "<<endl;
        cin>>cantidad;
        cout<<"De que tipo desea la masa (Arroz/Maiz): "<<endl;
        cin>>tipo;
        cin.ignore();
        cout<<"De que ingrediente desea ordenar sus pupusas (Queso,Frijol/Queso,Revueltas)"<<endl;
        getline(cin,ingredientes);
        cout<<"Desea agregar Coca-Cola? (Si/No)"<<endl;
        cin>>soda;
        cin.ignore();

        objlist.insorden(cantidad, tipo, ingredientes,soda);
        break;
    case 2:
       cout<<"Los datos  almacenados de las ordenes son: "<<endl<<endl;
       objlist.showlist();
       option=0;
       break;
    case 3: continuemenu=false;
            break;

    default: cout<<"No existe esa opcion"<<endl;
              break;
        }
    } while (continuemenu);

    cout<<"Ha salido correctamente"<<endl;
    
    return 0;
}
