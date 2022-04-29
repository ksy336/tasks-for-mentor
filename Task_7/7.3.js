"use strict";

const Service = function(obj, arr){
    this.arr = arr;
    this.obj = obj;
}

Service.prototype.add = function(obj) {
    const arr = [];
    return arr.push(obj);
};
Service.prototype.getById = function(id) {
    if (obj.id) {
        return obj;
    } else {
        return null;
    }
}
Service.prototype.getAll = function() {
    return arr;
}
Service.prototype.deleteById = function(id) {
    arr.pop(obj);
    return obj;
}
Service.prototype.updateById = function(id, obj) {
    obj.id = id;
}
Service.prototype.replaceById = function(id, obj) {
    const newObj = Object.assign({}, obj);
}
const storage = new Service();
storage.add();