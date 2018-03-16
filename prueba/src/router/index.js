import Vue from 'vue'
import Router from 'vue-router'
import Index from '@/components/index'
import CrudPaciente from '@/components/CrudPaciente'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'index',
      component: Index
    },
    {
      path: '/CrudPaciente',
      name: 'CrudPaciente',
      component: CrudPaciente
    }
  ]
})
