namespace Bestellsystem_Lieferdienst_Client.BL
{
    public static class FormExtention
    {
        public static void LoadView(this Control form, ContainerControl view)
        {
            form.Controls.Clear();
            view.Dock = DockStyle.Fill;
            form.Controls.Add(view);
        }
    }
}