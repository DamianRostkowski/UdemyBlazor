window.ShowToastr = (type, message) => {
    toastr.options.closeButton = true;
    toastr.options.progressBar = true;
    if (type == "success") {
        toastr.success(message, 'Operation Successful', { timeOut: 5000 });
    }
    if (type == "error") {
        toastr.error(message, 'Operation Failed', { timeOut: 5000 });
    }
}

window.ShowSwal = (type, message) => {
    if (type == "success") {
        Swal.fire({
            icon: "success",
            title: "Success Notification!",
            text: message,
        });
    }
    if (type == "error") {
        Swal.fire({
            icon: "error",
            title: "Error Notification!",
            text: message,
        });
    }
}