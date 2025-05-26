namespace Bestellsystem_Lieferdienst.PL
{
    public static class FormExtention
    {
        public static void LoadView(this ContainerControl form, ContainerControl view)
        {
            form.Controls.Clear();
            view.Dock = DockStyle.Fill;
            form.Controls.Add(view);

        }
    }
}