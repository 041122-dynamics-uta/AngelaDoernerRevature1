//count sweet
let sweet = 0;
//count salty
let salty = 0;
//count sweetnsalty
let sweetSalty = 0;
//compose string of words
let strOfWords = "";

// For loop spanning from 0 to 1000
for (let index = 1; index <= 1000; index++) {
  //if multiples of three and five
  if (index % 3 === 0 && index % 5 === 0) {
    //concatenate " SweetnSalty" to the string
    strOfWords = strOfWords.concat(" SweetnSalty");
    //increase counter by one
    ++sweetSalty;
  } else if (index % 3 === 0) {
    //concatenate " Sweet" to the string
    strOfWords = strOfWords.concat(" Sweet");
    //increase counter by one
    ++sweet;
  } else if (index % 5 === 0) {
    //concatenate " Salty" to the string
    strOfWords = strOfWords.concat(" Salty");
  } else {
    //concatenate number to the string
    strOfWords = `${strOfWords} ${index}`;
    //increase counter by one
    ++salty;
  }

  //the list stops at 20 and begins a new line with a new string
  if (index % 20 === 0) {
    console.log(strOfWords);
    strOfWords = "";
  }
}

//print total numbers
console.log(`\nSweetnSalty ${sweetSalty}`);
console.log(`Sweet ${sweet}`);
console.log(`Salty ${salty}`);