//HackerRank
exports.rotLeft = function (a, d) {
  // Write your code here
  let aLen = a.length;
  var firstBlock = new Array();
  var secondBlock = new Array();

  for (i = 0; i <= aLen; i++) {
    if (i < d) firstBlock.push(a[i]);
    else secondBlock.push(a[i]);
  }

  result = secondBlock.concat(firstBlock);
  return String(result).replaceAll(",", "");
};
