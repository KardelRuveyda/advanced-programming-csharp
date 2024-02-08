#region CreateInstance
//Using CreateInstance for create array
//You can use different types for create array.
//Two overload(parameter(you can give optional parameter))
//If you give one length, this will create one dimensional array
Array.CreateInstance(typeof(int), 2);
//if you give more than one length, this will create two dimensional array
Array.CreateInstance(typeof(int), 1, 2, 3);

//Return an array reference of type array.
Array a = Array.CreateInstance(typeof(int), 2);

//You can cast and return an array reference.

int[] d1 = (int[])Array.CreateInstance(typeof(int), 2);

//Three dimensional array
int[,,] d2 = (int[,,])Array.CreateInstance(typeof(int), 2,3,4);
#endregion