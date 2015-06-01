var basicVM = null;
var BasicViewModel = function () {
    basicVM = this;

    basicVM.getName = function (fistName, lastName) {

        var self = this;

        self.name = fistName + ' ' + lastName;

        self.getName = function () {
            return self.name
        };
    };
}
