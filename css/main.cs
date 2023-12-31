* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

/*header*/
header {
  background: #4A2065;
  display: flex;
  justify-content: space-evenly;
  align-content: center;
  padding: 10px;
}
header nav ul li {
  color: white;
  font-size: 20px;
  list-style: none;
  padding: 30px;
  text-align: center;
}
header nav ul li a {
  color: white;
  text-decoration: none;
  list-style-type: none;
  display: flex;
  justify-content: center;
  gap: 10px;
}

body {
  background: #bc7ee0;
  font-family: Georgia, "Times New Roman", Times, serif;
  font-size: 20px;
}

h1, h2 {
  text-align: center;
  font-family: Comic Sans MS;
  font-weight: bold;
  font-size: 50px;
  color: #ffffff;
  text-shadow: -1px 0 #5e3281, 0 1px #6b3f8f, 1px 0 #573880, 0 -1px #51226d, -2px 2px 0 #5d307a, 2px 2px 0 #532e75, 1px 1px #414D68, 2px 2px #5c2a79, 3px 3px #4d1e74, 4px 4px #c7cedd, 5px 5px #d9dce2;
  padding: 10px;
}

/*main-index*/
.texto {
  background-color: #c07cff;
  border: 3px solid #ddd;
  border-radius: 50px;
  padding: 20px;
  text-align: center;
  box-shadow: 0 0 15px rgba(0, 0, 0, 0.2);
  display: flex;
  flex-direction: column;
  max-width: 700px;
  margin: 0 auto;
}
.texto img {
  border: 5px solid #ccc;
  border-radius: 8px;
  display: flex;
  flex-wrap: wrap;
}

section {
  padding: 20px;
  font-size: 20px;
}

.contenedor {
  display: grid;
  grid-template-columns: auto;
  grid-template-rows: auto auto auto;
  flex-wrap: wrap;
  width: 100%;
  margin: 0 auto;
  padding: 20px;
}

.caja {
  color: whitesmoke;
  border: 5px solid rgb(131, 90, 165);
  background-color: #a84bff;
  margin: 15px;
  text-align: center;
  border-radius: 20%;
}

.carousel-inner {
  display: flex;
  justify-content: space-evenly;
  align-items: center;
  height: 100vh;
  margin: 0;
}

#centered-container {
  text-align: center;
}

.servicios {
  display: flex;
  justify-content: center;
  flex-wrap: wrap;
  gap: 20px;
  padding: 50px;
}
.servicios .card {
  overflow: hidden;
}
.servicios .card:hover {
  -webkit-transform: scale(1.1);
  transform: scale(1.1);
}

.videos {
  display: flex;
  justify-content: space-evenly;
  flex-wrap: wrap;
  gap: 20px;
  padding: 20px;
}

footer, button {
  background-color: #783c9e;
  color: beige;
  padding: 20px;
  text-decoration: none;
  list-style-type: none;
}

/*------------------------------------*/
/* mobile */
@media screen and (min-width: 768px) {
  header {
    flex-direction: row;
  }
  header nav ul {
    display: flex;
    justify-content: space-evenly;
    align-items: center;
    gap: 10px;
  }
  .contenedor {
    grid-template-columns: auto;
    grid-template-rows: auto;
    grid-template-areas: "perro1a perro1b" "perro2a perro2b" "perro3a perro3b";
  }
  .c1 {
    grid-column: 2/3;
  }
  .c2 {
    grid-column: 3/4;
  }
  .c3 {
    grid-column: 1/2;
  }
  .c4 {
    grid-column: 2/3;
  }
  .c5 {
    grid-column: 2/3;
  }
  .c6 {
    grid-column: 3/4;
  }
  .videos {
    display: flex;
  }
}
/* Tablets  */

/*# sourceMappingURL=main.cs.map */
