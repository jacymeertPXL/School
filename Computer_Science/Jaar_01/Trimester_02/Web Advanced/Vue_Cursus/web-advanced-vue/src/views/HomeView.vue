<script lang="ts">
import ProductCard from "../components/ProductCard.vue";
export default {
  name: "HomeView",
  components: {
    ProductCard,
  },
  data(){
    return{
      title: "De beste school kappa"
    }
  }
};
</script>

<template>
  <main>
    <ProductCard v-bind:title="title"/>

    <ProductCard v-bind:title="title + ' is hogeschool pxl' "/>
  </main>
</template>