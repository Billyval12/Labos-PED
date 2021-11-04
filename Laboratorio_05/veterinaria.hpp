#include <iostream>
#include <string>
using namespace std;

struct mascota{
    string nombre;
    int id;
    string raza;
    double peso;
    int edad;
};

mascota solicitarMascota(void){
    mascota p;
    cout << "Nombre del dueno: ";
    getline(cin, p.nombre);
    cout << "ID: ";
    cin >> p.id; cin.ignore();
    cout<< "Raza: ";
    getline(cin, p.raza);
     cout << "Peso(Kg): ";
    cin >> p.peso; cin.ignore();
    cout << "Edad: ";
    cin >> p.edad; cin.ignore();
    return p;
}

void mostrarMascota(mascota p){
    cout<<"------------------------------"<<endl;
    cout << "Nombre: " << p.nombre<<endl;
    cout << "ID: " << p.id << endl;
    cout << "Raza: "<< p.raza<< endl;
    cout << "Peso: "<< p.peso<<endl;
    cout << "Edad: "<< p.edad<<endl;
    cout<<"------------------------------"<<endl;
}


typedef mascota T;
const T noValido = {"",0};

struct nodo{
    T dato;
    nodo *sig;
};

class ListaCirc{
    private:
        nodo *pInicio;
    public:
        ListaCirc();
        ~ListaCirc();
        void insert(T);
        void showlist();
        void borrar(T);
        void eliminarListaCirc(nodo *);
        void eliminar(T,nodo*);
};

ListaCirc::ListaCirc(void){
    pInicio = NULL;
}

ListaCirc::~ListaCirc(void){
    cout<< "Desructor ejecutandose" <<endl;
    if(pInicio){
        eliminarListaCirc(pInicio);
        pInicio=NULL;
    }
}

void ListaCirc::eliminarListaCirc(nodo *p){
    if(p->sig != pInicio)
        eliminarListaCirc(p->sig);
    delete p;
}

void ListaCirc::insert(T dato){
    nodo *nuevo;

    nuevo = new nodo;
    nuevo->dato = dato;
    if(!pInicio){
        pInicio=nuevo;
        pInicio->sig =pInicio;
    }else{
        nuevo->sig = pInicio;
        nodo *saltarin =pInicio;
        while(saltarin->sig != pInicio){
            saltarin = saltarin->sig;
        }
        saltarin->sig= nuevo;
        pInicio = nuevo;
    }
} 

void ListaCirc::showlist(){
    nodo *saltarin;

    cout<<endl;
    if(pInicio){
        saltarin = pInicio;
        do{
            mostrarMascota(saltarin->dato);
            saltarin = saltarin->sig;
        }while(saltarin != pInicio);
    }

}

void ListaCirc::borrar(T dat){
    nodo *p =pInicio;
    if(!p){
        cout<< "No hay elementos en la lista" <<endl;
        return;
    }
    else if(p->sig==pInicio){
        if(p->dato.id == dat.id){
            pInicio = NULL;
            delete p;
        }else{
            cout<<"Mascota no encontrada"<<endl;
        }
        return;
    }
    else{
        eliminar(dat,p);
    }
}

void ListaCirc::eliminar(T dat, nodo *p){
    if(p== pInicio && p->dato.id == dat.id){
        nodo *saltarin =p;
        while(saltarin->sig != pInicio)
            saltarin= saltarin->sig;
        pInicio = p->sig;
        saltarin->sig = pInicio;
        delete p;
        return;
    }
    if(p->sig->dato.id == dat.id){
        p->sig = p->sig->sig;
        return;
    }
    eliminar(dat, p->sig);
}


