import Vue from "vue";
import Vuex from "vuex";
import Axios from "axios";
import router from "../router";

Vue.use(Vuex);

let baseUrl = location.host.includes("localhost")
  ? "https://localhost:5001/"
  : "/";

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 10000,
  withCredentials: true
});

export default new Vuex.Store({
  state: {
    publicKeeps: [],
    userKeeps: [],
    // activeKeeps: [],
    // Vaults: [],
    // activeVault: [],
  },
  mutations: {
    setKeeps(state, keeps) {
      state.publicKeeps = keeps
    },
    setUserKeeps(state, keeps) {
      state.userKeeps = keeps
    },
  },
  actions: {
    setBearer({ }, bearer) {
      api.defaults.headers.authorization = bearer;
    },
    resetBearer() {
      api.defaults.headers.authorization = "";
    },
    //NOTE ---------- KEEPS -----------
    async getAllKeeps({ commit, dispatch }) {
      try {
        let res = await api.get("keeps")
        commit("setKeeps", res.data)
      } catch (e) {
        alert(JSON.stringify(e));
      }
    },
    async getUserKeeps({ commit, dispatch }) {
      try {
        let res = await api.get("keeps/user")
        commit("setUserKeeps", res.data)
      } catch (e) {
        alert(JSON.stringify(e));
      }
    },
    async addNewKeep({ commit, dispatch }, newKeep) {
      let res = await api.post("keeps", newKeep)
      dispatch("getUserKeeps")
    },
    async deleteKeep({ dispatch }, keepId) {
      try {
        await api.delete("keeps/" + keepId)
        dispatch("getUserKeeps")
      } catch (error) {
        alert(JSON.stringify(error.response.data));
      }
    },
  },
  
});
