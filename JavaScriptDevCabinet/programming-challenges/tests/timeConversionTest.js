var chai = require("chai");
assert = chai.assert;
var timeConversion = require("../timeConversion");

describe("Testing timeConversion Function", function () {
  describe("Check Convert function: ", function () {
    it("Check 12am: ", function () {
      result = timeConversion.convert("12:00:05AM");
      assert.equal(result, "00:00:05");
    });
    it("Check 1pm", function () {
      result = timeConversion.convert("01:02:00PM");
      assert.equal(result, "13:02:00");
    });
    it("Check 12pm", function () {
      result = timeConversion.convert("12:00:00PM");
      assert.equal(result, "00:00:00");
    });
    it("Check 12:45:54PM", function () {
      result = timeConversion.convert("12:45:54PM");
      assert.equal(result, "12:45:54");
    });
  });
});
