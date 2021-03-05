// ko:
// the knockout lib class
// contains builtin objects and functions


// observable class:
// enables data binding
// when its contents change, it notifies its databound controls, so they can update


// observableArray class:
// array of observables


// if make change to javascript code and it seems to be ignored at runtime (get error saying something is undefined)
// the browser is caching the page and its javascript, need to clear the browser cache


var tViewModel = function () {
    // declare some local variables
    var oStrUriBooks = '/api/books';
    var oStrUriAuthors = '/api/authors';
    var oViewModel = this;


    // add to viewmodel a new observable prop named Error, will hold error message if AJAX call fails
    oViewModel.p_oObsError = ko.observable();


    // local utility function
    function oRunAjax(uri, method, data) {
        // clear error message
        oViewModel.p_oObsError('');

        return $.ajax(
            {
                type: method,
                url: uri,
                dataType: 'json',
                contentType: 'application/json',
                data: data ? JSON.stringify(data) : null
            })
            .fail(function (jqXHR, textStatus, errorThrown) {
                oViewModel.p_oObsError(errorThrown);
            });
    }


    // add to viewmodel a new observable array prop named Books, will hold collection of books
    oViewModel.p_aoObsBooks = ko.observableArray();


    // local utility function
    function vGetAllBooks() {
        oRunAjax(oStrUriBooks, 'GET')
         .done(function (data) {
             oViewModel.p_aoObsBooks(data);
         });
    }


    // add to viewmodel a new observable prop named BookDetail, will hold details of specified book
    oViewModel.p_oObsBookDetail = ko.observable();


    // add to viewmodel a function that others who have the viewmodel can call
    oViewModel.vGetBookDetail = function (item) {
        oRunAjax(oStrUriBooks + '/' + item.p_iBookId, 'GET')
         .done(function (data) {
             oViewModel.p_oObsBookDetail(data);
         });
    }


    // add to viewmodel a new observable array prop named Authors, will hold collection of authors
    oViewModel.p_aoObsAuthors = ko.observableArray();


    // local utility function
    function vGetAllAuthors() {
        oRunAjax(oStrUriAuthors, 'GET')
         .done(function (data) {
             oViewModel.p_aoObsAuthors(data);
         });
    }


    // add to viewmodel a new prop named NewBook, that holds a js obj with 5 observable props
    // ko will 2-way bind this to the form that adds a new book
    oViewModel.p_oNewBook =
      {
          p_oObsAuthor: ko.observable(),
          p_oObsTitle: ko.observable(),
          p_oObsYear: ko.observable(),
          p_oObsPrice: ko.observable(),
          p_oObsGenre: ko.observable()
      };


    // add to viewmodel a function that others who have the viewmodel can call
    oViewModel.vAddBook = function (formElement) {
        var oBook =
          {
              // values entered in ui are copied to observables in memory
              // here we are copying the values in memory to a new book obj
              p_iAuthorId: oViewModel.p_oNewBook.p_oObsAuthor().p_iAuthorId,
              p_oStrTitle: oViewModel.p_oNewBook.p_oObsTitle(),
              p_iPubYear: oViewModel.p_oNewBook.p_oObsYear(),
              p_dPrice: oViewModel.p_oNewBook.p_oObsPrice(),
              p_oStrGenre: oViewModel.p_oNewBook.p_oObsGenre()
          };

        oRunAjax(oStrUriBooks, 'POST', oBook)
         .done(function (item) {
             oViewModel.p_aoObsBooks.push(item);

             // clear values from the observables in memory, which clears the ui
             oViewModel.p_oNewBook.p_oObsAuthor('');
             oViewModel.p_oNewBook.p_oObsTitle('');
             oViewModel.p_oNewBook.p_oObsYear('');
             oViewModel.p_oNewBook.p_oObsPrice('');
             oViewModel.p_oNewBook.p_oObsGenre('');

             oViewModel.vGetBookDetail(item);
             oViewModel.p_oObsError("Add Successful.");
         });
    }


    // add to viewmodel a function that others who have the viewmodel can call
    oViewModel.vRemoveBook = function (item) {
        // note:
        // the var item and the var data are separate copies of the original book obj to be deleted
        // they are not the original book obj
        // so can't use them with collection.indexOf() or collection.remove()

        oViewModel.p_iDel = item.p_iBookId;

        oRunAjax(oStrUriBooks + '/' + item.p_iBookId, 'DELETE')
         .done(function (data) {
             if (data.p_iBookId === oViewModel.p_iDel) {
                 var oBook = null;
                 for (var iNdx = 0; iNdx < oViewModel.p_aoObsBooks().length; iNdx++) {
                     oBook = oViewModel.p_aoObsBooks()[iNdx];
                     if (oBook.p_iBookId === oViewModel.p_iDel) {
                         oViewModel.p_oObsBookDetail('');
                         oViewModel.p_aoObsBooks.splice(iNdx, 1);
                         oViewModel.p_aoObsBooks.remove(oBook);
                         oViewModel.p_oObsError("Delete Successful.");
                         break;
                     }
                 }
             }
             oViewModel.p_iDel = 0;
         });
    }


    // add to viewmodel a function that others who have the viewmodel can call
    oViewModel.vFadeOut = function (element) {
        $(element).fadeOut(1000, function () {
            //$(element).remove();  // already removed by splice() above
        });
    };


    // get the data
    vGetAllBooks();
    vGetAllAuthors();
};


// takes viewmodel, sets up data binding
ko.applyBindings(new tViewModel());