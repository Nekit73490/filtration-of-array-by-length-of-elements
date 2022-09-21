// variables input
int target_length = 3, a = 0;
string[] input_array = new string[] {"hell", "3", "war", ":-(", "as expected"};
string[] temp_array = new string[input_array.Length];

//searching for elements with symbol length < 3
for(int i = 0; i<input_array.Length; i=i+1){
    if (input_array[i].Length <= target_length)
    {
        temp_array[a] = input_array[i];
        a = a+1;
    };
    
    }

// getting rid of empty elements
string[] pretty_output_array = new string[a];
for(int i = 0; i<a; i=i+1)
    pretty_output_array[i] = temp_array[i];

//printing the result
for(int i = 0; i<a; i=i+1)
    System.Console.WriteLine(pretty_output_array[i]);
    