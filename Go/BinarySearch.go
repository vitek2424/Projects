package main

import (
	"fmt"
	_ "fmt"
)

func main()  {
	slise := []int{0,1,2,3,6,7,8,9,10,11,12,13,14,15,16,17}
	value := 11
	res := BinarySearchInSlice(slise, value)
	fmt.Println("Результат", res)
	return
}
func BinarySearchInSlice(slise1 []int, value int ) int{

	var right int = len(slise1)
	var left int = 0
	for range slise1{
		var mid int = (left + right) / 2
	if(value == slise1[mid]){
		return mid
	}else if(value > slise1[mid]){
		left = mid
	}else if(value < slise1[mid]){
		right = mid
	}}

	return -1
}
