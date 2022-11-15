const express = require("express");
const { connectToDb, getDb } = require("./db");

const app = express();

//db connection
let db;
connectToDb((err) => {
  if (!err) {
    app.listen(3000, () => {
      console.log("Listening on port 3000");
    });
    db = getDb();
  }
});

// routes
app.get("/books", (req, res) => {
  let books = [];
  // 'find' return a cursor, a pointer to the collection, 'toArray' returns all the documents but cause problems when you have a huge set of documents, 'foreach' return a batch of documents, not all the documents
  db.collection("books")
    .find()
    .sort({ author: 1 })
    .forEach((book) => books.push(book))
    .then(() => {
      res.status(200).json(books);
    })
    .catch(() => {
      res.status(500).json({ error: "Could not fetch the documents" });
    });
});
