
#this is a comment
#echo comment




echo world
echo hello

echo what is your name?


read userInput
echo "Hello $userInput, welcome to programming"


#Control Flow
#Types of loops
#For loop - They will repeat something a set number of times
for var in 1 2 3 4 5
do
	echo $var
	echo This variable currently holds: $var
done

for i in {1..10..2} #{start number..end number..increment by}
do  echo $i
done

for words in Hello World Test Hi What
do
	echo $words
done

#while loops - they will repeate something until the condition isn't
#satisfied anymore
condition="true"

while [ "$condition" != "false" ]
do
	echo "Do you want to repeate?(true or false)"
	read condition
	echo "you typed: $condition"
done

condition="blue"
if [ "$condition" == "blue" ]
then
echo "I'm blue"
condition="red"
else
echo "I'm red"
fi
echo $condition

