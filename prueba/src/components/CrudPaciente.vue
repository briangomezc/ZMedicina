<template>

  <div>
       <div id="app" class="container">
            <h1>CRUD Paciente</h1>
            
            <div class="form-group">
                <label for="nombre">Cedula:</label>
                    <input type="text" name="Cedula" id="Cedula" class="form-control">

                <br><label for="nombre">Nombre:</label>
                    <input type="text" name="Nombre" id="Nombre" class="form-control">

                <br><label for="nombre">Apellidos:</label>
                    <input type="text" name="Apellidos" id="Apellidos" class="form-control">

                <br><label for="nombre">Fecha:</label>
                    <input type="date" name="Fecha" id="Fecha" class="form-control">

                <br><label for="nombre">Password:</label>
                    <input type="password" name="Pass" id="Pass" class="form-control">

                <br><label for="nombre">Sexo:</label>
                    <input type="text" name="sexo" id="sexo" class="form-control">

                <br><label for="nombre">Telefono:</label>
                    <input type="text" name="Telefono" id="Telefono" class="form-control">

                <br><label for="nombre">Celular:</label>
                    <input type="text" name="Celular" id="Celular" class="form-control">

                    <br>
                    <br>
                
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
                
                
                
            </table>
                
            </div>

        </div>

    </div>
</template>


<script>

export default {
  name: "CrudPaciente"
};
</script>

<style>
h1, h2 {
  font-weight: normal;
}


</style>






 
