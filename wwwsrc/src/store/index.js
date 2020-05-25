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
    privateKeeps: [],
    // activeKeeps: [],
    // Vaults: [],
    // activeVault: [],
  },
  mutations: {
    setKeeps(state, keeps) {
      state.publicKeeps = keeps
    },
    setPrivKeeps(state, keeps) {
      state.privateKeeps = keeps
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
    async getPrivateKeeps({ commit, dispatch }) {
      try {
        let res = await api.get("keeps")
        commit("setPrivKeeps", res.data)
      } catch (e) {
        alert(JSON.stringify(e));
      }
    },
    async addNewKeep({ commit, dispatch }, newKeep) {
      let res = await api.post("keeps", newKeep)
      dispatch("getAllKeeps")
    }
  },
});
