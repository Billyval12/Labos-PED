#include <iostream>
#include <string>
using namespace std;

struct Persona{
    string nombre;
    int id;
    string perfil;
};

Persona solicitarPersona(void){
    Persona p;
    cout << "Nombre: ";
    getline(cin, p.nombre);
    cout << "ID: ";
    cin >> p.id; cin.ignore();
    cout<< "Perfil (administrador, cliente, o trabajador): ";
    getline(cin,p.perfil);
    return p;
}

void mostrarPersona(Persona p){
    cout<<"------------------------------"<<endl;
    cout << "Nombre: " << p.nombre<<endl;
    cout << "ID: " << p.id << endl;
    cout << "Perfil: "<< p.perfil<< endl;
    cout<<"------------------------------"<<endl;
}


typedef Persona T;
const T noValido = {"",0};

struct nodo{
    T dato;
    nodo *sig;
    nodo *ant;
};

class ListaDoble{
    private:
        nodo *pInicio;
    public:
        ListaDoble();
        ~ListaDoble();
        void insertFront(T);
        void insertBack(T);
        void traversalForwardDirection(void);
        void traversalForwardDirection(nodo*);
        void traversalReverseDirection(void);
};

ListaDoble::ListaDoble(void){
    pInicio = NULL;
}

ListaDoble::~ListaDoble(void){
    nodo *p;
    while(pInicio){
        p = pInicio;
        pInicio = pInicio->sig;
        delete p;
    }
}

void ListaDoble::insertFront(T dato){
    nodo *nuevo = new nodo;
    nuevo->dato = dato;
    nuevo->sig = pInicio;
    if(pInicio != NULL)
        pInicio->ant = nuevo;
    pInicio = nuevo;
}

void ListaDoble::insertBack(T dato){
    nodo *nuevo = new nodo; 
    nuevo->dato = dato;
    if(!pInicio){
        pInicio = nuevo;
        pInicio->sig = pInicio->ant = NULL;
    }
    else{
        nodo *saltarin = pInicio;
        while(saltarin->sig != NULL)
            saltarin = saltarin->sig;
        saltarin->sig = nuevo;
        nuevo->ant = saltarin;
        nuevo->sig = NULL;
    }
}

void ListaDoble::traversalForwardDirection(void){ //Recorrer la lista de forma recursiva :/
    nodo *saltarin = pInicio;
    traversalForwardDirection(saltarin);
}

void ListaDoble::traversalForwardDirection(nodo *saltarin){
    if(saltarin==NULL)
    return;
    else{
        mostrarPersona(saltarin->dato);
        traversalForwardDirection(saltarin->sig);
    }
}

void ListaDoble::traversalReverseDirection(void){
    if(!pInicio)
        cout<<"Lista vacia"<<endl;
    nodo *p = pInicio;
    nodo *q = NULL;
    while(p){
        q = p;
        p = p->sig;
    }
    while(q){
        mostrarPersona(q->dato);
        q = q->ant;
    }
}