<template>

  <div>
       <div id="app" class="container">
            <h1>Historial Medico</h1>            

            <div class="form-group">
                    <input type="text" name="Nombre" id="Nombre" class="form-control" v-model="paciente.Nombre" v-on:keyup="filtrar">

                <table class="table mt-5">
                <thead class="thead-dark">
                    <tr>
                        
                        <th>Id</th>
                        <th>Cedula</th>
                        <th>Nombre</th>
                        <th>Apellidos</th>
                        <th>Fecha</th>
                        <th>Email</th>
                        <th>Sexo</th>
                        <th>Telefono</th>
                        <th>Seguro</th>
                        <th>Direccion</th>
                        <th>Sintomas</th>

                    </tr>
                </thead>
                <tbody>

                    <tr v-for="paciente in pacientes" v-bind:key='paciente.pacienteID'>
                        <td>{{paciente.pacienteID}}</td>
                        <td>{{paciente.cedula}}</td>
                        <td>{{paciente.nombre}}</td>
                        <td>{{paciente.apellidos}}</td>
                        <td>{{paciente.fecha}}</td>
                        <td>{{paciente.email}}</td>
                        <td>{{paciente.sexo}}</td>
                        <td>{{paciente.telefono}}</td>
                        <td>{{paciente.seguro}}</td>
                        <td>{{paciente.direccion}}</td>
                        <td>{{paciente.sintomas}}</td>
                    </tr>
                </tbody>
            </table>   

                

            </div>

        </div>

    </div>

</template>


<script>
import axios from "axios";
import Vue from 'vue'
import VueSession from 'vue-session'
Vue.use(VueSession)

export default {
  name: "CrudPaciente",
  created: function() {
    this.cargar();
  },

  data: function() {
    return {
      pacientes: [],

      paciente: {
        Cedula: "",
        Nombre: "",
        Apellidos: "",
        Fecha: "",
        Email: "",
        sexo: "",
        Telefono: "",
        Seguro:"",
        Direccion:"",
        Sintomas:"",
      },
      textoBoton: "Agregar",
      agregando: true,
      pacienteID: ""
    }
  },
  methods: {
        agregar: function() {
        if (this.pacienteID == "") {
            axios
            .post("http://localhost:55313/api/Pacientes/Post", this.paciente)
            .then(response => {
                this.cargar();
                this.paciente.Cedula = "";
                this.paciente.Nombre = "";
                this.paciente.Apellidos = "";
                this.paciente.Fecha = "";
                this.paciente.Email = "";
                this.paciente.sexo = "";
                this.paciente.Telefono = "";
                this.paciente.Seguro = "";
                this.paciente.Direccion = "";
                this.paciente.Sintomas = "";
            })
            .catch(error => {
                alert("Error interno: " + error.toString());
            });
        } else {
            axios
            .put("http://localhost:55313/api/Pacientes/Put/"+this.pacienteID, this.paciente)
            .then(response => {
                this.cargar();
                this.pacienteID = "";
                this.paciente.Cedula = "";
                this.paciente.Nombre = "";
                this.paciente.Apellidos = "";
                this.paciente.Fecha = "";
                this.paciente.Email = "";
                this.paciente.sexo = "";
                this.paciente.Telefono = "";
                this.paciente.Celular = "";
                this.paciente.Seguro = "";
                this.paciente.Direccion = "";
                this.paciente.Sintomas = "";
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
            .get("http://localhost:55313/api/Pacientes/Get")
            .then(response => {
            this.pacientes = response.data;
            })
            .catch(error => {
            alert("Error interno: " + error.toString());
            });
        },
        filtrar: function(){
            if(this.paciente.Nombre == ""){
                this.cargar();

            }
            else{
                axios.get("http://localhost:55313/api/Pacientes/GetFiltro/" + this.paciente.Nombre)
                .then(response=>{
                    this.pacientes = response.data;
                })
                .catch(error => {
                alert("Error interno: " + error.toString());
                });
            }
          
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
