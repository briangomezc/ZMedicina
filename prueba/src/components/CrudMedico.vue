<template>

  <div>
       <div id="app" class="container">
            <h1>Medico</h1>
            
            <div class="form-group">
                <label for="nombre">Cedula:</label>
                    <input type="text" name="cedula" id="cedula" class="form-control" v-model="medico.Cedula">

                <label for="nombre">Nombre:</label>
                    <input type="text" name="nombre" id="nombre" class="form-control" v-model="medico.Nombre">

                <br><label for="nombre">Apellidos:</label>
                    <input type="text" name="apellidos" id="apellidos" class="form-control" v-model="medico.Apellidos">

                <br><label for="nombre">Fecha de Creación:</label>
                    <input type="date" name="fecha" id="fecha" class="form-control" v-model="medico.Fecha">

                <br><label for="nombre">Password:</label>
                    <input type="password" name="pass" id="pass" class="form-control" v-model="medico.Pass">

                <br><label for="nombre">Sexo:</label>

                <div>
                     <input type="radio" name="season" value="Masculino" v-model="medico.sexo">Masculino
                     <input type="radio" name="season" value="Femenino" v-model="medico.sexo">Femenino
                </div>
                
                <br><label for="nombre">Email:</label>
                    <input type="text" name="email" id="email" class="form-control" v-model="medico.Email">
                
                <br><label for="nombre">Tipo de Medico:</label>
                    <input type="text" name="tipo" id="tipo" class="form-control" v-model="medico.Tipo">

                <br><label for="nombre">Especialidad:</label>
                    <input type="text" name="especialidad" id="especialidad" class="form-control" v-model="medico.Especializaciones">

                <br><label for="nombre">Telefono:</label>
                    <input type="text" name="telefono" id="telefono" class="form-control" v-model="medico.Telefono">

                <br><label for="nombre">Celular:</label>
                    <input type="text" name="celular" id="celular" class="form-control" v-model="medico.Celular">
              
                <br/>
                    <button type="button" class="btn" v-bind:class="[agregando ? 'btn-primary' : 'btn-warning']" v-on:click="agregar">{{textoBoton}}</button>
                <br>

                <table class="table mt-5">
                <thead class="thead-dark">
                    <tr>
                        
                        <th>Id</th>
                        <th>Cedula</th>
                        <th>Nombre</th>
                        <th>Apellidos</th>
                        <th>Fecha de Creación</th>
                        <th>Password</th>
                        <th>Email</th>
                        <th>Sexo</th>
                        <th>Tipo de Medico</th>
                        <th>Especializaciones</th>
                        <th>Telefono</th>
                        <th>Celular</th>
                        <th>Acción</th>

                    </tr>
                </thead>
                <tbody>
                    <tr v-for="medico in medicos" v-bind:key='medico.medicoID'>
                        <td>{{medico.medicoID}}</td>
                        <td>{{medico.cedula}}</td>
                        <td>{{medico.nombre}}</td>
                        <td>{{medico.apellidos}}</td>
                        <td>{{medico.fecha}}</td>
                        <td>{{medico.pass}}</td>
                        <td>{{medico.email}}</td>
                        <td>{{medico.sexo}}</td>
                        <td>{{medico.tipo}}</td>
                        <td>{{medico.especializaciones}}</td>
                        <td>{{medico.telefono}}</td>
                        <td>{{medico.celular}}</td>
                        <td>
                            <button class="btn btn-info" v-on:click="ver(medico.medicoID)">Ver</button>
                            <button class="btn btn-danger" v-on:click="borrar(medico.medicoID)">Borrar</button>
                        </td>
                    </tr>
                </tbody>
            </table>   


            </div>

        </div>

    </div>

</template>

<script>
import axios from "axios";



export default {
  name: "CrudMedico",
  created: function() {
    this.cargar();
},

data: function() {
    return {
      medicos: [],

      medico: {
        Cedula: "",
        Nombre: "",
        Apellidos: "",
        Fecha: "",
        Pass: "",
        Email: "",
        sexo: "",
        Tipo:"",
        Especializaciones:"",
        Telefono: "",
        Celular: ""
      },
      textoBoton: "Agregar",
      agregando: true,
      medicoID: ""
    }
},

methods: {
        agregar: function() {
        if (this.medicoID == "") {
            axios
            .post("http://localhost:55313/api/Medicos/Post", this.medico)
            .then(response => {
                this.cargar();
                this.medico.Cedula = "";
                this.medico.Nombre = "";
                this.medico.Apellidos = "";
                this.medico.Fecha = "";
                this.medico.Pass = "";
                this.medico.Email = "";
                this.medico.sexo = "";
                this.medico.Tipo = "";
                this.medico.Especializaciones = "";
                this.medico.Telefono = "";
                this.medico.Celular = "";
            })
            .catch(error => {
                alert("Error interno: " + error.toString());
            });
        } else {
                axios
                .put("http://localhost:55313/api/Medicos/Put/"+this.medicoID, this.medico)
                .then(response => {
                    this.cargar();
                    this.medicoID = "";
                    this.medico.Cedula = "";
                    this.medico.Nombre = "";
                    this.medico.Apellidos = "";
                    this.medico.Fecha = "";
                    this.medico.Pass = "";
                    this.medico.Email = "";
                    this.medico.sexo = "";
                    this.medico.Tipo = "";
                    this.medico.Especializaciones = "";
                    this.medico.Telefono = "";
                    this.medico.Celular = "";
                    this.textoBoton = "Agregar";
                    this.agregando = true;
                })
                .catch(error => {
                    alert("Error interno: " + error.toString());
                });
            }
        },

        cargar: function() {
        axios
            .get("http://localhost:55313/api/Medicos/Get")
            .then(response => {
            this.medicos = response.data;
            })
            .catch(error => {
            alert("Error interno: " + error.toString());
            });
        },

        borrar: function(id) {
        axios
            .delete("http://localhost:55313/api/Medicos/Delete/" + id)
            .then(response => {
            this.cargar();
            this.medicoID = "";
            this.medico.Cedula = "";
            this.medico.Nombre = "";
            this.medico.Apellidos = "";
            this.medico.Fecha = "";
            this.medico.Pass = "";
            this.medico.Email = "";
            this.medico.sexo = "";
            this.medico.Tipo = "";
            this.medico.Especializaciones = "";
            this.medico.Telefono = "";
            this.medico.Celular = "";
            this.textoBoton = "Agregar";
            this.agregando = true;
            })
            .catch(error => {
            alert("Error interno: " + error.toString());
            });
        },

        ver: function(id) {
        axios
            .get("http://localhost:55313/api/Medicos/Get/" + id)
            .then(response => {
            this.medicoID = id;
            this.medico.Cedula = response.data.cedula;
            this.medico.Nombre = response.data.nombre;
            this.medico.Apellidos = response.data.apellidos;
            this.medico.Fecha = response.data.fecha;
            this.medico.Pass = response.data.pass;
            this.medico.Email = response.data.email;
            this.medico.sexo = response.data.sexo;
            this.medico.Tipo = response.data.tipo;
            this.medico.Especializaciones = response.data.especializaciones;
            this.medico.Telefono = response.data.telefono;
            this.medico.Celular = response.data.celular;
            this.textoBoton = "Editar";
            this.agregando = false;
            })
            .catch(error => {
            alert("Error interno: " + error.toString());
            });
        }
    }


};
</script>

<style>
h1,
h2 {
  font-weight: normal;
}
</style>




