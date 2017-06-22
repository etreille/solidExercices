using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class Operateurs
    {
        private readonly List<IOperateur> _operateurs = new List<IOperateur>();
        public IOperateur Current { get; private set; }

        public void NextOperateur()
        {
            var nextOperateur = _operateurs.IndexOf(Current) + 1;
            if (nextOperateur == _operateurs.Count) nextOperateur = 0;
            Current = _operateurs[nextOperateur];
        }

        public void Add(IOperateur operateur)
        {
            if (!_operateurs.Any())
            {
                Current = operateur;
            }
            _operateurs.Add(operateur);
        }

        public int Count()
        {
            return _operateurs.Count;
        }



    }
}
