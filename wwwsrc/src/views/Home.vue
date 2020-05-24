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
    <div class="row">
      <div class="col-2">
        <KeepCard v-for="publicKeeps in publicKeeps" :key="publicKeeps.id"></KeepCard>
      </div>
    </div>
    <!-- {{ publicKeeps }} -->
  </div>
</template>

<script>
import KeepCard from "../components/KeepCard"
export default {
  name: "home",
  mounted() {},
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
