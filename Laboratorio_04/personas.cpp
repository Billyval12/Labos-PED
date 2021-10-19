#include "personas.hpp"

int menu(){
    int opcion = 0;
    cout << endl << "1) Agregar una persona al inicio." << endl;
    cout << "2) Agregar una persona al final." << endl;
    cout << "3) Mostrar lista de inicio a fin." << endl;
    cout << "4) Mostrar lista de fin a inicio." << endl;
    cout << "5) Salir." << endl;
    cout << "Opcion: ";
    cin >> opcion; cin.ignore();
    return opcion;
}

int main(void){
    ListaDoble saga;
    
    bool continuar = true;
    Persona p;
    do{
        switch(menu()){
            case 1: //Agregar una persona al  inicio
                p = solicitarPersona();
                saga.insertFront(p);
                cout << "Persona almacenada exitosamente!" << endl;
                break;
            case 2: //Agregar una persona al final
                p = solicitarPersona();
                saga.insertBack(p);
                cout << "Persona almacenada exitosamente!" << endl;
                break;
            case 3: //Mostrar lista de inicio a fin
                saga.traversalForwardDirection();
                break;
            case 4: //Mostrar lista de fin a inicio
                saga.traversalReverseDirection();
                break;
            case 5: //Salir
                continuar = false;
                break;
            default: //El usuario se equivoco
                cout << "La opcion no es valida" << endl;
                break;
        }
    }while(continuar);
    
    return 0;
}