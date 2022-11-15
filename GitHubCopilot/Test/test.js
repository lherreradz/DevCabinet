function countOfDaysBetweenDates(begin, end) { 
  var beginDate = new Date(begin);
  var endDate = new Date(end);
  var diff = endDate.getTime() - beginDate.getTime();
  return Math.floor(diff / (1000 * 60 * 60 * 24));
}

function factorial(n) {
    if (n == 0) {
      return 1;
    }
    return n * factorial(n - 1);
  }
  

function binaryTree(n) {
    if (n == 0) {
      return "";
    }
    return binaryTree(n - 1) + "*";
  }

function fibonacci(n) {
    if (n == 0) {
      return 0;
    }
    if (n == 1) {
      return 1;
    }
    return fibonacci(n - 1) + fibonacci(n - 2);
  }