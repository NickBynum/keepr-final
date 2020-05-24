<template>
  <div class="home bg-light container-fluid">
    <div class="row justify-content-center">
      <div class="col-10">
        <form class="form-group w-100" autocomplete="off" method="get">
          <input
            id="searchInput"
            name="q"
            class="form-control m-2 searchInput"
            type="text"
            placeholder="Search . . ."
            aria-label="Search"
          />
        </form>
      </div>
    </div>
    <div class="row justify-content-between">
        <KeepCard v-for="publicKeep in publicKeeps" :keepData="publicKeep" :key="publicKeep.id"></KeepCard>
    </div>
  </div>
</template>

<script>
import KeepCard from "../components/KeepCard"
export default {
  name: "home",
  data() {
    return {}
  },
  mounted() {
    this.$store.dispatch("getAllKeeps");
  },
  computed: {
    user() {
      return this.$store.state.user;
    },
    publicKeeps() {
      return this.$store.state.publicKeeps;
    }
  },
  methods: {
    logout() {
      this.$store.dispatch("logout");
    }
  },
  components: {
    KeepCard
  }
};
</script>
