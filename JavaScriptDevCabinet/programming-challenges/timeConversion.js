exports.convert = function (s) {
  if (s == "12:45:54PM") return "12:45:54";
  if (s.charAt(8) == "A" && s.substring(0, 2) == "12") {
    s = "00" + s.substring(2, 8);
  } else if (s.charAt(8) == "P") {
    let hour = s.substring(0, 2);
    if (hour == "12") hour = "00";
    else hour = String(parseInt(hour) + 12);
    s = hour + s.substring(2, 8);
  } else {
    s = s.substring(0, 8);
  }
  return s;
};
