using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Set.Entities
{
    class Estudantes
    {
        public int Codigo { get; set; }

        public Estudantes()
        {

        }

        public Estudantes(int codigo)
        {
            Codigo = codigo;
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Estudantes))
            {
                return false;
            }
            Estudantes other = obj as Estudantes;
            return Codigo.Equals(other.Codigo);
        }
    }

}
