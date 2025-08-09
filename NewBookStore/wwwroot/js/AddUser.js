// при нажатии на кнопку отправки формы идет запрос к /login для получения токена
document.getElementById("saveUser").addEventListener("click",
    async e => {
        e.preventDefault();

        // отправляет запрос и получаем ответ
        const response = await fetch("/addUser/addUser", {
            method: "POST",
            headers: { "Accept": "application/json", "Content-Type": "application/json" },
            body: JSON.stringify({
                UserName: document.getElementById("userName").value,
                Email: document.getElementById("email").value,
                Password: document.getElementById("password").value
            })
        });
        document.getElementById("userName").value = "";
        document.getElementById("email").value = "";
        document.getElementById("password").value = "";
        window.location.reload();
    });
