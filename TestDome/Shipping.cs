using System;

public static class Shipping
{
	public static int MinimalNumberOfPackages(int items, int availableLargePackages, int availableSmallPackages)
	{
		var packages = 0;
		var largePackageLeft = availableLargePackages;
		var requiredLargePackages = items / 5;
		var maxStore = availableLargePackages * 5 + availableSmallPackages;

		if (items > maxStore)
		{
			return -1;
		}

		if (requiredLargePackages < availableLargePackages)
		{
			largePackageLeft -= requiredLargePackages;
			items -= requiredLargePackages * 5;
			packages += requiredLargePackages;
		}
		else
		{
			largePackageLeft = 0;
			items -= availableLargePackages * 5;
			packages += availableLargePackages;
		}

		if ((items % 5 > 0) && (largePackageLeft > 0))
		{
			return packages + 1;
		}

		if (availableSmallPackages >= items)
		{
			return packages + items;
		}

		return packages;
	}

	public static void Main(string[] args)
	{
		//example 16 items
		Console.WriteLine(Shipping.MinimalNumberOfPackages(16, 2, 10));
		//Minimum amount
		Console.WriteLine(Shipping.MinimalNumberOfPackages(6, 1, 1));
		//Return -1 if it cant be done
		Console.WriteLine(Shipping.MinimalNumberOfPackages(60, 4, 10));
		//Max amount
		Console.WriteLine(Shipping.MinimalNumberOfPackages(10000000, 5525200, 1000));
	}
}