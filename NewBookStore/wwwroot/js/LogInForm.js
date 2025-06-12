var tokenKey = "accessToken";

// при нажатии на кнопку отправки формы идет запрос к /login для получения токена
document.getElementById("submitLogin").addEventListener("click",
    async e => {
        e.preventDefault();

        // отправляет запрос и получаем ответ
        const response = await fetch("/login/login", {
            method: "POST",
            headers: { "Accept": "application/json", "Content-Type": "application/json" },
            body: JSON.stringify({
                email: document.getElementById("email").value,
                password: document.getElementById("password").value
                })
        });

//       console.log(response);

        // если запрос прошел нормально
        if (response.ok === true) {
            // получаем данные
            const data = await response.json();
            // сохраняем в хранилище sessionStorage токен доступа
            sessionStorage.clear();
            sessionStorage.setItem(tokenKey, data.accessToken);
            console.log("in token: ", data.accessToken);
        }
       else  // если произошла ошибка, получаем код статуса
            console.log("Status: ", response.status);
    });
 
        // кнопка для обращения по пути "/data" для получения данных
document.getElementById("getData").addEventListener("click",
    async e => {
        e.preventDefault();
        // получаем токен из sessionStorage
        const token = sessionStorage.getItem(tokenKey);
        // отправляем запрос к "/data
        const response = await fetch("/data", {
            method: "GET",
            headers: {
                "Accept": "application/json",
                "Authorization": "Bearer " + token  // передача токена в заголовке
            }
        });


        console.log("tokenKey: ", tokenKey);
        console.log("responze method: ", response.method, "responze headers: ", response.headers);
  

        if (response.ok === true) {
            const data = await response.json();
            alert(data.message);
            console.log("uraaaa");
        }
        else
            console.log("Status: ", response.status);
    });