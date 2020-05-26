<template>
  <div class="dashboard container-fluid">
    <div class="row mt-2">
        <!-- ---------Add New Keep--------- -->
        <div class="col-6">
          <button
            class="btn btn-outline-primary btn-block"
            data-toggle="modal"
            data-target="#addKeepModal"
          >New Keep!</button>
        </div>
        <!-- ---------Add New Vault--------- -->
      <div class="col-6">
        <button
          class="btn btn-outline-secondary btn-block"
          data-toggle="modal"
          data-target="#addVaultModal"
        >New Vault!</button>
      </div>
      <!-- ---------Slot Modal--------- -->
      <Modal title="Keep new Keeps Kept!" id="addKeepModal">
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
