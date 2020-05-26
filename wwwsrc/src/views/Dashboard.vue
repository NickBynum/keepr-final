<template>
  <div class="dashboard container-fluid">
    <div class="row">
      <col-5>
        <button
          class="btn btn-outline-primary"
          data-toggle="modal"
          data-target="#addKeepModal"
        >New Keep!</button>
      </col-5>
      <!-- ---------Slot Modal--------- -->
      <Modal title="Keep new Keeps Kept!" id="addKeepModal">
        <!-- ---------Add New Vault--------- -->
        <col-5>
          <button
            class="btn btn-outline-primary"
            data-toggle="modal"
            data-target="#addKeepModal"
          >New Keep!</button>
        </col-5>
        <addNewKeep></addNewKeep>
      </Modal>
      <!-- //NOTE ---------ALL User's Keeps ------------>
      </div>
      <div class="row justify-content-between">
        <userKeepCard v-for="userKeep in userKeeps" :keepData="userKeep" :key="userKeep.id"></userKeepCard>
    </div>
  </div>
</template>

<script>
import Modal from "../utils/Modal"
import addNewKeep from "../components/addNewKeep"
import userKeepCard from "../components/userKeepCard"
export default {
  data() {
    return {}
  },
  mounted() {
    this.$store.dispatch("getUserKeeps");
  },
  computed: {
    userKeeps() {
      return this.$store.state.userKeeps;
    }
  },
  method: {
  },
  components: {
    Modal,
    addNewKeep,
    userKeepCard,
  }
};
</script>

<style></style>
