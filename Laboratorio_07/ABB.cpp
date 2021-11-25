// ADMINISTRACIÓN DE UN ÁRBOL BINARIO DE BÚSQUEDA
#include <iostream>

using namespace std;

int menu();

struct nodo{
    int dato;
    nodo *hijoIzq; // Puntero al subárbol izquierdo.
    nodo *hijoDer; // Puntero al subárbol derecho.
};

class ABB{

    private:
        nodo *pAbb;
    
    public:
        ABB();
        ~ABB();
        void insertar(void);
        void insNodoAbb(nodo **, int);
        void buscarNodo(int);
        void buscarN(nodo *, int);
        void borrarNodo(int);
        void borrarNodoRec(nodo **, int);
        void mostrarEnPreorden(nodo *);
        void mostrarEnInorden(void);
        void mostrarIn(nodo *);
        void mostrarEnPostorden(nodo *);
        void mostrarEnPreorden(void);
        void mostrarPre(nodo *);
        void mostrarEnPostorden(void);
        void mostrarPost(nodo *);
};

ABB::ABB(void)
{
    pAbb = NULL;
}

ABB::~ABB()
{
    cout << "Destructor ejecutandose" << endl;
}

void ABB::insertar(void)
{
    int dato;
    char resp;

    do{
        cout << "Desea digitar un dato? (s/n)";
        cin >> resp;
        if(resp == 's'){
            cout << "Digite el dato: ";
            cin >> dato;
            insNodoAbb(&pAbb, dato);
        }

    }while(resp == 's');
}

void ABB::insNodoAbb(nodo **p, int dato)
{
    if(!(*p)){
        *p = new nodo;
        (*p)->dato = dato;
        (*p)->hijoIzq = NULL;
        (*p)->hijoDer = NULL;
    }
    else
        if(dato < (*p)->dato)
            insNodoAbb(&((*p)->hijoIzq), dato);
        else
            if(dato > (*p)->dato)
                insNodoAbb(&((*p)->hijoDer), dato);
            else
                cout << "El dato ya esta en el arbol" << endl << endl; 
}

void ABB::buscarNodo(int dato)
{
    buscarN(pAbb, dato);
}

void ABB::buscarN(nodo *p, int dato)
{
    if(!p)
        cout << "El dato no esta en el árbol" << endl << endl;
    else
        if(dato < p->dato)
            buscarN(p->hijoIzq, dato);
        else
            if(dato > p->dato)
                buscarN(p->hijoDer, dato);
            else
                cout << "Dato encontrado exitosamente!!" << endl << endl;
}

void ABB::borrarNodo(int dato)
{
    borrarNodoRec(&pAbb, dato);
}

// Función recursiva que borra un nodo en un
// árbol binario de búsqueda.

void ABB::borrarNodoRec(nodo **r, int dato)
{
    nodo *p;

    if(!(*r)) //si se llegó a un NULL.
        cout << "El dato NO está en el árbol" << endl << endl;
    else
        if(dato < (*r)->dato) //Buscar por subárbol izquierdo del nodo.
            borrarNodoRec(&((*r)->hijoIzq), dato);
        else
            if(dato > (*r)->dato) //Buscar por subárbol derecho del nodo.
                borrarNodoRec(&((*r)->hijoDer), dato);
            else{ //El borrado del nodo se hace a partir de aquí:
                if(!((*r)->hijoIzq) && !((*r)->hijoDer)){ //Si nodo a borrar es una hoja.
                    p = *r;
                    *r = NULL;
                }
                else
                    if(!((*r)->hijoIzq) && (*r)->hijoDer){ //Si el nodo a borrar
                        p = *r; //solo tiene hijo derecho.
                        *r = (*r)->hijoDer;
                    }
                    else
                        if((*r)->hijoIzq && !((*r)->hijoDer)){ //Si nodo a borrar
                            p = *r; //solo tiene hijo
                            *r = (*r)->hijoIzq; //izquierdo.
                        }
                        else
                            if((*r)->hijoIzq && (*r)->hijoDer){ //Si nodo a borrar tiene
                                p = (*r)->hijoIzq; //dos hijos.
                                if(!p->hijoDer){
                                    (*r)->dato = p ->dato;
                                    (*r)->hijoIzq = p->hijoIzq;
                                }
                                else{
                                    nodo *q;
                                    while(p->hijoDer){
                                        q = p;
                                        p = p->hijoDer;
                                    }
                                    (*r)->dato = p->dato;
                                    q->hijoDer = p->hijoIzq;
                                }
                            }
                delete p;
            }
}


void ABB::mostrarEnInorden(void)
{
    mostrarIn(pAbb);
}

void ABB::mostrarIn(nodo *p)
{
    if(p){
        mostrarIn(p->hijoIzq);
        cout << p->dato << "  ";
        mostrarIn(p->hijoDer);
    }

}

void ABB::mostrarEnPreorden(void)
{
    mostrarPre(pAbb);
}

void ABB::mostrarPre(nodo *p)
{
    if(p){
        cout << p->dato << "  ";
        mostrarPre(p->hijoIzq);
        mostrarPre(p->hijoDer);
    }

}

void ABB::mostrarEnPostorden(void)
{
    mostrarPost(pAbb);
}

void ABB::mostrarPost(nodo *p)
{
    if(p){
        mostrarPost(p->hijoIzq);
        mostrarPost(p->hijoDer);
        cout << p->dato << "  ";
    }

}

int menu(){
    int opcion = 0;
    cout << endl << "1) Agregar una entero al arbol." << endl;
    cout << "2) Mostrar en InOrden." << endl;
    cout << "3) Mostrar en PostOrden." << endl;
    cout << "4) Mostrar en PreOrden." << endl;
    cout << "5) Buscar entero." << endl;
    cout << "6) Eliminar entero." << endl;
    cout << "7) Salir." << endl;
    cout << "Opcion: ";
    cin >> opcion; cin.ignore();
    return opcion;
}

int main(void)
{
    cout << endl;
    cout<<"------------------------------------------------------"<<endl;
    cout << "ADMINISTRACION DE UN ARBOL BINARIO DE BUSQUEDA" << endl;
    cout<<"------------------------------------------------------"<<endl;

    ABB objAbb;
    int d,f=0;
    bool continuar = true;
    do{
        switch(menu()){
            case 1: //Agregar un dato
                objAbb.insertar();
                break;
            case 2: //Mostrar en InOrden
                cout<<"Mostrando en Inorden"<<endl;
                cout<<"----------------------------"<<endl;
                objAbb.mostrarEnInorden();
                break;
            case 3: //Mostrar en PostOrden
                cout<<"Mostrando en Postorden"<<endl;
                cout<<"----------------------------"<<endl;
                objAbb.mostrarEnPostorden();
                break;
            case 4: //Mostrar en PreOrden
                cout<<"Mostrando en Preorden"<<endl;
                cout<<"----------------------------"<<endl;
                objAbb.mostrarEnPreorden();
                break;
            case 5: //Buscar un dato 
                cout<<"Digite el dato que desea rastrear"<<endl;
                cin>>d;
                objAbb.buscarNodo(d);
                break;
            case 6: //Eliminar un dato
                cout<<"Digite el dato que desea suprimir"<<endl;
                cin>>f;
                objAbb.borrarNodo(f);
                break;
            case 7: //Salir
                continuar=false;
                break;
            default: //El usuario se equivoco
                cout << "La opcion no es valida, favor intente denuevo." << endl;
                break;
        }
    }while(continuar);
    return 0;
}