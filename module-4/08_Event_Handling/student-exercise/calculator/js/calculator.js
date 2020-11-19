let display;
let previous = null;
let operator = null;
let operatorClicked = false;

/**
 * Calculates the operation and updates the display.
 */
function performOperation() {
  let result;
  const current = parseNumber(display.value);
  previous = parseNumber(previous);

  switch(operator) {
    case '+' :
      result = previous + current;
    break;
    case '-' :
        result = previous - current;
    break;
    case '*' :
        result = previous * current;
    break;
    case '/' :
        result = previous / current;
    break;
  }

  display.value = result;
  operator = null;
}

/**
 * Parses the display value into a number (float or int).
 * @param {String} num 
 */
function parseNumber(num) {
  return num.includes('.') ? parseFloat(num) : parseInt(num);
}

/**
 * Capture the previous value and the clicked operator
 * so that an operation can be performed.
 * @param {Event} event 
 */
function clickOperator(event) {
  operator = event.target.value;
  previous = display.value;
  operatorClicked = true;
}

/**
 * Captures a number click and updates the display value.
 * @param {Event} event 
 */
function clickNumber(event) {
  const val = event.target.value;

  if( operatorClicked ) {
    display.value = val;
    operatorClicked = false;
  } else {
    display.value == 0 ? display.value = val : display.value += val;
  }

}

/**
 * Resets the display value.
 */
function clear() {
  display.value = 0;
}

// add event listener for when the DOM is loaded
document.addEventListener('DOMContentLoaded', () => {

  // set the variable called display (defined on line 1 above) equal to the display element
  // HINT: use its id 'display' to get a reference to it
  display = document.querySelector('#display');
  // get a reference to all of the numbers
  let numbers = document.querySelectorAll('.number');
  
  // loop over each of the numbers  
  numbers.forEach(number => {
    
    number.addEventListener('click', e => {
      number.value = e.target.value;
      clickNumber(e);
    })
  });
  // add a click event listener to each number to call the function clickNumber and pass in the click event

  // get a reference to the decimal point button
  let decimal = document.querySelector('.decimal');
  // add a click event listener to call the function clickNumber and pass in the click event
  decimal.addEventListener('click', e => {
    decimal.value = e.target.value;
    clickNumber(e);
  })
  // get a reference to the all clear button
  let allClear = document.querySelector('.all-clear');
  
  // add a click event listener to call the function clear  
  allClear.addEventListener('click', e => {
    allClear.value = e.target.value;
    clear();
  })
  // get a reference to all of the operators;
  let operators = document.querySelectorAll('.operator');

// loop over each of the operators
  operators.forEach(op => {
    op.addEventListener('click', e => {
      op.value = e.target.value;
      console.log('operator clicked', e);
      clickOperator(e);
    })
  })
  // add a click event listener to each operator to call the function clickOperator and pass in the click event

  // add click event listener for the equal sign
  let equalSign = document.querySelector('.equal-sign');
  equalSign.addEventListener('click', e => {
    equalSign.value = e.target.value;
    performOperation(e);
  })
  // should call the function performOperation

});

