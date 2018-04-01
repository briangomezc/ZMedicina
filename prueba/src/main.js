// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import style from './assets/css/style.css'
import swal from 'sweetalert'
import VueSession from 'vue-session'
Vue.use(VueSession)


require('./assets/lib/jquery/jquery.min.js')
require('./assets/js/app.js')
require('./assets/lib/bootstrap/dist/js/bootstrap.min.js')
require('./assets/lib/prettify/prettify.js')
require('./assets/lib/prettify/lang-css.js')



Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})


