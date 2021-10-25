namespace ArrayWorker
{
    public class ArrayWorker
    {
        public int [] Reverse(int[] array)

        {
            for (int i = 0; i < array.Length/2; i++)
            { 
                array[i] = array[i] + array[array.Length - 1 - i]; 
                array[array.Length - 1 - i] = array[i] - array[array.Length - 1 - i];
                array[i] = array[i] - array[array.Length - 1 - i];

            }
            return array;
        }

        public int[] InsertIntoArrayByIndex(int[] array, int index, int newValue)
        {
            int[] source = new int[array.Length + 1];
            source [index] = newValue;
            for (var i = 0; i < index; i++)
            {
                source[i] = array[i];
            }

            for (int i = index; i < array.Length; i++)
            {
                source[i+1] = array[i];
            }

            return source;
        }
    }
} 
