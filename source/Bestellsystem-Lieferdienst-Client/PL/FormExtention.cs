using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem_Lieferdienst.PL
{
    public static class FormExtention
    {
        public static void LoadView(this ContainerControl form, UserControl view)
        {
            form.Controls.Clear();
            view.Dock = DockStyle.Fill;
            form.Controls.Add(view);
        }
    }
}
