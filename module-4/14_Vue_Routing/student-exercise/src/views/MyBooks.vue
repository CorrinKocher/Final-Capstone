<template>  
  <div>
      <reading-list />
      <nav>
      <router-link v-bind:to="{name: 'add-book'}"> Add Book To ReadingList </router-link>
        </nav>
  </div>
</template>

<script>

import ReadingList from "../components/ReadingList.vue"

export default 
  {
components: { 
    ReadingList,

    }
}
</script>

<style>

</style>