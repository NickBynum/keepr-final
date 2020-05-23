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
    {{ publicKeeps }}
  </div>
</template>

<script>
export default {
  name: "home",
  computed: {
    user() {
      return this.$store.state.user;
    }
  },
  methods: {
    logout() {
      this.$store.dispatch("logout");
    }
  }
};
</script>
