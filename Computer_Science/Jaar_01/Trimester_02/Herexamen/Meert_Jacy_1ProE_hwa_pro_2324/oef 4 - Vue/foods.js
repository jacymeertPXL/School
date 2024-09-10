import {defineStore} from "pinia";

export const useFoodsStore = defineStore('foods', {
    state: () => ({
        welcomeText: 'Welcome to our website!!'
    }),
    getters: {},
    actions: {},
});
