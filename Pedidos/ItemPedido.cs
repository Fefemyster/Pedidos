
namespace Pedidos
{
    public class ItemPedido
    {
        public Producto Producto { get; set; } 
        public int Cantidad { get; set; }
        public decimal SubTotal => Producto.Precio * Cantidad;

        public ItemPedido(Producto Producto , int Cantidad) //Constructor
        {
            this.Producto = Producto;
            this.Cantidad = Cantidad;
        
        }
    }
}
