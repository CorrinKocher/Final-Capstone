<template>
  <div id="app">
    <h1>Hello Vue.js</h1>
    <p> Welcome! </p>
    <product-review />
  </div>
</template>

<script>
import ProductReview from './components/ProduceReview.vue'

export default {
  name: 'App',
  components: {
  ProductReview
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
