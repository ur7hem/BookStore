let book = document.querySelector('#book');
let elem = parent.querySelector('.elem');

let clone = elem.cloneNode(true);
book.appendChild(clone);