using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Locadora.Enums
{
    enum Generos
    {
        [Description("Ação")]
        Acao,
        [Description("Aventrura")]
        Aventura,
        [Description("Artes Marciais")]
        Artes_Marciais,
        [Description("Classicos")]
        Classicos,
        [Description("Comédia")]
        Comedia,
        [Description("Drama")]
        Drama,
        [Description("Ficção")]
        Ficcao,
        [Description("Guerra")]
        Guerra,
        [Description("Musicais")]
        Musicais,
        [Description("Policial")]
        Policial,
        [Description("Romance")]
        Romance,
        [Description("Suspense")]
        Suspense,
        [Description("Terror")]
        Terror
    }
}