namespace Solid.SingleResponsability.Before
{
    public class Order
    {
        public void AddItem(string item) { /* Lógica para adicionar item ao pedido */ }

        public void CalculateTotal() { /* Lógica para calcular o total do pedido */ }

        public void SaveToDatabase() { /* Lógica para salvar o pedido no banco de dados */ }

        public void SendEmailConfirmation() { /* Lógica para enviar confirmação por e-mail */ }
    }

}
