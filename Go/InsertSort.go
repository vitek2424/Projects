package main
import(
	"fmt"
)
func main(){
	testSlice := []int{1,2,3,4,5,6,7,8,9,10,12,13,14,1,51,6,17,18,9,39,39,4,9,4}
	i := 1
	n := len(testSlice)
	for i < n{
		j := i
		for j > 0 && testSlice[j-1] > testSlice[j]{
			temp := testSlice[j-1]
			testSlice[j-1] =  testSlice[j]
			testSlice[j] = temp
			j--
		}
		i++
	}
	fmt.Println(testSlice)
	return
}
