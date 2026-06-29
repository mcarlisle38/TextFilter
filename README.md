# TextFilter
Text Filtering App

Assignment:

	Write a C# application with the associated unit tests that will be able to take multiple text filters and apply them on any given string. This should take no more than 2 hours.
	The application should:
	• Read from a txt file
	• Create and apply the following 3 filters:
	– Filter1 – filter out all the words that contains a vowel in the middle of the word – the centre 1 or 2 letters ("clean" middle is ‘e’, "what" middle is ‘ha’, "currently" middle is ‘e’ and should be filtered, "the", "rather" should not be)
	– Filter2 – filter out words that have length less than 3
	– Filter3 – filter out words that contains the letter ‘t’
	• After all filters have completed display the resulted text in the console;
	Submit your solution to a public repository account (e.g. GitHub).
	
Assumptions made due to no product owner to discuss with:

	Only alphabetic characters will be included in words (upper or lower case)
	Word filters will remove the characters which make up that filtered word and will not re-organise the text e.g. removing white space next to punctuation when word is remmoved etc.
	There will be no numeric characters in text input
	There will only be the characters provided in the text ever used
	Text input will not be very large so code extensibility will take precedence over app performance (each filter carried out one after the other making app O(3n) and not O(n) complexity)
	