using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_III.Tarea_III
{
    public partial class Neumaticos : Form
    {
        public Neumaticos()
        {
            InitializeComponent();
        }

        enum TiposNeumaticos
        {
            NeumaticosDeVerano, NeumaticosDeInvierno, NeumaticosAllSeasons, NeumaticosCoche,
            NeumaticosFurgoneta, Neumaticos4x4, NeumaticosPerfilBajo, NeumaticosPerfilAlto,
            NeumaticosRunflat, NeumaticosTubuless, NeumaticosRecauchados, NeumaticosVerdes,
            NeumaticosRadiales, NeumaticosDiagonales
        };
    }
}
