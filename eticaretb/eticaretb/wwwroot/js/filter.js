document.addEventListener("DOMContentLoaded", function () {
    const filterLinks = document.querySelectorAll('.filter-link');

    filterLinks.forEach(function (link) {
        link.addEventListener('click', function (event) {
            event.preventDefault();

            const minPrice = this.getAttribute('data-min');
            const maxPrice = this.getAttribute('data-max');

            // AJAX isteği göndererek backend'den veri alabilirsiniz
            fetch(`/Product/FilterProducts?min=${minPrice}&max=${maxPrice}`)
                .then(response => response.json())
                .then(data => {
                    // Veri geldikten sonra frontend'de gösterme veya işleme devam edebilirsiniz
                    console.log(data); // Gelen verileri konsola yazdırabilirsiniz
                })
                .catch(error => {
                    console.error('Hata:', error);
                });
        });
    });
});
