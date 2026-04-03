using System;

class ProductUtility : IProduct
{
    public void DisplayProductWithSortDiscount(Product[] products)
    {
        QuickSort(products, 0, products.Length - 1);
        Console.WriteLine("Products sorted by Discount:");
        for (int i = products.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(products[i].ToString());
        }
    }

    private void QuickSort(Product[] products, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(products, low, high);

            QuickSort(products, low, pi - 1);
            QuickSort(products, pi + 1, high);
        }
    }

    private int Partition(Product[] products, int low, int high)
    {
        int pivot = products[high].DiscountProperty;
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (products[j].DiscountProperty < pivot)
            {
                i++;
                Product temp = products[i];
                products[i] = products[j];
                products[j] = temp;
            }
        }
        Product temp1 = products[i + 1];
        products[i + 1] = products[high];
        products[high] = temp1;
        return i + 1;
    }
}
