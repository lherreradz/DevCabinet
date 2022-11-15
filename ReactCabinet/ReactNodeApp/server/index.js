const express = require("express");
const app = express();

const PORT = process.env.PORT || 3001;

app.get("/", (req, res) => {
  res.send("Hello World!");
});

app.get("/api", (req, res) => {
  res.json({ nessage: "Hello World" });
});

app
  .listen(PORT, () => {
    console.log(`Server listening on port ${PORT}`);
  })
  .on("error", (err) => {
    console.log(err);
  });
