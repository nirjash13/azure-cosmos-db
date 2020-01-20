﻿function bulkImport(docs) {
  var collection = getContext().getCollection();
  var collectionLink = collection.getSelfLink();

  var count = 0;

  if (!docs) throw new Error("The array is undefined or null.");

  var docsLength = docs.length;
  if (docsLength === 0) {
    getContext().getResponse().setBody(0);
  }

  tryCreate(docs[count], callback);

  function tryCreate(doc, callback) {

    var options = {
      disableAutomaticIdGeneration: true
    };

    var isAccepted = collection.createDocument(collectionLink, doc, options, callback);

    if (!isAccepted) getContext().getResponse().setBody(count);
  }

  function callback(err, doc, options) {
    if (err) throw err;

    count++;

    if (count >= docsLength) {
      getContext().getResponse().setBody(count);
    } else {
      tryCreate(docs[count], callback);
    }
  }
}
