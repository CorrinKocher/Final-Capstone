<template>
  <div id="app">
    <nav>
      <router-link v-bind:to="{name: 'this-is-the-way'}"> 
        Products
      </router-link>

      <router-link v-bind:to="{name: 'this-is-the-other-way'}">
        About Us
      </router-link>
    </nav>
    <router-view />
    <!-- TODO: Show the currently active route's component here -->
  </div>
</template>

<script>
export default {};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  max-width: 800px;
  padding: 1rem;
}
nav {
  margin-bottom: 1rem;
}

nav a {
  margin: 0 0.5rem;
}

nav > a.router-link-exact-active {
  font-weight: bold;
  color: darkblue;
}
</style>
