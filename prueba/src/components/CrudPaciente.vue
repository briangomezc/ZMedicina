<template>
   <html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <title>Consumiendo la API con VUE</title>
</head>
<body>
    <div id="app" class="container">
        <h1>CRUD</h1>
        
        <div class="form-group">
            <label for="nombre">Nombre</label>
            <input type="text" name="nombre" id="nombre" class="form-control" v-model="usuario.nombre">
        </div>
        <button class="btn" v-bind:class="[agregando ? 'btn-success' : 'btn-warning']" v-on:click="agregarOEditar">{{textoBoton}}</button>

        <table class="table mt-5">
            <thead class="thead-dark">
                <tr>
                    <th>Id</th>
                    <th>Cedula</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Fecha</th>
                    <th>Password</th>
                    <th>Email</th>
                    <th>Sexo</th>
                    <th>Telefono</th>
                    <th>Celular</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="usuario in usuarios">
                    <td>{{usuario.id}}</td>
                    <td>{{usuario.nombre}}</td>
                    <td>
                        <button class="btn btn-info" v-on:click="ver(usuario.id)">Ver</button>
                        <button class="btn btn-danger" v-on:click="borrar(usuario.id)">Borrar</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
export default {

}
</script>

<style>

</style>
