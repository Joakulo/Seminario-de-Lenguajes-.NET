namespace Teoria2;
class ListaDePersonas
{
    private List<Persona> List = new List<Persona>();

    public void Agregar(Persona P) {
        List.Add(P);
    }

    public Persona this[int i]{
        get {
            foreach (Persona P in List) {
                if (P.getDNI() == i) {
                    return P;
                }
            }
            return null;
        }  
    }

    public List<string> this[char c]{
        get {
            List<string> L = new List<string>();
            foreach (Persona P in List) {
                if (P.getNombre()[0] == c){
                    L.Add(P.getNombre());
                }
            }
            return L;
        }
    }
}
