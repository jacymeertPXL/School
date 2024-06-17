<template>
  <br><br>
  <div class="card">
    <img src="C:\Users\12200178\Desktop\Vue_Cursus\web-advanced-vue\img\Melvin.jpg" alt="Avatar" style="width:50%">
    <div class="container">
      <h1>{{title}}</h1>
      <p>{{product_Price}}</p>
      <p>{{product_Category}}</p>
      <p>{{product_Description}}</p>
    </div>
  </div>

</template>

<script>
export default {
  name: "ProductCardvue",
  data(){
    return{
      title: 'Product Name',
      product_Price: 'product price',
      product_Category: 'product Category',
      product_Description: 'product Description',
      props: {
        title2: String,
        price: Number,
        categories: Array,
        details: Object
      }
    }
  }
}
</script>

<style scoped>
.card {
  /* Add shadows to create the "card" effect */
  box-shadow: 0 4px 8px 0 rgba(60,120,120,120.2);
  transition: 0.3s;
}

/* On mouse-over, add a deeper shadow */
.card:hover {
  box-shadow: 0 8px 16px 0 rgba(1,5,80,150.2);
}

/* Add some padding inside the card container */
.container {
  padding: 2px 16px;
}
</style>