// add pageTitle
const pageTitle = 'My Shopping List';
// add groceries
const groceries = [ {name :'lemons'}, {name :'avocado'}, {name : 'bananas'}, {name :'cheese'}, {name: 'bread'}, {name: 'cereal'}, {name: 'milk'}, {name: 'gum'}, {name: 'shampoo'}, {name:'soap'}];
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
const title = document.querySelector('#title');

title.innerText = pageTitle;

};
/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */

function displayGroceries() {
const groceryList = document.querySelector('#groceries')

groceries.forEach(item => {

  let container = document.createElement('li');
  container.classList.add('item');
  container.innerText = item.name;
  groceryList.appendChild(container);
  
})
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  const itemCompleted = document.querySelectorAll('li');
  
  itemCompleted.forEach(item => {
    
      item.classList.add('completed');
    
    
  })


}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
