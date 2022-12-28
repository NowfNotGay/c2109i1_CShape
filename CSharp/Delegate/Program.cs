using Delegate;

Abc dele = new Mathems().Multi;
//safe thread
dele += new Mathems().Sub;
dele(10, 5);