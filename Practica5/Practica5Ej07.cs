namespace Teoria2;

class Persona
{
    private string _nombre {get; set;}
    private char _sexo {get; set;}
    private int _DNI {get; set;}
    private DateTime _FechaNacimiento {get; set;}
    private int _edad {
        get{
            DateTime aux = DateTime.Now;
            int edad = aux.Year - _FechaNacimiento.Year-1;
            if(aux.Month > _FechaNacimiento.Month){
                edad++;
            }else if(aux.Month == _FechaNacimiento.Month){
                if(aux.Day >= _FechaNacimiento.Day){
                    edad++;
                }
            }
            return edad;
        }
    }

    public object this[int i]{
        get {
            switch (i) {
                case 0: return _nombre;
                case 1: return _sexo;
                case 2: return _DNI;
                case 3: return _FechaNacimiento;
                case 4: return _edad;
                default: return null;
            }
        }
        set {
            switch (i) {
                case 0: _nombre = (string)value; break;
                case 1: _sexo = (char)value; break;
                case 2: _DNI = (int)value; break;
                case 3: _FechaNacimiento = (DateTime)value; break;
                default: break;
            }
        }

    }
}