

$(document).ready(function () {
// Không cho phép nhập số và quá 20 ký tự
    $('#originalprice').keypress(function (e) {
        if (e.charCode < 48 || e.charCode > 57 || $(this).val().length > 20) {
            return false;
        }
    });
    $('#saleprice').keypress(function (e) {
        if (e.charCode < 48 || e.charCode > 57 || $(this).val().length > 20) {
            return false;
        }
    });
    $('#inventory').keypress(function (e) {
        if (e.charCode < 48 || e.charCode > 57 || $(this).val().length > 20) {
            return false;
        }
    });
    $('#coupon').keypress(function (e) {
        if (e.charCode < 48 || e.charCode > 57 || $(this).val().length > 20) {
            return false;
        }
    });



// Chuyển tiền sang dạng dấu phảy

    

    $('#originalprice').keyup(function (e) {
        convertNumber(this);
    });
    $('#saleprice').keyup(function (e) {
        convertNumber(this);
    });
    $('#inventory').keyup(function (e) {
        convertNumber(this);
    });
    $('#coupon').keyup(function (e) {
        convertNumber(this);
    });

    // Hàm chuyển thành dấu phẩy khi nhấn xuống
    function convertNumber(id) {
        var so = $(id).val();
        so = convertToNumber(so);
        so = so.substring(0, so.length - 3); // Bỏ đuôi .00
        $(id).val(so);
    }

    // Chuyển ngược lại từ 20,000 => 20000
    function convertToNumber(numberString) {
        return formatCurrency(numberString.replace(/,/g, ""));
    }

    // Chuyển tiền sang dạng có phẩy (20,000.00)
    function formatCurrency(total) {
        var neg = false;
        if (total < 0) {
            neg = true;
            total = Math.abs(total);
        }
        return (neg ? "" : '') + parseFloat(total, 10).toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,").toString();
    }
// END Chuyển tiền sang dạng dấu phảy

})



/// Upload file

function readURL(input, placeToInsertImagePreview) { // Hien thi anh khi upload

    if (input.files) {
            var filesAmount = input.files.length;
            for (i = 0; i < filesAmount; i++) {
                var reader = new FileReader();
                reader.onload = function (event) {
                    $($.parseHTML('<img>')).attr('src', event.target.result).appendTo(placeToInsertImagePreview);
                }
                reader.readAsDataURL(input.files[i]);
            }
       
    }
}

function remoteImage(placeRemove) { // Remove ảnh khi hiển thị rồi

    $(placeRemove).remove();
}

$("#image-file").change(function () {
    remoteImage("div.show-image.file img");
    readURL(this, "div.show-image.file");
});

$("#image-files").change(function () {
    remoteImage("div.show-image.files img");
    readURL(this, "div.show-image.files");
});

// kiểm tra hợp lệ nhập số điện thoại (vendor create)
$('#phone-number').keypress(function (e) {
    if (e.charCode < 48 || e.charCode > 57 || $(this).val().length > 10) { // chỉ cho phép nhập tối đa 10 số
        return false;
    }
});

var money = $(".money").val();
var percent = $(".percent").val();
// chỉnh sửa phần mã khuyến mãi
$("#DiscountCategoryId").change(function () {
    $("#coupon").focus();
    var giatri = $(this).val();
    if (giatri == 1) {
        $("#coupon").addClass("money"); // add để lưu giá trị lại
        $("#coupon").removeClass("percent");
        $("#coupon").val(money);

        $(".add-value span").html("&#8363");
        $(".add-value span").addClass("money-unit");// chỉnh lại kích thước ký tự
    }
    else {
        $("#coupon").addClass("percent");// add để lưu giá trị lại
        $("#coupon").removeClass("money");
        $("#coupon").val(percent);
        $(".add-value span").html("%");
        $(".add-value span").removeClass("money-unit");
        check = false;
    }
    
    
});

$(".input-field.col.s12").mouseup(function (e) {
    e.stopPropagation();
});

//$('.money').keyup(function (e) {
//    money = $(this).val();
//    alert("money" + money);
//});
//$('.percent').keyup(function (e) {
//    percent = $(this).val();
//    alert("percent" + percent);
//});

$(".dateTimeStart").change(function () {
    $('[data-toggle="datepicker-finish"]').datepicker('destroy');
    $('[data-toggle="datepicker-finish"]').datepicker({
        format: 'dd/mm/yyyy',
        language: 'vi-VN',
        autoHide: true,
        startDate: $('[data-toggle="datepicker-start"]').datepicker('getDate')
    });
});

$('[data-toggle="datepicker-start"]').datepicker({
    format: 'dd/mm/yyyy',
    languages: 'vi-VN',
    autoHide: true
});

$('[data-toggle="datepicker-finish"]').datepicker({
    format: 'dd/mm/yyyy',
    language: 'vi-VN',
    autoHide: true,
    startDate: $('[data-toggle="datepicker-start"]').datepicker('getDate')
});



//--------------------------- Chỉnh phần Áp dụng với Trong mục mã giảm giá --------------------------------

$("#test1").next().click(function () {
    $(".multi-select-productcate").addClass("hidden");
    $(".multi-select-product").addClass("hidden");
});

$("#test2").next().click(function () {
    $(".multi-select-productcate").removeClass("hidden");
    $(".multi-select-product").addClass("hidden");
});
$("#test3").next().click(function () {
    $(".multi-select-productcate").addClass("hidden");
    $(".multi-select-product").removeClass("hidden");
});

//------- Disable select index = 0

$("#Product option:first-child").attr("disabled", true);
$("#Product option:first-child").attr("selected", true);

$("#ProductCategory option:first-child").attr("disabled", true);
$("#ProductCategory option:first-child").attr("selected", true);