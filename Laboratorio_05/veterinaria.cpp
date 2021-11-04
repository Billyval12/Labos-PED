#include "veterinaria.hpp"

int menu(){
    int opcion = 0;
    cout << endl << "1) Agregar una mascota." << endl;
    cout << "2) Mostrar mascotas." << endl;
    cout << "3) Eliminar una mascota." << endl;
    cout << "4) Salir."<<endl;
    cout << "Opcion: ";
    cin >> opcion; cin.ignore();
    return opcion;
}

int main(void){
    ListaCirc list;
    
    bool continuar = true;
    mascota p,t;
    do{
        switch(menu()){
            case 1: //Agregar una mascota
                p = solicitarMascota();
                list.insert(p);
                cout << "Mascota almacenada exitosamente!" << endl;
                break;
            case 2: //Mostrar todas las mascotas
                list.showlist();
                break;
            case 3: //Eliminar una mascota
                cout<< "Digite los datos de la mascota que desea eliminar: "<<endl;
                t = solicitarMascota();
                list.borrar(t);
                break;
            case 4: //Salir
                continuar = false;
                break;
            default: //El usuario se equivoco
                cout << "La opcion no es valida" << endl;
                break;
        }
    }while(continuar);
    cout<<"Ha salido correctamente"<<endl;
    
    return 0;
}