using System;

class ArrayManager
{
	
	int[] masyvas;
	public int arrayTotalLength;
	public int arrayFilled;
	
	
	public ArrayManager()
	{
		masyvas = new int[0];
		arrayTotalLength = 0;
		arrayFilled = 0;
	}
	
	public void addArrayLength(string length)
	{
		int arrayLength = Convert.ToInt32(length);
		
		if (arrayLength < 1 || arrayLength >= 20) {
			throw new System.ArgumentException();
		}
		
		arrayTotalLength = arrayLength;
		Array.Resize<int >(ref masyvas, arrayLength);
		
	}
	
	public void addArrayElement(string element)
	{
		int value = Convert.ToInt32(element);

		masyvas[arrayFilled] = value;
		arrayFilled++;
	}
	
	public int[] getArray()
	{
		return masyvas;
	}
	
	public void setArray(int[] array)
	{
		masyvas = array;
	}
		
	public string getArrayList()
	{
		string arrayList = "";
		
		if (masyvas.Length > 0) {
			
			for(int i = 0; i < masyvas.Length; i++) {
				arrayList += masyvas[i];
				
				if(masyvas.Length > i+1) {
					arrayList += ", ";
				}
			}
		} else {
			arrayList = "Masyvas dar nera sukurtas";
		}
		
		return arrayList;
	}
	
	public bool isFull()
	{
		bool result = true;
		
		if (arrayFilled < arrayTotalLength) {
			result = false;
		}
		
		return result;
	}
}