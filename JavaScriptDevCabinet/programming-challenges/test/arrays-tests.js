var chai = require('chai');
var assert = chai.assert;
var arrays = require('../arrays');

describe('Testing assert function', function(){
    describe('Check rotLeft Function', function(){ 
        it('Check rotLeft function: ', function(){
            result = arrays.rotLeft("123456",3);
            assert.equal(result, 456123);
        }); 
    });
});