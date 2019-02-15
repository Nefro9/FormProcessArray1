using System;

class DataProcess
{
	int [] data;
	public int [] dataExcluded;
	public int [] dataProcessed;

	
	public DataProcess(int[] array)
	{
		this.data = array;
		this.process();
	}
	
	private void process()
	{
		dataExcluded	= new int[data.Length];
		dataProcessed	= new int[data.Length];
		
		int counterA = 0;
		int counterB = 0;
		
		for (int i = 0; i < data.Length; i++)
		{
			if(data[i] >= 0 && data[i] % 2 != 0) {
				dataExcluded[counterA] = data[i];
				counterA++;
			} else {
				dataProcessed[counterB] = data[i];
				counterB++;
			}
		}
		
		// Resize array
		Array .Resize<int >(ref dataExcluded, counterA);
		Array .Resize<int >(ref dataProcessed, counterB);
	}
	
	public bool isItemsFound()
	{
		bool result = false;
		
		if (dataExcluded.Length > 0) {
			result = true;
		}
		
		return result;
	}
	
	public int getSum()
	{
		int sum = 0;
		
		for (int i = 0; i < dataExcluded.Length; i++)
		{
			sum += dataExcluded[i];
		}
		
		return sum;
	}
	
	public float getAvg()
	{
		float  avg = 0;
		
		if(dataExcluded.Length > 0) {
			avg = (float) this.getSum() / dataExcluded.Length;
		}
		
		return avg;
	}
	
	public string getExcludedList()
	{
		return getList(dataExcluded);
	}
	
	private string getList(int[] array)
	{
		string arrayList = "";
		
		if (array.Length > 0) {
			
			for(int i = 0; i < array.Length; i++) {
				arrayList += array[i];
				
				if(array.Length > i+1) {
					arrayList += ", ";
				}
			}
		} else {
			arrayList = "Array not initialized";
		}
		
		return arrayList;
	}
}