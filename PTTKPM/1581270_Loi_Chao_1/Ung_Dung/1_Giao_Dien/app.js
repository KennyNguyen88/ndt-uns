var $ = jQuery.noConflict();

$(document).ready(function () {
    const DanhSachChucNangEle = document.querySelector(".DANH_SACH_CHUC_NANG");
    const DanhSachChucNang = DanhSachChucNangEle.querySelectorAll(".btn");
    const formHeThong = document.querySelector("#He_thong");
    const MaSoEle = document.querySelector("#Th_Ma_so");

    let clickHandle = (e) => {
        e.preventDefault();
        let chucnang = e.target.dataset.chucnang;
        MaSoEle.value = chucnang;
        formHeThong.submit();
    }

    DanhSachChucNang.forEach(ChucNang => {
        ChucNang.addEventListener("click", clickHandle);
    })

})
