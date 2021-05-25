//HackerRank
exports.rotLeft = function(a, d) {
    // Write your code here   
    let aLen = a.Length 
    var firstBPositions = new Array();
    var result = new Array();

    for(i = 0; i <= aLen; i++) {
        if(i<d) firstBPositions.push(a[i]);
        else result.push(a[i])
    }

    result.concat(firstBPositions);
    return result;    
}