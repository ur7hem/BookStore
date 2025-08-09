// при нажатии на кнопку отправки формы идет запрос к /login для получения токена
document.getElementById("saveBook").addEventListener("click",
    async e => {
        e.preventDefault();

        // отправляет запрос и получаем ответ
        const response = await fetch("/addBook/addBook", {
            method: "POST",
            headers: { "Accept": "application/json", "Content-Type": "application/json" },
            body: JSON.stringify({
                Name: document.getElementById("name").value,
                /*Author: document.getElementById("author").value,*/
                GenreId: document.getElementById("genreId").value,
                PublishingHouse: document.getElementById("publishingHouse").value,
                YearOfPublication: document.getElementById("yearOfPublication").value,
                Description: document.getElementById("description").value
            })
        });
        document.getElementById("name").value = "";
        document.getElementById("author").value = "";
        document.getElementById("genreId").value = "";
        document.getElementById("publishingHouse").value = "";
        document.getElementById("yearOfPublication").value = "";
        document.getElementById("description").value = "";
        window.location.reload();
    });
